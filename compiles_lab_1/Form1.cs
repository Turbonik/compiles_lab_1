namespace compiles_lab_1
{
    public partial class Form1 : Form
    {
        private FileManager fileManager;

        private class DocumentTab
        {
            public string Title;
            public string FilePath;
            public string Text;
            public bool IsModified;
            public ToolStripButton Button;
        }

        private List<DocumentTab> documents = new();
        private DocumentTab currentDocument;

        public Form1()
        {
            InitializeComponent();
            fileManager = new FileManager();

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
            HighlightAllВсеToolStripMenuItem.Click += SelectAllText;

            toolStripButton2.Click += CreateFile;
            toolStripButton3.Click += OpenFile;
            toolStripButton4.Click += SaveFile;
            toolStripButton5.Click += UndoText;
            toolStripButton11.Click += RedoText;
            toolStripButton10.Click += CopyText;
            toolStripButton9.Click += CutText;
            toolStripButton8.Click += PasteText;

            FormClosing += Form1_FormClosing;

            tabContextMenu.Items[0].Click += (s, e) =>
            {
                if (currentDocument != null)
                    CloseDocument(currentDocument);
            };

            richTextBox1.TextChanged += (s, e) =>
            {
                if (currentDocument != null)
                    currentDocument.IsModified = true;
            };
        }
 
        private void CreateFile(object sender, EventArgs e)
        {
            if (!CanCreateNewDocument()) return;

            var doc = new DocumentTab
            {
                Title = "Новый документ",
                FilePath = null,
                Text = "",
                IsModified = false
            };

            var btn = new ToolStripButton(doc.Title);
            btn.CheckOnClick = false;
            btn.MouseUp += TabMouseUp;
            btn.Click += (s, ev) => SwitchToDocument(doc);

            doc.Button = btn;
            documents.Add(doc);
            tabsStrip.Items.Add(btn);

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

            richTextBox1.Text = doc.Text;

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
                MessageBox.Show(
                    "Достигнуто максимальное количество открытых файлов.",
                    "Ограничение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

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
                var result = MessageBox.Show(
                    "Сохранить изменения?",
                    "Закрытие документа",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

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
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show(
                "Вы действительно хотите выйти?",
                "Выход",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            foreach (var doc in documents.ToList())
            {
                if (!doc.IsModified)
                    continue;

                var r = MessageBox.Show(
                    $"Сохранить изменения в \"{doc.Title}\"?",
                    "Сохранение",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

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
