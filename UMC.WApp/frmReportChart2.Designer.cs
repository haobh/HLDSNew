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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem7 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem8 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem9 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem10 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem11 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem12 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dgvPU1 = new System.Windows.Forms.DataGridView();
            this.chartPU1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvLD = new System.Windows.Forms.DataGridView();
            this.chartLD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblText = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPU1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPU1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLD)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPU1
            // 
            this.dgvPU1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPU1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPU1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPU1.Location = new System.Drawing.Point(3, 3);
            this.dgvPU1.Name = "dgvPU1";
            this.dgvPU1.Size = new System.Drawing.Size(198, 333);
            this.dgvPU1.TabIndex = 10;
            // 
            // chartPU1
            // 
            this.chartPU1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chartPU1.ChartAreas.Add(chartArea3);
            legend3.Alignment = System.Drawing.StringAlignment.Center;
            legendItem7.Color = System.Drawing.Color.DodgerBlue;
            legendItem7.Name = "Shift A";
            legendItem8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            legendItem8.Name = "Shift B";
            legendItem9.Color = System.Drawing.Color.Fuchsia;
            legendItem9.Name = "Rate";
            legend3.CustomItems.Add(legendItem7);
            legend3.CustomItems.Add(legendItem8);
            legend3.CustomItems.Add(legendItem9);
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.Name = "PU1Legend";
            this.chartPU1.Legends.Add(legend3);
            this.chartPU1.Location = new System.Drawing.Point(207, 3);
            this.chartPU1.Name = "chartPU1";
            series5.ChartArea = "ChartArea1";
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series5.IsValueShownAsLabel = true;
            series5.IsVisibleInLegend = false;
            series5.Legend = "PU1Legend";
            series5.Name = "Total";
            series6.ChartArea = "ChartArea1";
            series6.IsVisibleInLegend = false;
            series6.Legend = "PU1Legend";
            series6.Name = "Rate";
            this.chartPU1.Series.Add(series5);
            this.chartPU1.Series.Add(series6);
            this.chartPU1.Size = new System.Drawing.Size(810, 333);
            this.chartPU1.TabIndex = 9;
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            title3.Name = "Title1";
            title3.Text = "PU1";
            this.chartPU1.Titles.Add(title3);
            // 
            // dgvLD
            // 
            this.dgvLD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLD.Location = new System.Drawing.Point(3, 342);
            this.dgvLD.Name = "dgvLD";
            this.dgvLD.Size = new System.Drawing.Size(198, 333);
            this.dgvLD.TabIndex = 5;
            // 
            // chartLD
            // 
            this.chartLD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.chartLD.ChartAreas.Add(chartArea4);
            legend4.Alignment = System.Drawing.StringAlignment.Center;
            legendItem10.Color = System.Drawing.Color.DodgerBlue;
            legendItem10.Name = "Shift A";
            legendItem11.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            legendItem11.Name = "Shift B";
            legendItem12.Color = System.Drawing.Color.Fuchsia;
            legendItem12.Name = "Rate";
            legend4.CustomItems.Add(legendItem10);
            legend4.CustomItems.Add(legendItem11);
            legend4.CustomItems.Add(legendItem12);
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend4.Name = "Legend1";
            this.chartLD.Legends.Add(legend4);
            this.chartLD.Location = new System.Drawing.Point(207, 342);
            this.chartLD.Name = "chartLD";
            series7.ChartArea = "ChartArea1";
            series7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series7.IsValueShownAsLabel = true;
            series7.IsVisibleInLegend = false;
            series7.Legend = "Legend1";
            series7.Name = "Total";
            series8.ChartArea = "ChartArea1";
            series8.IsVisibleInLegend = false;
            series8.Legend = "Legend1";
            series8.Name = "Rate";
            this.chartLD.Series.Add(series7);
            this.chartLD.Series.Add(series8);
            this.chartLD.Size = new System.Drawing.Size(810, 333);
            this.chartLD.TabIndex = 4;
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            title4.Name = "Title1";
            title4.Text = "LD";
            this.chartLD.Titles.Add(title4);
            // 
            // lblText
            // 
            this.lblText.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.lblText.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblText.Appearance.Image = global::UMC.WApp.Properties.Resources.logo1;
            this.lblText.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblText.Appearance.Options.UseFont = true;
            this.lblText.Appearance.Options.UseForeColor = true;
            this.lblText.Appearance.Options.UseImage = true;
            this.lblText.Appearance.Options.UseImageAlign = true;
            this.lblText.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblText.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblText.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblText.LineVisible = true;
            this.lblText.Location = new System.Drawing.Point(0, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(1020, 57);
            this.lblText.TabIndex = 15;
            this.lblText.Text = "UMC Electronic VietNam - Quantity Report - 産量 ポート";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.dgvPU1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvLD, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chartLD, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.chartPU1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1020, 678);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // frmReportChart2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 741);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblText);
            this.Name = "frmReportChart2";
            this.Text = "Daily Report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReportChart2_FormClosing);
            this.Load += new System.EventHandler(this.ReportChart2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPU1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPU1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLD)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPU1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPU1;
        private System.Windows.Forms.DataGridView dgvLD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLD;
        private DevExpress.XtraEditors.LabelControl lblText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}