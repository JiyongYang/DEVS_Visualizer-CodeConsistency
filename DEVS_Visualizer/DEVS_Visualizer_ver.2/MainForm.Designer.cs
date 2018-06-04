namespace DEVS_Visualizer_ver._2
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip_main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView_DEVSStructure = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel_TreeViewMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_TreeViewModelPool = new System.Windows.Forms.TableLayoutPanel();
            this.button_AddCM = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label_treeView_DEVSStructure = new System.Windows.Forms.Label();
            this.label_treeViw_ModelPool = new System.Windows.Forms.Label();
            this.tableLayoutPanel_MainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.nDrawingView = new Nevron.Diagram.WinForm.NDrawingView();
            this.nDrawingDocument = new Nevron.Diagram.NDrawingDocument();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip_main.SuspendLayout();
            this.tableLayoutPanel_TreeViewMain.SuspendLayout();
            this.tableLayoutPanel_TreeViewModelPool.SuspendLayout();
            this.tableLayoutPanel_MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_main
            // 
            this.menuStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip_main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_main.Name = "menuStrip_main";
            this.menuStrip_main.Size = new System.Drawing.Size(1487, 24);
            this.menuStrip_main.TabIndex = 0;
            this.menuStrip_main.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // treeView_DEVSStructure
            // 
            this.treeView_DEVSStructure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView_DEVSStructure.Location = new System.Drawing.Point(3, 40);
            this.treeView_DEVSStructure.Name = "treeView_DEVSStructure";
            this.treeView_DEVSStructure.Size = new System.Drawing.Size(211, 333);
            this.treeView_DEVSStructure.TabIndex = 1;
            // 
            // tableLayoutPanel_TreeViewMain
            // 
            this.tableLayoutPanel_TreeViewMain.ColumnCount = 1;
            this.tableLayoutPanel_TreeViewMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TreeViewMain.Controls.Add(this.tableLayoutPanel_TreeViewModelPool, 0, 3);
            this.tableLayoutPanel_TreeViewMain.Controls.Add(this.treeView_DEVSStructure, 0, 1);
            this.tableLayoutPanel_TreeViewMain.Controls.Add(this.label_treeView_DEVSStructure, 0, 0);
            this.tableLayoutPanel_TreeViewMain.Controls.Add(this.label_treeViw_ModelPool, 0, 2);
            this.tableLayoutPanel_TreeViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TreeViewMain.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_TreeViewMain.Name = "tableLayoutPanel_TreeViewMain";
            this.tableLayoutPanel_TreeViewMain.RowCount = 4;
            this.tableLayoutPanel_TreeViewMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel_TreeViewMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel_TreeViewMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel_TreeViewMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel_TreeViewMain.Size = new System.Drawing.Size(217, 754);
            this.tableLayoutPanel_TreeViewMain.TabIndex = 3;
            // 
            // tableLayoutPanel_TreeViewModelPool
            // 
            this.tableLayoutPanel_TreeViewModelPool.ColumnCount = 1;
            this.tableLayoutPanel_TreeViewModelPool.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_TreeViewModelPool.Controls.Add(this.button_AddCM, 0, 1);
            this.tableLayoutPanel_TreeViewModelPool.Controls.Add(this.treeView1, 0, 0);
            this.tableLayoutPanel_TreeViewModelPool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_TreeViewModelPool.Location = new System.Drawing.Point(3, 416);
            this.tableLayoutPanel_TreeViewModelPool.Name = "tableLayoutPanel_TreeViewModelPool";
            this.tableLayoutPanel_TreeViewModelPool.RowCount = 2;
            this.tableLayoutPanel_TreeViewModelPool.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.72603F));
            this.tableLayoutPanel_TreeViewModelPool.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.27397F));
            this.tableLayoutPanel_TreeViewModelPool.Size = new System.Drawing.Size(211, 335);
            this.tableLayoutPanel_TreeViewModelPool.TabIndex = 5;
            // 
            // button_AddCM
            // 
            this.button_AddCM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_AddCM.Location = new System.Drawing.Point(3, 303);
            this.button_AddCM.Name = "button_AddCM";
            this.button_AddCM.Size = new System.Drawing.Size(205, 29);
            this.button_AddCM.TabIndex = 4;
            this.button_AddCM.Text = "Add Coupled Model";
            this.button_AddCM.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(205, 294);
            this.treeView1.TabIndex = 2;
            // 
            // label_treeView_DEVSStructure
            // 
            this.label_treeView_DEVSStructure.AutoSize = true;
            this.label_treeView_DEVSStructure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_treeView_DEVSStructure.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_treeView_DEVSStructure.Location = new System.Drawing.Point(3, 0);
            this.label_treeView_DEVSStructure.Name = "label_treeView_DEVSStructure";
            this.label_treeView_DEVSStructure.Size = new System.Drawing.Size(211, 37);
            this.label_treeView_DEVSStructure.TabIndex = 6;
            this.label_treeView_DEVSStructure.Text = "DEVS_Structure";
            this.label_treeView_DEVSStructure.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label_treeViw_ModelPool
            // 
            this.label_treeViw_ModelPool.AutoSize = true;
            this.label_treeViw_ModelPool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_treeViw_ModelPool.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_treeViw_ModelPool.Location = new System.Drawing.Point(3, 376);
            this.label_treeViw_ModelPool.Name = "label_treeViw_ModelPool";
            this.label_treeViw_ModelPool.Size = new System.Drawing.Size(211, 37);
            this.label_treeViw_ModelPool.TabIndex = 7;
            this.label_treeViw_ModelPool.Text = "DEVS_Model Pool";
            this.label_treeViw_ModelPool.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel_MainPanel
            // 
            this.tableLayoutPanel_MainPanel.ColumnCount = 2;
            this.tableLayoutPanel_MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel_MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel_MainPanel.Controls.Add(this.tableLayoutPanel_TreeViewMain, 0, 0);
            this.tableLayoutPanel_MainPanel.Controls.Add(this.nDrawingView, 1, 0);
            this.tableLayoutPanel_MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_MainPanel.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel_MainPanel.Name = "tableLayoutPanel_MainPanel";
            this.tableLayoutPanel_MainPanel.RowCount = 1;
            this.tableLayoutPanel_MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_MainPanel.Size = new System.Drawing.Size(1487, 760);
            this.tableLayoutPanel_MainPanel.TabIndex = 4;
            // 
            // nDrawingView
            // 
            this.nDrawingView.AllowDrop = true;
            this.nDrawingView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nDrawingView.DesignTimeState = ((Nevron.Diagram.NBinaryState)(resources.GetObject("nDrawingView.DesignTimeState")));
            this.nDrawingView.Document = null;
            this.nDrawingView.Location = new System.Drawing.Point(226, 3);
            this.nDrawingView.Name = "nDrawingView";
            this.nDrawingView.RenderTechnology = Nevron.GraphicsCore.RenderTechnology.GDIPlus;
            this.nDrawingView.Size = new System.Drawing.Size(1258, 754);
            this.nDrawingView.TabIndex = 4;
            this.nDrawingView.Text = "nDrawingView1";
            // 
            // nDrawingDocument
            // 
            this.nDrawingDocument.DesignTimeState = ((Nevron.Diagram.NBinaryState)(resources.GetObject("nDrawingDocument.DesignTimeState")));
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 784);
            this.Controls.Add(this.tableLayoutPanel_MainPanel);
            this.Controls.Add(this.menuStrip_main);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip_main.ResumeLayout(false);
            this.menuStrip_main.PerformLayout();
            this.tableLayoutPanel_TreeViewMain.ResumeLayout(false);
            this.tableLayoutPanel_TreeViewMain.PerformLayout();
            this.tableLayoutPanel_TreeViewModelPool.ResumeLayout(false);
            this.tableLayoutPanel_MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView_DEVSStructure;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TreeViewMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_TreeViewModelPool;
        private System.Windows.Forms.Button button_AddCM;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label_treeView_DEVSStructure;
        private System.Windows.Forms.Label label_treeViw_ModelPool;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_MainPanel;
        private Nevron.Diagram.WinForm.NDrawingView nDrawingView;
        private Nevron.Diagram.NDrawingDocument nDrawingDocument;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

