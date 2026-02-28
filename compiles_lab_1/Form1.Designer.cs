using System.Windows.Forms;

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
            components = new System.ComponentModel.Container();
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
            TextSizeMenuItem = new ToolStripMenuItem();
            TextSizeComboBox = new ToolStripComboBox();
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
            tabContextMenu = new ContextMenuStrip(components);
            splitContainer1 = new SplitContainer();
            splitContainerLines = new SplitContainer();
            lineNumberBox = new RichTextBox();
            richTextBox1 = new RichTextBox();
            tabControlResults = new TabControl();
            tabPageResults = new TabPage();
            richTextBox2 = new RichTextBox();
            tabPageErrors = new TabPage();
            dataGridViewErrors = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            tableLayoutPanelMain = new TableLayoutPanel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerLines).BeginInit();
            splitContainerLines.Panel1.SuspendLayout();
            splitContainerLines.Panel2.SuspendLayout();
            splitContainerLines.SuspendLayout();
            tabControlResults.SuspendLayout();
            tabPageResults.SuspendLayout();
            tabPageErrors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewErrors).BeginInit();
            tableLayoutPanelMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileMenu, editMenu, textMenu, runMenu, helpMenu, localizationMenu, viewMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            // 
            // fileMenu
            // 
            fileMenu.DropDownItems.AddRange(new ToolStripItem[] { CreateToolStripMenuItem, OpenToolStripMenuItem, SaveToolStripMenuItem, SaveAsToolStripMenuItem, ExitToolStripMenuItem });
            fileMenu.Name = "fileMenu";
            fileMenu.Size = new Size(59, 24);
            fileMenu.Text = "Файл";
            // 
            // CreateToolStripMenuItem
            // 
            CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            CreateToolStripMenuItem.Size = new Size(192, 26);
            CreateToolStripMenuItem.Text = "Создать";
            // 
            // OpenToolStripMenuItem
            // 
            OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            OpenToolStripMenuItem.Size = new Size(192, 26);
            OpenToolStripMenuItem.Text = "Открыть";
            // 
            // SaveToolStripMenuItem
            // 
            SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            SaveToolStripMenuItem.Size = new Size(192, 26);
            SaveToolStripMenuItem.Text = "Сохранить";
            // 
            // SaveAsToolStripMenuItem
            // 
            SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            SaveAsToolStripMenuItem.Size = new Size(192, 26);
            SaveAsToolStripMenuItem.Text = "Сохранить как";
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new Size(192, 26);
            ExitToolStripMenuItem.Text = "Выход";
            // 
            // editMenu
            // 
            editMenu.DropDownItems.AddRange(new ToolStripItem[] { CancelToolStripMenuItem, RepeatToolStripMenuItem, CutToolStripMenuItem, CopyToolStripMenuItem, PasteToolStripMenuItem, DeleteToolStripMenuItem, HighlightAllВсеToolStripMenuItem });
            editMenu.Name = "editMenu";
            editMenu.Size = new Size(74, 24);
            editMenu.Text = "Правка";
            // 
            // CancelToolStripMenuItem
            // 
            CancelToolStripMenuItem.Name = "CancelToolStripMenuItem";
            CancelToolStripMenuItem.Size = new Size(186, 26);
            CancelToolStripMenuItem.Text = "Отменить";
            // 
            // RepeatToolStripMenuItem
            // 
            RepeatToolStripMenuItem.Name = "RepeatToolStripMenuItem";
            RepeatToolStripMenuItem.Size = new Size(186, 26);
            RepeatToolStripMenuItem.Text = "Повторить";
            // 
            // CutToolStripMenuItem
            // 
            CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            CutToolStripMenuItem.Size = new Size(186, 26);
            CutToolStripMenuItem.Text = "Вырезать";
            // 
            // CopyToolStripMenuItem
            // 
            CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            CopyToolStripMenuItem.Size = new Size(186, 26);
            CopyToolStripMenuItem.Text = "Копировать";
            // 
            // PasteToolStripMenuItem
            // 
            PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            PasteToolStripMenuItem.Size = new Size(186, 26);
            PasteToolStripMenuItem.Text = "Вставить";
            // 
            // DeleteToolStripMenuItem
            // 
            DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            DeleteToolStripMenuItem.Size = new Size(186, 26);
            DeleteToolStripMenuItem.Text = "Удалить";
            // 
            // HighlightAllВсеToolStripMenuItem
            // 
            HighlightAllВсеToolStripMenuItem.Name = "HighlightAllВсеToolStripMenuItem";
            HighlightAllВсеToolStripMenuItem.Size = new Size(186, 26);
            HighlightAllВсеToolStripMenuItem.Text = "Выделить все";
            // 
            // textMenu
            // 
            textMenu.DropDownItems.AddRange(new ToolStripItem[] { TaskToolStripMenuItem, GrammarToolStripMenuItem, ClassificationToolStripMenuItem, AnalysisToolStripMenuItem, ExampleToolStripMenuItem, SourceListToolStripMenuItem, CodeToolStripMenuItem });
            textMenu.Name = "textMenu";
            textMenu.Size = new Size(59, 24);
            textMenu.Text = "Текст";
            // 
            // TaskToolStripMenuItem
            // 
            TaskToolStripMenuItem.Name = "TaskToolStripMenuItem";
            TaskToolStripMenuItem.Size = new Size(288, 26);
            TaskToolStripMenuItem.Text = "Постановка задачи";
            // 
            // GrammarToolStripMenuItem
            // 
            GrammarToolStripMenuItem.Name = "GrammarToolStripMenuItem";
            GrammarToolStripMenuItem.Size = new Size(288, 26);
            GrammarToolStripMenuItem.Text = "Грамматика";
            // 
            // ClassificationToolStripMenuItem
            // 
            ClassificationToolStripMenuItem.Name = "ClassificationToolStripMenuItem";
            ClassificationToolStripMenuItem.Size = new Size(288, 26);
            ClassificationToolStripMenuItem.Text = "Классификация грамматики";
            // 
            // AnalysisToolStripMenuItem
            // 
            AnalysisToolStripMenuItem.Name = "AnalysisToolStripMenuItem";
            AnalysisToolStripMenuItem.Size = new Size(288, 26);
            AnalysisToolStripMenuItem.Text = "Метод анализа";
            // 
            // ExampleToolStripMenuItem
            // 
            ExampleToolStripMenuItem.Name = "ExampleToolStripMenuItem";
            ExampleToolStripMenuItem.Size = new Size(288, 26);
            ExampleToolStripMenuItem.Text = "Тестовый пример";
            // 
            // SourceListToolStripMenuItem
            // 
            SourceListToolStripMenuItem.Name = "SourceListToolStripMenuItem";
            SourceListToolStripMenuItem.Size = new Size(288, 26);
            SourceListToolStripMenuItem.Text = "Список литературы";
            // 
            // CodeToolStripMenuItem
            // 
            CodeToolStripMenuItem.Name = "CodeToolStripMenuItem";
            CodeToolStripMenuItem.Size = new Size(288, 26);
            CodeToolStripMenuItem.Text = "Исходный код программы";
            // 
            // runMenu
            // 
            runMenu.Name = "runMenu";
            runMenu.Size = new Size(55, 24);
            runMenu.Text = "Пуск";
            // 
            // helpMenu
            // 
            helpMenu.DropDownItems.AddRange(new ToolStripItem[] { CallHelpToolStripMenuItem, AboutToolStripMenuItem });
            helpMenu.Name = "helpMenu";
            helpMenu.Size = new Size(81, 24);
            helpMenu.Text = "Справка";
            // 
            // CallHelpToolStripMenuItem
            // 
            CallHelpToolStripMenuItem.Name = "CallHelpToolStripMenuItem";
            CallHelpToolStripMenuItem.Size = new Size(197, 26);
            CallHelpToolStripMenuItem.Text = "Вызов справки";
            // 
            // AboutToolStripMenuItem
            // 
            AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            AboutToolStripMenuItem.Size = new Size(197, 26);
            AboutToolStripMenuItem.Text = "О программе";
            // 
            // localizationMenu
            // 
            localizationMenu.Name = "localizationMenu";
            localizationMenu.Size = new Size(115, 24);
            localizationMenu.Text = "Локализация";
            // 
            // viewMenu
            // 
            viewMenu.DropDownItems.AddRange(new ToolStripItem[] { TextSizeMenuItem });
            viewMenu.Name = "viewMenu";
            viewMenu.Size = new Size(49, 24);
            viewMenu.Text = "Вид";
            // 
            // TextSizeMenuItem
            // 
            TextSizeMenuItem.DropDownItems.AddRange(new ToolStripItem[] { TextSizeComboBox });
            TextSizeMenuItem.Name = "TextSizeMenuItem";
            TextSizeMenuItem.Size = new Size(189, 26);
            TextSizeMenuItem.Text = "Размер текста";
            // 
            // TextSizeComboBox
            // 
            TextSizeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TextSizeComboBox.Items.AddRange(new object[] { "8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72" });
            TextSizeComboBox.Name = "TextSizeComboBox";
            TextSizeComboBox.Size = new Size(121, 28);
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton2, toolStripButton3, toolStripButton4, toolStripButton5, toolStripButton11, toolStripButton10, toolStripButton9, toolStripButton8, toolStripButton7, toolStripButton6, toolStripButton1 });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 54);
            toolStrip1.TabIndex = 1;
            // 
            // toolStripButton2
            // 
            toolStripButton2.AccessibleDescription = "";
            toolStripButton2.BackgroundImageLayout = ImageLayout.None;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(36, 51);
            toolStripButton2.ToolTipText = "Создать";
            // 
            // toolStripButton3
            // 
            toolStripButton3.AccessibleDescription = "";
            toolStripButton3.BackgroundImageLayout = ImageLayout.None;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(36, 51);
            toolStripButton3.ToolTipText = "Открыть";
            // 
            // toolStripButton4
            // 
            toolStripButton4.AccessibleDescription = "";
            toolStripButton4.BackgroundImageLayout = ImageLayout.None;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(36, 51);
            toolStripButton4.ToolTipText = "Сохранить";
            // 
            // toolStripButton5
            // 
            toolStripButton5.AccessibleDescription = "";
            toolStripButton5.BackgroundImageLayout = ImageLayout.None;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(36, 51);
            toolStripButton5.ToolTipText = "Отменить";
            // 
            // toolStripButton11
            // 
            toolStripButton11.AccessibleDescription = "";
            toolStripButton11.BackgroundImageLayout = ImageLayout.None;
            toolStripButton11.Image = (Image)resources.GetObject("toolStripButton11.Image");
            toolStripButton11.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton11.Name = "toolStripButton11";
            toolStripButton11.Size = new Size(36, 51);
            toolStripButton11.ToolTipText = "Повторить";
            // 
            // toolStripButton10
            // 
            toolStripButton10.AccessibleDescription = "";
            toolStripButton10.BackgroundImageLayout = ImageLayout.None;
            toolStripButton10.Image = (Image)resources.GetObject("toolStripButton10.Image");
            toolStripButton10.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton10.Name = "toolStripButton10";
            toolStripButton10.Size = new Size(36, 51);
            toolStripButton10.ToolTipText = "Копировать";
            // 
            // toolStripButton9
            // 
            toolStripButton9.AccessibleDescription = "";
            toolStripButton9.BackgroundImageLayout = ImageLayout.None;
            toolStripButton9.Image = (Image)resources.GetObject("toolStripButton9.Image");
            toolStripButton9.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton9.Name = "toolStripButton9";
            toolStripButton9.Size = new Size(36, 51);
            toolStripButton9.ToolTipText = "Вырезать";
            // 
            // toolStripButton8
            // 
            toolStripButton8.AccessibleDescription = "";
            toolStripButton8.BackgroundImageLayout = ImageLayout.None;
            toolStripButton8.Image = (Image)resources.GetObject("toolStripButton8.Image");
            toolStripButton8.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton8.Name = "toolStripButton8";
            toolStripButton8.Size = new Size(36, 51);
            toolStripButton8.ToolTipText = "Вставить";
            // 
            // toolStripButton7
            // 
            toolStripButton7.AccessibleDescription = "";
            toolStripButton7.BackgroundImageLayout = ImageLayout.None;
            toolStripButton7.Image = (Image)resources.GetObject("toolStripButton7.Image");
            toolStripButton7.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton7.Name = "toolStripButton7";
            toolStripButton7.Size = new Size(36, 51);
            toolStripButton7.ToolTipText = "Пуск";
            // 
            // toolStripButton6
            // 
            toolStripButton6.AccessibleDescription = "";
            toolStripButton6.BackgroundImageLayout = ImageLayout.None;
            toolStripButton6.Image = (Image)resources.GetObject("toolStripButton6.Image");
            toolStripButton6.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(36, 51);
            toolStripButton6.ToolTipText = "Вызов справки";
            // 
            // toolStripButton1
            // 
            toolStripButton1.AccessibleDescription = "";
            toolStripButton1.BackgroundImageLayout = ImageLayout.None;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(36, 51);
            toolStripButton1.ToolTipText = "О программе";
            // 
            // tabsStrip
            // 
            tabsStrip.AutoSize = false;
            tabsStrip.GripStyle = ToolStripGripStyle.Hidden;
            tabsStrip.ImageScalingSize = new Size(20, 20);
            tabsStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            tabsStrip.Location = new Point(0, 82);
            tabsStrip.Name = "tabsStrip";
            tabsStrip.Size = new Size(800, 30);
            tabsStrip.TabIndex = 2;
            // 
            // tabContextMenu
            // 
            tabContextMenu.ImageScalingSize = new Size(20, 20);
            tabContextMenu.Name = "tabContextMenu";
            tabContextMenu.Size = new Size(61, 4);
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 115);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainerLines);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabControlResults);
            splitContainer1.Size = new Size(794, 382);
            splitContainer1.SplitterDistance = 191;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 3;
            // 
            // splitContainerLines
            // 
            splitContainerLines.Dock = DockStyle.Fill;
            splitContainerLines.FixedPanel = FixedPanel.Panel1;
            splitContainerLines.IsSplitterFixed = true;
            splitContainerLines.Location = new Point(0, 0);
            splitContainerLines.Name = "splitContainerLines";
            // 
            // splitContainerLines.Panel1
            // 
            splitContainerLines.Panel1.Controls.Add(lineNumberBox);
            splitContainerLines.Panel1MinSize = 40;
            // 
            // splitContainerLines.Panel2
            // 
            splitContainerLines.Panel2.Controls.Add(richTextBox1);
            splitContainerLines.Size = new Size(794, 191);
            splitContainerLines.SplitterDistance = 40;
            splitContainerLines.SplitterWidth = 3;
            splitContainerLines.TabIndex = 0;
            // 
            // lineNumberBox
            // 
            lineNumberBox.BackColor = Color.LightGray;
            lineNumberBox.Dock = DockStyle.Fill;
            lineNumberBox.Enabled = false;
            lineNumberBox.Font = new Font("Segoe UI", 9F);
            lineNumberBox.ForeColor = Color.Black;
            lineNumberBox.Location = new Point(0, 0);
            lineNumberBox.Name = "lineNumberBox";
            lineNumberBox.ReadOnly = true;
            lineNumberBox.ScrollBars = RichTextBoxScrollBars.None;
            lineNumberBox.Size = new Size(40, 191);
            lineNumberBox.TabIndex = 0;
            lineNumberBox.Text = "";
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Enabled = false;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(751, 191);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // tabControlResults
            // 
            tabControlResults.Controls.Add(tabPageResults);
            tabControlResults.Controls.Add(tabPageErrors);
            tabControlResults.Dock = DockStyle.Fill;
            tabControlResults.Location = new Point(0, 0);
            tabControlResults.Name = "tabControlResults";
            tabControlResults.SelectedIndex = 0;
            tabControlResults.Size = new Size(794, 185);
            tabControlResults.TabIndex = 0;
            // 
            // tabPageResults
            // 
            tabPageResults.Controls.Add(richTextBox2);
            tabPageResults.Location = new Point(4, 29);
            tabPageResults.Name = "tabPageResults";
            tabPageResults.Size = new Size(786, 152);
            tabPageResults.TabIndex = 0;
            tabPageResults.Text = "Результаты";
            // 
            // richTextBox2
            // 
            richTextBox2.Dock = DockStyle.Fill;
            richTextBox2.Enabled = false;
            richTextBox2.Location = new Point(0, 0);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(786, 152);
            richTextBox2.TabIndex = 0;
            richTextBox2.Text = "";
            // 
            // tabPageErrors
            // 
            tabPageErrors.Controls.Add(dataGridViewErrors);
            tabPageErrors.Location = new Point(4, 29);
            tabPageErrors.Name = "tabPageErrors";
            tabPageErrors.Size = new Size(786, 152);
            tabPageErrors.TabIndex = 1;
            tabPageErrors.Text = "Ошибки";
            // 
            // dataGridViewErrors
            // 
            dataGridViewErrors.AllowUserToAddRows = false;
            dataGridViewErrors.AllowUserToDeleteRows = false;
            dataGridViewErrors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewErrors.ColumnHeadersHeight = 29;
            dataGridViewErrors.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewErrors.Dock = DockStyle.Fill;
            dataGridViewErrors.Location = new Point(0, 0);
            dataGridViewErrors.Name = "dataGridViewErrors";
            dataGridViewErrors.ReadOnly = true;
            dataGridViewErrors.RowHeadersVisible = false;
            dataGridViewErrors.RowHeadersWidth = 51;
            dataGridViewErrors.Size = new Size(786, 152);
            dataGridViewErrors.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "FilePath";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Line";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Column";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Message";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(menuStrip1, 0, 0);
            tableLayoutPanelMain.Controls.Add(toolStrip1, 0, 1);
            tableLayoutPanelMain.Controls.Add(tabsStrip, 0, 2);
            tableLayoutPanelMain.Controls.Add(splitContainer1, 0, 3);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 4;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Size = new Size(800, 500);
            tableLayoutPanelMain.TabIndex = 1;
            // 
            // Form1
            // 
            ClientSize = new Size(800, 500);
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
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainerLines.Panel1.ResumeLayout(false);
            splitContainerLines.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerLines).EndInit();
            splitContainerLines.ResumeLayout(false);
            tabControlResults.ResumeLayout(false);
            tabPageResults.ResumeLayout(false);
            tabPageErrors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewErrors).EndInit();
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelMain.PerformLayout();
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

        private SplitContainer splitContainer1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;

        private TabControl tabControlResults;
        private TabPage tabPageResults;
        private TabPage tabPageErrors;
        private DataGridView dataGridViewErrors;

        private TableLayoutPanel tableLayoutPanelMain;
        private SplitContainer splitContainerLines;
        private RichTextBox lineNumberBox;

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

        private ToolStripMenuItem TextSizeMenuItem;
        private ToolStripComboBox TextSizeComboBox;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
