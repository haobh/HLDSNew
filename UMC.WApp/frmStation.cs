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
            dgvStation.DataSource = db.Stations.OrderBy(x => x.StationName).ToList();
           
        }
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400, UseSystemPasswordChar = true };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                string promptValue = ShowDialog("Please Input Code", "Confirm Code");
                if(promptValue =="umcvn@123321")
                {
                    if (!string.IsNullOrEmpty(txtName.Text))
                    {
                        StationViewModel stationVm = new StationViewModel();
                        stationVm.StationName = txtName.Text;
                        stationVm.NumberConfig = float.Parse(txtNumberConfig.Text);

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
                else
                {
                    MessageBox.Show("Error", "Error",
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
            txtNumberConfig.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string promptValue = ShowDialog("Please Input Code", "Confirm Code");
                if(promptValue == "umcvn@123321")
                {
                    if (txtName.Text != "")
                    {
                        StationViewModel stationVm = new StationViewModel();
                        stationVm.StationName = txtName.Text;
                        stationVm.NumberConfig = float.Parse(txtNumberConfig.Text);

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
                else
                {
                    MessageBox.Show("Error", "Error",
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
            txtNumberConfig.Text = dgvStation.Rows[e.RowIndex].Cells[2].Value.ToString();
            btnAddNew.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string promptValue = ShowDialog("Please Input Code", "Confirm Code");
                if (promptValue == "umcvn@123321")
                {
                    var id = Convert.ToInt32(dgvStation.Rows[dgvStation.CurrentRow.Index].Cells[0].Value);
                    var station = db.Stations.Find(id);
                    db.Stations.Remove(station);
                    db.SaveChanges();
                    MessageBox.Show("Đã xóa bản ghi !");
                    ClearData();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Bạn không được xóa", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Không xóa được bản ghi !" + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
