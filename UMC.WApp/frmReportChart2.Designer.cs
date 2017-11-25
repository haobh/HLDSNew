namespace UMC.WApp
{
    partial class frmReportChart2
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
            this.chartPU2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvPU2 = new System.Windows.Forms.DataGridView();
            this.dgvPU1 = new System.Windows.Forms.DataGridView();
            this.chartPU1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartPU2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPU2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPU1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPU1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartPU2
            // 
            this.chartPU2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartPU2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPU2.Legends.Add(legend1);
            this.chartPU2.Location = new System.Drawing.Point(563, 19);
            this.chartPU2.Name = "chartPU2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Total";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Rate";
            this.chartPU2.Series.Add(series1);
            this.chartPU2.Series.Add(series2);
            this.chartPU2.Size = new System.Drawing.Size(581, 332);
            this.chartPU2.TabIndex = 12;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "PU2";
            this.chartPU2.Titles.Add(title1);
            // 
            // dgvPU2
            // 
            this.dgvPU2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPU2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPU2.Location = new System.Drawing.Point(0, 19);
            this.dgvPU2.Name = "dgvPU2";
            this.dgvPU2.Size = new System.Drawing.Size(556, 332);
            this.dgvPU2.TabIndex = 11;
            // 
            // dgvPU1
            // 
            this.dgvPU1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPU1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPU1.Location = new System.Drawing.Point(16, 24);
            this.dgvPU1.Name = "dgvPU1";
            this.dgvPU1.Size = new System.Drawing.Size(555, 333);
            this.dgvPU1.TabIndex = 10;
            // 
            // chartPU1
            // 
            this.chartPU1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartPU1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartPU1.Legends.Add(legend2);
            this.chartPU1.Location = new System.Drawing.Point(563, 14);
            this.chartPU1.Name = "chartPU1";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Total";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Rate";
            this.chartPU1.Series.Add(series3);
            this.chartPU1.Series.Add(series4);
            this.chartPU1.Size = new System.Drawing.Size(581, 333);
            this.chartPU1.TabIndex = 9;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            title2.Name = "Title1";
            title2.Text = "PU1";
            this.chartPU1.Titles.Add(title2);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.chartPU1);
            this.groupBox1.Location = new System.Drawing.Point(14, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1150, 359);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infor PU1";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.dgvPU2);
            this.groupBox2.Controls.Add(this.chartPU2);
            this.groupBox2.Location = new System.Drawing.Point(14, 375);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1150, 370);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Infor PU2";
            // 
            // frmReportChart2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 752);
            this.Controls.Add(this.dgvPU1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmReportChart2";
            this.Text = "Daily Report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReportChart2_FormClosing);
            this.Load += new System.EventHandler(this.ReportChart2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartPU2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPU2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPU1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPU1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPU2;
        private System.Windows.Forms.DataGridView dgvPU2;
        private System.Windows.Forms.DataGridView dgvPU1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPU1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}