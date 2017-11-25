using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using UMC.Data;
using UMC.WApp.ViewModel;

namespace UMC.WApp
{
    public partial class frmReportChart3 : Form
    {
        HLDSDbContext db = null;
        public frmReportChart3()
        {
            InitializeComponent();
            db = new HLDSDbContext();
        }

        public void LoadChartOPT1()
        {
            var timeDaily = db.TimeDailies.ToList();
            var numberConfig = db.Stations.ToList();
            float? numberConfigOPT1 = 0;

            foreach (var item in numberConfig.Where(x => x.StationName == "Ngoại Quan OPT1"))
            {
                numberConfigOPT1 = item.NumberConfig;
            }


            var dateNow = DateTime.Now;
            var query = from station in db.Stations
                        join quantities in db.Quantities
                        on station.ID equals quantities.StationID

                        join line in db.Lines
                        on quantities.LineID equals line.ID

                        where quantities.CreatedDate.Day == dateNow.Day &&
                                  quantities.CreatedDate.Month == dateNow.Month &&
                                  quantities.CreatedDate.Year == dateNow.Year
                        group quantities by new { quantities.LineID, line.Name, station.StationName, station.ID, quantities.ShiftCode } into fGroup
                        select new ReportChartViewModel
                        {
                            LineId = fGroup.Key.LineID,
                            NameLine = fGroup.Key.Name,
                            NameStation = fGroup.Key.StationName,
                            ShiftCode = fGroup.Key.ShiftCode,
                            TotalQuantities = fGroup.Sum(g => g.T1) +
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

            DataTable dt = new DataTable("OPT1");
            dt.Columns.AddRange(new DataColumn[5] { new DataColumn("Id", typeof(int)),
                                new DataColumn("NameLine", typeof(string)),
                                new DataColumn("ShiftCode", typeof(string)),
                                new DataColumn("TotalQuantities", typeof(float)),
                                new DataColumn("Rate", typeof(string))});

            foreach (var item in query.Where(x => x.NameStation == "Ngoại Quan OPT1").OrderBy(x => x.NameLine).ThenBy(x => x.NameLine))
            {
                foreach (var time in timeDaily)
                {
                    if (item.NameLine == "Line 1")
                    {
                        var rate = (numberConfigOPT1 / (time.Time1 / item.TotalQuantities) * 100);
                        item.TotalRate = rate;
                    }
                    if (item.NameLine == "Line 2")
                    {
                        var rate = (numberConfigOPT1 / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRate = rate;
                    }
                    if (item.NameLine == "Line 3")
                    {
                        var rate = (numberConfigOPT1 / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRate = rate;
                    }
                    if (item.NameLine == "Line 4")
                    {
                        var rate = (numberConfigOPT1 / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRate = rate;
                    }
                    if (item.NameLine == "Line 5")
                    {
                        var rate = (numberConfigOPT1 / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRate = rate;
                    }
                    if (item.NameLine == "Line 6")
                    {
                        var rate = (numberConfigOPT1 / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRate = rate;
                    }
                }
                dt.Rows.Add(item.LineId, item.NameLine, item.ShiftCode, item.TotalQuantities, item.TotalRate);
            }

            DataTable dtShow = new DataTable();
            dtShow.Columns.AddRange(new DataColumn[4] { new DataColumn("NameLine", typeof(string)),
                                new DataColumn("ShiftCode", typeof(string)),
                                new DataColumn("TotalQuantities", typeof(float)),
                                new DataColumn("Rate", typeof(string))});

            foreach (var item in query.Where(x => x.NameStation == "Ngoại Quan OPT1").OrderBy(x => x.NameLine).ThenBy(x => x.NameLine))
            {
                foreach (var time in timeDaily)
                {
                    if (item.NameLine == "Line 1")
                    {
                        var rate = (numberConfigOPT1 / (time.Time1 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                    if (item.NameLine == "Line 2")
                    {
                        var rate = (numberConfigOPT1 / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                    if (item.NameLine == "Line 3")
                    {
                        var rate = (numberConfigOPT1 / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                    if (item.NameLine == "Line 4")
                    {
                        var rate = (numberConfigOPT1 / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                    if (item.NameLine == "Line 5")
                    {
                        var rate = (numberConfigOPT1 / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                    if (item.NameLine == "Line 6")
                    {
                        var rate = (numberConfigOPT1 / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                }
                dtShow.Rows.Add(item.NameLine, item.ShiftCode, item.TotalQuantities, item.TotalRateDisplay);
            }

            chartOPT1.Series.Clear();
            chartOPT1.DataSource = dt;
            chartOPT1.ChartAreas[0].AxisX.Title = "Line";
            chartOPT1.ChartAreas[0].AxisY.Title = "Quantities";

            chartOPT1.Series.Add("Total");
            chartOPT1.Series[0].XValueMember = "ShiftCode";
            chartOPT1.Series[0].YValueMembers = "TotalQuantities";
            chartOPT1.Series[0].ChartType = SeriesChartType.Column;
            chartOPT1.Series[0].IsValueShownAsLabel = true;
            chartOPT1.Series[0].IsVisibleInLegend = true;
            chartOPT1.Series[0]["PixelPointWidth"] = "30";
            chartOPT1.Series[0].ToolTip = "Đây là Tổng số lượng đã làm";


            chartOPT1.Series.Add("Rate");
            chartOPT1.Series[1].XValueMember = "ShiftCode";
            chartOPT1.Series[1].YValueMembers = "TotalQuantities";
            chartOPT1.Series[1].ChartType = SeriesChartType.Line;
            chartOPT1.Series[1].BorderWidth = 3;
            chartOPT1.Series[1].IsValueShownAsLabel = false;
            chartOPT1.Series[1].IsVisibleInLegend = true;
            chartOPT1.DataBind();

            dgvOPT1.DataSource = dtShow;
        }

        public void LoadChartOPT2()
        {
            var timeDaily = db.TimeDailies.ToList();
            var numberConfig = db.Stations.ToList();
            float? numberConfigOPT2 = 0;

            foreach (var item in numberConfig.Where(x => x.StationName == "Ngoại Quan OPT2"))
            {
                numberConfigOPT2 = item.NumberConfig;
            }

            var dateNow = DateTime.Now;
            var query = from station in db.Stations
                        join quantities in db.Quantities
                        on station.ID equals quantities.StationID

                        join line in db.Lines
                        on quantities.LineID equals line.ID

                        where quantities.CreatedDate.Day == dateNow.Day &&
                                  quantities.CreatedDate.Month == dateNow.Month &&
                                  quantities.CreatedDate.Year == dateNow.Year
                        group quantities by new { quantities.LineID, line.Name, station.StationName, station.ID, quantities.ShiftCode } into fGroup
                        select new ReportChartViewModel
                        {
                            LineId = fGroup.Key.LineID,
                            NameLine = fGroup.Key.Name,
                            NameStation = fGroup.Key.StationName,
                            ShiftCode = fGroup.Key.ShiftCode,
                            TotalQuantities = fGroup.Sum(g => g.T1) +
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

            DataTable dt = new DataTable("OPT2");
            dt.Columns.AddRange(new DataColumn[5] { new DataColumn("Id", typeof(int)),
                                new DataColumn("NameLine", typeof(string)),
                                new DataColumn("ShiftCode", typeof(string)),
                                new DataColumn("TotalQuantities", typeof(float)),
                                new DataColumn("Rate", typeof(string))});

            foreach (var item in query.Where(x => x.NameStation == "Ngoại Quan OPT2").OrderBy(x => x.NameLine).ThenBy(x => x.NameLine))
            {
                foreach (var time in timeDaily)
                {
                    if (item.NameLine == "Line 1")
                    {
                        var rate = (numberConfigOPT2 / (time.Time1 / item.TotalQuantities) * 100);
                        item.TotalRate = rate;
                    }
                    if (item.NameLine == "Line 2")
                    {
                        var rate = (numberConfigOPT2 / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRate = rate;
                    }
                    if (item.NameLine == "Line 3")
                    {
                        var rate = (numberConfigOPT2 / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRate = rate;
                    }
                    if (item.NameLine == "Line 4")
                    {
                        var rate = (numberConfigOPT2 / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRate = rate;
                    }
                    if (item.NameLine == "Line 5")
                    {
                        var rate = (numberConfigOPT2 / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRate = rate;
                    }
                    if (item.NameLine == "Line 6")
                    {
                        var rate = (numberConfigOPT2 / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRate = rate;
                    }
                }
                dt.Rows.Add(item.LineId, item.NameLine, item.ShiftCode, item.TotalQuantities, item.TotalRate);
            }

            DataTable dtShow = new DataTable();
            dtShow.Columns.AddRange(new DataColumn[4] { new DataColumn("NameLine", typeof(string)),
                                new DataColumn("ShiftCode", typeof(string)),
                                new DataColumn("TotalQuantities", typeof(float)),
                                new DataColumn("Rate", typeof(string))});

            foreach (var item in query.Where(x => x.NameStation == "Ngoại Quan OPT2").OrderBy(x => x.NameLine).ThenBy(x => x.NameLine))
            {
                foreach (var time in timeDaily)
                {
                    if (item.NameLine == "Line 1")
                    {
                        var rate = (numberConfigOPT2 / (time.Time1 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                    if (item.NameLine == "Line 2")
                    {
                        var rate = (numberConfigOPT2 / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                    if (item.NameLine == "Line 3")
                    {
                        var rate = (numberConfigOPT2 / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                    if (item.NameLine == "Line 4")
                    {
                        var rate = (numberConfigOPT2 / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                    if (item.NameLine == "Line 5")
                    {
                        var rate = (numberConfigOPT2 / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                    if (item.NameLine == "Line 6")
                    {
                        var rate = (numberConfigOPT2 / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                }
                dtShow.Rows.Add(item.NameLine, item.ShiftCode, item.TotalQuantities, item.TotalRateDisplay);
            }

            chartOPT2.Series.Clear();
            chartOPT2.DataSource = dt;
            chartOPT2.ChartAreas[0].AxisX.Title = "Line";
            chartOPT2.ChartAreas[0].AxisY.Title = "Quantities";

            chartOPT2.Series.Add("Total");
            chartOPT2.Series[0].XValueMember = "ShiftCode";
            chartOPT2.Series[0].YValueMembers = "TotalQuantities";
            chartOPT2.Series[0].ChartType = SeriesChartType.Column;
            chartOPT2.Series[0].IsValueShownAsLabel = true;
            chartOPT2.Series[0].IsVisibleInLegend = true;
            chartOPT2.Series[0]["PixelPointWidth"] = "30";
            chartOPT2.Series[0].ToolTip = "Đây là Tổng số lượng đã làm";

            chartOPT2.Series.Add("Rate");
            chartOPT2.Series[1].XValueMember = "ShiftCode";
            chartOPT2.Series[1].YValueMembers = "TotalQuantities";
            chartOPT2.Series[1].ChartType = SeriesChartType.Line;
            chartOPT2.Series[1].BorderWidth = 3;
            chartOPT2.Series[1].IsValueShownAsLabel = false;
            chartOPT2.Series[1].IsVisibleInLegend = true;
            chartOPT2.DataBind();

            dgvOPT2.DataSource = dtShow;
        }
        private Timer tm;
        private void frmReportChart3_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            LoadChartOPT1();
            LoadChartOPT2();

            tm = new Timer();
            tm.Interval = 5 * 1000; // 10 seconds
            tm.Tick += new EventHandler(tm_Tick);
            tm.Start();
        }
        private void tm_Tick(object sender, EventArgs e)
        {
            tm.Stop();
            frmReportChart2 frm = new frmReportChart2();
            frm.MdiParent = frmMain.ActiveForm;
            frm.Show();
            this.Hide();
        }

        private void frmReportChart3_FormClosing(object sender, FormClosingEventArgs e)
        {
            tm.Stop();
        }
    }
}
