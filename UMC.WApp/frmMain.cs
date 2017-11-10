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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnsShift_Click(object sender, EventArgs e)
        {
            frmShift frmshift = new frmShift();
            frmshift.MdiParent = this;
            frmshift.Show();
        }

        private void mnsLine_Click(object sender, EventArgs e)
        {
            frmLine frmline = new frmLine();
            frmline.MdiParent = this;
            frmline.Show();
        }

        private void mnsStation_Click(object sender, EventArgs e)
        {
            frmStation frmstation = new frmStation();
            frmstation.MdiParent = this;
            frmstation.Show();
        }

        private void mnsTimeSetting_Click(object sender, EventArgs e)
        {
            frmTimeSetting frmtime= new frmTimeSetting();
            frmtime.MdiParent = this;
            frmtime.Show();
        }

        private void reportDailyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport frmreport = new frmReport();
            frmreport.MdiParent = this;
            frmreport.Show();
        }

        private void mnsReportChart_Click(object sender, EventArgs e)
        {
            frmReportChart frmreportChart = new frmReportChart();
            frmreportChart.MdiParent = this;
            frmreportChart.Show();
        }

        private void mnsMothlyChartReport_Click(object sender, EventArgs e)
        {
            frmMonthlyReport frmmonthlyreport = new frmMonthlyReport();
            frmmonthlyreport.MdiParent = this;
            frmmonthlyreport.Show();
        }
    }
}
