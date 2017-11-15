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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvLD = new System.Windows.Forms.DataGridView();
            this.chartLD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPU2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvPU2 = new System.Windows.Forms.DataGridView();
            this.dgvPU1 = new System.Windows.Forms.DataGridView();
            this.chartPU1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPU2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPU2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPU1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPU1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvLD);
            this.groupBox3.Controls.Add(this.chartLD);
            this.groupBox3.Location = new System.Drawing.Point(14, 394);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(582, 348);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Infor LD";
            // 
            // dgvLD
            // 
            this.dgvLD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLD.Location = new System.Drawing.Point(6, 15);
            this.dgvLD.Name = "dgvLD";
            this.dgvLD.Size = new System.Drawing.Size(563, 124);
            this.dgvLD.TabIndex = 3;
            // 
            // chartLD
            // 
            chartArea4.Name = "ChartArea1";
            this.chartLD.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartLD.Legends.Add(legend4);
            this.chartLD.Location = new System.Drawing.Point(6, 145);
            this.chartLD.Name = "chartLD";
            series7.ChartArea = "ChartArea1";
            series7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series7.IsValueShownAsLabel = true;
            series7.Legend = "Legend1";
            series7.Name = "Total";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Rate";
            this.chartLD.Series.Add(series7);
            this.chartLD.Series.Add(series8);
            this.chartLD.Size = new System.Drawing.Size(563, 194);
            this.chartLD.TabIndex = 2;
            this.chartLD.Text = "LD";
            // 
            // chartPU2
            // 
            chartArea5.Name = "ChartArea1";
            this.chartPU2.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartPU2.Legends.Add(legend5);
            this.chartPU2.Location = new System.Drawing.Point(596, 161);
            this.chartPU2.Name = "chartPU2";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Total";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Rate";
            this.chartPU2.Series.Add(series9);
            this.chartPU2.Series.Add(series10);
            this.chartPU2.Size = new System.Drawing.Size(555, 227);
            this.chartPU2.TabIndex = 12;
            this.chartPU2.Text = "PU1";
            // 
            // dgvPU2
            // 
            this.dgvPU2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPU2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPU2.Location = new System.Drawing.Point(595, 24);
            this.dgvPU2.Name = "dgvPU2";
            this.dgvPU2.Size = new System.Drawing.Size(556, 130);
            this.dgvPU2.TabIndex = 11;
            // 
            // dgvPU1
            // 
            this.dgvPU1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPU1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPU1.Location = new System.Drawing.Point(16, 24);
            this.dgvPU1.Name = "dgvPU1";
            this.dgvPU1.Size = new System.Drawing.Size(563, 130);
            this.dgvPU1.TabIndex = 10;
            // 
            // chartPU1
            // 
            chartArea6.Name = "ChartArea1";
            this.chartPU1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartPU1.Legends.Add(legend6);
            this.chartPU1.Location = new System.Drawing.Point(16, 161);
            this.chartPU1.Name = "chartPU1";
            series11.ChartArea = "ChartArea1";
            series11.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series11.IsValueShownAsLabel = true;
            series11.Legend = "Legend1";
            series11.Name = "Total";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "Rate";
            this.chartPU1.Series.Add(series11);
            this.chartPU1.Series.Add(series12);
            this.chartPU1.Size = new System.Drawing.Size(563, 227);
            this.chartPU1.TabIndex = 9;
            this.chartPU1.Text = "PU1";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Location = new System.Drawing.Point(14, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 378);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infor PU1";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Location = new System.Drawing.Point(589, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(567, 378);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Infor PU2";
            // 
            // ReportChart2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 752);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.chartPU2);
            this.Controls.Add(this.dgvPU2);
            this.Controls.Add(this.dgvPU1);
            this.Controls.Add(this.chartPU1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ReportChart2";
            this.Text = "ReportChart2";
            this.Load += new System.EventHandler(this.ReportChart2_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPU2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPU2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPU1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPU1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvLD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPU2;
        private System.Windows.Forms.DataGridView dgvPU2;
        private System.Windows.Forms.DataGridView dgvPU1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPU1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}