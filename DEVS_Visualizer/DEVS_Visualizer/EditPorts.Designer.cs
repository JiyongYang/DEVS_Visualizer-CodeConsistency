namespace DEVS_Visualizer
{
    partial class EditPorts
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_InPorts = new System.Windows.Forms.ListBox();
            this.lb_OutPorts = new System.Windows.Forms.ListBox();
            this.label_inputports = new System.Windows.Forms.Label();
            this.label_outputports = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_input_add = new System.Windows.Forms.Button();
            this.btn_input_del = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_output_add = new System.Windows.Forms.Button();
            this.btn_output_del = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.41177F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.58823F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.Controls.Add(this.lb_InPorts, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_OutPorts, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_inputports, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_outputports, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(425, 228);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lb_InPorts
            // 
            this.lb_InPorts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_InPorts.FormattingEnabled = true;
            this.lb_InPorts.ItemHeight = 12;
            this.lb_InPorts.Location = new System.Drawing.Point(52, 3);
            this.lb_InPorts.Name = "lb_InPorts";
            this.lb_InPorts.Size = new System.Drawing.Size(316, 108);
            this.lb_InPorts.TabIndex = 0;
            // 
            // lb_OutPorts
            // 
            this.lb_OutPorts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_OutPorts.FormattingEnabled = true;
            this.lb_OutPorts.ItemHeight = 12;
            this.lb_OutPorts.Location = new System.Drawing.Point(52, 117);
            this.lb_OutPorts.Name = "lb_OutPorts";
            this.lb_OutPorts.Size = new System.Drawing.Size(316, 108);
            this.lb_OutPorts.TabIndex = 1;
            // 
            // label_inputports
            // 
            this.label_inputports.AutoSize = true;
            this.label_inputports.Location = new System.Drawing.Point(3, 0);
            this.label_inputports.Name = "label_inputports";
            this.label_inputports.Size = new System.Drawing.Size(36, 24);
            this.label_inputports.TabIndex = 2;
            this.label_inputports.Text = "Input Ports";
            // 
            // label_outputports
            // 
            this.label_outputports.AutoSize = true;
            this.label_outputports.Location = new System.Drawing.Point(3, 114);
            this.label_outputports.Name = "label_outputports";
            this.label_outputports.Size = new System.Drawing.Size(41, 24);
            this.label_outputports.TabIndex = 3;
            this.label_outputports.Text = "Output Ports";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btn_input_add, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_input_del, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(374, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(48, 108);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // btn_input_add
            // 
            this.btn_input_add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_input_add.Location = new System.Drawing.Point(3, 3);
            this.btn_input_add.Name = "btn_input_add";
            this.btn_input_add.Size = new System.Drawing.Size(42, 48);
            this.btn_input_add.TabIndex = 0;
            this.btn_input_add.Text = "+";
            this.btn_input_add.UseVisualStyleBackColor = true;
            this.btn_input_add.Click += new System.EventHandler(this.btn_input_add_Click);
            // 
            // btn_input_del
            // 
            this.btn_input_del.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_input_del.Location = new System.Drawing.Point(3, 57);
            this.btn_input_del.Name = "btn_input_del";
            this.btn_input_del.Size = new System.Drawing.Size(42, 48);
            this.btn_input_del.TabIndex = 1;
            this.btn_input_del.Text = "-";
            this.btn_input_del.UseVisualStyleBackColor = true;
            this.btn_input_del.Click += new System.EventHandler(this.btn_input_del_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btn_output_add, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_output_del, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(374, 117);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(48, 108);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // btn_output_add
            // 
            this.btn_output_add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_output_add.Location = new System.Drawing.Point(3, 3);
            this.btn_output_add.Name = "btn_output_add";
            this.btn_output_add.Size = new System.Drawing.Size(42, 48);
            this.btn_output_add.TabIndex = 0;
            this.btn_output_add.Text = "+";
            this.btn_output_add.UseVisualStyleBackColor = true;
            this.btn_output_add.Click += new System.EventHandler(this.btn_output_add_Click);
            // 
            // btn_output_del
            // 
            this.btn_output_del.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_output_del.Location = new System.Drawing.Point(3, 57);
            this.btn_output_del.Name = "btn_output_del";
            this.btn_output_del.Size = new System.Drawing.Size(42, 48);
            this.btn_output_del.TabIndex = 1;
            this.btn_output_del.Text = "-";
            this.btn_output_del.UseVisualStyleBackColor = true;
            this.btn_output_del.Click += new System.EventHandler(this.btn_output_del_Click);
            // 
            // EditPorts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 269);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EditPorts";
            this.Text = "EditPorts";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox lb_InPorts;
        private System.Windows.Forms.ListBox lb_OutPorts;
        private System.Windows.Forms.Label label_inputports;
        private System.Windows.Forms.Label label_outputports;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_input_add;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_input_del;
        private System.Windows.Forms.Button btn_output_add;
        private System.Windows.Forms.Button btn_output_del;
    }
}