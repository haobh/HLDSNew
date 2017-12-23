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
    public partial class frmReportChart4 : Form
    {
        HLDSDbContext db = null;
        public frmReportChart4()
        {
            InitializeComponent();
            db = new HLDSDbContext();
            this.WindowState = FormWindowState.Maximized;
        }
        
        public void LoadChartPU2()
        {
            var timeDaily = db.TimeDailies.ToList();
            var numberConfig = db.Stations.ToList();
            float? numberConfigPU2 = 0;

            foreach (var item in numberConfig.Where(x => x.StationName == "Ngoại Quan PU2"))
            {
                numberConfigPU2 = item.NumberConfig;
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

            DataTable dt = new DataTable("PU2");
            dt.Columns.AddRange(new DataColumn[5] { new DataColumn("Id", typeof(int)),
                                new DataColumn("NameLine", typeof(string)),
                                new DataColumn("ShiftCode", typeof(string)),
                                new DataColumn("TotalQuantities", typeof(float)),
                                new DataColumn("Rate", typeof(string))});

            foreach (var item in query.Where(x => x.NameStation == "Ngoại Quan PU2").OrderBy(x => x.NameLine).ThenBy(x => x.NameLine))
            {
                foreach (var time in timeDaily)
                {
                    if (item.NameLine == "Line 1")
                    {
                        var rate = (numberConfigPU2 / (time.Time1 / item.TotalQuantities) * 100);
                        item.TotalRate = rate;
                    }
                    if (item.NameLine == "Line 2")
                    {
                        var rate = (numberConfigPU2 / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRate = rate;
                    }
                    if (item.NameLine == "Line 3")
                    {
                        var rate = (numberConfigPU2 / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRate = rate;
                    }
                    if (item.NameLine == "Line 4")
                    {
                        var rate = (numberConfigPU2 / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRate = rate;
                    }
                    if (item.NameLine == "Line 5")
                    {
                        var rate = (numberConfigPU2 / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRate = rate;
                    }
                    if (item.NameLine == "Line 6")
                    {
                        var rate = (numberConfigPU2 / (time.Time2 / item.TotalQuantities) * 100);
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

            foreach (var item in query.Where(x => x.NameStation == "Ngoại Quan PU2").OrderBy(x => x.NameLine).ThenBy(x => x.NameLine))
            {
                foreach (var time in timeDaily)
                {
                    if (item.NameLine == "Line 1")
                    {
                        var rate = (numberConfigPU2 / (time.Time1 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                    if (item.NameLine == "Line 2")
                    {
                        var rate = (numberConfigPU2 / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                    if (item.NameLine == "Line 3")
                    {
                        var rate = (numberConfigPU2 / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                    if (item.NameLine == "Line 4")
                    {
                        var rate = (numberConfigPU2 / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                    if (item.NameLine == "Line 5")
                    {
                        var rate = (numberConfigPU2 / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                    if (item.NameLine == "Line 6")
                    {
                        var rate = (numberConfigPU2 / (time.Time2 / item.TotalQuantities) * 100);
                        item.TotalRateDisplay = Convert.ToString(string.Format("{0:#,###.##} %", rate));
                    }
                }
                dtShow.Rows.Add(item.NameLine, item.ShiftCode, item.TotalQuantities, item.TotalRateDisplay);
            }

            chartPU2.Series.Clear();
            chartPU2.DataSource = dt;
            //chartPU2.ChartAreas[0].AxisX.Title = "Line";
            //chartPU2.ChartAreas[0].AxisY.Title = "Quantities";

            chartPU2.Series.Add("Total");
            //chartPU2.Series[0].XValueMember = "ShiftCode";
            //chartPU2.Series[0].YValueMembers = "TotalQuantities";
            foreach (var item in query.Where(x => x.NameStation == "Ngoại Quan PU2").OrderBy(x => x.NameLine).ThenBy(x => x.NameLine))
            {
                int index = chartPU2.Series[0].Points.AddXY(item.ShiftCode, item.TotalQuantities);
                if (item.ShiftCode == "Shift A")
                {
                    chartPU2.Series[0].Points[index].Color = Color.DodgerBlue;
                }
                if (item.ShiftCode == "Shift B")
                {
                    chartPU2.Series[0].Points[index].Color = Color.Orange;
                }
            }
            chartPU2.Series[0].ChartType = SeriesChartType.Column;
            chartPU2.Series[0].IsValueShownAsLabel = true;
            chartPU2.Series[0]["LabelStyle"] = "Center";
            chartPU2.Series[0]["PointWidth"] = "0.7";
            chartPU2.Series[0].IsValueShownAsLabel = true;
            chartPU2.Series[0].Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            chartPU2.Series[0]["LabelStyle"] = "Top";
            chartPU2.Series[0].LabelBackColor = Color.LightCyan;
            chartPU2.Series[0].IsVisibleInLegend = false;
            chartPU2.Series[0]["PixelPointWidth"] = "60";
            chartPU2.Series[0].ToolTip = "Đây là Tổng số lượng đã làm";
            chartPU2.ChartAreas[0].AxisY.LabelAutoFitStyle = LabelAutoFitStyles.WordWrap;
            chartPU2.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Times New Roman", 9, FontStyle.Bold);
            chartPU2.ChartAreas[0].AxisX.IsLabelAutoFit = true;

            chartPU2.Series.Add("Rate");
            chartPU2.Series[1].XValueMember = "ShiftCode";
            chartPU2.Series[1].YValueMembers = "TotalQuantities";
            chartPU2.Series[1].ChartType = SeriesChartType.Line;
            chartPU2.Series[1].BorderWidth = 3;
            chartPU2.Series[1].IsValueShownAsLabel = false;
            chartPU2.Series[1].IsVisibleInLegend = false;
            chartPU2.Series[1].Color = Color.Fuchsia;
            chartPU2.DataBind();

            dgvPU2.DataSource = dtShow;
        }
        private Timer tm;
        private void frmReportChart4_Load(object sender, EventArgs e)
        {
            LoadChartPU2();

            tm = new Timer();
            tm.Interval = 10000; // 10 seconds
            tm.Tick += new EventHandler(tm_Tick);
            tm.Start();
        }

        private void tm_Tick(object sender, EventArgs e)
        {
            tm.Stop();
            frmReportChart frm = new frmReportChart();
            //frm.MdiParent = frmMain.ActiveForm;
            frm.Show();
            tm.Tick -= new EventHandler(tm_Tick);
            this.Close();
        }

        private void frmReportChart4_FormClosing(object sender, FormClosingEventArgs e)
        {
            tm.Stop();
        }
    }
}