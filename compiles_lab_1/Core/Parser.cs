using System;
using System.Collections.Generic;

namespace compiles_lab_1.Core
{
    public enum ParsePhase
    {
        ExpectStart,
        ExpectVal,
        ExpectId,
        ExpectColon,
        ExpectIntKeyword,
        ExpectAssign,
        ExpectNumber,
        Done
    }

    public class ParseError
    {
        public string Fragment { get; set; }
        public string Message { get; set; }
        public int Line { get; set; }
        public int StartColumn { get; set; }
        public int EndColumn { get; set; }
    }

    public class ParseResult
    {
        public List<ParseError> Errors { get; } = new();
    }

    public static class Parser
    {
        static string MsgConst => $"{Strings.Expkey} \"const\"";
        static string MsgVal => $"{Strings.Expkey} \"val\"";
        static string MsgInt => $"{Strings.Expkey} \"Int\"";
        static string MsgColon => $"{Strings.Expsymb} ':'";
        static string MsgAssign => $"{Strings.Expsymb} '='";
        static string MsgNumber => Strings.Expnum;
        static string MsgId => $"{Strings.Expid}";
        static string MsgSemi => $"{Strings.Expsymb} ';'";

        public static ParseResult Analyze(string source)
        {
            var scan = Scanner.Analyze(source);
            var tokens = scan.Lexemes;
            var result = new ParseResult();

            int i = 0;
            ParsePhase phase = ParsePhase.ExpectStart;

            Lexeme Cur() => i < tokens.Count ? tokens[i] : null;
            void Adv() { if (i < tokens.Count) i++; }

            void AddBlockError(string msg, string fragment, Lexeme first, Lexeme last)
            {
                result.Errors.Add(new ParseError
                {
                    Fragment = fragment,
                    Message = msg,
                    Line = first.Line,
                    StartColumn = first.StartColumn,
                    EndColumn = last.EndColumn
                });
            }

            void AddPointError(string msg, Lexeme prev)
            {
                result.Errors.Add(new ParseError
                {
                    Fragment = "",
                    Message = msg,
                    Line = prev.Line,
                    StartColumn = prev.EndColumn + 1,
                    EndColumn = prev.EndColumn + 1
                });
            }

            void AddEOFError(string msg, Lexeme last)
            {
                result.Errors.Add(new ParseError
                {
                    Fragment = "",
                    Message = msg,
                    Line = last.Line,
                    StartColumn = last.EndColumn + 1,
                    EndColumn = last.EndColumn + 1
                });
            }

            bool ValidUnsigned(Lexeme lex)
            {
                var s = lex.Text;
                if (s == "0") return true;
                if (s.Length > 1 && s[0] == '0') return false;
                foreach (var c in s)
                    if (c < '0' || c > '9') return false;
                return true;
            }

            bool ValidSigned(Lexeme lex)
            {
                var s = lex.Text;
                if (s.Length == 0) return false;
                if (s[0] == '0') return false;
                foreach (var c in s)
                    if (c < '0' || c > '9') return false;
                return true;
            }

            bool IsRecoveryPoint(LexemeCode code)
            {
                return phase switch
                {
                    ParsePhase.ExpectStart =>
                        code is LexemeCode.KeywordConst
                               or LexemeCode.KeywordVal
                               or LexemeCode.KeywordInt
                               or LexemeCode.Semicolon,

                    ParsePhase.ExpectVal =>
                        code is LexemeCode.KeywordVal
                               or LexemeCode.Semicolon,

                    ParsePhase.ExpectId =>
                        code is LexemeCode.Semicolon,

                    ParsePhase.ExpectColon =>
                        code is LexemeCode.KeywordInt
                               or LexemeCode.Semicolon,

                    ParsePhase.ExpectIntKeyword =>
                        code is LexemeCode.KeywordInt
                               or LexemeCode.Semicolon,

                    ParsePhase.ExpectAssign =>
                        code is LexemeCode.Assign
                               or LexemeCode.Semicolon,

                    ParsePhase.ExpectNumber =>
                        code is LexemeCode.Semicolon,

                    ParsePhase.Done =>
                        code is LexemeCode.Semicolon,

                    _ => false
                };
            }

            void ConsumeGarbage(string msg)
            {
                int startIndex = i;
                var first = tokens[startIndex];
                int k = startIndex + 1;

                while (k < tokens.Count && !IsRecoveryPoint(tokens[k].Code))
                    k++;

                int endIndex = k - 1;
                var last = tokens[endIndex];

                string fragment = "";
                for (int j = startIndex; j <= endIndex; j++)
                    fragment += tokens[j].Text;

                AddBlockError(msg, fragment, first, last);
                i = k;

                if (i >= tokens.Count)
                    phase = ParsePhase.ExpectStart;
            }

            void AfterRecovery(ref ParsePhase phase)
            {
                var t = Cur();
                if (t == null) return;

                switch (t.Code)
                {
                    case LexemeCode.KeywordConst:
                        Adv();
                        phase = ParsePhase.ExpectVal;
                        break;

                    case LexemeCode.KeywordVal:
                        Adv();
                        phase = ParsePhase.ExpectId;
                        break;

                    case LexemeCode.KeywordInt:
                        Adv();
                        phase = ParsePhase.ExpectAssign;
                        break;

                    case LexemeCode.Semicolon:
                        Adv();
                        phase = ParsePhase.ExpectStart;
                        break;
                }
            }

            while (true)
            {
                var t = Cur();

                if (t == null)
                {
                    if (tokens.Count > 0 && phase != ParsePhase.ExpectStart)
                    {
                        var last = tokens[^1];
                        switch (phase)
                        {
                            case ParsePhase.ExpectVal: AddEOFError(MsgVal, last); break;
                            case ParsePhase.ExpectId: AddEOFError(MsgId, last); break;
                            case ParsePhase.ExpectColon: AddEOFError(MsgColon, last); break;
                            case ParsePhase.ExpectIntKeyword: AddEOFError(MsgInt, last); break;
                            case ParsePhase.ExpectAssign: AddEOFError(MsgAssign, last); break;
                            case ParsePhase.ExpectNumber: AddEOFError(MsgNumber, last); break;
                            case ParsePhase.Done: AddEOFError(MsgSemi, last); break;
                        }
                    }
                    break;
                }

                if (t.Code == LexemeCode.Error)
                {
                    AddBlockError(Strings.InvalidLexeme, t.Text, t, t);
                    Adv();
                    continue;
                }

                switch (phase)
                {
                    case ParsePhase.ExpectStart:

                        if (t.Code == LexemeCode.KeywordConst)
                        {
                            Adv();
                            phase = ParsePhase.ExpectVal;
                            break;
                        }

                        if (t.Code == LexemeCode.Semicolon)
                        {
                            Adv();
                            break;
                        }

                        ConsumeGarbage(MsgConst);
                        AfterRecovery(ref phase);
                        break;

                    case ParsePhase.ExpectVal:
                        if (t.Code == LexemeCode.KeywordVal)
                        {
                            Adv();
                            phase = ParsePhase.ExpectId;
                            break;
                        }

                        ConsumeGarbage(MsgVal);
                        AfterRecovery(ref phase);
                        break;

                    case ParsePhase.ExpectId:

                        if (t.Code == LexemeCode.Identifier &&
                          t.Text != "val" &&
                          t.Text != "const")
                        {
                            Adv();
                            phase = ParsePhase.ExpectColon;
                            break;
                        }
 
                        ConsumeGarbage(MsgId);
                        AfterRecovery(ref phase);
                        break;

                    case ParsePhase.ExpectColon:

                        if (t.Code == LexemeCode.Colon)
                        {
                            Adv();
                            phase = ParsePhase.ExpectIntKeyword;
                            break;
                        }

                        if (t.Code == LexemeCode.Semicolon)
                        {
                            var prev = tokens[i - 1];
                            AddPointError(MsgColon, prev);
                            Adv();
                            phase = ParsePhase.ExpectStart;
                            break;
                        }

                        ConsumeGarbage(MsgColon);
                        AfterRecovery(ref phase);
                        break;

                    case ParsePhase.ExpectIntKeyword:
                        if (t.Code == LexemeCode.KeywordInt)
                        {
                            Adv();
                            phase = ParsePhase.ExpectAssign;
                            break;
                        }

                        if (t.Code == LexemeCode.Semicolon)
                        {
                            var prev = tokens[i - 1];
                            AddPointError(MsgInt, prev);
                            Adv();
                            phase = ParsePhase.ExpectStart;
                            break;
                        }

                        ConsumeGarbage(MsgInt);
                        AfterRecovery(ref phase);
                        break;

                    case ParsePhase.ExpectAssign:
                        if (t.Code == LexemeCode.Assign)
                        {
                            Adv();
                            phase = ParsePhase.ExpectNumber;
                            break;
                        }

                        if (t.Code == LexemeCode.Semicolon)
                        {
                            var prev = tokens[i - 1];
                            AddPointError(MsgAssign, prev);
                            Adv();
                            phase = ParsePhase.ExpectStart;
                            break;
                        }

                        ConsumeGarbage(MsgAssign);
                        AfterRecovery(ref phase);
                        break;

                    case ParsePhase.ExpectNumber:

                        if (t.Code == LexemeCode.Integer)
                        {
                            if (!ValidUnsigned(t))
                            {
                                ConsumeGarbage(MsgNumber);
                                AfterRecovery(ref phase);
                                break;
                            }

                            Adv();
                            phase = ParsePhase.Done;
                            break;
                        }

                        if (t.Code == LexemeCode.Minus)
                        {
                            Adv();
                            var t2 = Cur();

                            if (t2 != null && t2.Code == LexemeCode.Integer)
                            {
                                if (!ValidSigned(t2))
                                {
                                    ConsumeGarbage(MsgNumber);
                                    AfterRecovery(ref phase);
                                    break;
                                }

                                Adv();
                                phase = ParsePhase.Done;
                                break;
                            }

                            ConsumeGarbage(MsgNumber);
                            AfterRecovery(ref phase);
                            break;
                        }

                        if (t.Code == LexemeCode.Semicolon)
                        {
                            var prev = tokens[i - 1];
                            AddPointError(MsgNumber, prev);
                            Adv();
                            phase = ParsePhase.ExpectStart;
                            break;
                        }

                        ConsumeGarbage(MsgNumber);
                        AfterRecovery(ref phase);
                        break;

                    case ParsePhase.Done:
                        if (t.Code == LexemeCode.Semicolon)
                        {
                            Adv();
                            phase = ParsePhase.ExpectStart;
                            break;
                        }

                        ConsumeGarbage(MsgSemi);
                        AfterRecovery(ref phase);
                        break;
                }
            }

            return result;
        }
    }
}
