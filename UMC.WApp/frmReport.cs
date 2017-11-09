using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UMC.Data;

namespace UMC.WApp
{
    public partial class frmReport : Form
    {
        HLDSDbContext db = null;

        public frmReport()
        {
            InitializeComponent();
            db = new HLDSDbContext();
        }

        public void LoadData()
        {
            dgvReportDaily.DataSource = db.Lines.OrderBy(x => x.Name).ToList();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvReportDaily_Click(object sender, EventArgs e)
        {
            var idLine = Convert.ToInt32(dgvReportDaily.Rows[dgvReportDaily.CurrentRow.Index].Cells[0].Value);
            var nameLine = dgvReportDaily.Rows[dgvReportDaily.CurrentRow.Index].Cells[1].Value;
            frmInputQuantities inputQuantity = new frmInputQuantities(nameLine.ToString(),idLine);
            inputQuantity.MdiParent = this.MdiParent;
            inputQuantity.Show();
        }
    }
}
