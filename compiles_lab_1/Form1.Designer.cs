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
            tableLayoutPanelMain = new TableLayoutPanel();
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
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(splitContainer1, "splitContainer1");
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainerLines);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabControlResults);
            // 
            // splitContainerLines
            // 
            resources.ApplyResources(splitContainerLines, "splitContainerLines");
            splitContainerLines.FixedPanel = FixedPanel.Panel1;
            splitContainerLines.Name = "splitContainerLines";
            // 
            // splitContainerLines.Panel1
            // 
            splitContainerLines.Panel1.Controls.Add(lineNumberBox);
            // 
            // splitContainerLines.Panel2
            // 
            splitContainerLines.Panel2.Controls.Add(richTextBox1);
            // 
            // lineNumberBox
            // 
            lineNumberBox.BackColor = Color.LightGray;
            resources.ApplyResources(lineNumberBox, "lineNumberBox");
            lineNumberBox.ForeColor = Color.Black;
            lineNumberBox.Name = "lineNumberBox";
            lineNumberBox.ReadOnly = true;
            // 
            // richTextBox1
            // 
            resources.ApplyResources(richTextBox1, "richTextBox1");
            richTextBox1.Name = "richTextBox1";
            // 
            // tabControlResults
            // 
            tabControlResults.Controls.Add(tabPageResults);
            tabControlResults.Controls.Add(tabPageErrors);
            resources.ApplyResources(tabControlResults, "tabControlResults");
            tabControlResults.Name = "tabControlResults";
            tabControlResults.SelectedIndex = 0;
            // 
            // tabPageResults
            // 
            tabPageResults.Controls.Add(richTextBox2);
            resources.ApplyResources(tabPageResults, "tabPageResults");
            tabPageResults.Name = "tabPageResults";
            // 
            // richTextBox2
            // 
            resources.ApplyResources(richTextBox2, "richTextBox2");
            richTextBox2.Name = "richTextBox2";
            // 
            // tabPageErrors
            // 
            tabPageErrors.Controls.Add(dataGridViewErrors);
            resources.ApplyResources(tabPageErrors, "tabPageErrors");
            tabPageErrors.Name = "tabPageErrors";
            // 
            // dataGridViewErrors
            // 
            dataGridViewErrors.AllowUserToAddRows = false;
            dataGridViewErrors.AllowUserToDeleteRows = false;
            dataGridViewErrors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            resources.ApplyResources(dataGridViewErrors, "dataGridViewErrors");
            dataGridViewErrors.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewErrors.Name = "dataGridViewErrors";
            dataGridViewErrors.ReadOnly = true;
            dataGridViewErrors.RowHeadersVisible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            resources.ApplyResources(dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            resources.ApplyResources(dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            resources.ApplyResources(dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            resources.ApplyResources(dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileMenu, editMenu, textMenu, runMenu, helpMenu, localizationMenu, viewMenu });
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
            // 
            // fileMenu
            // 
            fileMenu.DropDownItems.AddRange(new ToolStripItem[] { CreateToolStripMenuItem, OpenToolStripMenuItem, SaveToolStripMenuItem, SaveAsToolStripMenuItem, ExitToolStripMenuItem });
            fileMenu.Name = "fileMenu";
            resources.ApplyResources(fileMenu, "fileMenu");
            // 
            // CreateToolStripMenuItem
            // 
            CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            resources.ApplyResources(CreateToolStripMenuItem, "CreateToolStripMenuItem");
            // 
            // OpenToolStripMenuItem
            // 
            OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            resources.ApplyResources(OpenToolStripMenuItem, "OpenToolStripMenuItem");
            // 
            // SaveToolStripMenuItem
            // 
            SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            resources.ApplyResources(SaveToolStripMenuItem, "SaveToolStripMenuItem");
            // 
            // SaveAsToolStripMenuItem
            // 
            SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            resources.ApplyResources(SaveAsToolStripMenuItem, "SaveAsToolStripMenuItem");
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            resources.ApplyResources(ExitToolStripMenuItem, "ExitToolStripMenuItem");
            // 
            // editMenu
            // 
            editMenu.DropDownItems.AddRange(new ToolStripItem[] { CancelToolStripMenuItem, RepeatToolStripMenuItem, CutToolStripMenuItem, CopyToolStripMenuItem, PasteToolStripMenuItem, DeleteToolStripMenuItem, HighlightAllВсеToolStripMenuItem });
            editMenu.Name = "editMenu";
            resources.ApplyResources(editMenu, "editMenu");
            // 
            // CancelToolStripMenuItem
            // 
            CancelToolStripMenuItem.Name = "CancelToolStripMenuItem";
            resources.ApplyResources(CancelToolStripMenuItem, "CancelToolStripMenuItem");
            // 
            // RepeatToolStripMenuItem
            // 
            RepeatToolStripMenuItem.Name = "RepeatToolStripMenuItem";
            resources.ApplyResources(RepeatToolStripMenuItem, "RepeatToolStripMenuItem");
            // 
            // CutToolStripMenuItem
            // 
            CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            resources.ApplyResources(CutToolStripMenuItem, "CutToolStripMenuItem");
            // 
            // CopyToolStripMenuItem
            // 
            CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            resources.ApplyResources(CopyToolStripMenuItem, "CopyToolStripMenuItem");
            // 
            // PasteToolStripMenuItem
            // 
            PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            resources.ApplyResources(PasteToolStripMenuItem, "PasteToolStripMenuItem");
            // 
            // DeleteToolStripMenuItem
            // 
            DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            resources.ApplyResources(DeleteToolStripMenuItem, "DeleteToolStripMenuItem");
            // 
            // HighlightAllВсеToolStripMenuItem
            // 
            HighlightAllВсеToolStripMenuItem.Name = "HighlightAllВсеToolStripMenuItem";
            resources.ApplyResources(HighlightAllВсеToolStripMenuItem, "HighlightAllВсеToolStripMenuItem");
            // 
            // textMenu
            // 
            textMenu.DropDownItems.AddRange(new ToolStripItem[] { TaskToolStripMenuItem, GrammarToolStripMenuItem, ClassificationToolStripMenuItem, AnalysisToolStripMenuItem, ExampleToolStripMenuItem, SourceListToolStripMenuItem, CodeToolStripMenuItem });
            textMenu.Name = "textMenu";
            resources.ApplyResources(textMenu, "textMenu");
            // 
            // TaskToolStripMenuItem
            // 
            TaskToolStripMenuItem.Name = "TaskToolStripMenuItem";
            resources.ApplyResources(TaskToolStripMenuItem, "TaskToolStripMenuItem");
            // 
            // GrammarToolStripMenuItem
            // 
            GrammarToolStripMenuItem.Name = "GrammarToolStripMenuItem";
            resources.ApplyResources(GrammarToolStripMenuItem, "GrammarToolStripMenuItem");
            // 
            // ClassificationToolStripMenuItem
            // 
            ClassificationToolStripMenuItem.Name = "ClassificationToolStripMenuItem";
            resources.ApplyResources(ClassificationToolStripMenuItem, "ClassificationToolStripMenuItem");
            // 
            // AnalysisToolStripMenuItem
            // 
            AnalysisToolStripMenuItem.Name = "AnalysisToolStripMenuItem";
            resources.ApplyResources(AnalysisToolStripMenuItem, "AnalysisToolStripMenuItem");
            // 
            // ExampleToolStripMenuItem
            // 
            ExampleToolStripMenuItem.Name = "ExampleToolStripMenuItem";
            resources.ApplyResources(ExampleToolStripMenuItem, "ExampleToolStripMenuItem");
            // 
            // SourceListToolStripMenuItem
            // 
            SourceListToolStripMenuItem.Name = "SourceListToolStripMenuItem";
            resources.ApplyResources(SourceListToolStripMenuItem, "SourceListToolStripMenuItem");
            // 
            // CodeToolStripMenuItem
            // 
            CodeToolStripMenuItem.Name = "CodeToolStripMenuItem";
            resources.ApplyResources(CodeToolStripMenuItem, "CodeToolStripMenuItem");
            // 
            // runMenu
            // 
            runMenu.Name = "runMenu";
            resources.ApplyResources(runMenu, "runMenu");
            // 
            // helpMenu
            // 
            helpMenu.DropDownItems.AddRange(new ToolStripItem[] { CallHelpToolStripMenuItem, AboutToolStripMenuItem });
            helpMenu.Name = "helpMenu";
            resources.ApplyResources(helpMenu, "helpMenu");
            // 
            // CallHelpToolStripMenuItem
            // 
            CallHelpToolStripMenuItem.Name = "CallHelpToolStripMenuItem";
            resources.ApplyResources(CallHelpToolStripMenuItem, "CallHelpToolStripMenuItem");
            // 
            // AboutToolStripMenuItem
            // 
            AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            resources.ApplyResources(AboutToolStripMenuItem, "AboutToolStripMenuItem");
            // 
            // localizationMenu
            // 
            localizationMenu.Name = "localizationMenu";
            resources.ApplyResources(localizationMenu, "localizationMenu");
            // 
            // viewMenu
            // 
            viewMenu.DropDownItems.AddRange(new ToolStripItem[] { TextSizeMenuItem });
            viewMenu.Name = "viewMenu";
            resources.ApplyResources(viewMenu, "viewMenu");
            // 
            // TextSizeMenuItem
            // 
            TextSizeMenuItem.DropDownItems.AddRange(new ToolStripItem[] { TextSizeComboBox });
            TextSizeMenuItem.Name = "TextSizeMenuItem";
            resources.ApplyResources(TextSizeMenuItem, "TextSizeMenuItem");
            // 
            // TextSizeComboBox
            // 
            TextSizeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TextSizeComboBox.Items.AddRange(new object[] { resources.GetString("TextSizeComboBox.Items"), resources.GetString("TextSizeComboBox.Items1"), resources.GetString("TextSizeComboBox.Items2"), resources.GetString("TextSizeComboBox.Items3"), resources.GetString("TextSizeComboBox.Items4"), resources.GetString("TextSizeComboBox.Items5"), resources.GetString("TextSizeComboBox.Items6"), resources.GetString("TextSizeComboBox.Items7"), resources.GetString("TextSizeComboBox.Items8"), resources.GetString("TextSizeComboBox.Items9"), resources.GetString("TextSizeComboBox.Items10"), resources.GetString("TextSizeComboBox.Items11"), resources.GetString("TextSizeComboBox.Items12"), resources.GetString("TextSizeComboBox.Items13"), resources.GetString("TextSizeComboBox.Items14"), resources.GetString("TextSizeComboBox.Items15") });
            TextSizeComboBox.Name = "TextSizeComboBox";
            resources.ApplyResources(TextSizeComboBox, "TextSizeComboBox");
            // 
            // toolStrip1
            // 
            resources.ApplyResources(toolStrip1, "toolStrip1");
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton2, toolStripButton3, toolStripButton4, toolStripButton5, toolStripButton11, toolStripButton10, toolStripButton9, toolStripButton8, toolStripButton7, toolStripButton6, toolStripButton1 });
            toolStrip1.Name = "toolStrip1";
            // 
            // toolStripButton2
            // 
            resources.ApplyResources(toolStripButton2, "toolStripButton2");
            toolStripButton2.Name = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            resources.ApplyResources(toolStripButton3, "toolStripButton3");
            toolStripButton3.Name = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            resources.ApplyResources(toolStripButton4, "toolStripButton4");
            toolStripButton4.Name = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            resources.ApplyResources(toolStripButton5, "toolStripButton5");
            toolStripButton5.Name = "toolStripButton5";
            // 
            // toolStripButton11
            // 
            resources.ApplyResources(toolStripButton11, "toolStripButton11");
            toolStripButton11.Name = "toolStripButton11";
            // 
            // toolStripButton10
            // 
            resources.ApplyResources(toolStripButton10, "toolStripButton10");
            toolStripButton10.Name = "toolStripButton10";
            // 
            // toolStripButton9
            // 
            resources.ApplyResources(toolStripButton9, "toolStripButton9");
            toolStripButton9.Name = "toolStripButton9";
            // 
            // toolStripButton8
            // 
            resources.ApplyResources(toolStripButton8, "toolStripButton8");
            toolStripButton8.Name = "toolStripButton8";
            // 
            // toolStripButton7
            // 
            resources.ApplyResources(toolStripButton7, "toolStripButton7");
            toolStripButton7.Name = "toolStripButton7";
            // 
            // toolStripButton6
            // 
            resources.ApplyResources(toolStripButton6, "toolStripButton6");
            toolStripButton6.Name = "toolStripButton6";
            // 
            // toolStripButton1
            // 
            resources.ApplyResources(toolStripButton1, "toolStripButton1");
            toolStripButton1.Name = "toolStripButton1";
            // 
            // tabsStrip
            // 
            resources.ApplyResources(tabsStrip, "tabsStrip");
            tabsStrip.GripStyle = ToolStripGripStyle.Hidden;
            tabsStrip.ImageScalingSize = new Size(20, 20);
            tabsStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            tabsStrip.Name = "tabsStrip";
            // 
            // tabContextMenu
            // 
            tabContextMenu.ImageScalingSize = new Size(20, 20);
            tabContextMenu.Name = "tabContextMenu";
            resources.ApplyResources(tabContextMenu, "tabContextMenu");
            // 
            // tableLayoutPanelMain
            // 
            resources.ApplyResources(tableLayoutPanelMain, "tableLayoutPanelMain");
            tableLayoutPanelMain.Controls.Add(menuStrip1, 0, 0);
            tableLayoutPanelMain.Controls.Add(toolStrip1, 0, 1);
            tableLayoutPanelMain.Controls.Add(tabsStrip, 0, 2);
            tableLayoutPanelMain.Controls.Add(splitContainer1, 0, 3);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            Controls.Add(tableLayoutPanelMain);
            Name = "Form1";
            WindowState = FormWindowState.Maximized;
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
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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
