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
    public partial class frmReportChart : Form
    {
        HLDSDbContext db = null;
        public frmReportChart()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            db = new HLDSDbContext();
        }

        public void LoadData()
        {
            var dateNow = DateTime.Now;
            var timeDaily = db.TimeDailies.ToList();
            var query = from station in db.Stations
                        join quantities in db.Quantities
                        on station.ID equals quantities.StationID

                        join line in db.Lines
                        on quantities.LineID equals line.ID

                        where quantities.CreatedDate.Day == dateNow.Day &&
                                  quantities.CreatedDate.Month == dateNow.Month &&
                                  quantities.CreatedDate.Year == dateNow.Year
                        group quantities by new { quantities.LineID, line.Name, quantities.ShiftCode } into fGroup
                        select new ReportChartViewModel
                        {
                            LineId = fGroup.Key.LineID,
                            NameLine = fGroup.Key.Name,
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
            dt.Columns.AddRange(new DataColumn[4] { new DataColumn("Id", typeof(int)),
                                new DataColumn("NameLine", typeof(string)),
                                new DataColumn("ShiftCode", typeof(string)),
                                new DataColumn("Total", typeof(string))});

            foreach (var item in query.OrderBy(x => x.NameLine))
            {
                dt.Rows.Add(item.LineId, item.NameLine, item.ShiftCode, item.TotalQuantities);
            }

            chartWire.DataSource = dt;
            chartWire.Titles.Add("WIRE-SASS");
            chartWire.Series.Add("WIRE");
            chartWire.Series["WIRE"].XValueMember = "ShiftCode";
            chartWire.Series["WIRE"].YValueMembers = "Total";
            chartWire.Series["WIRE"].ChartType = SeriesChartType.Column;
            chartWire.Series["WIRE"].IsValueShownAsLabel = true;
            chartWire.Series[0].IsVisibleInLegend = true;
            chartWire.ChartAreas[0].AxisX.Title = "Line";
            chartWire.ChartAreas[0].AxisY.Title = "Quantities";
            chartWire.Series[0].Color = Color.Green;

            chartWire.DataBind();
        }
        /*public void LoadData2()
        {
            var dateNow = DateTime.Now;
            var model = db.Quantities.ToList();
            //DataTable dt = new DataTable();
            //dt.Columns.AddRange(new DataColumn[16] { new DataColumn("Id", typeof(string)),
            //                    new DataColumn("NameLine", typeof(string)),
            //                    new DataColumn("ShiftCode", typeof(string)),
            //                    new DataColumn("TotalShift1A", typeof(string)),
            //                    new DataColumn("TotalShift1A", typeof(string)),
            //                    new DataColumn("TotalShift1B", typeof(string)),
            //                    new DataColumn("TotalShift2A", typeof(string)),
            //                    new DataColumn("TotalShift2B", typeof(string)),
            //                    new DataColumn("TotalShift3A", typeof(string)),
            //                    new DataColumn("TotalShift3B", typeof(string)),
            //                    new DataColumn("TotalShift4A", typeof(string)),
            //                    new DataColumn("TotalShift4B", typeof(string)),
            //                    new DataColumn("TotalShift5A", typeof(string)),
            //                    new DataColumn("TotalShift5B", typeof(string)),
            //                    new DataColumn("TotalShift6A",typeof(string)),
            //                    new DataColumn("TotalShift6B",typeof(string))});
            var timeDailies = db.TimeDailies.ToList();
            //Hiển thị SumT
            var query = from station in db.Stations
                        join quantities in db.Quantities
                        on station.ID equals quantities.StationID

                        join line in db.Lines
                        on quantities.LineID equals line.ID

                        where quantities.CreatedDate.Day == dateNow.Day &&
                                  quantities.CreatedDate.Month == dateNow.Month &&
                                  quantities.CreatedDate.Year == dateNow.Year
                        group quantities by new { quantities.LineID, line.Name, quantities.ShiftCode } into q
                        select new GetSumLineViewModel
                        {
                            Id = q.Key.LineID,
                            NameLine = q.Key.Name,
                            ShiftCode = q.Key.ShiftCode,
                            TotalShift1A = q.Where(x => x.LineID == q.Key.LineID && x.ShiftCode == "Shift A").Sum(x => x.T1) +
                                        q.Sum(x => x.T2) +
                                        q.Sum(x => x.T3) +
                                        q.Sum(x => x.T4) +
                                        q.Sum(x => x.T5) +
                                        q.Sum(x => x.T6) +
                                        q.Sum(x => x.T7) +
                                        q.Sum(x => x.T8) +
                                        q.Sum(x => x.T9) +
                                        q.Sum(x => x.T10) +
                                        q.Sum(x => x.T11) +
                                        q.Sum(x => x.T12),
                            TotalShift1B = q.Where(x => x.LineID == q.Key.LineID && x.ShiftCode == "Shift B").Sum(x => x.T1) +
                                        q.Sum(x => x.T2) +
                                        q.Sum(x => x.T3) +
                                        q.Sum(x => x.T4) +
                                        q.Sum(x => x.T5) +
                                        q.Sum(x => x.T6) +
                                        q.Sum(x => x.T7) +
                                        q.Sum(x => x.T8) +
                                        q.Sum(x => x.T9) +
                                        q.Sum(x => x.T10) +
                                        q.Sum(x => x.T11) +
                                        q.Sum(x => x.T12),
                            TotalShift2A = q.Where(x => x.LineID == q.Key.LineID && x.ShiftCode == "Shift A").Sum(x => x.T1) +
                                         q.Sum(x => x.T2) +
                                        q.Sum(x => x.T3) +
                                        q.Sum(x => x.T4) +
                                        q.Sum(x => x.T5) +
                                        q.Sum(x => x.T6) +
                                        q.Sum(x => x.T7) +
                                        q.Sum(x => x.T8) +
                                        q.Sum(x => x.T9) +
                                        q.Sum(x => x.T10) +
                                        q.Sum(x => x.T11) +
                                        q.Sum(x => x.T12),
                            TotalShift2B = q.Where(x => x.LineID == q.Key.LineID && x.ShiftCode == "Shift B").Sum(x => x.T1) +
                                         q.Sum(x => x.T2) +
                                        q.Sum(x => x.T3) +
                                        q.Sum(x => x.T4) +
                                        q.Sum(x => x.T5) +
                                        q.Sum(x => x.T6) +
                                        q.Sum(x => x.T7) +
                                        q.Sum(x => x.T8) +
                                        q.Sum(x => x.T9) +
                                        q.Sum(x => x.T10) +
                                        q.Sum(x => x.T11) +
                                        q.Sum(x => x.T12),

                            TotalShift3A = q.Where(x => x.LineID == q.Key.LineID && x.ShiftCode == "Shift A").Sum(x => x.T1) +
                                         q.Sum(x => x.T2) +
                                        q.Sum(x => x.T3) +
                                        q.Sum(x => x.T4) +
                                        q.Sum(x => x.T5) +
                                        q.Sum(x => x.T6) +
                                        q.Sum(x => x.T7) +
                                        q.Sum(x => x.T8) +
                                        q.Sum(x => x.T9) +
                                        q.Sum(x => x.T10) +
                                        q.Sum(x => x.T11) +
                                        q.Sum(x => x.T12),
                            TotalShift3B = q.Where(x => x.LineID == q.Key.LineID && x.ShiftCode == "Shift B").Sum(x => x.T1) +
                                         q.Sum(x => x.T2) +
                                        q.Sum(x => x.T3) +
                                        q.Sum(x => x.T4) +
                                        q.Sum(x => x.T5) +
                                        q.Sum(x => x.T6) +
                                        q.Sum(x => x.T7) +
                                        q.Sum(x => x.T8) +
                                        q.Sum(x => x.T9) +
                                        q.Sum(x => x.T10) +
                                        q.Sum(x => x.T11) +
                                        q.Sum(x => x.T12),
                            TotalShift4A = q.Where(x => x.LineID == q.Key.LineID && x.ShiftCode == "Shift A").Sum(x => x.T1) +
                                         q.Sum(x => x.T2) +
                                        q.Sum(x => x.T3) +
                                        q.Sum(x => x.T4) +
                                        q.Sum(x => x.T5) +
                                        q.Sum(x => x.T6) +
                                        q.Sum(x => x.T7) +
                                        q.Sum(x => x.T8) +
                                        q.Sum(x => x.T9) +
                                        q.Sum(x => x.T10) +
                                        q.Sum(x => x.T11) +
                                        q.Sum(x => x.T12),
                            TotalShift4B = q.Where(x => x.LineID == q.Key.LineID && x.ShiftCode == "Shift B").Sum(x => x.T1) +
                                        q.Sum(x => x.T2) +
                                        q.Sum(x => x.T3) +
                                        q.Sum(x => x.T4) +
                                        q.Sum(x => x.T5) +
                                        q.Sum(x => x.T6) +
                                        q.Sum(x => x.T7) +
                                        q.Sum(x => x.T8) +
                                        q.Sum(x => x.T9) +
                                        q.Sum(x => x.T10) +
                                        q.Sum(x => x.T11) +
                                        q.Sum(x => x.T12),
                            TotalShift5A = q.Where(x => x.LineID == q.Key.LineID && x.ShiftCode == "Shift A").Sum(x => x.T1) +
                                        q.Sum(x => x.T2) +
                                        q.Sum(x => x.T3) +
                                        q.Sum(x => x.T4) +
                                        q.Sum(x => x.T5) +
                                        q.Sum(x => x.T6) +
                                        q.Sum(x => x.T7) +
                                        q.Sum(x => x.T8) +
                                        q.Sum(x => x.T9) +
                                        q.Sum(x => x.T10) +
                                        q.Sum(x => x.T11) +
                                        q.Sum(x => x.T12),
                            TotalShift5B = q.Where(x => x.LineID == q.Key.LineID && x.ShiftCode == "Shift B").Sum(x => x.T1) +
                                        q.Sum(x => x.T2) +
                                        q.Sum(x => x.T3) +
                                        q.Sum(x => x.T4) +
                                        q.Sum(x => x.T5) +
                                        q.Sum(x => x.T6) +
                                        q.Sum(x => x.T7) +
                                        q.Sum(x => x.T8) +
                                        q.Sum(x => x.T9) +
                                        q.Sum(x => x.T10) +
                                        q.Sum(x => x.T11) +
                                        q.Sum(x => x.T12),
                            TotalShift6A = q.Where(x => x.LineID == q.Key.LineID && x.ShiftCode == "Shift A").Sum(x => x.T1) +
                                       q.Sum(x => x.T2) +
                                        q.Sum(x => x.T3) +
                                        q.Sum(x => x.T4) +
                                        q.Sum(x => x.T5) +
                                        q.Sum(x => x.T6) +
                                        q.Sum(x => x.T7) +
                                        q.Sum(x => x.T8) +
                                        q.Sum(x => x.T9) +
                                        q.Sum(x => x.T10) +
                                        q.Sum(x => x.T11) +
                                        q.Sum(x => x.T12),
                            TotalShift6B = q.Where(x => x.LineID == q.Key.LineID && x.ShiftCode == "Shift B").Sum(x => x.T1) +
                                       q.Sum(x => x.T2) +
                                        q.Sum(x => x.T3) +
                                        q.Sum(x => x.T4) +
                                        q.Sum(x => x.T5) +
                                        q.Sum(x => x.T6) +
                                        q.Sum(x => x.T7) +
                                        q.Sum(x => x.T8) +
                                        q.Sum(x => x.T9) +
                                        q.Sum(x => x.T10) +
                                        q.Sum(x => x.T11) +
                                        q.Sum(x => x.T12),
                        };
            //dgvReportChart.DataSource = query.ToList();
        }*/
       /* public void LoadChartWireSass()
        {
            string rateLine1A = "";
            string rateLine1B = "";
            string rateLine2A = "";
            string rateLine2B = "";
            string rateLine3A = "";
            string rateLine3B = "";
            string rateLine4A = "";
            string rateLine4B = "";
            string rateLine5A = "";
            string rateLine5B = "";
            string rateLine6A = "";
            string rateLine6B = "";
            var dateNow = DateTime.Now;
            var query = from station in db.Stations
                        join quantities in db.Quantities
                        on station.ID equals quantities.StationID

                        join line in db.Lines
                        on quantities.LineID equals line.ID

                        where quantities.CreatedDate.Day == dateNow.Day &&
                                  quantities.CreatedDate.Month == dateNow.Month &&
                                  quantities.CreatedDate.Year == dateNow.Year
                        group quantities by new { quantities.LineID, line.Name, quantities.ShiftCode } into fGroup
                        select new ReportChartViewModel
                        {
                            LineId = fGroup.Key.LineID,
                            NameLine = fGroup.Key.Name,
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
            dt.Columns.AddRange(new DataColumn[4] { new DataColumn("Id", typeof(int)),
                                new DataColumn("NameLine", typeof(string)),
                                new DataColumn("ShiftCode", typeof(string)),
                                new DataColumn("TotalQuantities", typeof(string))});

            foreach (var item in query.OrderBy(x => x.NameLine).ThenBy(x => x.NameLine))
            {
                dt.Rows.Add(item.LineId, item.NameLine, item.ShiftCode, item.TotalQuantities);
            }
            chartWire.DataSource = dt;
            chartWire.Titles.Add("WIRE-SASS");
            chartWire.Series.Add("WIRE");
            chartWire.Series["WIRE"].XValueMember = "ShiftCode";
            chartWire.Series["WIRE"].YValueMembers = "TotalQuantities";
            chartWire.Series["WIRE"].ChartType = SeriesChartType.Column;
            chartWire.Series["WIRE"].IsValueShownAsLabel = true;
            chartWire.Series[0].IsVisibleInLegend = true;
            chartWire.ChartAreas[0].AxisX.Title = "Line";
            chartWire.ChartAreas[0].AxisY.Title = "Quantities";
            chartWire.Series["WIRE"]["PixelPointWidth"] = "15";
            chartWire.Series[0].Color = Color.Green;
            chartWire.DataBind();

            //Biểu đồ Line Rate  
            var queryTotalLineShift = from station in db.Stations
                                      join quantities in db.Quantities
                                      on station.ID equals quantities.StationID

                                      join line in db.Lines
                                      on quantities.LineID equals line.ID

                                      where quantities.CreatedDate.Day == dateNow.Day &&
                                                quantities.CreatedDate.Month == dateNow.Month &&
                                                quantities.CreatedDate.Year == dateNow.Year
                                      group quantities by new { quantities.LineID, line.Name, quantities.ShiftCode } into q
                                      select new GetSumLineViewModel
                                      {
                                          Id = q.Key.LineID,
                                          ShiftCode = q.Key.ShiftCode,
                                          TotalShift1A = q.Where(x =>x.LineID==33 && x.ShiftCode == "Shift A").Sum(x => x.T1 + x.T2 + x.T3 + x.T4 + x.T5 + x.T6 + x.T7 + x.T8 + x.T9 + x.T10 + x.T11 + x.T12),
                                          TotalShift1B = q.Where(x =>x.LineID == 33 && x.ShiftCode == "Shift B").Sum(x => x.T1 + x.T2 + x.T3 + x.T4 + x.T5 + x.T6 + x.T7 + x.T8 + x.T9 + x.T10 + x.T11 + x.T12),
                                          TotalShift2A = q.Where(x => x.LineID == 26 && x.ShiftCode == "Shift A").Sum(x => x.T1 + x.T2 + x.T3 + x.T4 + x.T5 + x.T6 + x.T7 + x.T8 + x.T9 + x.T10 + x.T11 + x.T12),
                                          TotalShift2B = q.Where(x => x.LineID == 26 && x.ShiftCode == "Shift B").Sum(x => x.T1 + x.T2 + x.T3 + x.T4 + x.T5 + x.T6 + x.T7 + x.T8 + x.T9 + x.T10 + x.T11 + x.T12),
                                          TotalShift3A = q.Where(x => x.LineID == 30 && x.ShiftCode == "Shift A").Sum(x => x.T1 + x.T2 + x.T3 + x.T4 + x.T5 + x.T6 + x.T7 + x.T8 + x.T9 + x.T10 + x.T11 + x.T12),
                                          TotalShift3B = q.Where(x => x.LineID == 30 && x.ShiftCode == "Shift B").Sum(x => x.T1 + x.T2 + x.T3 + x.T4 + x.T5 + x.T6 + x.T7 + x.T8 + x.T9 + x.T10 + x.T11 + x.T12),
                                          TotalShift4A = q.Where(x => x.LineID == 31 && x.ShiftCode == "Shift A").Sum(x => x.T1 + x.T2 + x.T3 + x.T4 + x.T5 + x.T6 + x.T7 + x.T8 + x.T9 + x.T10 + x.T11 + x.T12),
                                          TotalShift4B = q.Where(x => x.LineID == 31 && x.ShiftCode == "Shift B").Sum(x => x.T1 + x.T2 + x.T3 + x.T4 + x.T5 + x.T6 + x.T7 + x.T8 + x.T9 + x.T10 + x.T11 + x.T12),
                                          TotalShift5A = q.Where(x => x.LineID == 34 && x.ShiftCode == "Shift A").Sum(x => x.T1 + x.T2 + x.T3 + x.T4 + x.T5 + x.T6 + x.T7 + x.T8 + x.T9 + x.T10 + x.T11 + x.T12),
                                          TotalShift5B = q.Where(x => x.LineID == 34 && x.ShiftCode == "Shift B").Sum(x => x.T1 + x.T2 + x.T3 + x.T4 + x.T5 + x.T6 + x.T7 + x.T8 + x.T9 + x.T10 + x.T11 + x.T12),
                                          TotalShift6A = q.Where(x => x.LineID == 36 && x.ShiftCode == "Shift A").Sum(x => x.T1 + x.T2 + x.T3 + x.T4 + x.T5 + x.T6 + x.T7 + x.T8 + x.T9 + x.T10 + x.T11 + x.T12),
                                          TotalShift6B = q.Where(x => x.LineID == 36 && x.ShiftCode == "Shift B").Sum(x => x.T1 + x.T2 + x.T3 + x.T4 + x.T5 + x.T6 + x.T7 + x.T8 + x.T9 + x.T10 + x.T11 + x.T12),
                                      };

            DataTable dtRate = new DataTable();
            dtRate.Columns.AddRange(new DataColumn[14] { new DataColumn("Id", typeof(int)),
                                new DataColumn("NameLine", typeof(string)),
                                new DataColumn("TotalShift1A", typeof(string)),
                                new DataColumn("TotalShift1B", typeof(string)),
                                new DataColumn("TotalShift2A", typeof(string)),
                                new DataColumn("TotalShift2B", typeof(string)),
                                new DataColumn("TotalShift3A", typeof(string)),
                                new DataColumn("TotalShift3B", typeof(string)),
                                new DataColumn("TotalShift4A", typeof(string)),
                                new DataColumn("TotalShift4B", typeof(string)),
                                new DataColumn("TotalShift5A", typeof(string)),
                                new DataColumn("TotalShift5B", typeof(string)),
                                new DataColumn("TotalShift6A", typeof(string)),
                                new DataColumn("TotalShift6B", typeof(string))});
            var timeDaily = db.TimeDailies.ToList();
            float? numberConfigWire = 0;
            float? numberConfigOPT1 = 0;
            float? numberConfigOPT2 = 0;
            float? numberConfigPU1 = 0;
            float? numberConfigPU2 = 0;
            float? numberConfigYoke = 0;
            float? numberConfigLD = 0;
            var getNumberConfig = db.Stations.ToList();
            foreach (var item in getNumberConfig)
            {
                numberConfig = item.;
            }
            foreach (var queryTotal in queryTotalLineShift)
            {
                foreach (var time in timeDaily)
                {
                    if (queryTotal.TotalShift1A != null)
                    {
                        var t1A = numberConfig / (time.Time1 / queryTotal.TotalShift1A) * 100;
                        rateLine1A = Convert.ToString(string.Format("{0:#,###.##}%", t1A));
                    }

                    if (queryTotal.TotalShift1B != null)
                    {
                        var t1B = numberConfig / (time.Time1 / queryTotal.TotalShift1B) * 100;
                        rateLine1A = Convert.ToString(string.Format("{0:#,###.##} %", t1B));
                    }

                    if (queryTotal.TotalShift2A != null)
                    {
                        var t2A = numberConfig / (time.Time2 / queryTotal.TotalShift2A) * 100;
                        rateLine2A = Convert.ToString(string.Format("{0:#,###.##} %", t2A));
                    }

                    if (queryTotal.TotalShift2B != null)
                    {
                        var t2B = numberConfig / (time.Time2 / queryTotal.TotalShift2B) * 100;
                        rateLine2B = Convert.ToString(string.Format("{0:#,###.##} %", t2B));
                    }

                    if (queryTotal.TotalShift3A != null)
                    {
                        var t3A = numberConfig / (time.Time3 / queryTotal.TotalShift3A) * 100;
                        rateLine3A = Convert.ToString(string.Format("{0:#,###.##} %", t3A));
                    }

                    if (queryTotal.TotalShift3B != null)
                    {
                        var t3B = numberConfig / (time.Time3 / queryTotal.TotalShift3B) * 100;
                        rateLine3B = Convert.ToString(string.Format("{0:#,###.##} %", t3B));
                    }

                    if (queryTotal.TotalShift4A != null)
                    {
                        var t4A = numberConfig / (time.Time4 / queryTotal.TotalShift4A) * 100;
                        rateLine4A = Convert.ToString(string.Format("{0:#,###.##} %", t4A));
                    }

                    if (queryTotal.TotalShift4B != null)
                    {
                        var t4B = numberConfig / (time.Time4 / queryTotal.TotalShift4B) * 100;
                        rateLine4B = Convert.ToString(string.Format("{0:#,###.##} %", t4B));
                    }

                    if (queryTotal.TotalShift5A != null)
                    {
                        var t5A = numberConfig / (time.Time5 / queryTotal.TotalShift5A) * 100;
                        rateLine5A = Convert.ToString(string.Format("{0:#,###.##} %", t5A));
                    }

                    if (queryTotal.TotalShift5B != null)
                    {
                        var t5B = numberConfig / (time.Time5 / queryTotal.TotalShift5B) * 100;
                        rateLine3A = Convert.ToString(string.Format("{0:#,###.##} %", t5B));
                    }

                    if (queryTotal.TotalShift6A != null)
                    {
                        var t6A = numberConfig / (time.Time6 / queryTotal.TotalShift6A) * 100;
                        rateLine6A = Convert.ToString(string.Format("{0:#,###.##} %", t6A));
                    }

                    if (queryTotal.TotalShift6B != null)
                    {
                        var t6B = numberConfig / (time.Time6 / queryTotal.TotalShift6B) * 100;
                        rateLine3A = Convert.ToString(string.Format("{0:#,###.##} %", t6B));
                    }
                    dtRate.Rows.Add(
                      queryTotal.Id,
                      queryTotal.NameLine,
                      rateLine1A.ToString(),
                      rateLine1B.ToString(),
                      rateLine2A.ToString(),
                      rateLine2B.ToString(),
                      rateLine3A.ToString(),
                      rateLine3B.ToString(),
                      rateLine4A.ToString(),
                      rateLine4B.ToString(),
                      rateLine5A.ToString(),
                      rateLine5B.ToString(),
                      rateLine6A.ToString(),
                      rateLine6B.ToString()
                  );
                }
            }
            dgvTest.DataSource = dtRate;
        }*/
        private void frmReportChart_Load(object sender, EventArgs e)
        {
            //LoadChartWireSass();
        }
    }
}
