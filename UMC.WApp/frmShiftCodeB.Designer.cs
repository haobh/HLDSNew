namespace UMC.WApp
{
    partial class frmShiftCodeB
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
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StackedBarSeriesView stackedBarSeriesView2 = new DevExpress.XtraCharts.StackedBarSeriesView();
            this.cbbShiftCode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbMonth = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch1 = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dgvMonthlyReportLine = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblStation = new System.Windows.Forms.Label();
            this.lblShiftCode = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chartReportLine = new DevExpress.XtraCharts.ChartControl();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyReportLine)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartReportLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbShiftCode
            // 
            this.cbbShiftCode.FormattingEnabled = true;
            this.cbbShiftCode.Location = new System.Drawing.Point(512, 27);
            this.cbbShiftCode.Name = "cbbShiftCode";
            this.cbbShiftCode.Size = new System.Drawing.Size(121, 21);
            this.cbbShiftCode.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Shift";
            // 
            // cbbMonth
            // 
            this.cbbMonth.FormattingEnabled = true;
            this.cbbMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbbMonth.Location = new System.Drawing.Point(319, 27);
            this.cbbMonth.Name = "cbbMonth";
            this.cbbMonth.Size = new System.Drawing.Size(121, 21);
            this.cbbMonth.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearch1);
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Location = new System.Drawing.Point(18, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(844, 55);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Infor Search";
            // 
            // btnSearch1
            // 
            this.btnSearch1.Image = global::UMC.WApp.Properties.Resources.Zoom;
            this.btnSearch1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch1.Location = new System.Drawing.Point(652, 18);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(75, 23);
            this.btnSearch1.TabIndex = 9;
            this.btnSearch1.Text = "Search";
            this.btnSearch1.UseVisualStyleBackColor = true;
            this.btnSearch1.Click += new System.EventHandler(this.btnSearch1_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::UMC.WApp.Properties.Resources.Print;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(733, 19);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dgvMonthlyReportLine
            // 
            this.dgvMonthlyReportLine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonthlyReportLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonthlyReportLine.Location = new System.Drawing.Point(7, 17);
            this.dgvMonthlyReportLine.Name = "dgvMonthlyReportLine";
            this.dgvMonthlyReportLine.Size = new System.Drawing.Size(643, 184);
            this.dgvMonthlyReportLine.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.lblMonth);
            this.groupBox3.Controls.Add(this.lblStation);
            this.groupBox3.Controls.Add(this.lblShiftCode);
            this.groupBox3.Location = new System.Drawing.Point(674, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 220);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Infor ShiftCode";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblMonth.Location = new System.Drawing.Point(105, 169);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(59, 22);
            this.lblMonth.TabIndex = 0;
            this.lblMonth.Text = "Month";
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStation.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblStation.Location = new System.Drawing.Point(103, 48);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(66, 22);
            this.lblStation.TabIndex = 0;
            this.lblStation.Text = "Station";
            // 
            // lblShiftCode
            // 
            this.lblShiftCode.AutoSize = true;
            this.lblShiftCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShiftCode.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblShiftCode.Location = new System.Drawing.Point(103, 106);
            this.lblShiftCode.Name = "lblShiftCode";
            this.lblShiftCode.Size = new System.Drawing.Size(46, 22);
            this.lblShiftCode.TabIndex = 0;
            this.lblShiftCode.Text = "Shift";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.dgvMonthlyReportLine);
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 220);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result Monthly Report";
            // 
            // chartReportLine
            // 
            this.chartReportLine.DataBindings = null;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.chartReportLine.Diagram = xyDiagram2;
            this.chartReportLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chartReportLine.Legend.Name = "Default Legend";
            this.chartReportLine.Legend.TextVisible = false;
            this.chartReportLine.Location = new System.Drawing.Point(0, 357);
            this.chartReportLine.Name = "chartReportLine";
            series2.LegendName = "Default Legend";
            series2.Name = "Series 1";
            series2.ShowInLegend = false;
            series2.View = stackedBarSeriesView2;
            this.chartReportLine.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartReportLine.Size = new System.Drawing.Size(863, 382);
            this.chartReportLine.TabIndex = 22;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::UMC.WApp.Properties.Resources.Zoom;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(657, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // frmShiftCodeB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 739);
            this.Controls.Add(this.cbbShiftCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbMonth);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chartReportLine);
            this.Controls.Add(this.btnSearch);
            this.Name = "frmShiftCodeB";
            this.Text = "frmShiftCodeB";
            this.Load += new System.EventHandler(this.frmShiftCodeB_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyReportLine)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartReportLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbShiftCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbMonth;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dgvMonthlyReportLine;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblShiftCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraCharts.ChartControl chartReportLine;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.Button btnSearch1;
    }
}