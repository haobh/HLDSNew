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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartWire = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvWire = new System.Windows.Forms.DataGridView();
            this.dgvOPT1 = new System.Windows.Forms.DataGridView();
            this.chartOPT1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvOPT2 = new System.Windows.Forms.DataGridView();
            this.chartOPT2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvYOKE = new System.Windows.Forms.DataGridView();
            this.chartYOKE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartWire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOPT1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOPT1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOPT2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOPT2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYOKE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartYOKE)).BeginInit();
            this.SuspendLayout();
            // 
            // chartWire
            // 
            chartArea5.Name = "ChartArea1";
            this.chartWire.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartWire.Legends.Add(legend5);
            this.chartWire.Location = new System.Drawing.Point(14, 156);
            this.chartWire.Name = "chartWire";
            series9.ChartArea = "ChartArea1";
            series9.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series9.IsValueShownAsLabel = true;
            series9.Legend = "Legend1";
            series9.Name = "Total";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Rate";
            this.chartWire.Series.Add(series9);
            this.chartWire.Series.Add(series10);
            this.chartWire.Size = new System.Drawing.Size(548, 216);
            this.chartWire.TabIndex = 2;
            this.chartWire.Text = "WIRE-SASS";
            // 
            // dgvWire
            // 
            this.dgvWire.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWire.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvWire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWire.Location = new System.Drawing.Point(14, 19);
            this.dgvWire.Name = "dgvWire";
            this.dgvWire.Size = new System.Drawing.Size(549, 130);
            this.dgvWire.TabIndex = 3;
            // 
            // dgvOPT1
            // 
            this.dgvOPT1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOPT1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOPT1.Location = new System.Drawing.Point(578, 19);
            this.dgvOPT1.Name = "dgvOPT1";
            this.dgvOPT1.Size = new System.Drawing.Size(556, 125);
            this.dgvOPT1.TabIndex = 4;
            // 
            // chartOPT1
            // 
            chartArea6.Name = "ChartArea1";
            this.chartOPT1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartOPT1.Legends.Add(legend6);
            this.chartOPT1.Location = new System.Drawing.Point(578, 156);
            this.chartOPT1.Name = "chartOPT1";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Total";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "Rate";
            this.chartOPT1.Series.Add(series11);
            this.chartOPT1.Series.Add(series12);
            this.chartOPT1.Size = new System.Drawing.Size(556, 216);
            this.chartOPT1.TabIndex = 5;
            this.chartOPT1.Text = "OPT1";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 373);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infor WIRE";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Location = new System.Drawing.Point(572, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(567, 373);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Infor OPT1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvOPT2);
            this.groupBox3.Controls.Add(this.chartOPT2);
            this.groupBox3.Location = new System.Drawing.Point(12, 389);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(554, 343);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Infor OPT2";
            // 
            // dgvOPT2
            // 
            this.dgvOPT2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOPT2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOPT2.Location = new System.Drawing.Point(3, 15);
            this.dgvOPT2.Name = "dgvOPT2";
            this.dgvOPT2.Size = new System.Drawing.Size(548, 119);
            this.dgvOPT2.TabIndex = 3;
            // 
            // chartOPT2
            // 
            chartArea7.Name = "ChartArea1";
            this.chartOPT2.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartOPT2.Legends.Add(legend7);
            this.chartOPT2.Location = new System.Drawing.Point(3, 145);
            this.chartOPT2.Name = "chartOPT2";
            series13.ChartArea = "ChartArea1";
            series13.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series13.IsValueShownAsLabel = true;
            series13.Legend = "Legend1";
            series13.Name = "Total";
            series14.ChartArea = "ChartArea1";
            series14.Legend = "Legend1";
            series14.Name = "Rate";
            this.chartOPT2.Series.Add(series13);
            this.chartOPT2.Series.Add(series14);
            this.chartOPT2.Size = new System.Drawing.Size(551, 194);
            this.chartOPT2.TabIndex = 2;
            this.chartOPT2.Text = "OPT2";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvYOKE);
            this.groupBox4.Controls.Add(this.chartYOKE);
            this.groupBox4.Location = new System.Drawing.Point(572, 389);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(567, 343);
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
            this.dgvYOKE.Size = new System.Drawing.Size(554, 124);
            this.dgvYOKE.TabIndex = 3;
            // 
            // chartYOKE
            // 
            chartArea8.Name = "ChartArea1";
            this.chartYOKE.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartYOKE.Legends.Add(legend8);
            this.chartYOKE.Location = new System.Drawing.Point(7, 149);
            this.chartYOKE.Name = "chartYOKE";
            series15.ChartArea = "ChartArea1";
            series15.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series15.IsValueShownAsLabel = true;
            series15.Legend = "Legend1";
            series15.Name = "Total";
            series16.ChartArea = "ChartArea1";
            series16.Legend = "Legend1";
            series16.Name = "Rate";
            this.chartYOKE.Series.Add(series15);
            this.chartYOKE.Series.Add(series16);
            this.chartYOKE.Size = new System.Drawing.Size(554, 185);
            this.chartYOKE.TabIndex = 2;
            this.chartYOKE.Text = "OPT2";
            // 
            // frmReportChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 744);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.chartOPT1);
            this.Controls.Add(this.dgvOPT1);
            this.Controls.Add(this.dgvWire);
            this.Controls.Add(this.chartWire);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmReportChart";
            this.Text = "Daily Report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReportChart_FormClosing);
            this.Load += new System.EventHandler(this.frmReportChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartWire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOPT1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOPT1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOPT2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOPT2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYOKE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartYOKE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWire;
        private System.Windows.Forms.DataGridView dgvWire;
        private System.Windows.Forms.DataGridView dgvOPT1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOPT1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvOPT2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOPT2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvYOKE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartYOKE;
    }
}