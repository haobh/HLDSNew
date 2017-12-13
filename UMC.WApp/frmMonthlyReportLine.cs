using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using UMC.Data;
using UMC.WApp.ViewModel;

namespace UMC.WApp
{
    public partial class frmMonthlyReportLine : Form
    {
        private HLDSDbContext db = null;
        public int _month;
        public int _idStation;
        public string _nameStation;

        public frmMonthlyReportLine(int idStation, string nameStation)
        {
            InitializeComponent();
            db = new HLDSDbContext();
            this._idStation = idStation;
            this._nameStation = nameStation;
        }

        public frmMonthlyReportLine(int month, int idStation, string nameStation)
        {
            InitializeComponent();
            db = new HLDSDbContext();
            this._month = month;
            this._idStation = idStation;
            this._nameStation = nameStation;
        }

        public void LoadData()
        {
            try
            {
                string shiftCode = "Shift A";
                var dateNow = DateTime.Now;
                var query = from station in db.Stations
                            join quantities in db.Quantities
                            on station.ID equals quantities.StationID

                            join line in db.Lines
                            on quantities.LineID equals line.ID

                            where quantities.CreatedDate.Month == dateNow.Month &&
                                      quantities.CreatedDate.Year == dateNow.Year &&
                                      quantities.ShiftCode == shiftCode &&
                                      quantities.StationID == _idStation
                            group quantities by new { line.Name, station.ID, station.StationName, quantities.CreatedDate, quantities.ShiftCode } into fGroup
                            select new ReportChartStationViewModel
                            {
                                LineName = fGroup.Key.Name,
                                StationId = fGroup.Key.ID,
                                StationName = fGroup.Key.StationName,
                                CreateDate = fGroup.Key.CreatedDate,
                                ShiftCode = fGroup.Key.ShiftCode,
                                TotalDay = fGroup.Sum(g => g.T1) +
                                              fGroup.Sum(g => g.T2) +
                                              fGroup.Sum(g => g.T3) +
                                              fGroup.Sum(g => g.T4) +
                                              fGroup.Sum(g => g.T5) +
                                              fGroup.Sum(g => g.T6) +
                                              fGroup.Sum(g => g.T7) +
                                              fGroup.Sum(g => g.T8) +
                                              fGroup.Sum(g => g.T9) +
                                              fGroup.Sum(g => g.T10) +
                                              fGroup.Sum(g => g.T11) +
                                              fGroup.Sum(g => g.T12)
                            };

                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[4] { new DataColumn("LineName", typeof(string)),
                                new DataColumn("ShiftCode", typeof(string)),
                                new DataColumn("CreatedDate", typeof(DateTime)),
                                new DataColumn("Total", typeof(int))});
                foreach (var item in query)
                {
                    dt.Rows.Add(item.LineName, item.ShiftCode, item.CreateDate, item.TotalDay);
                }
                dgvMonthlyReportLine.DataSource = dt;

                Series line1 = new Series("line1", ViewType.StackedBar);
                foreach (var item in query.Where(x => x.LineName == "Line 1" && x.ShiftCode == shiftCode))
                {
                    line1.Points.Add(new SeriesPoint(item.CreateDate, item.TotalDay));
                }
                Series line2 = new Series("line2", ViewType.StackedBar);
                foreach (var item in query.Where(x => x.LineName == "Line 2" && x.ShiftCode == shiftCode))
                {
                    line2.Points.Add(new SeriesPoint(item.CreateDate, item.TotalDay));
                }

                Series line3 = new Series("line3", ViewType.StackedBar);
                foreach (var item in query.Where(x => x.LineName == "Line 3" && x.ShiftCode == shiftCode))
                {
                    line3.Points.Add(new SeriesPoint(item.CreateDate, item.TotalDay));
                }

                Series line4 = new Series("line4", ViewType.StackedBar);
                foreach (var item in query.Where(x => x.LineName == "Line 4" && x.ShiftCode == shiftCode))
                {
                    line4.Points.Add(new SeriesPoint(item.CreateDate, item.TotalDay));
                }

                Series line5 = new Series("line5", ViewType.StackedBar);
                foreach (var item in query.Where(x => x.LineName == "Line 5" && x.ShiftCode == shiftCode))
                {
                    line5.Points.Add(new SeriesPoint(item.CreateDate, item.TotalDay));
                }

                Series line6 = new Series("line6", ViewType.StackedBar);
                foreach (var item in query.Where(x => x.LineName == "Line 6" && x.ShiftCode == shiftCode))
                {
                    line6.Points.Add(new SeriesPoint(item.CreateDate, item.TotalDay));
                }
                chartReportLine.Series.AddRange(new Series[] { line1, line2, line3, line4, line5, line6 });

                line1.ArgumentScaleType = ScaleType.DateTime;
                line2.ArgumentScaleType = ScaleType.DateTime;
                line3.ArgumentScaleType = ScaleType.DateTime;
                line4.ArgumentScaleType = ScaleType.DateTime;
                line5.ArgumentScaleType = ScaleType.DateTime;
                line6.ArgumentScaleType = ScaleType.DateTime;

                // Access the view-type-specific options of the series.
                ((StackedBarSeriesView)line1.View).BarWidth = 0.2;
                ((StackedBarSeriesView)line2.View).BarWidth = 0.2;
                ((StackedBarSeriesView)line3.View).BarWidth = 0.2;
                ((StackedBarSeriesView)line4.View).BarWidth = 0.2;
                ((StackedBarSeriesView)line5.View).BarWidth = 0.2;
                ((StackedBarSeriesView)line6.View).BarWidth = 0.2;

                // Access the type-specific options of the diagram.
                ((XYDiagram)chartReportLine.Diagram).EnableAxisXZooming = true;

                // Hide the legend (if necessary).
                chartReportLine.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;

                // Hide the legend (if necessary).
                chartReportLine.Legend.Visible = false;

                // Add a title to the chart (if necessary).
                chartReportLine.Titles.Add(new ChartTitle());
                chartReportLine.Titles[0].Text = "Report Monthly Chart";

                chartReportLine.Series["line1"].LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
                chartReportLine.Series["line2"].LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
                chartReportLine.Series["line3"].LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
                chartReportLine.Series["line4"].LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
                chartReportLine.Series["line5"].LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
                chartReportLine.Series["line6"].LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;

                chartReportLine.Dock = DockStyle.Bottom;
                this.Controls.Add(chartReportLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
        }

        public void LoadDataSearch()
        {
            try
            {
                string shiftCode = "Shift A";
                var dateNow = DateTime.Now;
                var query = from station in db.Stations
                            join quantities in db.Quantities
                            on station.ID equals quantities.StationID

                            join line in db.Lines
                            on quantities.LineID equals line.ID

                            where quantities.CreatedDate.Month == _month &&
                                      quantities.CreatedDate.Year == dateNow.Year &&
                                      quantities.ShiftCode == shiftCode &&
                                      quantities.StationID == _idStation
                            group quantities by new { line.Name, station.ID, station.StationName, quantities.CreatedDate, quantities.ShiftCode } into fGroup
                            select new ReportChartStationViewModel
                            {
                                LineName = fGroup.Key.Name,
                                StationId = fGroup.Key.ID,
                                StationName = fGroup.Key.StationName,
                                CreateDate = fGroup.Key.CreatedDate,
                                ShiftCode = fGroup.Key.ShiftCode,
                                TotalDay = fGroup.Sum(g => g.T1) +
                                              fGroup.Sum(g => g.T2) +
                                              fGroup.Sum(g => g.T3) +
                                              fGroup.Sum(g => g.T4) +
                                              fGroup.Sum(g => g.T5) +
                                              fGroup.Sum(g => g.T6) +
                                              fGroup.Sum(g => g.T7) +
                                              fGroup.Sum(g => g.T8) +
                                              fGroup.Sum(g => g.T9) +
                                              fGroup.Sum(g => g.T10) +
                                              fGroup.Sum(g => g.T11) +
                                              fGroup.Sum(g => g.T12)
                            };

                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[4] { new DataColumn("LineName", typeof(string)),
                                new DataColumn("ShiftCode", typeof(string)),
                                new DataColumn("CreatedDate", typeof(DateTime)),
                                new DataColumn("Total", typeof(int))});
                foreach (var item in query)
                {
                    dt.Rows.Add(item.LineName, item.ShiftCode, item.CreateDate, item.TotalDay);
                }
                dgvMonthlyReportLine.DataSource = dt;

                Series line1 = new Series("line1", ViewType.StackedBar);
                foreach (var item in query.Where(x => x.LineName == "Line 1" && x.ShiftCode == shiftCode))
                {
                    line1.Points.Add(new SeriesPoint(item.CreateDate, item.TotalDay));
                }
                Series line2 = new Series("line2", ViewType.StackedBar);
                foreach (var item in query.Where(x => x.LineName == "Line 2" && x.ShiftCode == shiftCode))
                {
                    line2.Points.Add(new SeriesPoint(item.CreateDate, item.TotalDay));
                }

                Series line3 = new Series("line3", ViewType.StackedBar);
                foreach (var item in query.Where(x => x.LineName == "Line 3" && x.ShiftCode == shiftCode))
                {
                    line3.Points.Add(new SeriesPoint(item.CreateDate, item.TotalDay));
                }

                Series line4 = new Series("line4", ViewType.StackedBar);
                foreach (var item in query.Where(x => x.LineName == "Line 4" && x.ShiftCode == shiftCode))
                {
                    line4.Points.Add(new SeriesPoint(item.CreateDate, item.TotalDay));
                }

                Series line5 = new Series("line5", ViewType.StackedBar);
                foreach (var item in query.Where(x => x.LineName == "Line 5" && x.ShiftCode == shiftCode))
                {
                    line5.Points.Add(new SeriesPoint(item.CreateDate, item.TotalDay));
                }

                Series line6 = new Series("line6", ViewType.StackedBar);
                foreach (var item in query.Where(x => x.LineName == "Line 6" && x.ShiftCode == shiftCode))
                {
                    line6.Points.Add(new SeriesPoint(item.CreateDate, item.TotalDay));
                }
                chartReportLine.Series.AddRange(new Series[] { line1, line2, line3, line4, line5, line6 });

                line1.ArgumentScaleType = ScaleType.DateTime;
                line2.ArgumentScaleType = ScaleType.DateTime;
                line3.ArgumentScaleType = ScaleType.DateTime;
                line4.ArgumentScaleType = ScaleType.DateTime;
                line5.ArgumentScaleType = ScaleType.DateTime;
                line6.ArgumentScaleType = ScaleType.DateTime;

                // Access the view-type-specific options of the series.
                ((StackedBarSeriesView)line1.View).BarWidth = 0.2;
                ((StackedBarSeriesView)line2.View).BarWidth = 0.2;
                ((StackedBarSeriesView)line3.View).BarWidth = 0.2;
                ((StackedBarSeriesView)line4.View).BarWidth = 0.2;
                ((StackedBarSeriesView)line5.View).BarWidth = 0.2;
                ((StackedBarSeriesView)line6.View).BarWidth = 0.2;

                // Access the type-specific options of the diagram.
                ((XYDiagram)chartReportLine.Diagram).EnableAxisXZooming = true;

                // Hide the legend (if necessary).
                chartReportLine.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;

                // Hide the legend (if necessary).
                chartReportLine.Legend.Visible = false;

                // Add a title to the chart (if necessary).
                chartReportLine.Titles.Add(new ChartTitle());
                chartReportLine.Titles[0].Text = "Report Monthly Chart";

                chartReportLine.Series["line1"].LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
                chartReportLine.Series["line2"].LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
                chartReportLine.Series["line3"].LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
                chartReportLine.Series["line4"].LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
                chartReportLine.Series["line5"].LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
                chartReportLine.Series["line6"].LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;

                chartReportLine.Dock = DockStyle.Bottom;
                this.Controls.Add(chartReportLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
        }

        private void frmMonthlyReportLine_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            LoadData();
            cbbMonth.Text = DateTime.Now.Month.ToString() ?? _month.ToString();
            var shiftCode = db.Shifts.Where(x => x.Name == "Shift B").ToList();
            cbbShiftCode.DataSource = shiftCode;
            cbbShiftCode.DisplayMember = "Name";
            cbbShiftCode.ValueMember = "ID";

            lblStation.Text = "Station: " + _nameStation;
            lblShiftCode.Text = "Shift A";
            lblMonth.Text = "Month:" + cbbMonth.Text;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Close();
            var month = Convert.ToInt32(cbbMonth.SelectedItem.ToString());
            frmShiftCodeB frm = new frmShiftCodeB(month, _idStation, _nameStation);
            frm.MdiParent = frmMain.ActiveForm;
            frm.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            chartReportLine.ShowRibbonPrintPreview();
        }
    }
}