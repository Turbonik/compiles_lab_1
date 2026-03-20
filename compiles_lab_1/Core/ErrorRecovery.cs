using System.Collections.Generic;

namespace compiles_lab_1.Core
{
    public static class ErrorRecovery
    {
        public static void SkipUntilExpected(
            List<Lexeme> tokens,
            ref int index,
            LexemeCode expected,
            LexemeCode sync)
        {
            while (index < tokens.Count)
            {
                var cur = tokens[index];

                if (cur.Code == expected)
                {
                    index++;
                    return;
                }

                if (cur.Code == sync)
                    return;

                index++;
            }
        }

        public static void SkipToSync(
            List<Lexeme> tokens,
            ref int index,
            LexemeCode sync)
        {
            while (index < tokens.Count &&
                   tokens[index].Code != sync)
            {
                index++;
            }
        }
    }
}
