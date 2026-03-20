using System;
using System.Collections.Generic;
using System.Linq;

namespace compiles_lab_1.Core
{
    public class ParseError
    {
        public string Fragment { get; set; }
        public int Line { get; set; }
        public int StartColumn { get; set; }
        public int EndColumn { get; set; }
        public string Message { get; set; }
    }

    public static class Parser
    {
        public static List<ParseError> Analyze(ScanResult scanResult)
        {
            var errors = new List<ParseError>();
            var tokens = scanResult.Lexemes;
            int index = 0;

            Lexeme Current() =>
                index < tokens.Count ? tokens[index] : null;

            void AddError(Lexeme lex, string message)
            {
                if (lex == null)
                {
                    var last = tokens.LastOrDefault();
                    errors.Add(new ParseError
                    {
                        Fragment = "<EOF>",
                        Line = last?.Line ?? 1,
                        StartColumn = last?.EndColumn ?? 1,
                        EndColumn = last?.EndColumn ?? 1,
                        Message = message
                    });
                    return;
                }

                errors.Add(new ParseError
                {
                    Fragment = lex.Text,
                    Line = lex.Line,
                    StartColumn = lex.StartColumn,
                    EndColumn = lex.EndColumn,
                    Message = message
                });
            }

            void SkipToSemicolon()
            {
                while (index < tokens.Count && tokens[index].Code != LexemeCode.Semicolon)
                    index++;

                if (index < tokens.Count && tokens[index].Code == LexemeCode.Semicolon)
                    index++;
            }

            bool RecoverToName()
            {
                while (index < tokens.Count)
                {
                    if (tokens[index].Code == LexemeCode.Semicolon)
                        return false;

                    if (tokens[index].Code == LexemeCode.Identifier &&
                        index + 1 < tokens.Count &&
                        tokens[index + 1].Code == LexemeCode.Colon)
                    {
                        return true;
                    }

                    index++;
                }

                return false;
            }

            void ParseNumber()
            {
                var cur = Current();

                if (cur == null)
                {
                    AddError(null, "Ожидалось число.");
                    return;
                }

                if (cur.Code == LexemeCode.Error)
                {
                    AddError(cur, "Недопустимая лексема в числе.");
                    index++;
                    return;
                }

                if (cur.Code == LexemeCode.Minus)
                {
                    index++;
                    cur = Current();

                    if (cur == null || cur.Code != LexemeCode.Integer)
                    {
                        AddError(cur, "После '-' ожидалось число.");
                        SkipToSemicolon();
                        return;
                    }

                    if (!IsValidNonZeroInteger(cur.Text))
                        AddError(cur, "После '-' ожидается ненулевое число без ведущих нулей.");

                    index++;
                    return;
                }

                if (cur.Code != LexemeCode.Integer)
                {
                    AddError(cur, "Ожидалось число.");
                    SkipToSemicolon();
                    return;
                }

                if (cur.Text.Length > 1 && cur.Text[0] == '0')
                    AddError(cur, "Число не должно начинаться с '0'.");

                index++;
            }

            while (index < tokens.Count)
            {
                var cur = Current();
                if (cur == null)
                    break;

                bool headerBroken = false;

                if (cur.Code == LexemeCode.KeywordConst)
                {
                    index++;
                }
                else
                {
                    AddError(cur, "Ожидалось ключевое слово 'const'.");
                    headerBroken = true;
                }

                if (!headerBroken)
                {
                    cur = Current();
                    if (cur != null && cur.Code == LexemeCode.KeywordVal)
                    {
                        index++;
                    }
                    else
                    {
                        AddError(cur, "Ожидалось ключевое слово 'val'.");
                        headerBroken = true;
                    }
                }

                if (headerBroken)
                {
                    if (!RecoverToName())
                    {
                        SkipToSemicolon();
                        continue;
                    }
                }

                cur = Current();
                if (cur == null || cur.Code != LexemeCode.Identifier)
                {
                    AddError(cur, "Ожидался идентификатор.");
                    SkipToSemicolon();
                    continue;
                }
                index++;

                cur = Current();
                if (cur == null || cur.Code != LexemeCode.Colon)
                {
                    AddError(cur, "Ожидался символ ':'.");
                    SkipToSemicolon();
                    continue;
                }
                index++;

                cur = Current();
                if (cur == null || cur.Code != LexemeCode.KeywordInt)
                {
                    AddError(cur, "Ожидалось ключевое слово 'Int'.");
                    SkipToSemicolon();
                    continue;
                }
                index++;

                cur = Current();
                if (cur == null || cur.Code != LexemeCode.Assign)
                {
                    AddError(cur, "Ожидался символ '='.");
                    SkipToSemicolon();
                    continue;
                }
                index++;

                ParseNumber();

                cur = Current();
                if (cur == null || cur.Code != LexemeCode.Semicolon)
                {
                    AddError(cur, "Ожидался символ ';'.");
                    SkipToSemicolon();
                    continue;
                }
                index++;
            }

            return errors;
        }

        static bool IsValidNonZeroInteger(string text)
        {
            if (string.IsNullOrEmpty(text))
                return false;

            if (text[0] == '0')
                return false;

            foreach (var c in text)
                if (!char.IsDigit(c))
                    return false;

            return true;
        }
    }
}