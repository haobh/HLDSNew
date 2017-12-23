using System.Data;
using System.Drawing;
using System.Linq;
using System;
using System.Windows.Forms;
using UMC.Data;
using UMC.WApp.ViewModel;
using System.Windows.Forms.DataVisualization.Charting;

namespace UMC.WApp
{
    public partial class frmReportChart : Form
    {
        HLDSDbContext db = null;
        public frmReportChart()
        {
            InitializeComponent();
            db = new HLDSDbContext();
            this.WindowState = FormWindowState.Maximized;
        }

        public void LoadChartWireSass()
        {
            var timeDaily = db.TimeDailies.ToList();
            var numberConfig = db.Stations.ToList();
            float? numberConfigWire = 0;

            foreach (var item in numberConfig.Where(x => x.StationName == "Ngoại Quan WIRE"))
            {
                numberConfigWire = item.NumberConfig;
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

            DataTable dt = new DataTable("WIRE");
            dt.Columns.AddRange(new DataColumn[5] { new DataColumn("Id", typeof(int)),
                                new DataColumn("NameLine", typeof(string)),
                                new DataColumn("ShiftCode", typeof(string)),
                                new DataColumn("TotalQuantities", typeof(float)),
                                new DataColumn("Rate", typeof(string))});

            foreach (var item in query.Where(x => x.NameStation == "Ngoại Quan WIRE").OrderBy(x => x.NameLine).ThenBy(x => x.NameLine))
            {
                foreach (var time in timeDaily)
                {
                    if (item.NameLine == "Line 1")
                    {
                        var rate = (numberConfigWire / (time.Time1 / item.TotalQuantities) * 100);
                        item.TotalRate = rate;
                    }
                    if (item.NameLine == "Line 2")
                    {
                        var rate = (numberConfigWire / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRate = rate;
                    }
                    if (item.NameLine == "Line 3")
                    {
                        var rate = (numberConfigWire / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRate = rate;
                    }
                    if (item.NameLine == "Line 4")
                    {
                        var rate = (numberConfigWire / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRate = rate;
                    }
                    if (item.NameLine == "Line 5")
                    {
                        var rate = (numberConfigWire / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRate = rate;
                    }
                    if (item.NameLine == "Line 6")
                    {
                        var rate = (numberConfigWire / (time.Time2 / item.TotalQuantities) * 100);
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

            foreach (var item in query.Where(x => x.NameStation == "Ngoại Quan WIRE").OrderBy(x => x.NameLine).ThenBy(x => x.NameLine))
            {
                foreach (var time in timeDaily)
                {
                    if (item.NameLine == "Line 1")
                    {
                        var rate = (numberConfigWire / (time.Time1 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                    if (item.NameLine == "Line 2")
                    {
                        var rate = (numberConfigWire / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                    if (item.NameLine == "Line 3")
                    {
                        var rate = (numberConfigWire / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                    if (item.NameLine == "Line 4")
                    {
                        var rate = (numberConfigWire / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                    if (item.NameLine == "Line 5")
                    {
                        var rate = (numberConfigWire / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                    if (item.NameLine == "Line 6")
                    {
                        var rate = (numberConfigWire / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                }
                dtShow.Rows.Add(item.NameLine, item.ShiftCode, item.TotalQuantities, item.TotalRateDisplay);
            }
            chartWire.Series.Clear();
            chartWire.DataSource = dt;
            //chartWire.ChartAreas[0].AxisX.Title = "Line";
            //chartWire.ChartAreas[0].AxisY.Title = "Quantities";
            chartWire.Series.Add("Total");
            //chartWire.Series[0].XValueMember = "ShiftCode";
            //chartWire.Series[0].YValueMembers = "TotalQuantities";
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    var setColor = dt.Columns[2].ColumnName = "ShiftCode";
            //    if (setColor == "Shift A")
            //    {
            //        chartWire.Series[0].Points[i].Color = Color.Yellow;
            //    }
            //    if (setColor == "Shift B")
            //    {
            //        chartWire.Series[0].Points[i].Color = Color.Red;
            //    }
            //}

            //Index: Gán giá trị X,Y vào biểu đồ, giống như AxisX, AxisY
            foreach (var item in query.Where(x => x.NameStation == "Ngoại Quan WIRE").OrderBy(x => x.NameLine).ThenBy(x => x.NameLine))
            {
                int index = chartWire.Series[0].Points.AddXY(item.ShiftCode, item.TotalQuantities);
                //Gán giá trị X,Y vào biểu đồ, giống như AxisX, AxisY
                if (item.ShiftCode == "Shift A")
                {
                    chartWire.Series[0].Points[index].Color = Color.DodgerBlue;
                }
                if (item.ShiftCode == "Shift B")
                {
                    chartWire.Series[0].Points[index].Color = Color.Orange;
                }
            }
            chartWire.Series[0].ChartType = SeriesChartType.Column;
            chartWire.Series[0].IsValueShownAsLabel = true;
            chartWire.Series[0]["LabelStyle"] = "Center";
            chartWire.Series[0]["PointWidth"] = "0.7";
            chartWire.Series[0].IsValueShownAsLabel = true;
            chartWire.Series[0].Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            chartWire.Series[0]["LabelStyle"] = "Top";
            chartWire.Series[0].LabelBackColor = Color.LightCyan;
            chartWire.Series[0].IsVisibleInLegend = false;
            chartWire.Series[0]["PixelPointWidth"] = "60";
            chartWire.Series[0].ToolTip = "Đây là Tổng số lượng đã làm";
            chartWire.ChartAreas[0].AxisY.LabelAutoFitStyle = LabelAutoFitStyles.WordWrap;
            chartWire.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Times New Roman", 9, FontStyle.Bold);
            chartWire.ChartAreas[0].AxisX.IsLabelAutoFit = true;

            chartWire.Series.Add("Rate");
            chartWire.Series[1].XValueMember = "ShiftCode";
            chartWire.Series[1].YValueMembers = "TotalQuantities";
            chartWire.Series[1].ChartType = SeriesChartType.Line;
            chartWire.Series[1].BorderWidth = 3;
            chartWire.Series[1].IsValueShownAsLabel = false;
            chartWire.Series[1].IsVisibleInLegend = false;
            chartWire.DataBind();
            chartWire.Series[1].Color = Color.Fuchsia;
            //Hiển thị ra GridView
            dgvWire.DataSource = dtShow;

        }

        public void LoadChartYOKE()
        {
            var timeDaily = db.TimeDailies.ToList();
            var numberConfig = db.Stations.ToList();
            float? numberConfigYOKE = 0;

            foreach (var item in numberConfig.Where(x => x.StationName == "Ngoại Quan YOKE"))
            {
                numberConfigYOKE = item.NumberConfig;
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

            DataTable dt = new DataTable("YOKE");
            dt.Columns.AddRange(new DataColumn[5] { new DataColumn("Id", typeof(int)),
                                new DataColumn("NameLine", typeof(string)),
                                new DataColumn("ShiftCode", typeof(string)),
                                new DataColumn("TotalQuantities", typeof(float)),
                                new DataColumn("Rate", typeof(string))});

            foreach (var item in query.Where(x => x.NameStation == "Ngoại Quan YOKE").OrderBy(x => x.NameLine).ThenBy(x => x.NameLine))
            {
                foreach (var time in timeDaily)
                {
                    if (item.NameLine == "Line 1")
                    {
                        var rate = (numberConfigYOKE / (time.Time1 / item.TotalQuantities) * 100);
                        item.TotalRate = rate;
                    }
                    if (item.NameLine == "Line 2")
                    {
                        var rate = (numberConfigYOKE / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRate = rate;
                    }
                    if (item.NameLine == "Line 3")
                    {
                        var rate = (numberConfigYOKE / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRate = rate;
                    }
                    if (item.NameLine == "Line 4")
                    {
                        var rate = (numberConfigYOKE / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRate = rate;
                    }
                    if (item.NameLine == "Line 5")
                    {
                        var rate = (numberConfigYOKE / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRate = rate;
                    }
                    if (item.NameLine == "Line 6")
                    {
                        var rate = (numberConfigYOKE / (time.Time2 / item.TotalQuantities) * 100);
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

            foreach (var item in query.Where(x => x.NameStation == "Ngoại Quan YOKE").OrderBy(x => x.NameLine).ThenBy(x => x.NameLine))
            {
                foreach (var time in timeDaily)
                {
                    if (item.NameLine == "Line 1")
                    {
                        var rate = (numberConfigYOKE / (time.Time1 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                    if (item.NameLine == "Line 2")
                    {
                        var rate = (numberConfigYOKE / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                    if (item.NameLine == "Line 3")
                    {
                        var rate = (numberConfigYOKE / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                    if (item.NameLine == "Line 4")
                    {
                        var rate = (numberConfigYOKE / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                    if (item.NameLine == "Line 5")
                    {
                        var rate = (numberConfigYOKE / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                    if (item.NameLine == "Line 6")
                    {
                        var rate = (numberConfigYOKE / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                }
                dtShow.Rows.Add(item.NameLine, item.ShiftCode, item.TotalQuantities, item.TotalRateDisplay);
            }

            chartYOKE.Series.Clear();
            chartYOKE.DataSource = dt;
            //chartYOKE.ChartAreas[0].AxisX.Title = "Line";
            //chartYOKE.ChartAreas[0].AxisY.Title = "Quantities";

            chartYOKE.Series.Add("Total");
            //chartYOKE.Series[0].XValueMember = "ShiftCode";
            //chartYOKE.Series[0].YValueMembers = "TotalQuantities";
            foreach (var item in query.Where(x => x.NameStation == "Ngoại Quan YOKE").OrderBy(x => x.NameLine).ThenBy(x => x.NameLine))
            {
                int index = chartYOKE.Series[0].Points.AddXY(item.ShiftCode, item.TotalQuantities);
                if (item.ShiftCode == "Shift A")
                {
                    chartYOKE.Series[0].Points[index].Color = Color.DodgerBlue;
                }
                if (item.ShiftCode == "Shift B")
                {
                    chartYOKE.Series[0].Points[index].Color = Color.Orange;
                }
            }
            chartYOKE.Series[0].ChartType = SeriesChartType.Column;
            chartYOKE.Series[0].IsValueShownAsLabel = true;
            chartYOKE.Series[0]["LabelStyle"] = "Center";
            chartYOKE.Series[0]["PointWidth"] = "0.7";
            chartYOKE.Series[0].IsValueShownAsLabel = true;
            chartYOKE.Series[0].Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            chartYOKE.Series[0]["LabelStyle"] = "Top";
            chartYOKE.Series[0].LabelBackColor = Color.LightCyan;
            chartYOKE.Series[0].IsVisibleInLegend = false;
            chartYOKE.Series[0]["PixelPointWidth"] = "60";
            chartYOKE.Series[0].ToolTip = "Đây là Tổng số lượng đã làm";
            chartYOKE.ChartAreas[0].AxisY.LabelAutoFitStyle = LabelAutoFitStyles.WordWrap;
            chartYOKE.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Times New Roman", 9, FontStyle.Bold);
            chartYOKE.ChartAreas[0].AxisX.IsLabelAutoFit = true;

            chartYOKE.Series.Add("Rate");
            chartYOKE.Series[1].XValueMember = "ShiftCode";
            chartYOKE.Series[1].YValueMembers = "TotalQuantities";
            chartYOKE.Series[1].ChartType = SeriesChartType.Line;
            chartYOKE.Series[1].Color = Color.Fuchsia;
            chartYOKE.Series[1].BorderWidth = 3;
            chartYOKE.Series[1].IsValueShownAsLabel = false;
            chartYOKE.Series[1].IsVisibleInLegend = false;
            chartYOKE.DataBind();

            dgvYOKE.DataSource = dtShow;
        }

        private Timer tm;
        private void frmReportChart_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            LoadChartWireSass();
            LoadChartYOKE();

            tm = new Timer();
            tm.Interval = 10000; // 10 seconds
            tm.Tick += new EventHandler(tm_Tick);
            tm.Start();
        }

        private void tm_Tick(object sender, EventArgs e)
        {
            tm.Stop();
            frmReportChart3 frm = new frmReportChart3();
            //frm.MdiParent = frmMain.ActiveForm;
            frm.Show();
            tm.Tick -= new EventHandler(tm_Tick);
            this.Close();    
        }

        private void frmReportChart_FormClosing(object sender, FormClosingEventArgs e)
        {
            tm.Stop();
        }
    }
}
