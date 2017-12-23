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
    public partial class frmTimeDaily : Form
    {
        HLDSDbContext db = null;
        public frmTimeDaily()
        {
            InitializeComponent();
            db = new HLDSDbContext();
        }
        public void LoadData()
        {
            dgvTimeDaily.DataSource = db.TimeDailies.ToList();
        }
        public void ClearData()
        {
            txtLine1.Text = "";
            txtLine2.Text = "";
            txtLine3.Text = "";
            txtLine4.Text = "";
            txtLine5.Text = "";
            txtLine6.Text = "";
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
        private void btAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                string promptValue = ShowDialog("Please Input Code", "Confirm Code");
                if (promptValue == "umcvn@123321")
                {
                    if (!string.IsNullOrEmpty(txtLine1.Text))
                    {
                        TimeDailyViewModel timeDailyVm = new TimeDailyViewModel();
                        timeDailyVm.Time1 = int.Parse(txtLine1.Text);
                        timeDailyVm.Time2 = int.Parse(txtLine2.Text);
                        timeDailyVm.Time3 = int.Parse(txtLine3.Text);
                        timeDailyVm.Time4 = int.Parse(txtLine4.Text);
                        timeDailyVm.Time5 = int.Parse(txtLine5.Text);
                        timeDailyVm.Time6 = int.Parse(txtLine6.Text);

                        TimeDaily newTimeDaily = new TimeDaily();
                        newTimeDaily.UpdateTimeDaily(timeDailyVm);
                        db.TimeDailies.Add(newTimeDaily);
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

        private void frmTimeDaily_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                string promptValue = ShowDialog("Please Input Code", "Confirm Code");
                if (promptValue == "umcvn@123321")
                {
                    if (txtLine1.Text != "")
                    {
                        TimeDailyViewModel timeDailyVm = new TimeDailyViewModel();
                        timeDailyVm.Time1 = int.Parse(txtLine1.Text);
                        timeDailyVm.Time2 = int.Parse(txtLine2.Text);
                        timeDailyVm.Time3 = int.Parse(txtLine3.Text);
                        timeDailyVm.Time4 = int.Parse(txtLine4.Text);
                        timeDailyVm.Time5 = int.Parse(txtLine5.Text);
                        timeDailyVm.Time6 = int.Parse(txtLine6.Text);

                        var id = Convert.ToInt32(dgvTimeDaily.Rows[dgvTimeDaily.CurrentRow.Index].Cells[0].Value);
                        timeDailyVm.ID = id;

                        TimeDaily newTimeDaily = new TimeDaily();
                        newTimeDaily.UpdateTimeDaily(timeDailyVm);

                        db.Set<TimeDaily>().AddOrUpdate(newTimeDaily);
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

        private void dgvTimeDaily_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtLine1.Text = dgvTimeDaily.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLine2.Text = dgvTimeDaily.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtLine3.Text = dgvTimeDaily.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtLine4.Text = dgvTimeDaily.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtLine5.Text = dgvTimeDaily.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtLine6.Text = dgvTimeDaily.Rows[e.RowIndex].Cells[6].Value.ToString();
            btAddNew.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string promptValue = ShowDialog("Please Input Code", "Confirm Code");
                if(promptValue == "umcvn@123321")
                {
                    var id = Convert.ToInt32(dgvTimeDaily.Rows[dgvTimeDaily.CurrentRow.Index].Cells[0].Value);
                    var time = db.TimeDailies.Find(id);
                    db.TimeDailies.Remove(time);
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
    }
}
