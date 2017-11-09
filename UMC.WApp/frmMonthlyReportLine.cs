using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using UMC.Data;
using UMC.Model.Entity;
using UMC.WApp.ViewModel;

namespace UMC.WApp
{
    public partial class frmMonthlyReportLine : Form
    {
        HLDSDbContext db = null;
        public int _idLine;

        public frmMonthlyReportLine(int idLine)
        {
            InitializeComponent();
            db = new HLDSDbContext();
            this._idLine = idLine;
        }

        public void LoadData()
        {
            List<string> date = new List<string>();
            var selectDate = db.Quantities.ToList();
            foreach(var item in selectDate)
            {
                date.Add(item.CreatedDate.ToString("dd/MM"));
            }

            var query = from f in db.Quantities
                      group f by new { f.CreatedDate, f.LineID } into fGroup
                      select new MonthlyReportViewModel
                      {
                          LineId = fGroup.Key.LineID,
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

            dgvMonthlyReportLine.DataSource = query.ToList();
        }

        /*private DataTable dt;

        private void PopulateGrid(List<MonthlyReportViewModel> qr)
        {
            // Create a DataTable as a DataSource for the grid
            dt = new DataTable();
            // Create the DataColumns for the data table
            DataColumn dc = new DataColumn("ISO Code", typeof(string));
            dt.Columns.Add(dc);
            dc = new DataColumn("Description", typeof(string));
            dt.Columns.Add(dc);

            // Get a list of Distinct years
            //var yearLabel = (from yList in qr.Select(year => year.LineId)
            //                 from year in yList
            //                 select year.ToString()).Distinct().ToList();

            // Create the DataColumns for the table
            //yearLabel.ForEach(delegate (string year)
            //{
            //    dc = new DataColumn(year, typeof(string));
            //    dt.Columns.Add(dc);
            //});

            // Populate the rowa of the DataTable
            foreach (MonthlyReportViewModel rec in qr)
            {
                // The first two columns of the row always has a ISO Code and Description
                DataRow dr = dt.NewRow();
                dr[0] = rec.StationId;
                dr[1] = rec.QuanitiesId;

                //// For each record
                //var years = rec.QuanitiesId.ToList();
                //var values = rec.Value.ToList();

                //// Because each row may have different years I am indexing
                //// the with the string name
                //for (int i = 0; i < values.Count; i++)
                //{
                //    dr[years[i].ToString()] = values[i];
                //}

                // Add the DataRow to the DataTable
                dt.Rows.Add(dr);
            }

            // Bind the DataTable to the DataGridView
            dgvMonthlyReportLine.DataSource = dt;

        }*/

        private void frmMonthlyReportLine_Load(object sender, EventArgs e)
        {
            LoadData();

            cbbMonth.Text = "1";
            var shiftCode = db.Shifts.ToList();
            cbbShiftCode.DataSource = shiftCode;
            cbbShiftCode.DisplayMember = "Name";
            cbbShiftCode.ValueMember = "ID";

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
