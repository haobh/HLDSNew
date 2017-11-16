using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using UMC.Data;
using UMC.WApp;
using UMC.WApp.ViewModel;

namespace UMC.WApp
{
    public partial class frmMonthlyReport : Form
    {
        HLDSDbContext db = null;
        public frmMonthlyReport()
        {           
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            db = new HLDSDbContext();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var month = cbbMonth.SelectedItem.ToString();
            var shiftCode = cbbShiftCode.Text;
        }

        private void frmMonthlyReport_Load(object sender, EventArgs e)
        {
            LoadData();
            cbbMonth.Text = "1";
            var shiftCode = db.Shifts.ToList();
            cbbShiftCode.DataSource = shiftCode;
            cbbShiftCode.DisplayMember = "Name";
            cbbShiftCode.ValueMember = "ID";       
        }
       
        public void LoadData()
        {
            var query = from f in db.Quantities
                        join lineStation in db.Lines
                        on f.LineID equals lineStation.ID

                        group f by new { f.CreatedDate, f.LineID, lineStation.Name } into fGroup
                        select new MonthlyReportViewModel
                        {
                            LineId = fGroup.Key.LineID,
                            NameLine = fGroup.Key.Name,
                            CreateDate = fGroup.Key.CreatedDate,
                            SumT1 = fGroup.Sum(g => g.T1),
                            SumT2 = fGroup.Sum(g => g.T2),
                            SumT3 = fGroup.Sum(g => g.T3),
                            SumT4 = fGroup.Sum(g => g.T4),
                            SumT5 = fGroup.Sum(g => g.T5),
                            SumT6 = fGroup.Sum(g => g.T6),
                            SumT7 = fGroup.Sum(g => g.T7),
                            SumT8 = fGroup.Sum(g => g.T8),
                            SumT9 = fGroup.Sum(g => g.T9),
                            SumT10 = fGroup.Sum(g => g.T10),
                            SumT11 = fGroup.Sum(g => g.T11),
                            SumT12 = fGroup.Sum(g => g.T12)
                        };

            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[15] { new DataColumn("Id", typeof(int)),
                                new DataColumn("Date", typeof(string)),
                                new DataColumn("Name Line", typeof(string)),
                                new DataColumn("Total T1",typeof(int)),
                                new DataColumn("Total T2",typeof(int)),
                                new DataColumn("Total T3",typeof(int)),
                                new DataColumn("Total T4",typeof(int)),
                                new DataColumn("Total T5",typeof(int)),
                                new DataColumn("Total T6",typeof(int)),
                                new DataColumn("Total T7",typeof(int)),
                                new DataColumn("Total T8",typeof(int)),
                                new DataColumn("Total T9",typeof(int)),
                                new DataColumn("Total T10",typeof(int)),
                                new DataColumn("Total T11",typeof(int)),
                                new DataColumn("Total T12",typeof(int))});
            foreach (var item in query.OrderBy(x=>x.CreateDate).ThenBy(x=>x.NameLine))
            {
                dt.Rows.Add(item.LineId, item.CreateDate.ToString("dd/MM/yyyy"), item.NameLine,
                    item.SumT1, item.SumT2, item.SumT3,
                    item.SumT4, item.SumT5, item.SumT6,
                    item.SumT7, item.SumT8, item.SumT9,
                    item.SumT10, item.SumT11, item.SumT12);
            }
            dgvMonthlyReport.DataSource = dt;
        }
    }
}
