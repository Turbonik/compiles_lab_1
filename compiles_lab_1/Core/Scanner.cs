using System;
using System.Collections.Generic;

namespace compiles_lab_1.Core
{
    public static class Scanner
    {
        static bool IsLatinLetter(char c) =>
            (c >= 'A' && c <= 'Z') ||
            (c >= 'a' && c <= 'z');

        public static ScanResult Analyze(string source)
        {
            var result = new ScanResult();

            int line = 1;
            int col = 1;
            int i = 0;

            while (i < source.Length)
            {
                char ch = source[i];

                if (ch == '\n')
                {
                    line++;
                    col = 1;
                    i++;
                    continue;
                }

                if (ch == ' ' || ch == '\t')
                {
                    result.Lexemes.Add(new Lexeme
                    {
                        Code = LexemeCode.Space,
                        Type = Strings.Separator,
                        Text = "(space)",
                        Line = line,
                        StartColumn = col,
                        EndColumn = col
                    });

                    i++;
                    col++;
                    continue;
                }

                if (char.IsDigit(ch))
                {
                    int startCol = col;
                    int startIndex = i;

                    while (i < source.Length && char.IsDigit(source[i]))
                    {
                        i++;
                        col++;
                    }

                    string text = source.Substring(startIndex, i - startIndex);

                    result.Lexemes.Add(new Lexeme
                    {
                        Code = LexemeCode.Integer,
                        Type = Strings.Integer,
                        Text = text,
                        Line = line,
                        StartColumn = startCol,
                        EndColumn = col - 1
                    });

                    continue;
                }

                if (IsLatinLetter(ch) || ch == '_')
                {
                    int startCol = col;
                    int startIndex = i;

                    while (i < source.Length &&
                          (IsLatinLetter(source[i]) || char.IsDigit(source[i]) || source[i] == '_'))
                    {
                        i++;
                        col++;
                    }

                    string word = source.Substring(startIndex, i - startIndex);

                    LexemeCode code = word switch
                    {
                        "const" => LexemeCode.KeywordConst,
                        "val" => LexemeCode.KeywordVal,
                        "Int" => LexemeCode.KeywordInt,
                        _ => LexemeCode.Identifier
                    };

                    result.Lexemes.Add(new Lexeme
                    {
                        Code = code,
                        Type = Strings.Keyword,
                        Text = word,
                        Line = line,
                        StartColumn = startCol,
                        EndColumn = col - 1
                    });

                    continue;
                }

                if (ch == ':')
                {
                    result.Lexemes.Add(new Lexeme
                    {
                        Code = LexemeCode.Colon,
                        Type = Strings.DeclareOperator,
                        Text = ":",
                        Line = line,
                        StartColumn = col,
                        EndColumn = col
                    });

                    i++; col++;
                    continue;
                }

                if (ch == '=')
                {
                    result.Lexemes.Add(new Lexeme
                    {
                        Code = LexemeCode.Assign,
                        Type = Strings.EqualsOperator,
                        Text = "=",
                        Line = line,
                        StartColumn = col,
                        EndColumn = col
                    });

                    i++; col++;
                    continue;
                }

                if (ch == ';')
                {
                    result.Lexemes.Add(new Lexeme
                    {
                        Code = LexemeCode.Semicolon,
                        Type = Strings.EndOperator,
                        Text = ";",
                        Line = line,
                        StartColumn = col,
                        EndColumn = col
                    });

                    i++; col++;
                    continue;
                }

                if (ch == '-')
                {
                    result.Lexemes.Add(new Lexeme
                    {
                        Code = LexemeCode.Minus,
                        Type = Strings.SubstractionOperator,
                        Text = "-",
                        Line = line,
                        StartColumn = col,
                        EndColumn = col
                    });

                    i++; col++;
                    continue;
                }

                result.Lexemes.Add(new Lexeme
                {
                    Code = LexemeCode.Error,
                    Type = Strings.Error,
                    Text = $"{Strings.InvalidLexeme} \"{ch}\"",
                    Line = line,
                    StartColumn = col,
                    EndColumn = col
                });

                i++;
                col++;
            }

            return result;
        }
    }
}
