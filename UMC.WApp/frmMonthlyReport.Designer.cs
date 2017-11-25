namespace UMC.WApp
{
    partial class frmMonthlyReport
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
            this.gbMothlyReport = new System.Windows.Forms.GroupBox();
            this.dgvMonthlyReport = new System.Windows.Forms.DataGridView();
            this.gbMothlyReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyReport)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMothlyReport
            // 
            this.gbMothlyReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMothlyReport.Controls.Add(this.dgvMonthlyReport);
            this.gbMothlyReport.Location = new System.Drawing.Point(12, 25);
            this.gbMothlyReport.Name = "gbMothlyReport";
            this.gbMothlyReport.Size = new System.Drawing.Size(833, 336);
            this.gbMothlyReport.TabIndex = 0;
            this.gbMothlyReport.TabStop = false;
            this.gbMothlyReport.Text = "Result Monthly Report";
            // 
            // dgvMonthlyReport
            // 
            this.dgvMonthlyReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMonthlyReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonthlyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonthlyReport.Location = new System.Drawing.Point(7, 19);
            this.dgvMonthlyReport.Name = "dgvMonthlyReport";
            this.dgvMonthlyReport.Size = new System.Drawing.Size(821, 314);
            this.dgvMonthlyReport.TabIndex = 3;
            this.dgvMonthlyReport.Click += new System.EventHandler(this.dgvMonthlyReport_Click);
            // 
            // frmMonthlyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 661);
            this.Controls.Add(this.gbMothlyReport);
            this.Name = "frmMonthlyReport";
            this.Text = "Monthly Report";
            this.Load += new System.EventHandler(this.frmMonthlyReport_Load);
            this.gbMothlyReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMothlyReport;
        private System.Windows.Forms.DataGridView dgvMonthlyReport;
    }
}