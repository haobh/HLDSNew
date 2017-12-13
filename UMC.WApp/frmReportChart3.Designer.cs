namespace UMC.WApp
{
    partial class frmReportChart3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartOPT1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvOPT1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvOPT2 = new System.Windows.Forms.DataGridView();
            this.chartOPT2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartOPT1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOPT1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOPT2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOPT2)).BeginInit();
            this.SuspendLayout();
            // 
            // chartOPT1
            // 
            this.chartOPT1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartOPT1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartOPT1.Legends.Add(legend1);
            this.chartOPT1.Location = new System.Drawing.Point(385, 19);
            this.chartOPT1.Name = "chartOPT1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Total";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Rate";
            this.chartOPT1.Series.Add(series1);
            this.chartOPT1.Series.Add(series2);
            this.chartOPT1.Size = new System.Drawing.Size(746, 315);
            this.chartOPT1.TabIndex = 9;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "OPT1";
            this.chartOPT1.Titles.Add(title1);
            // 
            // dgvOPT1
            // 
            this.dgvOPT1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOPT1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOPT1.Location = new System.Drawing.Point(6, 19);
            this.dgvOPT1.Name = "dgvOPT1";
            this.dgvOPT1.Size = new System.Drawing.Size(373, 315);
            this.dgvOPT1.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.dgvOPT1);
            this.groupBox2.Controls.Add(this.chartOPT1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1140, 353);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Infor OPT1";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgvOPT2);
            this.groupBox3.Controls.Add(this.chartOPT2);
            this.groupBox3.Location = new System.Drawing.Point(12, 352);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1140, 387);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Infor OPT2";
            // 
            // dgvOPT2
            // 
            this.dgvOPT2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOPT2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOPT2.Location = new System.Drawing.Point(6, 23);
            this.dgvOPT2.Name = "dgvOPT2";
            this.dgvOPT2.Size = new System.Drawing.Size(373, 350);
            this.dgvOPT2.TabIndex = 3;
            // 
            // chartOPT2
            // 
            this.chartOPT2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartOPT2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartOPT2.Legends.Add(legend2);
            this.chartOPT2.Location = new System.Drawing.Point(385, 23);
            this.chartOPT2.Name = "chartOPT2";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Total";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Rate";
            this.chartOPT2.Series.Add(series3);
            this.chartOPT2.Series.Add(series4);
            this.chartOPT2.Size = new System.Drawing.Size(746, 350);
            this.chartOPT2.TabIndex = 2;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            title2.Name = "Title1";
            title2.Text = "OPT2";
            this.chartOPT2.Titles.Add(title2);
            // 
            // frmReportChart3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 751);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmReportChart3";
            this.Text = "ReportChart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReportChart3_FormClosing);
            this.Load += new System.EventHandler(this.frmReportChart3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartOPT1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOPT1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOPT2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOPT2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartOPT1;
        private System.Windows.Forms.DataGridView dgvOPT1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvOPT2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOPT2;
    }
}