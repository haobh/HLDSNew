using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using UMC.Data;
using UMC.Model.Entity;
using UMC.WApp.Infrastructure.Extensions;
using UMC.WApp.ViewModel;

namespace UMC.WApp
{
    public partial class frmShift : Form
    {
        HLDSDbContext db = null;

        public frmShift()
        {
            InitializeComponent();
            db = new HLDSDbContext();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                string promptValue = ShowDialog("Please Input Code", "Confirm Code");
                if(promptValue == "umcvn@123321")
                {
                    if (!string.IsNullOrEmpty(txtName.Text))
                    {
                        ShiftViewModel shiftVm = new ShiftViewModel();
                        shiftVm.Name = txtName.Text;
                        shiftVm.StartHour = int.Parse(cbbStartHour.SelectedItem.ToString());
                        shiftVm.StartMinute = int.Parse(cbbStartMinute.SelectedItem.ToString());
                        shiftVm.EndHour = int.Parse(cbbEndHour.SelectedItem.ToString());
                        shiftVm.EndMinute = int.Parse(cbbEndMinute.SelectedItem.ToString());

                        Shift newShift = new Shift();
                        newShift.UpdateShift(shiftVm);
                        db.Shifts.Add(newShift);
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
                    MessageBox.Show("Bạn không được thêm mới", "Error",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thêm được dữ liệu" + ex.Message);
            }

        }

        private void frmShift_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            dgvShift.DataSource = db.Shifts.OrderBy(x => x.Name).ToList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string promptValue = ShowDialog("Please Input Code", "Confirm Code");
                if (promptValue == "umcvn@123321")
                {
                    if (txtName.Text != "")
                    {
                        ShiftViewModel shiftVm = new ShiftViewModel();
                        shiftVm.Name = txtName.Text;
                        shiftVm.StartHour = int.Parse(cbbStartHour.Text.ToString());
                        shiftVm.StartMinute = int.Parse(cbbStartMinute.Text.ToString());
                        shiftVm.EndHour = int.Parse(cbbEndHour.Text.ToString());
                        shiftVm.EndMinute = int.Parse(cbbEndMinute.Text.ToString());

                        var id = Convert.ToInt32(dgvShift.Rows[dgvShift.CurrentRow.Index].Cells[0].Value);
                        shiftVm.ID = id;

                        Shift newShift = new Shift();
                        newShift.UpdateShift(shiftVm);

                        db.Set<Shift>().AddOrUpdate(newShift);
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
                    MessageBox.Show("Bạn không được Update", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật không thành công !, Error:" + ex.Message);
            }

        }

        private void dgvShift_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtName.Text = dgvShift.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbbStartHour.Text = dgvShift.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbbStartMinute.Text = dgvShift.Rows[e.RowIndex].Cells[4].Value.ToString();
            cbbEndHour.Text = dgvShift.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbbEndMinute.Text = dgvShift.Rows[e.RowIndex].Cells[5].Value.ToString();
            btnAddNew.Enabled = false;
        }

        public Shift GetShiftByID(int id)
        {
            return db.Shifts.Find(id);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string promptValue = ShowDialog("Please Input Code", "Confirm Code");
                if (promptValue == "umcvn@123321")
                {
                    var id = Convert.ToInt32(dgvShift.Rows[dgvShift.CurrentRow.Index].Cells[0].Value);
                    var shift = db.Shifts.Find(id);
                    db.Shifts.Remove(shift);
                    db.SaveChanges();
                    MessageBox.Show("Đã xóa bản ghi !");
                    ClearData();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Error", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Không xóa được bản ghi !" + ex.Message);
            }          
        }
        public void ClearData()
        {
            txtName.Text = "";
            cbbStartHour.Text = "";
            cbbStartMinute.Text = "";
            cbbEndHour.Text = "";
            cbbEndMinute.Text = "";
        }
    }
}
