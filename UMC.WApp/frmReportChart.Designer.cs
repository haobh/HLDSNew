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
            this.chartWire = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvTest = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chartWire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).BeginInit();
            this.SuspendLayout();
            // 
            // chartWire
            // 
            chartArea1.Name = "ChartArea1";
            this.chartWire.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartWire.Legends.Add(legend1);
            this.chartWire.Location = new System.Drawing.Point(33, 32);
            this.chartWire.Name = "chartWire";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartWire.Series.Add(series1);
            this.chartWire.Size = new System.Drawing.Size(346, 280);
            this.chartWire.TabIndex = 0;
            this.chartWire.Text = "WIRE";
            // 
            // dgvTest
            // 
            this.dgvTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTest.Location = new System.Drawing.Point(33, 345);
            this.dgvTest.Name = "dgvTest";
            this.dgvTest.Size = new System.Drawing.Size(710, 326);
            this.dgvTest.TabIndex = 1;
            // 
            // frmReportChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 735);
            this.Controls.Add(this.dgvTest);
            this.Controls.Add(this.chartWire);
            this.Name = "frmReportChart";
            this.Text = "Report Chart";
            this.Load += new System.EventHandler(this.frmReportChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartWire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartWire;
        private System.Windows.Forms.DataGridView dgvTest;
    }
}