using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;

namespace compiles_lab_1
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern int GetScrollPos(IntPtr hWnd, int nBar);

        [DllImport("user32.dll")]
        static extern int SetScrollPos(IntPtr hWnd, int nBar, int nPos, bool bRedraw);

        [DllImport("user32.dll")]
        static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        const int SB_VERT = 1;
        const int WM_VSCROLL = 0x115;
        const int SB_THUMBPOSITION = 4;

        private FileManager fileManager;

        private class DocumentTab
        {
            public string Title;
            public string FilePath;
            public string Text;
            public bool IsModified;
            public ToolStripButton Button;
        }

        private readonly List<DocumentTab> documents = new();
        private DocumentTab currentDocument;
        private bool _internalTextUpdate = false;

        public Form1()
        {
            InitializeComponent();
            fileManager = new FileManager();
            ReattachEvents();
         
        }

        private void SetLanguage(string culture)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            var res = new ComponentResourceManager(typeof(Form1));
            SuspendLayout();
            ApplyResourcesRecursive(this, res);
            ResumeLayout(true);

            foreach (var doc in documents)
                if (doc.Button != null)
                    doc.Button.Text = doc.Title;

            if (currentDocument != null && currentDocument.Button != null)
            {
                foreach (ToolStripButton b in tabsStrip.Items)
                    b.BackColor = SystemColors.Control;
                currentDocument.Button.BackColor = Color.LightGray;
            }
        }

        private void ApplyResourcesRecursive(Control control, ComponentResourceManager res)
        {
            if (!string.IsNullOrEmpty(control.Name))
                res.ApplyResources(control, control.Name);

            if (control is MenuStrip ms)
                foreach (ToolStripItem item in ms.Items)
                    ApplyResourcesToolStripItem(item, res);

            if (control is ToolStrip ts)
                foreach (ToolStripItem item in ts.Items)
                    ApplyResourcesToolStripItem(item, res);

            foreach (Control child in control.Controls)
                ApplyResourcesRecursive(child, res);
        }

        private void ApplyResourcesToolStripItem(ToolStripItem item, ComponentResourceManager res)
        {
            if (!string.IsNullOrEmpty(item.Name))
                res.ApplyResources(item, item.Name);

            if (item is ToolStripDropDownItem dd)
                foreach (ToolStripItem sub in dd.DropDownItems)
                    ApplyResourcesToolStripItem(sub, res);
        }
 
        private void ReattachEvents()
        {
            if (tabContextMenu.Items.Count == 0)
                tabContextMenu.Items.Add(Strings.CloseTab);

            TextSizeComboBox.Text = "9";
            splitContainer1.Panel1.AllowDrop = true;
            richTextBox1.AllowDrop = true;
            
            localizationMenu.DropDownItems.Add("English", null, (s, e) => SetLanguage("en"));
            localizationMenu.DropDownItems.Add("Ðóññêèé", null, (s, e) => SetLanguage("ru"));

            CreateToolStripMenuItem.Click += CreateFile;
            OpenToolStripMenuItem.Click += OpenFile;
            SaveToolStripMenuItem.Click += SaveFile;
            SaveAsToolStripMenuItem.Click += SaveFileAs;
            ExitToolStripMenuItem.Click += ExitApp;

            CancelToolStripMenuItem.Click += UndoText;
            RepeatToolStripMenuItem.Click += RedoText;
            CutToolStripMenuItem.Click += CutText;
            CopyToolStripMenuItem.Click += CopyText;
            PasteToolStripMenuItem.Click += PasteText;
            DeleteToolStripMenuItem.Click += DeleteText;
            HighlightAllÂñåToolStripMenuItem.Click += SelectAllText;

            toolStripButton2.Click += CreateFile;
            toolStripButton3.Click += OpenFile;
            toolStripButton4.Click += SaveFile;
            toolStripButton5.Click += UndoText;
            toolStripButton11.Click += RedoText;
            toolStripButton10.Click += CopyText;
            toolStripButton9.Click += CutText;
            toolStripButton8.Click += PasteText;

            richTextBox1.VScroll += (s, e) => { SyncScroll(); UpdateLineNumberWidth(); };

            FormClosing += Form1_FormClosing;

            TextSizeComboBox.SelectedIndexChanged += (s, e) =>
            {
                if (float.TryParse(TextSizeComboBox.Text, out float size))
                    SetEditorFontSize(size);
            };

            splitContainer1.Panel1.DragEnter += File_DragEnter;
            splitContainer1.Panel1.DragDrop += File_DragDrop;

            tabContextMenu.Items[0].Click += (s, e) =>
            {
                if (currentDocument != null)
                    CloseDocument(currentDocument);
            };

            richTextBox1.TextChanged += (s, e) =>
            {
                if (_internalTextUpdate) return;

                int caretIndex = richTextBox1.SelectionStart;
                Point caretPos = richTextBox1.GetPositionFromCharIndex(caretIndex);

                if (caretPos.Y > richTextBox1.ClientSize.Height - richTextBox1.Font.Height * 2)
                    richTextBox1.ScrollToCaret();

                if (currentDocument != null)
                    currentDocument.IsModified = true;

                UpdateLineNumbers();
                SyncScroll();
            };
        }

        private void CreateFile(object sender, EventArgs e)
        {
            if (!CanCreateNewDocument()) return;

            var doc = new DocumentTab
            {
                Title = Strings.NewDocument,
                FilePath = null,
                Text = "",
                IsModified = false
            };

            var btn = new ToolStripButton(doc.Title);
            btn.MouseUp += TabMouseUp;
            btn.Click += (s, ev) => SwitchToDocument(doc);

            doc.Button = btn;
            documents.Add(doc);
            tabsStrip.Items.Add(btn);
            richTextBox1.Enabled = true;
            SwitchToDocument(doc);
        }

        private void TabMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var btn = sender as ToolStripButton;
                var doc = documents.FirstOrDefault(d => d.Button == btn);
                if (doc != null)
                {
                    SwitchToDocument(doc);
                    tabContextMenu.Show(Cursor.Position);
                }
            }
        }

        private void SwitchToDocument(DocumentTab doc)
        {
            if (currentDocument != null)
                currentDocument.Text = richTextBox1.Text;

            currentDocument = doc;

            _internalTextUpdate = true;
            richTextBox1.Text = doc.Text;
            UpdateLineNumberWidth();
            _internalTextUpdate = false;

            foreach (ToolStripButton b in tabsStrip.Items)
                b.BackColor = SystemColors.Control;

            doc.Button.BackColor = Color.LightGray;
        }

        private void OpenFile(object sender, EventArgs e)
        {
            if (!CanCreateNewDocument()) return;

            string path;
            var text = fileManager.OpenFileDialogAndRead(out path);
            if (text == null)
                return;

            OpenFileFromPath(path);
            richTextBox1.Enabled = true;
        }

        private void OpenFileFromPath(string path)
        {
            if (!CanCreateNewDocument()) return;

            string text = File.ReadAllText(path);

            var doc = new DocumentTab
            {
                Title = Path.GetFileName(path),
                FilePath = path,
                Text = text,
                IsModified = false
            };

            var btn = new ToolStripButton(doc.Title);
            btn.MouseUp += TabMouseUp;
            btn.Click += (s, ev) => SwitchToDocument(doc);

            doc.Button = btn;
            documents.Add(doc);
            tabsStrip.Items.Add(btn);

            SwitchToDocument(doc);
        }

        private bool CanCreateNewDocument()
        {
            if (documents.Count >= 14)
            {
                MessageBox.Show(Strings.MaxFiles, Strings.Limit, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void SaveFile(object sender, EventArgs e)
        {
            if (currentDocument == null)
                return;

            currentDocument.Text = richTextBox1.Text;

            if (currentDocument.FilePath == null)
            {
                SaveFileAs(sender, e);
                return;
            }

            fileManager.SaveFile(currentDocument.FilePath, currentDocument.Text);
            currentDocument.IsModified = false;
        }

        private void SaveFileAs(object sender, EventArgs e)
        {
            if (currentDocument == null)
                return;

            currentDocument.Text = richTextBox1.Text;

            var path = fileManager.SaveFileDialogAndWrite(currentDocument.Text);
            if (path != null)
            {
                currentDocument.FilePath = path;
                currentDocument.Title = Path.GetFileName(path);
                currentDocument.Button.Text = currentDocument.Title;
                currentDocument.IsModified = false;
            }
        }

        private void CloseDocument(DocumentTab doc)
        {
            if (doc.IsModified)
            {
                var result = MessageBox.Show(Strings.SaveChanges, Strings.CloseDocument, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Cancel)
                    return;

                if (result == DialogResult.Yes)
                {
                    currentDocument = doc;
                    SaveFile(null, null);
                }
            }

            tabsStrip.Items.Remove(doc.Button);
            documents.Remove(doc);

            if (documents.Count > 0)
                SwitchToDocument(documents.Last());
            else
            {
                currentDocument = null;
                richTextBox1.Clear();
                richTextBox1.Enabled = false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show(Strings.ExitConfirm, Strings.Exit, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            foreach (var doc in documents.ToList())
            {
                if (!doc.IsModified)
                    continue;

                var r = MessageBox.Show($"{Strings.SaveChangesIn} \"{doc.Title}\"?", Strings.Saving, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (r == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }

                if (r == DialogResult.Yes)
                {
                    currentDocument = doc;
                    SaveFile(null, null);
                }
            }
        }

        private void UpdateLineNumbers()
        {
            int lineCount = richTextBox1.Lines.Length;
            var sb = new StringBuilder();

            for (int i = 1; i <= lineCount; i++)
                sb.AppendLine(i.ToString());

            lineNumberBox.Text = sb.ToString();
            UpdateLineNumberWidth();
        }

        private void UpdateLineNumberWidth()
        {
            int lineCount = Math.Max(1, richTextBox1.Lines.Length);
            string maxNumber = lineCount.ToString();
            int width = TextRenderer.MeasureText(maxNumber, lineNumberBox.Font).Width + 10;
            splitContainerLines.SplitterDistance = width;
        }

        private void SetEditorFontSize(float size)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, size);
            richTextBox2.Font = new Font(richTextBox2.Font.FontFamily, size);
            lineNumberBox.Font = new Font(richTextBox1.Font.FontFamily, size);
            UpdateLineNumberWidth();
        }

        private void File_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void File_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files.Length > 0)
            {
                string path = files[0];
                OpenFileFromPath(path);
                richTextBox1.Enabled = true;
            }
        }

        private void SyncScroll()
        {
            int pos = GetScrollPos(richTextBox1.Handle, SB_VERT);
            int firstVisibleChar = richTextBox1.GetCharIndexFromPosition(new Point(1, 1));
            int firstVisibleLine = richTextBox1.GetLineFromCharIndex(firstVisibleChar);
            int correctedPos = Math.Max(pos, firstVisibleLine);

            SetScrollPos(lineNumberBox.Handle, SB_VERT, correctedPos, true);

            SendMessage(
                lineNumberBox.Handle,
                WM_VSCROLL,
                (IntPtr)(correctedPos << 16 | SB_THUMBPOSITION),
                IntPtr.Zero
            );
        }

        private void UndoText(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo)
                richTextBox1.Undo();
        }

        private void RedoText(object sender, EventArgs e)
        {
            if (richTextBox1.CanRedo)
                richTextBox1.Redo();
        }

        private void CutText(object sender, EventArgs e) => richTextBox1.Cut();
        private void CopyText(object sender, EventArgs e) => richTextBox1.Copy();
        private void PasteText(object sender, EventArgs e) => richTextBox1.Paste();
        private void DeleteText(object sender, EventArgs e) => richTextBox1.SelectedText = "";
        private void SelectAllText(object sender, EventArgs e) => richTextBox1.SelectAll();

        private void ExitApp(object sender, EventArgs e) => Close();
    }
}
