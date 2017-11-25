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
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void bbtnShift_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmShift frmshift = new frmShift();
            frmshift.MdiParent = this;
            //frmshift.Dock = DockStyle.Fill;
            frmshift.Show();
        }

        private void bbtnLine_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLine frmline = new frmLine();
            frmline.MdiParent = this;
            frmline.Show();
        }

        private void bbtnTimeT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTimeSetting frmT = new frmTimeSetting();
            frmT.MdiParent = this;
            frmT.Show();
        }

        private void bbtnTimeLine_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTimeDaily frmT = new frmTimeDaily();
            frmT.MdiParent = this;
            frmT.Show();
        }

        private void bbtnStation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmStation frmS = new frmStation();
            frmS.MdiParent = this;
            frmS.Show();
        }

        private void bbtnDailyInput_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmReport frmI = new frmReport();
            frmI.MdiParent = this;
            frmI.Show();
        }

        private void bbtnDailyReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmReportChart frmR = new frmReportChart();
            frmR.MdiParent = this;
            frmR.Show();
        }

        private void bbtnMonthlyReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMonthlyReport frmM = new frmMonthlyReport();
            frmM.MdiParent = this;
            frmM.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            MdiClient ctlMDI;
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    ctlMDI = (MdiClient)ctl;
                    ctlMDI.BackColor = Color.Snow;
                }
                catch (InvalidCastException exc)
                {
                    
                }
            }
        }
    }
}
