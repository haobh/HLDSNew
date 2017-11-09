namespace UMC.WApp
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnsReportDaily = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsShift = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsLine = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsStation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsTimeSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.reportDailyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMonthlyReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsReportChart = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Green;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsReportDaily});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(837, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnsReportDaily
            // 
            this.mnsReportDaily.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsShift,
            this.mnsLine,
            this.mnsStation,
            this.mnsTimeSetting,
            this.reportDailyToolStripMenuItem,
            this.mnsMonthlyReport,
            this.mnsReportChart});
            this.mnsReportDaily.Name = "mnsReportDaily";
            this.mnsReportDaily.Size = new System.Drawing.Size(50, 20);
            this.mnsReportDaily.Text = "Menu";
            // 
            // mnsShift
            // 
            this.mnsShift.Name = "mnsShift";
            this.mnsShift.Size = new System.Drawing.Size(157, 22);
            this.mnsShift.Text = "Shift";
            this.mnsShift.Click += new System.EventHandler(this.mnsShift_Click);
            // 
            // mnsLine
            // 
            this.mnsLine.Name = "mnsLine";
            this.mnsLine.Size = new System.Drawing.Size(157, 22);
            this.mnsLine.Text = "Line";
            this.mnsLine.Click += new System.EventHandler(this.mnsLine_Click);
            // 
            // mnsStation
            // 
            this.mnsStation.Name = "mnsStation";
            this.mnsStation.Size = new System.Drawing.Size(157, 22);
            this.mnsStation.Text = "Station";
            this.mnsStation.Click += new System.EventHandler(this.mnsStation_Click);
            // 
            // mnsTimeSetting
            // 
            this.mnsTimeSetting.Name = "mnsTimeSetting";
            this.mnsTimeSetting.Size = new System.Drawing.Size(157, 22);
            this.mnsTimeSetting.Text = "Time Setting";
            this.mnsTimeSetting.Click += new System.EventHandler(this.mnsTimeSetting_Click);
            // 
            // reportDailyToolStripMenuItem
            // 
            this.reportDailyToolStripMenuItem.Name = "reportDailyToolStripMenuItem";
            this.reportDailyToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.reportDailyToolStripMenuItem.Text = "Daily Report";
            this.reportDailyToolStripMenuItem.Click += new System.EventHandler(this.reportDailyToolStripMenuItem_Click);
            // 
            // mnsMonthlyReport
            // 
            this.mnsMonthlyReport.Name = "mnsMonthlyReport";
            this.mnsMonthlyReport.Size = new System.Drawing.Size(157, 22);
            this.mnsMonthlyReport.Text = "Monthly Report";
            this.mnsMonthlyReport.Click += new System.EventHandler(this.mnsMonthlyReport_Click);
            // 
            // mnsReportChart
            // 
            this.mnsReportChart.Name = "mnsReportChart";
            this.mnsReportChart.Size = new System.Drawing.Size(157, 22);
            this.mnsReportChart.Text = "Report Chart";
            this.mnsReportChart.Click += new System.EventHandler(this.mnsReportChart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Green;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::UMC.WApp.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(837, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(108, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "HLDS Report System";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(0, 716);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(837, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "© 2017 UMCVN PD-IT. All rights reserved | Design by Haobh ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(837, 749);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnsReportDaily;
        private System.Windows.Forms.ToolStripMenuItem mnsShift;
        private System.Windows.Forms.ToolStripMenuItem mnsLine;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem mnsStation;
        private System.Windows.Forms.ToolStripMenuItem mnsTimeSetting;
        private System.Windows.Forms.ToolStripMenuItem reportDailyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnsMonthlyReport;
        private System.Windows.Forms.ToolStripMenuItem mnsReportChart;
    }
}

