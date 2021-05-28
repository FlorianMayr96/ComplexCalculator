namespace ComplexCalculator.Views
{
    partial class MainView
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
            this.lbl_Number1 = new System.Windows.Forms.Label();
            this.lbl_Number2 = new System.Windows.Forms.Label();
            this.tb_Number1 = new System.Windows.Forms.TextBox();
            this.tb_Number2 = new System.Windows.Forms.TextBox();
            this.btn_Div = new System.Windows.Forms.Button();
            this.btn_Mul = new System.Windows.Forms.Button();
            this.btn_Sub = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.tb_Result = new System.Windows.Forms.TextBox();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.ss_Status = new System.Windows.Forms.StatusStrip();
            this.tssl_Message = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_History = new System.Windows.Forms.Button();
            this.ss_Status.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Number1
            // 
            this.lbl_Number1.AutoSize = true;
            this.lbl_Number1.Location = new System.Drawing.Point(12, 19);
            this.lbl_Number1.Name = "lbl_Number1";
            this.lbl_Number1.Size = new System.Drawing.Size(56, 13);
            this.lbl_Number1.TabIndex = 0;
            this.lbl_Number1.Text = "Number 1:";
            // 
            // lbl_Number2
            // 
            this.lbl_Number2.AutoSize = true;
            this.lbl_Number2.Location = new System.Drawing.Point(12, 55);
            this.lbl_Number2.Name = "lbl_Number2";
            this.lbl_Number2.Size = new System.Drawing.Size(56, 13);
            this.lbl_Number2.TabIndex = 1;
            this.lbl_Number2.Text = "Number 2:";
            // 
            // tb_Number1
            // 
            this.tb_Number1.Location = new System.Drawing.Point(74, 16);
            this.tb_Number1.Name = "tb_Number1";
            this.tb_Number1.Size = new System.Drawing.Size(151, 20);
            this.tb_Number1.TabIndex = 2;
            // 
            // tb_Number2
            // 
            this.tb_Number2.Location = new System.Drawing.Point(74, 52);
            this.tb_Number2.Name = "tb_Number2";
            this.tb_Number2.Size = new System.Drawing.Size(151, 20);
            this.tb_Number2.TabIndex = 3;
            // 
            // btn_Div
            // 
            this.btn_Div.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Div.Location = new System.Drawing.Point(312, 3);
            this.btn_Div.Name = "btn_Div";
            this.btn_Div.Size = new System.Drawing.Size(75, 23);
            this.btn_Div.TabIndex = 4;
            this.btn_Div.Text = "/";
            this.btn_Div.UseVisualStyleBackColor = true;
            this.btn_Div.Click += new System.EventHandler(this.btn_Div_Click);
            // 
            // btn_Mul
            // 
            this.btn_Mul.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Mul.Location = new System.Drawing.Point(212, 3);
            this.btn_Mul.Name = "btn_Mul";
            this.btn_Mul.Size = new System.Drawing.Size(75, 23);
            this.btn_Mul.TabIndex = 5;
            this.btn_Mul.Text = "*";
            this.btn_Mul.UseVisualStyleBackColor = true;
            this.btn_Mul.Click += new System.EventHandler(this.btn_Mul_Click);
            // 
            // btn_Sub
            // 
            this.btn_Sub.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Sub.Location = new System.Drawing.Point(112, 3);
            this.btn_Sub.Name = "btn_Sub";
            this.btn_Sub.Size = new System.Drawing.Size(75, 23);
            this.btn_Sub.TabIndex = 6;
            this.btn_Sub.Text = "-";
            this.btn_Sub.UseVisualStyleBackColor = true;
            this.btn_Sub.Click += new System.EventHandler(this.btn_Sub_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Add.Location = new System.Drawing.Point(12, 3);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Text = "+";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // tb_Result
            // 
            this.tb_Result.Location = new System.Drawing.Point(301, 36);
            this.tb_Result.Name = "tb_Result";
            this.tb_Result.ReadOnly = true;
            this.tb_Result.Size = new System.Drawing.Size(191, 20);
            this.tb_Result.TabIndex = 9;
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Location = new System.Drawing.Point(244, 39);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(40, 13);
            this.lbl_Result.TabIndex = 8;
            this.lbl_Result.Text = "Result:";
            // 
            // ss_Status
            // 
            this.ss_Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_Message});
            this.ss_Status.Location = new System.Drawing.Point(0, 168);
            this.ss_Status.Name = "ss_Status";
            this.ss_Status.Size = new System.Drawing.Size(504, 22);
            this.ss_Status.TabIndex = 10;
            // 
            // tssl_Message
            // 
            this.tssl_Message.Name = "tssl_Message";
            this.tssl_Message.Size = new System.Drawing.Size(39, 17);
            this.tssl_Message.Text = "Ready";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btn_History, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Add, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Sub, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Mul, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Div, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 134);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(504, 34);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // btn_History
            // 
            this.btn_History.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_History.Location = new System.Drawing.Point(414, 3);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(75, 23);
            this.btn_History.TabIndex = 12;
            this.btn_History.Text = "History";
            this.btn_History.UseVisualStyleBackColor = true;
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 190);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ss_Status);
            this.Controls.Add(this.tb_Result);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.tb_Number2);
            this.Controls.Add(this.tb_Number1);
            this.Controls.Add(this.lbl_Number2);
            this.Controls.Add(this.lbl_Number1);
            this.MinimumSize = new System.Drawing.Size(520, 213);
            this.Name = "MainView";
            this.ShowIcon = false;
            this.Text = "ComplexCalculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainView_FormClosed);
            this.ss_Status.ResumeLayout(false);
            this.ss_Status.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Number1;
        private System.Windows.Forms.Label lbl_Number2;
        private System.Windows.Forms.TextBox tb_Number1;
        private System.Windows.Forms.TextBox tb_Number2;
        private System.Windows.Forms.Button btn_Div;
        private System.Windows.Forms.Button btn_Mul;
        private System.Windows.Forms.Button btn_Sub;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox tb_Result;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.StatusStrip ss_Status;
        private System.Windows.Forms.ToolStripStatusLabel tssl_Message;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_History;
    }
}

