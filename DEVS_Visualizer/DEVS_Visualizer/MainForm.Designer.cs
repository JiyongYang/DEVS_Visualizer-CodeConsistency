namespace DEVS_Visualizer
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.nDrawingDocument = new Nevron.Diagram.NDrawingDocument();
            this.nDrawingView = new Nevron.Diagram.WinForm.NDrawingView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.ShowPlusMinus = false;
            this.treeView1.Size = new System.Drawing.Size(175, 309);
            this.treeView1.TabIndex = 0;
            this.treeView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDoubleClick);
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(12, 328);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(175, 341);
            this.treeView2.TabIndex = 1;
            this.treeView2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeView2_MouseDoubleClick);
            // 
            // nDrawingDocument
            // 
            this.nDrawingDocument.DesignTimeState = ((Nevron.Diagram.NBinaryState)(resources.GetObject("nDrawingDocument.DesignTimeState")));
            // 
            // nDrawingView
            // 
            this.nDrawingView.AllowDrop = true;
            this.nDrawingView.DesignTimeState = ((Nevron.Diagram.NBinaryState)(resources.GetObject("nDrawingView.DesignTimeState")));
            this.nDrawingView.Document = null;
            this.nDrawingView.Location = new System.Drawing.Point(194, 13);
            this.nDrawingView.Name = "nDrawingView";
            this.nDrawingView.RenderTechnology = Nevron.GraphicsCore.RenderTechnology.GDIPlus;
            this.nDrawingView.Size = new System.Drawing.Size(1058, 656);
            this.nDrawingView.TabIndex = 2;
            this.nDrawingView.Text = "nDrawingView";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.nDrawingView);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.treeView1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TreeView treeView2;
        private Nevron.Diagram.NDrawingDocument nDrawingDocument;
        private Nevron.Diagram.WinForm.NDrawingView nDrawingView;
    }
}

