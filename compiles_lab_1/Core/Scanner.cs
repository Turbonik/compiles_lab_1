using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace compiles_lab_1.Core
{
    public static class Scanner
    {
        public static ScanResult Analyze(string source)
        {
            var result = new ScanResult();

            int line = 1;
            int col = 1;
            int i = 0;

            bool IsValidInteger(string text)
            {
                if (text == "0")
                    return true;
                if (text.Length > 1 && text[0] == '0')
                    return false;
                return true;
            }

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

                if (ch == ' ')
                {
                    result.Lexemes.Add(new Lexeme
                    {
                        Code = LexemeCode.Space,
                        Type = Strings.Separator,
                        Text = $"({Strings.Space})",
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

                    if (!IsValidInteger(text))
                    {
                        result.Lexemes.Add(new Lexeme
                        {
                            Code = LexemeCode.Error,
                            Type = Strings.Error,
                            Text = $"{Strings.InvalidLexeme} \"{text}\"",
                            Line = line,
                            StartColumn = startCol,
                            EndColumn = col - 1
                        });
                    }
                    else
                    {
                        result.Lexemes.Add(new Lexeme
                        {
                            Code = LexemeCode.Integer,
                            Type = Strings.Integer,
                            Text = text,
                            Line = line,
                            StartColumn = startCol,
                            EndColumn = col - 1
                        });
                    }

                    continue;
                }

                if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
                {
                    int startCol = col;
                    int startIndex = i;

                    while (i < source.Length &&
                          ((source[i] >= 'A' && source[i] <= 'Z') ||
                           (source[i] >= 'a' && source[i] <= 'z') ||
                           char.IsDigit(source[i])))
                    {
                        i++;
                        col++;
                    }

                    string word = source.Substring(startIndex, i - startIndex);

                    LexemeCode code;

                    switch (word)
                    {
                        case "Int":
                            code = LexemeCode.KeywordInt;
                            break;
                        case "const":
                            code = LexemeCode.KeywordConst;
                            break;
                        case "val":
                            code = LexemeCode.KeywordVal;
                            break;
                        default:
                            code = LexemeCode.Identifier;
                            break;
                    }

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

                    i++;
                    col++;
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

                    i++;
                    col++;
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

                    i++;
                    col++;
                    continue;
                }

                if (ch == '-')
                {
                    int minusCol = col;
                    int minusIndex = i;

                    i++;
                    col++;

                    if (i >= source.Length || !char.IsDigit(source[i]))
                    {
                        result.Lexemes.Add(new Lexeme
                        {
                            Code = LexemeCode.Minus,
                            Type = Strings.SubstractionOperator,
                            Text = "-",
                            Line = line,
                            StartColumn = minusCol,
                            EndColumn = minusCol
                        });

                        continue;
                    }

                    int numStartCol = col;
                    int numStartIndex = i;

                    while (i < source.Length && char.IsDigit(source[i]))
                    {
                        i++;
                        col++;
                    }

                    string number = source.Substring(numStartIndex, i - numStartIndex);
                    string full = "-" + number;

                    if (!IsValidInteger(number) || number == "0")
                    {
                        result.Lexemes.Add(new Lexeme
                        {
                            Code = LexemeCode.Error,
                            Type = Strings.Error,
                            Text = $"{Strings.InvalidLexeme} \"{full}\"",
                            Line = line,
                            StartColumn = minusCol,
                            EndColumn = minusCol + full.Length - 1
                        });

                        continue;
                    }

                    result.Lexemes.Add(new Lexeme
                    {
                        Code = LexemeCode.Minus,
                        Type = Strings.SubstractionOperator,
                        Text = "-",
                        Line = line,
                        StartColumn = minusCol,
                        EndColumn = minusCol
                    });

                    result.Lexemes.Add(new Lexeme
                    {
                        Code = LexemeCode.Integer,
                        Type = Strings.Integer,
                        Text = number,
                        Line = line,
                        StartColumn = numStartCol,
                        EndColumn = col - 1
                    });

                    continue;
                }

                int badStartCol = col;
                int badStartIndex = i;

                while (i < source.Length)
                {
                    char c = source[i];

                    bool isValid =
                        c == ' ' || c == '\n' ||
                        char.IsDigit(c) ||
                        (c >= 'A' && c <= 'Z') ||
                        (c >= 'a' && c <= 'z') ||
                        c == ':' || c == '=' || c == ';' || c == '-';

                    if (isValid)
                        break;

                    i++;
                    col++;
                }

                string bad = source.Substring(badStartIndex, i - badStartIndex);

                result.Lexemes.Add(new Lexeme
                {
                    Code = LexemeCode.Error,
                    Type = Strings.Error,
                    Text = $"{Strings.InvalidLexeme} \"{bad}\"",
                    Line = line,
                    StartColumn = badStartCol,
                    EndColumn = badStartCol + bad.Length - 1
                });
            }

            return result;
        }
    }
}
