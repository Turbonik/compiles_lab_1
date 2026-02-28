namespace compiles_lab_1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileMenu = new ToolStripMenuItem();
            CreateToolStripMenuItem = new ToolStripMenuItem();
            OpenToolStripMenuItem = new ToolStripMenuItem();
            SaveToolStripMenuItem = new ToolStripMenuItem();
            SaveAsToolStripMenuItem = new ToolStripMenuItem();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            editMenu = new ToolStripMenuItem();
            CancelToolStripMenuItem = new ToolStripMenuItem();
            RepeatToolStripMenuItem = new ToolStripMenuItem();
            CutToolStripMenuItem = new ToolStripMenuItem();
            CopyToolStripMenuItem = new ToolStripMenuItem();
            PasteToolStripMenuItem = new ToolStripMenuItem();
            DeleteToolStripMenuItem = new ToolStripMenuItem();
            HighlightAllВсеToolStripMenuItem = new ToolStripMenuItem();
            textMenu = new ToolStripMenuItem();
            TaskToolStripMenuItem = new ToolStripMenuItem();
            GrammarToolStripMenuItem = new ToolStripMenuItem();
            ClassificationToolStripMenuItem = new ToolStripMenuItem();
            AnalysisToolStripMenuItem = new ToolStripMenuItem();
            ExampleToolStripMenuItem = new ToolStripMenuItem();
            SourceListToolStripMenuItem = new ToolStripMenuItem();
            CodeToolStripMenuItem = new ToolStripMenuItem();
            runMenu = new ToolStripMenuItem();
            helpMenu = new ToolStripMenuItem();
            CallHelpToolStripMenuItem = new ToolStripMenuItem();
            AboutToolStripMenuItem = new ToolStripMenuItem();
            localizationMenu = new ToolStripMenuItem();
            viewMenu = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStripButton11 = new ToolStripButton();
            toolStripButton10 = new ToolStripButton();
            toolStripButton9 = new ToolStripButton();
            toolStripButton8 = new ToolStripButton();
            toolStripButton7 = new ToolStripButton();
            toolStripButton6 = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            tabsStrip = new ToolStrip();
            tabContextMenu = new ContextMenuStrip();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            tableLayoutPanelMain = new TableLayoutPanel();
            tableLayoutPanelEditors = new TableLayoutPanel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            tableLayoutPanelEditors.SuspendLayout();
            SuspendLayout();

            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileMenu, editMenu, textMenu, runMenu, helpMenu, localizationMenu, viewMenu, toolStripMenuItem1, toolStripMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(582, 28);
            menuStrip1.TabIndex = 0;

            fileMenu.DropDownItems.AddRange(new ToolStripItem[] { CreateToolStripMenuItem, OpenToolStripMenuItem, SaveToolStripMenuItem, SaveAsToolStripMenuItem, ExitToolStripMenuItem });
            fileMenu.Name = "fileMenu";
            fileMenu.Size = new Size(59, 24);
            fileMenu.Text = "Файл";

            CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            CreateToolStripMenuItem.Size = new Size(192, 26);
            CreateToolStripMenuItem.Text = "Создать";

            OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            OpenToolStripMenuItem.Size = new Size(192, 26);
            OpenToolStripMenuItem.Text = "Открыть";

            SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            SaveToolStripMenuItem.Size = new Size(192, 26);
            SaveToolStripMenuItem.Text = "Сохранить";

            SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            SaveAsToolStripMenuItem.Size = new Size(192, 26);
            SaveAsToolStripMenuItem.Text = "Сохранить как";

            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new Size(192, 26);
            ExitToolStripMenuItem.Text = "Выход";

            editMenu.DropDownItems.AddRange(new ToolStripItem[] { CancelToolStripMenuItem, RepeatToolStripMenuItem, CutToolStripMenuItem, CopyToolStripMenuItem, PasteToolStripMenuItem, DeleteToolStripMenuItem, HighlightAllВсеToolStripMenuItem });
            editMenu.Name = "editMenu";
            editMenu.Size = new Size(74, 24);
            editMenu.Text = "Правка";

            CancelToolStripMenuItem.Name = "CancelToolStripMenuItem";
            CancelToolStripMenuItem.Size = new Size(186, 26);
            CancelToolStripMenuItem.Text = "Отменить";

            RepeatToolStripMenuItem.Name = "RepeatToolStripMenuItem";
            RepeatToolStripMenuItem.Size = new Size(186, 26);
            RepeatToolStripMenuItem.Text = "Повторить";

            CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            CutToolStripMenuItem.Size = new Size(186, 26);
            CutToolStripMenuItem.Text = "Вырезать";

            CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            CopyToolStripMenuItem.Size = new Size(186, 26);
            CopyToolStripMenuItem.Text = "Копировать";

            PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            PasteToolStripMenuItem.Size = new Size(186, 26);
            PasteToolStripMenuItem.Text = "Вставить";

            DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            DeleteToolStripMenuItem.Size = new Size(186, 26);
            DeleteToolStripMenuItem.Text = "Удалить";

            HighlightAllВсеToolStripMenuItem.Name = "HighlightAllВсеToolStripMenuItem";
            HighlightAllВсеToolStripMenuItem.Size = new Size(186, 26);
            HighlightAllВсеToolStripMenuItem.Text = "Выделить все";

            textMenu.DropDownItems.AddRange(new ToolStripItem[] { TaskToolStripMenuItem, GrammarToolStripMenuItem, ClassificationToolStripMenuItem, AnalysisToolStripMenuItem, ExampleToolStripMenuItem, SourceListToolStripMenuItem, CodeToolStripMenuItem });
            textMenu.Name = "textMenu";
            textMenu.Size = new Size(59, 24);
            textMenu.Text = "Текст";

            TaskToolStripMenuItem.Name = "TaskToolStripMenuItem";
            TaskToolStripMenuItem.Size = new Size(288, 26);
            TaskToolStripMenuItem.Text = "Постановка задачи";

            GrammarToolStripMenuItem.Name = "GrammarToolStripMenuItem";
            GrammarToolStripMenuItem.Size = new Size(288, 26);
            GrammarToolStripMenuItem.Text = "Грамматика";

            ClassificationToolStripMenuItem.Name = "ClassificationToolStripMenuItem";
            ClassificationToolStripMenuItem.Size = new Size(288, 26);
            ClassificationToolStripMenuItem.Text = "Классификация грамматики";

            AnalysisToolStripMenuItem.Name = "AnalysisToolStripMenuItem";
            AnalysisToolStripMenuItem.Size = new Size(288, 26);
            AnalysisToolStripMenuItem.Text = "Метод анализа";

            ExampleToolStripMenuItem.Name = "ExampleToolStripMenuItem";
            ExampleToolStripMenuItem.Size = new Size(288, 26);
            ExampleToolStripMenuItem.Text = "Тестовый пример";

            SourceListToolStripMenuItem.Name = "SourceListToolStripMenuItem";
            SourceListToolStripMenuItem.Size = new Size(288, 26);
            SourceListToolStripMenuItem.Text = "Список литературы";

            CodeToolStripMenuItem.Name = "CodeToolStripMenuItem";
            CodeToolStripMenuItem.Size = new Size(288, 26);
            CodeToolStripMenuItem.Text = "Исходный код программы";

            runMenu.Name = "runMenu";
            runMenu.Size = new Size(55, 24);
            runMenu.Text = "Пуск";

            helpMenu.DropDownItems.AddRange(new ToolStripItem[] { CallHelpToolStripMenuItem, AboutToolStripMenuItem });
            helpMenu.Name = "helpMenu";
            helpMenu.Size = new Size(81, 24);
            helpMenu.Text = "Справка";

            CallHelpToolStripMenuItem.Name = "CallHelpToolStripMenuItem";
            CallHelpToolStripMenuItem.Size = new Size(197, 26);
            CallHelpToolStripMenuItem.Text = "Вызов справки";

            AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            AboutToolStripMenuItem.Size = new Size(197, 26);
            AboutToolStripMenuItem.Text = "О программе";

            localizationMenu.Name = "localizationMenu";
            localizationMenu.Size = new Size(115, 24);
            localizationMenu.Text = "Локализация";

            viewMenu.Name = "viewMenu";
            viewMenu.Size = new Size(49, 24);
            viewMenu.Text = "Вид";

            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(14, 24);

            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(14, 24);

            toolStrip1.AutoSize = false;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton2, toolStripButton3, toolStripButton4, toolStripButton5, toolStripButton11, toolStripButton10, toolStripButton9, toolStripButton8, toolStripButton7, toolStripButton6, toolStripButton1 });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(582, 54);
            toolStrip1.TabIndex = 1;

            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(36, 51);
            toolStripButton2.ToolTipText = "Создать";

            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(36, 51);
            toolStripButton3.ToolTipText = "Открыть";

            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(36, 51);
            toolStripButton4.ToolTipText = "Сохранить";

            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(36, 51);
            toolStripButton5.ToolTipText = "Отменить";

            toolStripButton11.Image = (Image)resources.GetObject("toolStripButton11.Image");
            toolStripButton11.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton11.Name = "toolStripButton11";
            toolStripButton11.Size = new Size(36, 51);
            toolStripButton11.ToolTipText = "Повторить";

            toolStripButton10.Image = (Image)resources.GetObject("toolStripButton10.Image");
            toolStripButton10.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton10.Name = "toolStripButton10";
            toolStripButton10.Size = new Size(36, 51);
            toolStripButton10.ToolTipText = "Копировать";

            toolStripButton9.Image = (Image)resources.GetObject("toolStripButton9.Image");
            toolStripButton9.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton9.Name = "toolStripButton9";
            toolStripButton9.Size = new Size(36, 51);
            toolStripButton9.ToolTipText = "Вырезать";

            toolStripButton8.Image = (Image)resources.GetObject("toolStripButton8.Image");
            toolStripButton8.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton8.Name = "toolStripButton8";
            toolStripButton8.Size = new Size(36, 51);
            toolStripButton8.ToolTipText = "Вставить";

            toolStripButton7.Image = (Image)resources.GetObject("toolStripButton7.Image");
            toolStripButton7.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton7.Name = "toolStripButton7";
            toolStripButton7.Size = new Size(36, 51);
            toolStripButton7.ToolTipText = "Пуск";

            toolStripButton6.Image = (Image)resources.GetObject("toolStripButton6.Image");
            toolStripButton6.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(36, 51);
            toolStripButton6.ToolTipText = "Вызов справки";

            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(36, 51);
            toolStripButton1.ToolTipText = "О программе";

            tabsStrip.AutoSize = false;
            tabsStrip.ImageScalingSize = new Size(20, 20);
            tabsStrip.Dock = DockStyle.Top;
            tabsStrip.GripStyle = ToolStripGripStyle.Hidden;
            tabsStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            tabsStrip.Height = 30;

            tabContextMenu.Items.Add("Закрыть вкладку");

            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(8, 8);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(560, 121);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";

            richTextBox2.Dock = DockStyle.Fill;
            richTextBox2.Enabled = false;
            richTextBox2.Location = new Point(8, 135);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(560, 122);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = "";

            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelMain.Controls.Add(menuStrip1, 0, 0);
            tableLayoutPanelMain.Controls.Add(toolStrip1, 0, 1);
            tableLayoutPanelMain.Controls.Add(tabsStrip, 0, 2);
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelEditors, 0, 3);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 4;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Size = new Size(582, 353);
            tableLayoutPanelMain.TabIndex = 0;

            tableLayoutPanelEditors.ColumnCount = 1;
            tableLayoutPanelEditors.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelEditors.Controls.Add(richTextBox1, 0, 0);
            tableLayoutPanelEditors.Controls.Add(richTextBox2, 0, 1);
            tableLayoutPanelEditors.Dock = DockStyle.Fill;
            tableLayoutPanelEditors.Location = new Point(3, 85);
            tableLayoutPanelEditors.Name = "tableLayoutPanelEditors";
            tableLayoutPanelEditors.Padding = new Padding(5);
            tableLayoutPanelEditors.RowCount = 2;
            tableLayoutPanelEditors.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelEditors.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelEditors.Size = new Size(576, 265);
            tableLayoutPanelEditors.TabIndex = 2;

            ClientSize = new Size(582, 353);
            Controls.Add(tableLayoutPanelMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(600, 400);
            Name = "Form1";
            Text = "Текстовый редактор";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelMain.PerformLayout();
            tableLayoutPanelEditors.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem editMenu;
        private ToolStripMenuItem textMenu;
        private ToolStripMenuItem runMenu;
        private ToolStripMenuItem helpMenu;
        private ToolStripMenuItem localizationMenu;
        private ToolStripMenuItem viewMenu;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton11;
        private ToolStripButton toolStripButton10;
        private ToolStripButton toolStripButton9;
        private ToolStripButton toolStripButton8;
        private ToolStripButton toolStripButton7;
        private ToolStripButton toolStripButton6;
        private ToolStripButton toolStripButton1;

        private ToolStrip tabsStrip;
        private ContextMenuStrip tabContextMenu;

        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;

        private TableLayoutPanel tableLayoutPanelMain;
        private TableLayoutPanel tableLayoutPanelEditors;

        private ToolStripMenuItem CreateToolStripMenuItem;
        private ToolStripMenuItem OpenToolStripMenuItem;
        private ToolStripMenuItem SaveToolStripMenuItem;
        private ToolStripMenuItem SaveAsToolStripMenuItem;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private ToolStripMenuItem CancelToolStripMenuItem;
        private ToolStripMenuItem RepeatToolStripMenuItem;
        private ToolStripMenuItem CutToolStripMenuItem;
        private ToolStripMenuItem CopyToolStripMenuItem;
        private ToolStripMenuItem PasteToolStripMenuItem;
        private ToolStripMenuItem DeleteToolStripMenuItem;
        private ToolStripMenuItem HighlightAllВсеToolStripMenuItem;
        private ToolStripMenuItem TaskToolStripMenuItem;
        private ToolStripMenuItem GrammarToolStripMenuItem;
        private ToolStripMenuItem ClassificationToolStripMenuItem;
        private ToolStripMenuItem AnalysisToolStripMenuItem;
        private ToolStripMenuItem ExampleToolStripMenuItem;
        private ToolStripMenuItem SourceListToolStripMenuItem;
        private ToolStripMenuItem CodeToolStripMenuItem;
        private ToolStripMenuItem CallHelpToolStripMenuItem;
        private ToolStripMenuItem AboutToolStripMenuItem;
    }
}

