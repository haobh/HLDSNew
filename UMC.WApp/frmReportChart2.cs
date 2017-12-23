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
    public partial class frmReportChart2 : Form
    {
        HLDSDbContext db = null;
        public frmReportChart2()
        {
            InitializeComponent();          
            db = new HLDSDbContext();
            this.WindowState = FormWindowState.Maximized;
        }
        public void LoadChartPU1()
        {
            var timeDaily = db.TimeDailies.ToList();
            var numberConfig = db.Stations.ToList();
            float? numberConfigPU1 = 0;

            foreach (var item in numberConfig.Where(x => x.StationName == "Ngoại Quan PU1"))
            {
                numberConfigPU1 = item.NumberConfig;
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

            DataTable dt = new DataTable("PU1");
            dt.Columns.AddRange(new DataColumn[5] { new DataColumn("Id", typeof(int)),
                                new DataColumn("NameLine", typeof(string)),
                                new DataColumn("ShiftCode", typeof(string)),
                                new DataColumn("TotalQuantities", typeof(float)),
                                new DataColumn("Rate", typeof(string))});

            foreach (var item in query.Where(x => x.NameStation == "Ngoại Quan PU1").OrderBy(x => x.NameLine).ThenBy(x => x.NameLine))
            {
                foreach (var time in timeDaily)
                {
                    if (item.NameLine == "Line 1")
                    {
                        var rate = (numberConfigPU1 / (time.Time1 / item.TotalQuantities) * 100);
                        item.TotalRate = rate;
                    }
                    if (item.NameLine == "Line 2")
                    {
                        var rate = (numberConfigPU1 / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRate = rate;
                    }
                    if (item.NameLine == "Line 3")
                    {
                        var rate = (numberConfigPU1 / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRate = rate;
                    }
                    if (item.NameLine == "Line 4")
                    {
                        var rate = (numberConfigPU1 / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRate = rate;
                    }
                    if (item.NameLine == "Line 5")
                    {
                        var rate = (numberConfigPU1 / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRate = rate;
                    }
                    if (item.NameLine == "Line 6")
                    {
                        var rate = (numberConfigPU1 / (time.Time2 / item.TotalQuantities) * 100);
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

            foreach (var item in query.Where(x => x.NameStation == "Ngoại Quan PU1").OrderBy(x => x.NameLine).ThenBy(x => x.NameLine))
            {
                foreach (var time in timeDaily)
                {
                    if (item.NameLine == "Line 1")
                    {
                        var rate = (numberConfigPU1 / (time.Time1 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                    if (item.NameLine == "Line 2")
                    {
                        var rate = (numberConfigPU1 / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                    if (item.NameLine == "Line 3")
                    {
                        var rate = (numberConfigPU1 / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                    if (item.NameLine == "Line 4")
                    {
                        var rate = (numberConfigPU1 / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                    if (item.NameLine == "Line 5")
                    {
                        var rate = (numberConfigPU1 / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                    if (item.NameLine == "Line 6")
                    {
                        var rate = (numberConfigPU1 / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                }
                dtShow.Rows.Add(item.NameLine, item.ShiftCode, item.TotalQuantities, item.TotalRateDisplay);
            }

            chartPU1.Series.Clear();
            chartPU1.DataSource = dt;
            //chartPU1.ChartAreas[0].AxisX.Title = "Line";
            //chartPU1.ChartAreas[0].AxisY.Title = "Quantities";

            chartPU1.Series.Add("Total");
            //chartPU1.Series[0].XValueMember = "ShiftCode";
            //chartPU1.Series[0].YValueMembers = "TotalQuantities";
            foreach (var item in query.Where(x => x.NameStation == "Ngoại Quan PU1").OrderBy(x => x.NameLine).ThenBy(x => x.NameLine))
            {
                int index = chartPU1.Series[0].Points.AddXY(item.ShiftCode, item.TotalQuantities);
                if (item.ShiftCode == "Shift A")
                {
                    chartPU1.Series[0].Points[index].Color = Color.DodgerBlue;
                }
                if (item.ShiftCode == "Shift B")
                {
                    chartPU1.Series[0].Points[index].Color = Color.Orange;
                }
            }
            chartPU1.Series[0].ChartType = SeriesChartType.Column;
            chartPU1.Series[0].IsValueShownAsLabel = true;
            chartPU1.Series[0]["LabelStyle"] = "Center";
            chartPU1.Series[0]["PointWidth"] = "0.7";
            chartPU1.Series[0].IsValueShownAsLabel = true;
            chartPU1.Series[0].Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            chartPU1.Series[0]["LabelStyle"] = "Top";
            chartPU1.Series[0].LabelBackColor = Color.LightCyan;
            chartPU1.Series[0].IsVisibleInLegend = false;
            chartPU1.Series[0]["PixelPointWidth"] = "60";
            chartPU1.Series[0].ToolTip = "Đây là Tổng số lượng đã làm";
            chartPU1.ChartAreas[0].AxisY.LabelAutoFitStyle = LabelAutoFitStyles.WordWrap;
            chartPU1.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Times New Roman", 9, FontStyle.Bold);
            chartPU1.ChartAreas[0].AxisX.IsLabelAutoFit = true;

            chartPU1.Series.Add("Rate");
            chartPU1.Series[1].XValueMember = "ShiftCode";
            chartPU1.Series[1].YValueMembers = "TotalQuantities";
            chartPU1.Series[1].ChartType = SeriesChartType.Line;
            chartPU1.Series[1].BorderWidth = 3;
            chartPU1.Series[1].IsValueShownAsLabel = false;
            chartPU1.Series[1].IsVisibleInLegend = false;
            chartPU1.Series[1].Color = Color.Fuchsia;
            chartPU1.DataBind();

            dgvPU1.DataSource = dtShow;

        }
        public void LoadChartLD()
        {
            var timeDaily = db.TimeDailies.ToList();
            var numberConfig = db.Stations.ToList();
            float? numberConfigLD = 0;

            foreach (var item in numberConfig.Where(x => x.StationName == "Ngoại Quan LD"))
            {
                numberConfigLD = item.NumberConfig;
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

            DataTable dt = new DataTable("LD");
            dt.Columns.AddRange(new DataColumn[5] { new DataColumn("Id", typeof(int)),
                                new DataColumn("NameLine", typeof(string)),
                                new DataColumn("ShiftCode", typeof(string)),
                                new DataColumn("TotalQuantities", typeof(float)),
                                new DataColumn("Rate", typeof(string))});

            foreach (var item in query.Where(x => x.NameStation == "Ngoại Quan LD").OrderBy(x => x.NameLine).ThenBy(x => x.NameLine))
            {
                foreach (var time in timeDaily)
                {
                    if (item.NameLine == "Line 1")
                    {
                        var rate = (numberConfigLD / (time.Time1 / item.TotalQuantities) * 100);
                        item.TotalRate = rate;
                    }
                    if (item.NameLine == "Line 2")
                    {
                        var rate = (numberConfigLD / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRate = rate;
                    }
                    if (item.NameLine == "Line 3")
                    {
                        var rate = (numberConfigLD / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRate = rate;
                    }
                    if (item.NameLine == "Line 4")
                    {
                        var rate = (numberConfigLD / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRate = rate;
                    }
                    if (item.NameLine == "Line 5")
                    {
                        var rate = (numberConfigLD / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRate = rate;
                    }
                    if (item.NameLine == "Line 6")
                    {
                        var rate = (numberConfigLD / (time.Time2 / item.TotalQuantities) * 100);
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

            foreach (var item in query.Where(x => x.NameStation == "Ngoại Quan LD").OrderBy(x => x.NameLine).ThenBy(x => x.NameLine))
            {
                foreach (var time in timeDaily)
                {
                    if (item.NameLine == "Line 1")
                    {
                        var rate = (numberConfigLD / (time.Time1 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                    if (item.NameLine == "Line 2")
                    {
                        var rate = (numberConfigLD / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                    if (item.NameLine == "Line 3")
                    {
                        var rate = (numberConfigLD / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                    if (item.NameLine == "Line 4")
                    {
                        var rate = (numberConfigLD / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                    if (item.NameLine == "Line 5")
                    {
                        var rate = (numberConfigLD / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                    if (item.NameLine == "Line 6")
                    {
                        var rate = (numberConfigLD / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                }
                dtShow.Rows.Add(item.NameLine, item.ShiftCode, item.TotalQuantities, item.TotalRateDisplay);
            }

            chartLD.Series.Clear();
            chartLD.DataSource = dt;
            //chartLD.ChartAreas[0].AxisX.Title = "Line";
            //chartLD.ChartAreas[0].AxisY.Title = "Quantities";

            chartLD.Series.Add("Total");
            //chartLD.Series[0].XValueMember = "ShiftCode";
            //chartLD.Series[0].YValueMembers = "TotalQuantities";
            foreach (var item in query.Where(x => x.NameStation == "Ngoại Quan LD").OrderBy(x => x.NameLine).ThenBy(x => x.NameLine))
            {
                int index = chartLD.Series[0].Points.AddXY(item.ShiftCode, item.TotalQuantities);
                if (item.ShiftCode == "Shift A")
                {
                    chartLD.Series[0].Points[index].Color = Color.DodgerBlue;
                }
                if (item.ShiftCode == "Shift B")
                {
                    chartLD.Series[0].Points[index].Color = Color.Orange;
                }
            }
            chartLD.Series[0].ChartType = SeriesChartType.Column;
            chartLD.Series[0].IsValueShownAsLabel = true;
            chartLD.Series[0]["LabelStyle"] = "Center";
            chartLD.Series[0]["PointWidth"] = "0.7";
            chartLD.Series[0].IsValueShownAsLabel = true;
            chartLD.Series[0].Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            chartLD.Series[0]["LabelStyle"] = "Top";
            chartLD.Series[0].LabelBackColor = Color.LightCyan;
            chartLD.Series[0].IsVisibleInLegend = false;
            chartLD.Series[0]["PixelPointWidth"] = "60";
            chartLD.Series[0].ToolTip = "Đây là Tổng số lượng đã làm";
            chartLD.ChartAreas[0].AxisY.LabelAutoFitStyle = LabelAutoFitStyles.WordWrap;
            chartLD.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Times New Roman", 9, FontStyle.Bold);
            chartLD.ChartAreas[0].AxisX.IsLabelAutoFit = true;

            chartLD.Series.Add("Rate");
            chartLD.Series[1].XValueMember = "ShiftCode";
            chartLD.Series[1].YValueMembers = "TotalQuantities";
            chartLD.Series[1].ChartType = SeriesChartType.Line;
            chartLD.Series[1].BorderWidth = 3;
            chartLD.Series[1].IsValueShownAsLabel = false;
            chartLD.Series[1].IsVisibleInLegend = false;
            chartLD.Series[1].Color = Color.Fuchsia;
            chartLD.DataBind();

            dgvLD.DataSource = dtShow;
        }

        private Timer tm;
        private void ReportChart2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            LoadChartPU1();
            LoadChartLD();           

            tm = new Timer();
            tm.Interval = 10000; // 10 seconds
            tm.Tick += new EventHandler(tm_Tick);
            tm.Start();

        }
        private void tm_Tick(object sender, EventArgs e)
        {
            tm.Stop();
            frmReportChart4 frm = new frmReportChart4();
            //frm.MdiParent = frmMain.ActiveForm;
            frm.Show();
            tm.Tick -= new EventHandler(tm_Tick);
            this.Close();
        }

        private void frmReportChart2_FormClosing(object sender, FormClosingEventArgs e)
        {
            tm.Stop();
        }
    }
}
