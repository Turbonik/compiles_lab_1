using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace compiles_lab_1
{
    public static class SyntaxHighlighter
    {
        private static readonly HashSet<string> keywords = new()
        {
            "if", "for", "while", "else", "return", "int", "string", "bool", "void"
        };

        public static void Highlight(RichTextBox box)
        {
            int selStart = box.SelectionStart;
            int selLength = box.SelectionLength;

            box.SuspendLayout();

            Color defaultColor = Color.Black;
            Color keywordColor = Color.Blue;

            int i = 0;
            while (i < box.Text.Length)
            {
                if (char.IsLetter(box.Text[i]))
                {
                    int start = i;
                    while (i < box.Text.Length && char.IsLetter(box.Text[i]))
                        i++;

                    string word = box.Text.Substring(start, i - start);

                    if (keywords.Contains(word.ToLower()))
                    {
                        box.Select(start, word.Length);
                        box.SelectionColor = keywordColor;
                    }
                    else
                    {
                        box.Select(start, word.Length);
                        box.SelectionColor = defaultColor;
                    }
                }
                else
                {
                    i++;
                }
            }

            box.Select(selStart, selLength);
            box.ResumeLayout();
        }
    }
}
