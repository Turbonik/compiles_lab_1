using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace compiles_lab_1.Core
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

            int wordStart = selStart;
            while (wordStart > 0 && !char.IsWhiteSpace(box.Text[wordStart - 1]))
                wordStart--;

            int wordEnd = selStart;
            while (wordEnd < box.Text.Length && !char.IsWhiteSpace(box.Text[wordEnd]))
                wordEnd++;

            if (wordEnd > wordStart)
            {
                string original = box.Text.Substring(wordStart, wordEnd - wordStart);
                string lower = original.ToLower();

                if (keywords.Contains(lower))
                {
                    box.SelectionStart = wordStart;
                    box.SelectionLength = original.Length;

                    if (original != lower)
                    {
                        box.SelectedText = lower;
                        box.SelectionStart = wordStart;
                        box.SelectionLength = lower.Length;
                    }

                    box.SelectionColor = Color.Blue;
                }
                else
                {
                    box.SelectionStart = wordStart;
                    box.SelectionLength = original.Length;
                    box.SelectionColor = Color.Black;
                }
            }

            box.SelectionStart = selStart;
            box.SelectionLength = selLength;
        }
    }
}


