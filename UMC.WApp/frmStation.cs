using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UMC.Data;
using UMC.Model.Entity;
using UMC.WApp.Infrastructure.Extensions;
using UMC.WApp.ViewModel;

namespace UMC.WApp
{
    public partial class frmStation : Form
    {
        HLDSDbContext db = null;
        public frmStation()
        {
            InitializeComponent();
            db = new HLDSDbContext();
        }
        public void LoadData()
        {
            dgvStation.DataSource = db.Stations.OrderBy(x => x.Name).ToList();
           
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtName.Text))
                {
                    StationViewModel stationVm = new StationViewModel();
                    stationVm.Name = txtName.Text;
                 
                    Station newStation = new Station();
                    newStation.UpdateStation(stationVm);

                    db.Stations.Add(newStation);
                    db.SaveChanges();
                    ClearData();
                    LoadData();
                    MessageBox.Show("Thêm mới thành công!");
                }
                else
                {
                    MessageBox.Show("Bạn không được để trống dữ liệu", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thêm được dữ liệu" + ex.Message);
            }
        }

        private void frmStation_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void ClearData()
        {
            txtName.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text != "")
                {
                    StationViewModel stationVm = new StationViewModel();
                    stationVm.Name = txtName.Text;

                    var id = Convert.ToInt32(dgvStation.Rows[dgvStation.CurrentRow.Index].Cells[0].Value);
                    stationVm.ID = id;

                    Station newStation = new Station();
                    newStation.UpdateStation(stationVm);

                    db.Set<Station>().AddOrUpdate(newStation);
                    db.SaveChanges();

                    ClearData();
                    LoadData();
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Please Select Record to Update", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật không thành công !, Error:" + ex.Message);
            }
        }

        private void dgvStation_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtName.Text = dgvStation.Rows[e.RowIndex].Cells[1].Value.ToString();
            btnAddNew.Enabled = false;
        }
    }
}
