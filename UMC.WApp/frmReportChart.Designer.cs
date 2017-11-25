namespace UMC.WApp
{
    partial class frmReportChart
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
            this.chartWire = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvWire = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvYOKE = new System.Windows.Forms.DataGridView();
            this.chartYOKE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartWire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWire)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYOKE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartYOKE)).BeginInit();
            this.SuspendLayout();
            // 
            // chartWire
            // 
            this.chartWire.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartWire.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartWire.Legends.Add(legend1);
            this.chartWire.Location = new System.Drawing.Point(560, 14);
            this.chartWire.Name = "chartWire";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Total";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Rate";
            this.chartWire.Series.Add(series1);
            this.chartWire.Series.Add(series2);
            this.chartWire.Size = new System.Drawing.Size(561, 323);
            this.chartWire.TabIndex = 2;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "WIRE-SASS";
            this.chartWire.Titles.Add(title1);
            // 
            // dgvWire
            // 
            this.dgvWire.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWire.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvWire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWire.Location = new System.Drawing.Point(14, 19);
            this.dgvWire.Name = "dgvWire";
            this.dgvWire.Size = new System.Drawing.Size(549, 323);
            this.dgvWire.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.chartWire);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1127, 356);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infor WIRE";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.AutoSize = true;
            this.groupBox4.Controls.Add(this.dgvYOKE);
            this.groupBox4.Controls.Add(this.chartYOKE);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 383);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1127, 353);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Infor YOKE";
            // 
            // dgvYOKE
            // 
            this.dgvYOKE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvYOKE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYOKE.Location = new System.Drawing.Point(7, 14);
            this.dgvYOKE.Name = "dgvYOKE";
            this.dgvYOKE.Size = new System.Drawing.Size(544, 320);
            this.dgvYOKE.TabIndex = 3;
            // 
            // chartYOKE
            // 
            this.chartYOKE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartYOKE.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartYOKE.Legends.Add(legend2);
            this.chartYOKE.Location = new System.Drawing.Point(560, 14);
            this.chartYOKE.Name = "chartYOKE";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Total";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Rate";
            this.chartYOKE.Series.Add(series3);
            this.chartYOKE.Series.Add(series4);
            this.chartYOKE.Size = new System.Drawing.Size(561, 320);
            this.chartYOKE.TabIndex = 2;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            title2.Name = "Title1";
            title2.Text = "YOKE";
            this.chartYOKE.Titles.Add(title2);
            // 
            // frmReportChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 744);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dgvWire);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmReportChart";
            this.Text = "Daily Report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReportChart_FormClosing);
            this.Load += new System.EventHandler(this.frmReportChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartWire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWire)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYOKE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartYOKE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWire;
        private System.Windows.Forms.DataGridView dgvWire;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvYOKE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartYOKE;
    }
}