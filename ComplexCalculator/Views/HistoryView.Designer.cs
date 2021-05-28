
namespace ComplexCalculator.Views
{
    partial class HistoryView
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
            this.lv_History = new System.Windows.Forms.ListView();
            this.FirstNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Operation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SecondNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Result = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lv_History
            // 
            this.lv_History.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstNumber,
            this.Operation,
            this.SecondNumber,
            this.Result});
            this.lv_History.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_History.FullRowSelect = true;
            this.lv_History.GridLines = true;
            this.lv_History.HideSelection = false;
            this.lv_History.Location = new System.Drawing.Point(0, 0);
            this.lv_History.MultiSelect = false;
            this.lv_History.Name = "lv_History";
            this.lv_History.Size = new System.Drawing.Size(378, 487);
            this.lv_History.TabIndex = 0;
            this.lv_History.UseCompatibleStateImageBehavior = false;
            this.lv_History.View = System.Windows.Forms.View.Details;
            this.lv_History.SelectedIndexChanged += new System.EventHandler(this.LvHistory_SelectedIndexChanged);
            // 
            // FirstNumber
            // 
            this.FirstNumber.Text = "First Number";
            this.FirstNumber.Width = 100;
            // 
            // Operation
            // 
            this.Operation.Text = "Operation";
            this.Operation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Operation.Width = 70;
            // 
            // SecondNumber
            // 
            this.SecondNumber.Text = "Second Number";
            this.SecondNumber.Width = 100;
            // 
            // Result
            // 
            this.Result.Text = "Result";
            this.Result.Width = 100;
            // 
            // HistoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 487);
            this.Controls.Add(this.lv_History);
            this.Name = "HistoryView";
            this.Text = "History";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HistoryView_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_History;
        private System.Windows.Forms.ColumnHeader FirstNumber;
        private System.Windows.Forms.ColumnHeader Operation;
        private System.Windows.Forms.ColumnHeader SecondNumber;
        private System.Windows.Forms.ColumnHeader Result;
    }
}