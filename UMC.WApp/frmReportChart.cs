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
            var query = from station in db.Stations
                        join quantities in db.Quantities
                        on station.ID equals quantities.StationID

                        join line in db.Lines
                        on quantities.LineID equals line.ID
                        group quantities by new { quantities.CreatedDate,quantities.LineID, line.Name } into fGroup
                        select new ReportChartViewModel
                        {
                            LineId = fGroup.Key.LineID,
                            NameLine = fGroup.Key.Name,
                            CreateDate = fGroup.Key.CreatedDate,
                            TotalShiftA = fGroup.Where(g=>g.ShiftCode=="Shift A").Sum(g => g.T1) + 
                                          fGroup.Where(g => g.ShiftCode == "Shift A").Sum(g => g.T2) +
                                          fGroup.Where(g => g.ShiftCode == "Shift A").Sum(g => g.T3) +
                                          fGroup.Where(g => g.ShiftCode == "Shift A").Sum(g => g.T4) +
                                          fGroup.Where(g => g.ShiftCode == "Shift A").Sum(g => g.T5) +
                                          fGroup.Where(g => g.ShiftCode == "Shift A").Sum(g => g.T6) +
                                          fGroup.Where(g => g.ShiftCode == "Shift A").Sum(g => g.T7) +
                                          fGroup.Where(g => g.ShiftCode == "Shift A").Sum(g => g.T8) +
                                          fGroup.Where(g => g.ShiftCode == "Shift A").Sum(g => g.T9) +
                                          fGroup.Where(g => g.ShiftCode == "Shift A").Sum(g => g.T10) +
                                          fGroup.Where(g => g.ShiftCode == "Shift A").Sum(g => g.T11) +
                                          fGroup.Where(g => g.ShiftCode == "Shift A").Sum(g => g.T12),

                            TotalShiftB = fGroup.Where(g => g.ShiftCode == "Shift B").Sum(g => g.T1) +
                                          fGroup.Where(g => g.ShiftCode == "Shift B").Sum(g => g.T2) +
                                          fGroup.Where(g => g.ShiftCode == "Shift B").Sum(g => g.T3) +
                                          fGroup.Where(g => g.ShiftCode == "Shift B").Sum(g => g.T4) +
                                          fGroup.Where(g => g.ShiftCode == "Shift B").Sum(g => g.T5) +
                                          fGroup.Where(g => g.ShiftCode == "Shift B").Sum(g => g.T6) +
                                          fGroup.Where(g => g.ShiftCode == "Shift B").Sum(g => g.T7) +
                                          fGroup.Where(g => g.ShiftCode == "Shift B").Sum(g => g.T8) +
                                          fGroup.Where(g => g.ShiftCode == "Shift B").Sum(g => g.T9) +
                                          fGroup.Where(g => g.ShiftCode == "Shift B").Sum(g => g.T10) +
                                          fGroup.Where(g => g.ShiftCode == "Shift B").Sum(g => g.T11) +
                                          fGroup.Where(g => g.ShiftCode == "Shift B").Sum(g => g.T12),
                        };
            DataTable dt = new DataTable("WIRE");
            dt.Columns.AddRange(new DataColumn[5] { new DataColumn("Id", typeof(int)),
                                new DataColumn("Date", typeof(string)),
                                new DataColumn("Name Station", typeof(string)),
                                new DataColumn("ShiftA", typeof(string)),
                                new DataColumn("ShiftB", typeof(string))});
            foreach (var item in query)
            {
                dt.Rows.Add(item.StationId, item.CreateDate.ToString("dd/MM/yyyy"), 
                    item.NameStation,item.TotalShiftA,item.TotalShiftB);
            }
            chartWire.DataSource = dt;
            chartWire.Series.Add("WIRE");
            chartWire.Series["WIRE"].XValueMember = "Date";
            chartWire.Series["WIRE"].YValueMembers = "ShiftA";
            chartWire.Series["WIRE"].ChartType = SeriesChartType.Column;
            chartWire.Titles.Add("WIRE-SASS");
        }

        private void frmReportChart_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
