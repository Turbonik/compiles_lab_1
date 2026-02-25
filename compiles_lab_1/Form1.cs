namespace compiles_lab_1
{
    public partial class Form1 : Form
    {
        private FileManager fileManager;

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
            HighlightAllÂñåToolStripMenuItem.Click += SelectAllText;

            toolStripButton2.Click += CreateFile;
            toolStripButton3.Click += OpenFile;
            toolStripButton4.Click += SaveFile;
            toolStripButton5.Click += UndoText;
            toolStripButton11.Click += RedoText;
            toolStripButton10.Click += CopyText;
            toolStripButton9.Click += CutText;
            toolStripButton8.Click += PasteText;
        }

        private void CreateFile(object sender, EventArgs e)
        {
            fileManager.CreateNew();
            richTextBox1.Clear();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            var text = fileManager.OpenFile();
            if (text != null)
                richTextBox1.Text = text;
        }

        private void SaveFile(object sender, EventArgs e)
        {
            fileManager.SaveFile(richTextBox1.Text);
        }

        private void SaveFileAs(object sender, EventArgs e)
        {
            fileManager.SaveFileAs(richTextBox1.Text);
        }

        private void ExitApp(object sender, EventArgs e)
        {
            Close();
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

        private void CutText(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void CopyText(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void PasteText(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void DeleteText(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void SelectAllText(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }
    }
}
