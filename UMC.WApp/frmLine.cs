using System;
using System.Windows.Forms;
using UMC.Data;
using UMC.Model.Entity;
using UMC.WApp.ViewModel;
using UMC.WApp.Infrastructure.Extensions;
using System.Linq;
using System.Data.Entity.Migrations;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Collections;
using System.Text;

namespace UMC.WApp
{
    public partial class frmLine : Form
    {
        HLDSDbContext db = null;
        public frmLine()
        {
            InitializeComponent();
            db = new HLDSDbContext();
            btnSelect.Enabled = false;
            btnRemoveStation.Enabled = false;
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
                        LineViewModel lineVm = new LineViewModel();
                        lineVm.Name = txtName.Text;
                        Line newLine = new Line();
                        newLine.UpdateLine(lineVm);
                        var lineId = db.Lines.Add(newLine);
                        db.SaveChanges();
                        foreach (var itemChecked in clbStation.CheckedItems)
                        {
                            var station = (Station)itemChecked;
                            LineStation lineStation = new LineStation();
                            lineStation.LineId = lineId.ID;
                            lineStation.StationId = station.ID;
                            db.LineStations.Add(lineStation);
                            db.SaveChanges();
                        }
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
        public void ClearData()
        {
            txtName.Text = "";
            foreach (int i in clbStation.CheckedIndices)
            {
                clbStation.SetItemCheckState(i, CheckState.Unchecked);
            }
        }
        public void LoadData()
        {
            dgvLine.DataSource = db.Lines.OrderBy(x => x.Name).ToList();
        }

        private void frmLine_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCheckListBox();
        }
        public void LoadCheckListBox()
        {
            var model = db.Stations.ToList();
            (clbStation as ListBox).DataSource = model;
            (clbStation as ListBox).DisplayMember = "StationName";
            (clbStation as ListBox).ValueMember = "ID";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string promptValue = ShowDialog("Please Input Code", "Confirm Code");
                if(promptValue =="umcvn@123321")
                {
                    if (!string.IsNullOrEmpty(txtName.Text))
                    {
                        var id = Convert.ToInt32(dgvLine.Rows[dgvLine.CurrentRow.Index].Cells[0].Value);
                        var line = db.Lines.Find(id);
                        LineViewModel lineVm = new LineViewModel();
                        lineVm.ID = line.ID;
                        lineVm.Name = txtName.Text;

                        Line newLine = new Line();
                        newLine.UpdateLine(lineVm);

                        db.Set<Line>().AddOrUpdate(newLine);
                        db.SaveChanges();
                        LoadData();
                        MessageBox.Show("Đã cập nhật xong !");
                        ClearData();
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
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string promptValue = ShowDialog("Please Input Code", "Confirm Code");
                if(promptValue == "umcvn@123321")
                {
                    var id = Convert.ToInt32(dgvLine.Rows[dgvLine.CurrentRow.Index].Cells[0].Value);
                    var line = db.Lines.Find(id);
                    db.Lines.Remove(line);
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

        private void dgvLine_Click(object sender, EventArgs e)
        {
            ClearData();
            var id = Convert.ToInt32(dgvLine.Rows[dgvLine.CurrentRow.Index].Cells[0].Value);
            var query = (from line in db.Lines
                         join lineStation in db.LineStations
                         on line.ID equals lineStation.LineId

                         join station in db.Stations
                         on lineStation.StationId equals station.ID

                         where line.ID == id
                         select new LineStationViewModel
                         {
                             NameStation = station.StationName,
                             NameLine = line.Name,
                             LineId = lineStation.LineId,
                             StationId = lineStation.StationId,
                             Id = station.ID,
                         });


            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[4] { new DataColumn("Id", typeof(int)),
                                new DataColumn("NameStation", typeof(string)),
                                new DataColumn("LineId",typeof(int)),
                                new DataColumn("StationId",typeof(int))});
            foreach (var item in query)
            {
                dt.Rows.Add(item.Id, item.NameStation, item.LineId, item.StationId);
            }

            (clbStation as ListBox).DataSource = dt;
            (clbStation as ListBox).DisplayMember = "NameStation";
            (clbStation as ListBox).ValueMember = "Id";

            var nameLine = db.Lines.Find(id);
            txtName.Text = nameLine.Name;
            btnAddNew.Enabled = false;
            btnSelect.Enabled = true;
            btnRemoveStation.Enabled = true;
                 
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnAddNew.Enabled = true;
            txtName.Text = "";
            ClearData();
            LoadData();
            LoadCheckListBox();
        }

        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var idLine = Convert.ToInt32(dgvLine.Rows[dgvLine.CurrentRow.Index].Cells[0].Value);
            frmUpdateLineStation frmUpdateLineStation = new frmUpdateLineStation(txtName.Text, idLine);
            frmUpdateLineStation.Show();
        }

        private void btnRemoveStation_Click(object sender, EventArgs e)
        {
            string promptValue = ShowDialog("Please Input Code", "Confirm Code");
            if(promptValue == "umcvn@123321")
            {
                string checkedStation = "";
                for (int i = 0; i < clbStation.Items.Count; i++)
                {
                    if (clbStation.GetItemChecked(i))
                    {
                        checkedStation = ((DataRowView)clbStation.Items[i])[0].ToString();
                        var stationId = Convert.ToInt32(checkedStation);
                        var line = db.LineStations.FirstOrDefault(x => x.StationId == stationId);
                        db.LineStations.Remove(line);
                        db.SaveChanges();
                    }
                }
                MessageBox.Show("Đã Remove bản ghi !");
            }
            else
            {
                MessageBox.Show("Error", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
