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
    public partial class frmTimeSetting : Form
    {
        HLDSDbContext db = null;
        public frmTimeSetting()
        {
            InitializeComponent();
            db = new HLDSDbContext();
            LoadData();
        }
        public void LoadData()
        {
            dgvTimeSetting.DataSource = db.TimeSettings.ToList();
        }
        public void ClearData()
        {
            txtT1.Text = "";
            txtT2.Text = "";
            txtT3.Text = "";
            txtT4.Text = "";
            txtT5.Text = "";
            txtT6.Text = "";
            txtT7.Text = "";
            txtT8.Text = "";
            txtT9.Text = "";
            txtT10.Text = "";
            txtT11.Text = "";
            txtT12.Text = "";
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtT1.Text))
                {
                    TimeSettingViewModel timeSettingVm = new TimeSettingViewModel();
                    timeSettingVm.T1 = int.Parse(txtT1.Text);
                    timeSettingVm.T2 = int.Parse(txtT2.Text);
                    timeSettingVm.T3 = int.Parse(txtT3.Text);
                    timeSettingVm.T4 = int.Parse(txtT4.Text);
                    timeSettingVm.T5 = int.Parse(txtT5.Text);
                    timeSettingVm.T6 = int.Parse(txtT6.Text);
                    timeSettingVm.T7 = int.Parse(txtT7.Text);
                    timeSettingVm.T8 = int.Parse(txtT8.Text);
                    timeSettingVm.T9 = int.Parse(txtT9.Text);
                    timeSettingVm.T10 = int.Parse(txtT10.Text);
                    timeSettingVm.T11 = int.Parse(txtT11.Text);
                    timeSettingVm.T12 = int.Parse(txtT12.Text);

                    TimeSetting newTimeSetting = new TimeSetting();
                    newTimeSetting.UpdateTimeSetting(timeSettingVm);
                    db.TimeSettings.Add(newTimeSetting);
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
            catch (Exception)
            {
                MessageBox.Show("Bạn không được để trống dữ liệu", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtT1.Text != "")
                {
                    TimeSettingViewModel timeSettingVm = new TimeSettingViewModel();
                    timeSettingVm.T1 = int.Parse(txtT1.Text);
                    timeSettingVm.T2 = int.Parse(txtT2.Text);
                    timeSettingVm.T3 = int.Parse(txtT3.Text);
                    timeSettingVm.T4 = int.Parse(txtT4.Text);
                    timeSettingVm.T5 = int.Parse(txtT5.Text);
                    timeSettingVm.T6 = int.Parse(txtT6.Text);
                    timeSettingVm.T7 = int.Parse(txtT7.Text);
                    timeSettingVm.T8 = int.Parse(txtT8.Text);
                    timeSettingVm.T9 = int.Parse(txtT9.Text);
                    timeSettingVm.T10 = int.Parse(txtT10.Text);
                    timeSettingVm.T11 = int.Parse(txtT11.Text);
                    timeSettingVm.T12 = int.Parse(txtT12.Text);

                    var id = Convert.ToInt32(dgvTimeSetting.Rows[dgvTimeSetting.CurrentRow.Index].Cells[0].Value);
                    timeSettingVm.ID = id;

                    TimeSetting newTimeSetting = new TimeSetting();
                    newTimeSetting.UpdateTimeSetting(timeSettingVm);

                    db.Set<TimeSetting>().AddOrUpdate(newTimeSetting);
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

        private void dgvTimeSetting_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtT1.Text = dgvTimeSetting.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtT2.Text = dgvTimeSetting.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtT3.Text = dgvTimeSetting.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtT4.Text = dgvTimeSetting.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtT5.Text = dgvTimeSetting.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtT6.Text = dgvTimeSetting.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtT7.Text = dgvTimeSetting.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtT8.Text = dgvTimeSetting.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtT9.Text = dgvTimeSetting.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtT10.Text = dgvTimeSetting.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtT11.Text = dgvTimeSetting.Rows[e.RowIndex].Cells[11].Value.ToString();
            txtT12.Text = dgvTimeSetting.Rows[e.RowIndex].Cells[12].Value.ToString();
            btnAddNew.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(dgvTimeSetting.Rows[dgvTimeSetting.CurrentRow.Index].Cells[0].Value);
                var timeSetting = db.TimeSettings.Find(id);
                db.TimeSettings.Remove(timeSetting);
                db.SaveChanges();
                MessageBox.Show("Đã xóa bản ghi !");
                ClearData();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Không xóa được bản ghi !" + ex.Message);
            }
        }
    }
}
