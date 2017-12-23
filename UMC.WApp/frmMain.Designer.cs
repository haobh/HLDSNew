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
            this.mnsShift = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsLine = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsStation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsTimeSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsTimeT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsTimeLine = new System.Windows.Forms.ToolStripMenuItem();
            this.reportDailyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsReportChart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMothlyChartReport = new System.Windows.Forms.ToolStripMenuItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbtnShift = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnLine = new DevExpress.XtraBars.BarButtonItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.bbtnTimeT = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnTimeLine = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnDailyReport = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnMonthlyReport = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnStation = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnDailyInput = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.lblText = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsShift
            // 
            this.mnsShift.Name = "mnsShift";
            this.mnsShift.Size = new System.Drawing.Size(32, 19);
            // 
            // mnsLine
            // 
            this.mnsLine.Name = "mnsLine";
            this.mnsLine.Size = new System.Drawing.Size(32, 19);
            // 
            // mnsStation
            // 
            this.mnsStation.Name = "mnsStation";
            this.mnsStation.Size = new System.Drawing.Size(32, 19);
            // 
            // mnsTimeSetting
            // 
            this.mnsTimeSetting.Name = "mnsTimeSetting";
            this.mnsTimeSetting.Size = new System.Drawing.Size(32, 19);
            // 
            // mnsTimeT
            // 
            this.mnsTimeT.Name = "mnsTimeT";
            this.mnsTimeT.Size = new System.Drawing.Size(32, 19);
            // 
            // mnsTimeLine
            // 
            this.mnsTimeLine.Name = "mnsTimeLine";
            this.mnsTimeLine.Size = new System.Drawing.Size(32, 19);
            // 
            // reportDailyToolStripMenuItem
            // 
            this.reportDailyToolStripMenuItem.Name = "reportDailyToolStripMenuItem";
            this.reportDailyToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // mnsReportChart
            // 
            this.mnsReportChart.Name = "mnsReportChart";
            this.mnsReportChart.Size = new System.Drawing.Size(32, 19);
            // 
            // mnsMothlyChartReport
            // 
            this.mnsMothlyChartReport.Name = "mnsMothlyChartReport";
            this.mnsMothlyChartReport.Size = new System.Drawing.Size(32, 19);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbtnShift,
            this.bbtnLine,
            this.barHeaderItem1,
            this.bbtnTimeT,
            this.bbtnTimeLine,
            this.bbtnDailyReport,
            this.bbtnMonthlyReport,
            this.bbtnStation,
            this.bbtnDailyInput});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 11;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage3});
            this.ribbonControl1.Size = new System.Drawing.Size(1026, 143);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // bbtnShift
            // 
            this.bbtnShift.Caption = "Shift";
            this.bbtnShift.Id = 1;
            this.bbtnShift.ImageOptions.Image = global::UMC.WApp.Properties.Resources.Company;
            this.bbtnShift.Name = "bbtnShift";
            this.bbtnShift.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnShift_ItemClick);
            // 
            // bbtnLine
            // 
            this.bbtnLine.Caption = "Line";
            this.bbtnLine.Id = 2;
            this.bbtnLine.ImageOptions.Image = global::UMC.WApp.Properties.Resources.Text;
            this.bbtnLine.Name = "bbtnLine";
            this.bbtnLine.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnLine_ItemClick);
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barHeaderItem1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.barHeaderItem1.Appearance.Options.UseFont = true;
            this.barHeaderItem1.Caption = "© 2017 UMCVN PD-IT Design by Haobh Support email: haobh@umcvn.com - ext: 2998";
            this.barHeaderItem1.Id = 3;
            this.barHeaderItem1.ImageOptions.Image = global::UMC.WApp.Properties.Resources.logo1;
            this.barHeaderItem1.MultiColumn = DevExpress.Utils.DefaultBoolean.True;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // bbtnTimeT
            // 
            this.bbtnTimeT.Caption = "Time T";
            this.bbtnTimeT.Id = 4;
            this.bbtnTimeT.ImageOptions.Image = global::UMC.WApp.Properties.Resources.Clock;
            this.bbtnTimeT.Name = "bbtnTimeT";
            this.bbtnTimeT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnTimeT_ItemClick);
            // 
            // bbtnTimeLine
            // 
            this.bbtnTimeLine.Caption = "Time Line";
            this.bbtnTimeLine.Id = 5;
            this.bbtnTimeLine.ImageOptions.Image = global::UMC.WApp.Properties.Resources.Compass;
            this.bbtnTimeLine.Name = "bbtnTimeLine";
            this.bbtnTimeLine.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnTimeLine_ItemClick);
            // 
            // bbtnDailyReport
            // 
            this.bbtnDailyReport.Caption = "Daily Report";
            this.bbtnDailyReport.Id = 6;
            this.bbtnDailyReport.ImageOptions.Image = global::UMC.WApp.Properties.Resources._3d_bar_chart;
            this.bbtnDailyReport.Name = "bbtnDailyReport";
            this.bbtnDailyReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnDailyReport_ItemClick);
            // 
            // bbtnMonthlyReport
            // 
            this.bbtnMonthlyReport.Caption = "Monthly Report";
            this.bbtnMonthlyReport.Id = 7;
            this.bbtnMonthlyReport.ImageOptions.Image = global::UMC.WApp.Properties.Resources.List;
            this.bbtnMonthlyReport.Name = "bbtnMonthlyReport";
            this.bbtnMonthlyReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnMonthlyReport_ItemClick);
            // 
            // bbtnStation
            // 
            this.bbtnStation.Caption = "Station";
            this.bbtnStation.Id = 8;
            this.bbtnStation.ImageOptions.Image = global::UMC.WApp.Properties.Resources.Comment;
            this.bbtnStation.Name = "bbtnStation";
            this.bbtnStation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnStation_ItemClick);
            // 
            // bbtnDailyInput
            // 
            this.bbtnDailyInput.Caption = "Daily Input";
            this.bbtnDailyInput.Id = 9;
            this.bbtnDailyInput.ImageOptions.Image = global::UMC.WApp.Properties.Resources.Table;
            this.bbtnDailyInput.Name = "bbtnDailyInput";
            this.bbtnDailyInput.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnDailyInput_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup5});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "File";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtnShift);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtnLine);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "PageGroupLine";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbtnTimeT);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbtnTimeLine);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "PageGroupTime";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.bbtnStation);
            this.ribbonPageGroup5.ItemLinks.Add(this.bbtnDailyInput);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "PageGroupInput";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Report";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bbtnDailyReport);
            this.ribbonPageGroup3.ItemLinks.Add(this.bbtnMonthlyReport);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "PageGroupReport";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.barHeaderItem1);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 748);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1026, 31);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
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
            this.lblText.Location = new System.Drawing.Point(0, 143);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(1026, 57);
            this.lblText.TabIndex = 3;
            this.lblText.Text = "UMC Electronic VietNam - Quantity Report - 産量 ポート";
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.Appearance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 779);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem mnsShift;
        private System.Windows.Forms.ToolStripMenuItem mnsLine;
        private System.Windows.Forms.ToolStripMenuItem mnsStation;
        private System.Windows.Forms.ToolStripMenuItem mnsTimeSetting;
        private System.Windows.Forms.ToolStripMenuItem mnsTimeT;
        private System.Windows.Forms.ToolStripMenuItem mnsTimeLine;
        private System.Windows.Forms.ToolStripMenuItem reportDailyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnsReportChart;
        private System.Windows.Forms.ToolStripMenuItem mnsMothlyChartReport;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem bbtnShift;
        private DevExpress.XtraBars.BarButtonItem bbtnLine;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarButtonItem bbtnTimeT;
        private DevExpress.XtraBars.BarButtonItem bbtnTimeLine;
        private DevExpress.XtraBars.BarButtonItem bbtnDailyReport;
        private DevExpress.XtraBars.BarButtonItem bbtnMonthlyReport;
        private DevExpress.XtraBars.BarButtonItem bbtnStation;
        private DevExpress.XtraBars.BarButtonItem bbtnDailyInput;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraEditors.LabelControl lblText;
    }
}

