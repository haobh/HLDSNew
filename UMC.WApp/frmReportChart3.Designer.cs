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
            this.dgvOPT1 = new System.Windows.Forms.DataGridView();
            this.dgvOPT2 = new System.Windows.Forms.DataGridView();
            this.chartOPT2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblText = new DevExpress.XtraEditors.LabelControl();
            this.chartOPT1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOPT1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOPT2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOPT2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOPT1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOPT1
            // 
            this.dgvOPT1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOPT1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOPT1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOPT1.Location = new System.Drawing.Point(3, 3);
            this.dgvOPT1.Name = "dgvOPT1";
            this.dgvOPT1.Size = new System.Drawing.Size(198, 333);
            this.dgvOPT1.TabIndex = 8;
            // 
            // dgvOPT2
            // 
            this.dgvOPT2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOPT2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOPT2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOPT2.Location = new System.Drawing.Point(3, 342);
            this.dgvOPT2.Name = "dgvOPT2";
            this.dgvOPT2.Size = new System.Drawing.Size(198, 333);
            this.dgvOPT2.TabIndex = 3;
            // 
            // chartOPT2
            // 
            this.chartOPT2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chartOPT2.ChartAreas.Add(chartArea3);
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
            legend3.Name = "Legend1";
            this.chartOPT2.Legends.Add(legend3);
            this.chartOPT2.Location = new System.Drawing.Point(207, 342);
            this.chartOPT2.Name = "chartOPT2";
            series5.ChartArea = "ChartArea1";
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series5.IsValueShownAsLabel = true;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Total";
            series6.ChartArea = "ChartArea1";
            series6.IsVisibleInLegend = false;
            series6.Legend = "Legend1";
            series6.Name = "Rate";
            this.chartOPT2.Series.Add(series5);
            this.chartOPT2.Series.Add(series6);
            this.chartOPT2.Size = new System.Drawing.Size(810, 333);
            this.chartOPT2.TabIndex = 2;
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            title3.Name = "Title1";
            title3.Text = "OPT2";
            this.chartOPT2.Titles.Add(title3);
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
            this.lblText.TabIndex = 16;
            this.lblText.Text = "UMC Electronic VietNam - Quantity Report - 産量 ポート";
            // 
            // chartOPT1
            // 
            this.chartOPT1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.chartOPT1.ChartAreas.Add(chartArea4);
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
            this.chartOPT1.Legends.Add(legend4);
            this.chartOPT1.Location = new System.Drawing.Point(207, 3);
            this.chartOPT1.Name = "chartOPT1";
            series7.ChartArea = "ChartArea1";
            series7.IsVisibleInLegend = false;
            series7.Legend = "Legend1";
            series7.Name = "Total";
            series8.ChartArea = "ChartArea1";
            series8.IsVisibleInLegend = false;
            series8.Legend = "Legend1";
            series8.Name = "Rate";
            this.chartOPT1.Series.Add(series7);
            this.chartOPT1.Series.Add(series8);
            this.chartOPT1.Size = new System.Drawing.Size(810, 333);
            this.chartOPT1.TabIndex = 9;
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            title4.Name = "Title1";
            title4.Text = "OPT1";
            this.chartOPT1.Titles.Add(title4);
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
            this.tableLayoutPanel1.Controls.Add(this.dgvOPT2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvOPT1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartOPT2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.chartOPT1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1020, 678);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // frmReportChart3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 741);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblText);
            this.Name = "frmReportChart3";
            this.Text = "ReportChart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReportChart3_FormClosing);
            this.Load += new System.EventHandler(this.frmReportChart3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOPT1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOPT2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOPT2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOPT1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvOPT1;
        private System.Windows.Forms.DataGridView dgvOPT2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOPT2;
        private DevExpress.XtraEditors.LabelControl lblText;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOPT1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}