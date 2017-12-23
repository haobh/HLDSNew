using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using UMC.Data;
using UMC.Model.Entity;
using UMC.WApp.Infrastructure.Extensions;
using UMC.WApp.ViewModel;

namespace UMC.WApp
{
    public partial class frmInputQuantities : Form
    {
        HLDSDbContext db = null;
        public int _idLine;
        public string _nameLine;

        public frmInputQuantities()
        {
            InitializeComponent();
            db = new HLDSDbContext();
        }
        public frmInputQuantities(string nameLine, int idLine)
        {
            InitializeComponent();
            db = new HLDSDbContext();
            this._idLine = idLine;
            this._nameLine = nameLine;
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
        private void frmInputQuantities_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            var id = _idLine;
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
            foreach (var item in query.OrderByDescending(x=>x.NameStation))
            {
                dt.Rows.Add(item.Id, item.NameStation, item.LineId, item.StationId);
            }
            dgvStation.DataSource = dt;
            lblLine.Text = "Selected: " + _nameLine;
            gbAddNew.Hide();
            gbShift.Hide();
            cbbType.Text = "PCS";
            //Không cho gõ trực tiếp vào combobox
            this.cbbShiftCode.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbbType.DropDownStyle = ComboBoxStyle.DropDownList;
            LoadDefaultShiftCode();
        }

        public void LoadDefaultShiftCode()
        {
            /*var timeNow = Convert.ToDateTime(DateTime.Now.ToShortTimeString());
            string startTime = "08:00 AM";
            var time1 = Convert.ToDateTime(startTime);
            string endTime = "20:00 PM";
            DateTime time2 = Convert.ToDateTime(endTime);

            var nameShift = "Shift B";
            if(timeNow >= time1 && timeNow <= time2)
            {
                nameShift = "Shift A";
            }

            var shiftCode = db.Shifts.Where(x => x.Name == nameShift).ToList();
            */
            var shiftCode = db.Shifts.ToList();
            cbbShiftCode.DataSource = shiftCode;
            cbbShiftCode.DisplayMember = "Name";
            cbbShiftCode.ValueMember = "ID";
        }

        private void grvLine_Click(object sender, EventArgs e)
        {
            try
            {
                ClearData();
                var id = Convert.ToInt32(dgvStation.Rows[dgvStation.CurrentRow.Index].Cells[0].Value);
                gbAddNew.Show();
                gbShift.Show();
                var nameStation = db.Stations.Find(id);
                lblStation.Text = "Add for: " + nameStation.StationName;
                lblShift.Text = "Choose: " + cbbShiftCode.Text;
                btnAddNew.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                LoadDataQuantity();
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn không được chọn vùng này", "Warning",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ClearData()
        {
            cbbShiftCode.Text = "Shift A";
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
        public void LoadDataQuantity()
        {
            try
            {
                var dateNow = DateTime.Now;
                var idLine = _idLine;
                var idStation = Convert.ToInt32(dgvStation.Rows[dgvStation.CurrentRow.Index].Cells[0].Value);

                var timeNow = Convert.ToDateTime(dateNow.ToShortTimeString());
                string startTime = "08:00 AM";
                var time1 = Convert.ToDateTime(startTime);
                string endTime = "20:00 PM";
                DateTime time2 = Convert.ToDateTime(endTime);

                var model = db.Quantities.Where(x => x.StationID == idStation && x.LineID == idLine && x.ShiftCode == "Shift B").ToList();
                if (timeNow >= time1 && timeNow <= time2)
                {
                    model = db.Quantities.Where(x => x.StationID == idStation && x.LineID == idLine && x.ShiftCode == "Shift A").ToList();
                }
                string rateT1 = "";
                string rateT2 = "";
                string rateT3 = "";
                string rateT4 = "";
                string rateT5 = "";
                string rateT6 = "";
                string rateT7 = "";
                string rateT8 = "";
                string rateT9 = "";
                string rateT10 = "";
                string rateT11 = "";
                string rateT12 = "";
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[15] { new DataColumn("Id", typeof(string)),
                                new DataColumn("Type", typeof(string)),
                                new DataColumn("ShiftCode", typeof(string)),
                                new DataColumn("T1", typeof(string)),
                                new DataColumn("T2",typeof(string)),
                                new DataColumn("T3",typeof(string)),
                                new DataColumn("T4", typeof(string)),
                                new DataColumn("T5",typeof(string)),
                                new DataColumn("T6",typeof(string)),
                                new DataColumn("T7", typeof(string)),
                                new DataColumn("T8",typeof(string)),
                                new DataColumn("T9",typeof(string)),
                                new DataColumn("T10", typeof(string)),
                                new DataColumn("T11",typeof(string)),
                                new DataColumn("T12",typeof(string))});
                if (model.Count > 0)
                {
                    var ct = db.TimeSettings.ToList();

                    var query = from p in model
                                where p.CreatedDate.Day == dateNow.Day &&
                                      p.CreatedDate.Month == dateNow.Month &&
                                      p.CreatedDate.Year == dateNow.Year
                                group p by (p.StationID == idStation) into q
                                select new GetSumQuantitiesViewModel
                                {
                                    SumT1 = q.Sum(x => x.T1),
                                    SumT2 = q.Sum(x => x.T2),
                                    SumT3 = q.Sum(x => x.T3),
                                    SumT4 = q.Sum(x => x.T4),
                                    SumT5 = q.Sum(x => x.T5),
                                    SumT6 = q.Sum(x => x.T6),
                                    SumT7 = q.Sum(x => x.T7),
                                    SumT8 = q.Sum(x => x.T8),
                                    SumT9 = q.Sum(x => x.T9),
                                    SumT10 = q.Sum(x => x.T10),
                                    SumT11 = q.Sum(x => x.T11),
                                    SumT12 = q.Sum(x => x.T12)
                                };
                    //Hiển thị S = time / pcs
                    foreach (var select in query)
                    {
                        foreach (var timeSetting in ct)
                        {
                            dt.Rows.Add("", "S", "",
                                Convert.ToString(string.Format("{0:#,###.##}", timeSetting.T1 / select.SumT1)),
                                Convert.ToString(string.Format("{0:#,###.##}", timeSetting.T2 / select.SumT2)),
                                Convert.ToString(string.Format("{0:#,###.##}", timeSetting.T3 / select.SumT3)),
                                Convert.ToString(string.Format("{0:#,###.##}", timeSetting.T4 / select.SumT4)),
                                Convert.ToString(string.Format("{0:#,###.##}", timeSetting.T5 / select.SumT5)),
                                Convert.ToString(string.Format("{0:#,###.##}", timeSetting.T6 / select.SumT6)),
                                Convert.ToString(string.Format("{0:#,###.##}", timeSetting.T7 / select.SumT7)),
                                Convert.ToString(string.Format("{0:#,###.##}", timeSetting.T8 / select.SumT8)),
                                Convert.ToString(string.Format("{0:#,###.##}", timeSetting.T9 / select.SumT9)),
                                Convert.ToString(string.Format("{0:#,###.##}", timeSetting.T10 / select.SumT10)),
                                Convert.ToString(string.Format("{0:#,###.##}", timeSetting.T11 / select.SumT11)),
                                Convert.ToString(string.Format("{0:#,###.##}", timeSetting.T12 / select.SumT12)));
                        }
                    }
                    //Hiển thị PCS
                    foreach (var item in model.Where(x => x.CreatedDate.Date == dateNow.Date))
                    {
                        dt.Rows.Add(item.ID, item.Type, item.ShiftCode, item.T1, item.T2, item.T3,
                            item.T4, item.T5, item.T6, item.T7, item.T8, item.T9,
                            item.T10, item.T11, item.T12);
                    }

                    //Hiển thị Total
                    foreach (var item in query)
                    {
                        dt.Rows.Add("", "TTL", "", item.SumT1, item.SumT2, item.SumT3,
                            item.SumT4, item.SumT5, item.SumT6, item.SumT7, item.SumT8, item.SumT9,
                            item.SumT10, item.SumT11, item.SumT12);
                    }

                    //Tính Phần trăm rate = NumberConfig /(s=timeSetting/Sản lượng PCS)
                    float? numberConfig = 0;
                    var getNumberConfigStation = db.Stations.ToList();
                    foreach (var item in getNumberConfigStation.Where(x => x.ID == idStation))
                    {
                        numberConfig = item.NumberConfig;
                    }
                    if (dt.Rows.Count > 0)
                    {
                        foreach (var select in query)
                        {
                            foreach (var timeSetting in ct)
                            {
                                if (select.SumT1 != null)
                                {
                                    var t1 = numberConfig / (timeSetting.T1 / select.SumT1) * 100;
                                    rateT1 = Convert.ToString(string.Format("{0:#,###.##}%", t1));
                                }

                                if (select.SumT2 != null)
                                {
                                    var t2 = numberConfig / (timeSetting.T2 / select.SumT2) * 100;
                                    rateT2 = Convert.ToString(string.Format("{0:#,###.##} %", t2));
                                }

                                if (select.SumT3 != null)
                                {
                                    var t3 = numberConfig / (timeSetting.T3 / select.SumT3) * 100;
                                    rateT3 = Convert.ToString(string.Format("{0:#,###.##} %", t3));
                                }

                                if (select.SumT4 != null)
                                {
                                    var t4 = numberConfig / (timeSetting.T4 / select.SumT4) * 100;
                                    rateT4 = Convert.ToString(string.Format("{0:#,###.##} %", t4));
                                }

                                if (select.SumT5 != null)
                                {
                                    var t5 = numberConfig / (timeSetting.T5 / select.SumT5) * 100;
                                    rateT5 = Convert.ToString(string.Format("{0:#,###.##} %", t5));
                                }

                                if (select.SumT6 != null)
                                {
                                    var t6 = numberConfig / (timeSetting.T6 / select.SumT6) * 100;
                                    rateT6 = Convert.ToString(string.Format("{0:#,###.##} %", t6));
                                }

                                if (select.SumT7 != null)
                                {
                                    var t7 = numberConfig / (timeSetting.T7 / select.SumT7) * 100;
                                    rateT7 = Convert.ToString(string.Format("{0:#,###.##} %", t7));
                                }

                                if (select.SumT8 != null)
                                {
                                    var t8 = numberConfig / (timeSetting.T8 / select.SumT8) * 100;
                                    rateT8 = Convert.ToString(string.Format("{0:#,###.##} %", t8));
                                }

                                if (select.SumT9 != null)
                                {
                                    var t9 = numberConfig / (timeSetting.T9 / select.SumT9) * 100;
                                    rateT9 = Convert.ToString(string.Format("{0:#,###.##} %", t9));
                                }

                                if (select.SumT10 != null)
                                {
                                    var t10 = numberConfig / (timeSetting.T10 / select.SumT10) * 100;
                                    rateT10 = Convert.ToString(string.Format("{0:#,###.##} %", t10));
                                }

                                if (select.SumT11 != null)
                                {
                                    var t11 = numberConfig / (timeSetting.T11 / select.SumT11) * 100;
                                    rateT11 = Convert.ToString(string.Format("{0:#,###.##} %", t11));
                                }

                                if (select.SumT12 != null)
                                {
                                    var t12 = numberConfig / (timeSetting.T12 / select.SumT12) * 100;
                                    rateT12 = Convert.ToString(string.Format("{0:#,###.##} %", t12));
                                }
                                dt.Rows.Add("", "Rate", "",
                                  rateT1.ToString(),
                                  rateT2.ToString(),
                                  rateT3.ToString(),
                                  rateT4.ToString(),
                                  rateT5.ToString(),
                                  rateT6.ToString(),
                                  rateT7.ToString(),
                                  rateT8.ToString(),
                                  rateT9.ToString(),
                                  rateT10.ToString(),
                                  rateT11.ToString(),
                                  rateT12.ToString()
                              );

                            }
                        }
                    }
                }
                dgvQuantity.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cbbType.SelectedItem.ToString()))
                {
                    var dateNow = DateTime.Now;
                    var id = Convert.ToInt32(dgvStation.Rows[dgvStation.CurrentRow.Index].Cells[0].Value);
                    QuantitiesViewModel quantitiesVm = new QuantitiesViewModel();
                    quantitiesVm.CreatedDate = DateTime.Parse(DateTime.Now.ToString("dd-MM-yyyy"));
                    quantitiesVm.UpdatedDate = DateTime.Now;
                    quantitiesVm.LineID = _idLine;
                    quantitiesVm.StationID = id;
                    quantitiesVm.ShiftCode = cbbShiftCode.Text;
                    quantitiesVm.Type = cbbType.SelectedItem.ToString();

                    var checkType = db.Quantities.Where(x => x.CreatedDate.Day == dateNow.Day &&
                                                        x.CreatedDate.Month == dateNow.Month &&
                                                        x.CreatedDate.Year == dateNow.Year &&
                                                        x.Type == quantitiesVm.Type &&
                                                        x.LineID == _idLine &&
                                                        x.StationID == id &&
                                                        x.ShiftCode == cbbShiftCode.Text).ToList();

                    if (checkType.Count > 0)
                    {
                        MessageBox.Show("Bạn đã nhập số lượng cho ngày hôm nay", "Error",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (txtT1.Text.Length > 0)
                        {
                            quantitiesVm.T1 = float.Parse(txtT1.Text); ;
                        }
                        else
                        {
                            quantitiesVm.T1 = 0;
                        }

                        if (txtT2.Text.Length > 0)
                        {
                            quantitiesVm.T2 = float.Parse(txtT2.Text); ;
                        }
                        else
                        {
                            quantitiesVm.T2 = 0;
                        }

                        if (txtT3.Text.Length > 0)
                        {
                            quantitiesVm.T3 = float.Parse(txtT3.Text); ;
                        }
                        else
                        {
                            quantitiesVm.T3 = 0;
                        }

                        if (txtT4.Text.Length > 0)
                        {
                            quantitiesVm.T4 = float.Parse(txtT4.Text); ;
                        }
                        else
                        {
                            quantitiesVm.T4 = 0;
                        }

                        if (txtT5.Text.Length > 0)
                        {
                            quantitiesVm.T5 = float.Parse(txtT5.Text); ;
                        }
                        else
                        {
                            quantitiesVm.T5 = 0;
                        }

                        if (txtT6.Text.Length > 0)
                        {
                            quantitiesVm.T6 = float.Parse(txtT6.Text); ;
                        }
                        else
                        {
                            quantitiesVm.T6 = 0;
                        }

                        if (txtT7.Text.Length > 0)
                        {
                            quantitiesVm.T7 = float.Parse(txtT7.Text); ;
                        }
                        else
                        {
                            quantitiesVm.T7 = 0;
                        }

                        if (txtT8.Text.Length > 0)
                        {
                            quantitiesVm.T8 = float.Parse(txtT8.Text); ;
                        }
                        else
                        {
                            quantitiesVm.T8 = 0;
                        }

                        if (txtT9.Text.Length > 0)
                        {
                            quantitiesVm.T9 = float.Parse(txtT9.Text); ;
                        }
                        else
                        {
                            quantitiesVm.T9 = 0;
                        }

                        if (txtT10.Text.Length > 0)
                        {
                            quantitiesVm.T10 = float.Parse(txtT10.Text); ;
                        }
                        else
                        {
                            quantitiesVm.T10 = 0;
                        }

                        if (txtT11.Text.Length > 0)
                        {
                            quantitiesVm.T11 = float.Parse(txtT11.Text); ;
                        }
                        else
                        {
                            quantitiesVm.T11 = 0;
                        }

                        if (txtT12.Text.Length > 0)
                        {
                            quantitiesVm.T12 = float.Parse(txtT12.Text); ;
                        }
                        else
                        {
                            quantitiesVm.T12 = 0;
                        }

                        Quantity newQuantity = new Quantity();
                        newQuantity.UpdateQuantities(quantitiesVm);

                        var quantityId = db.Quantities.Add(newQuantity);
                        db.SaveChanges();

                        ClearData();
                        LoadDataQuantity(); ;
                        MessageBox.Show("Thêm mới thành công!");
                    }

                }
                else
                {
                    MessageBox.Show("Bạn không được để trống dữ liệu", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thêm được dữ liệu" + ex, "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cbbType.SelectedItem.ToString()))
                {
                    QuantitiesViewModel quantitiesVm = new QuantitiesViewModel();
                    if (txtT1.Text.Length > 0)
                    {
                        quantitiesVm.T1 = float.Parse(txtT1.Text); ;
                    }
                    else
                    {
                        quantitiesVm.T1 = 0;
                    }
                    if (txtT2.Text.Length > 0)
                    {
                        quantitiesVm.T2 = float.Parse(txtT2.Text); ;
                    }
                    else
                    {
                        quantitiesVm.T2 = 0;
                    }
                    if (txtT3.Text.Length > 0)
                    {
                        quantitiesVm.T3 = float.Parse(txtT3.Text); ;
                    }
                    else
                    {
                        quantitiesVm.T3 = 0;
                    }
                    if (txtT4.Text.Length > 0)
                    {
                        quantitiesVm.T4 = float.Parse(txtT4.Text); ;
                    }
                    else
                    {
                        quantitiesVm.T4 = 0;
                    }
                    if (txtT5.Text.Length > 0)
                    {
                        quantitiesVm.T5 = float.Parse(txtT5.Text); ;
                    }
                    else
                    {
                        quantitiesVm.T5 = 0;
                    }
                    if (txtT6.Text.Length > 0)
                    {
                        quantitiesVm.T6 = float.Parse(txtT6.Text); ;
                    }
                    else
                    {
                        quantitiesVm.T6 = 0;
                    }
                    if (txtT7.Text.Length > 0)
                    {
                        quantitiesVm.T7 = float.Parse(txtT7.Text); ;
                    }
                    else
                    {
                        quantitiesVm.T7 = 0;
                    }
                    if (txtT8.Text.Length > 0)
                    {
                        quantitiesVm.T8 = float.Parse(txtT8.Text); ;
                    }
                    else
                    {
                        quantitiesVm.T8 = 0;
                    }
                    if (txtT9.Text.Length > 0)
                    {
                        quantitiesVm.T9 = float.Parse(txtT9.Text); ;
                    }
                    else
                    {
                        quantitiesVm.T9 = 0;
                    }
                    if (txtT10.Text.Length > 0)
                    {
                        quantitiesVm.T10 = float.Parse(txtT10.Text); ;
                    }
                    else
                    {
                        quantitiesVm.T10 = 0;
                    }
                    if (txtT11.Text.Length > 0)
                    {
                        quantitiesVm.T11 = float.Parse(txtT11.Text); ;
                    }
                    else
                    {
                        quantitiesVm.T11 = 0;
                    }
                    if (txtT12.Text.Length > 0)
                    {
                        quantitiesVm.T12 = float.Parse(txtT12.Text); ;
                    }
                    else
                    {
                        quantitiesVm.T12 = 0;
                    }

                    var id = Convert.ToInt32(dgvQuantity.Rows[dgvQuantity.CurrentRow.Index].Cells["QuantitiesId"].Value);
                    var quantities = db.Quantities.Find(id);
                    quantitiesVm.ID = id;
                    quantitiesVm.LineID = quantities.LineID;
                    quantitiesVm.StationID = quantities.StationID;
                    quantitiesVm.CreatedDate = quantities.CreatedDate;
                    quantitiesVm.UpdatedDate = quantities.UpdatedDate;
                    quantitiesVm.Type = cbbType.SelectedItem.ToString();
                    quantitiesVm.ShiftCode = cbbShiftCode.Text;

                    Quantity newQuantities = new Quantity();
                    newQuantities.UpdateQuantities(quantitiesVm);

                    db.Set<Quantity>().AddOrUpdate(newQuantities);
                    db.SaveChanges();

                    ClearData();
                    LoadDataQuantity();
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

        private void dgvQuantity_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = 0;
                DataGridViewRow row = this.dgvQuantity.Rows[e.RowIndex];
                id = Convert.ToInt32(row.Cells["QuantitiesId"].Value.ToString());

                var checkId = db.Quantities.Where(x => x.ID == id).ToList();
                var quantities = db.Quantities.Find(id);
                txtT1.Text = quantities.T1.ToString();
                txtT2.Text = quantities.T2.ToString();
                txtT3.Text = quantities.T3.ToString();
                txtT4.Text = quantities.T4.ToString();
                txtT5.Text = quantities.T5.ToString();
                txtT6.Text = quantities.T6.ToString();
                txtT7.Text = quantities.T7.ToString();
                txtT8.Text = quantities.T8.ToString();
                txtT9.Text = quantities.T9.ToString();
                txtT10.Text = quantities.T10.ToString();
                txtT11.Text = quantities.T11.ToString();
                txtT12.Text = quantities.T12.ToString();
                cbbType.Text = quantities.Type.ToString();
                cbbShiftCode.Text = quantities.ShiftCode.ToString();

                btnAddNew.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn không được chọn vùng này", "Warning",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string promptValue = ShowDialog("Please Input Code", "Confirm Code");
                if (promptValue == "umcvn@123321")
                {
                    var id = Convert.ToInt32(dgvQuantity.Rows[dgvQuantity.CurrentRow.Index].Cells["QuantitiesId"].Value);
                    var quantities = db.Quantities.Find(id);
                    db.Quantities.Remove(quantities);
                    db.SaveChanges();
                    ClearData();
                    LoadDataQuantity();
                    MessageBox.Show("Đã xóa bản ghi !");
                }
                else
                {
                    MessageBox.Show("Error", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }   
            }
            catch (Exception)
            {
                MessageBox.Show("Không xóa được bản ghi", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbbShiftCode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                lblShift.Text = "Choose: " + cbbShiftCode.Text;
                var dateNow = DateTime.Now;
                var idLine = _idLine;
                var idStation = Convert.ToInt32(dgvStation.Rows[dgvStation.CurrentRow.Index].Cells[0].Value);
                var shiftCode = cbbShiftCode.Text;
                var model = db.Quantities.Where(x => x.StationID == idStation && x.LineID == idLine && x.ShiftCode == shiftCode).ToList();

                string rateT1 = "";
                string rateT2 = "";
                string rateT3 = "";
                string rateT4 = "";
                string rateT5 = "";
                string rateT6 = "";
                string rateT7 = "";
                string rateT8 = "";
                string rateT9 = "";
                string rateT10 = "";
                string rateT11 = "";
                string rateT12 = "";
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[15] { new DataColumn("Id", typeof(string)),
                                new DataColumn("Type", typeof(string)),
                                new DataColumn("ShiftCode", typeof(string)),
                                new DataColumn("T1", typeof(string)),
                                new DataColumn("T2",typeof(string)),
                                new DataColumn("T3",typeof(string)),
                                new DataColumn("T4", typeof(string)),
                                new DataColumn("T5",typeof(string)),
                                new DataColumn("T6",typeof(string)),
                                new DataColumn("T7", typeof(string)),
                                new DataColumn("T8",typeof(string)),
                                new DataColumn("T9",typeof(string)),
                                new DataColumn("T10", typeof(string)),
                                new DataColumn("T11",typeof(string)),
                                new DataColumn("T12",typeof(string))});
                if (model.Count > 0)
                {
                    var ct = db.TimeSettings.ToList();

                    var query = from p in model
                                where p.CreatedDate.Day == dateNow.Day &&
                                      p.CreatedDate.Month == dateNow.Month &&
                                      p.CreatedDate.Year == dateNow.Year
                                group p by (p.StationID == idStation) into q
                                select new GetSumQuantitiesViewModel
                                {
                                    SumT1 = q.Sum(x => x.T1),
                                    SumT2 = q.Sum(x => x.T2),
                                    SumT3 = q.Sum(x => x.T3),
                                    SumT4 = q.Sum(x => x.T4),
                                    SumT5 = q.Sum(x => x.T5),
                                    SumT6 = q.Sum(x => x.T6),
                                    SumT7 = q.Sum(x => x.T7),
                                    SumT8 = q.Sum(x => x.T8),
                                    SumT9 = q.Sum(x => x.T9),
                                    SumT10 = q.Sum(x => x.T10),
                                    SumT11 = q.Sum(x => x.T11),
                                    SumT12 = q.Sum(x => x.T12)
                                };
                    //Hiển thị S = time / pcs
                    foreach (var select in query)
                    {
                        foreach (var timeSetting in ct)
                        {
                            dt.Rows.Add("", "S", "",
                                Convert.ToString(string.Format("{0:#,###.##}", timeSetting.T1 / select.SumT1)),
                                Convert.ToString(string.Format("{0:#,###.##}", timeSetting.T2 / select.SumT2)),
                                Convert.ToString(string.Format("{0:#,###.##}", timeSetting.T3 / select.SumT3)),
                                Convert.ToString(string.Format("{0:#,###.##}", timeSetting.T4 / select.SumT4)),
                                Convert.ToString(string.Format("{0:#,###.##}", timeSetting.T5 / select.SumT5)),
                                Convert.ToString(string.Format("{0:#,###.##}", timeSetting.T6 / select.SumT6)),
                                Convert.ToString(string.Format("{0:#,###.##}", timeSetting.T7 / select.SumT7)),
                                Convert.ToString(string.Format("{0:#,###.##}", timeSetting.T8 / select.SumT8)),
                                Convert.ToString(string.Format("{0:#,###.##}", timeSetting.T9 / select.SumT9)),
                                Convert.ToString(string.Format("{0:#,###.##}", timeSetting.T10 / select.SumT10)),
                                Convert.ToString(string.Format("{0:#,###.##}", timeSetting.T11 / select.SumT11)),
                                Convert.ToString(string.Format("{0:#,###.##}", timeSetting.T12 / select.SumT12)));
                        }
                    }
                    //Hiển thị PCS
                    foreach (var item in model.Where(x => x.CreatedDate.Date == dateNow.Date))
                    {
                        dt.Rows.Add(item.ID, item.Type, item.ShiftCode, item.T1, item.T2, item.T3,
                            item.T4, item.T5, item.T6, item.T7, item.T8, item.T9,
                            item.T10, item.T11, item.T12);
                    }

                    //Hiển thị Total
                    foreach (var item in query)
                    {
                        dt.Rows.Add("", "TTL", "", item.SumT1, item.SumT2, item.SumT3,
                            item.SumT4, item.SumT5, item.SumT6, item.SumT7, item.SumT8, item.SumT9,
                            item.SumT10, item.SumT11, item.SumT12);
                    }

                    //Tính Phần trăm rate = NumberConfig /(s=timeSetting/Sản lượng PCS)
                    float? numberConfig = 0;
                    var getNumberConfigStation = db.Stations.ToList();
                    foreach (var item in getNumberConfigStation.Where(x => x.ID == idStation))
                    {
                        numberConfig = item.NumberConfig;
                    }
                    if (dt.Rows.Count > 0)
                    {
                        foreach (var select in query)
                        {
                            foreach (var timeSetting in ct)
                            {
                                if (select.SumT1 != null)
                                {
                                    var t1 = numberConfig / (timeSetting.T1 / select.SumT1) * 100;
                                    rateT1 = Convert.ToString(string.Format("{0:#,###.##}%", t1));
                                }

                                if (select.SumT2 != null)
                                {
                                    var t2 = numberConfig / (timeSetting.T2 / select.SumT2) * 100;
                                    rateT2 = Convert.ToString(string.Format("{0:#,###.##} %", t2));
                                }

                                if (select.SumT3 != null)
                                {
                                    var t3 = numberConfig / (timeSetting.T3 / select.SumT3) * 100;
                                    rateT3 = Convert.ToString(string.Format("{0:#,###.##} %", t3));
                                }

                                if (select.SumT4 != null)
                                {
                                    var t4 = numberConfig / (timeSetting.T4 / select.SumT4) * 100;
                                    rateT4 = Convert.ToString(string.Format("{0:#,###.##} %", t4));
                                }

                                if (select.SumT5 != null)
                                {
                                    var t5 = numberConfig / (timeSetting.T5 / select.SumT5) * 100;
                                    rateT5 = Convert.ToString(string.Format("{0:#,###.##} %", t5));
                                }

                                if (select.SumT6 != null)
                                {
                                    var t6 = numberConfig / (timeSetting.T6 / select.SumT6) * 100;
                                    rateT6 = Convert.ToString(string.Format("{0:#,###.##} %", t6));
                                }

                                if (select.SumT7 != null)
                                {
                                    var t7 = numberConfig / (timeSetting.T7 / select.SumT7) * 100;
                                    rateT7 = Convert.ToString(string.Format("{0:#,###.##} %", t7));
                                }

                                if (select.SumT8 != null)
                                {
                                    var t8 = numberConfig / (timeSetting.T8 / select.SumT8) * 100;
                                    rateT8 = Convert.ToString(string.Format("{0:#,###.##} %", t8));
                                }

                                if (select.SumT9 != null)
                                {
                                    var t9 = numberConfig / (timeSetting.T9 / select.SumT9) * 100;
                                    rateT9 = Convert.ToString(string.Format("{0:#,###.##} %", t9));
                                }

                                if (select.SumT10 != null)
                                {
                                    var t10 = numberConfig / (timeSetting.T10 / select.SumT10) * 100;
                                    rateT10 = Convert.ToString(string.Format("{0:#,###.##} %", t10));
                                }

                                if (select.SumT11 != null)
                                {
                                    var t11 = numberConfig / (timeSetting.T11 / select.SumT11) * 100;
                                    rateT11 = Convert.ToString(string.Format("{0:#,###.##} %", t11));
                                }

                                if (select.SumT12 != null)
                                {
                                    var t12 = numberConfig / (timeSetting.T12 / select.SumT12) * 100;
                                    rateT12 = Convert.ToString(string.Format("{0:#,###.##} %", t12));
                                }
                                dt.Rows.Add("", "Rate", "",
                                  rateT1.ToString(),
                                  rateT2.ToString(),
                                  rateT3.ToString(),
                                  rateT4.ToString(),
                                  rateT5.ToString(),
                                  rateT6.ToString(),
                                  rateT7.ToString(),
                                  rateT8.ToString(),
                                  rateT9.ToString(),
                                  rateT10.ToString(),
                                  rateT11.ToString(),
                                  rateT12.ToString()
                              );

                            }
                        }
                    }
                }
                dgvQuantity.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
        }
    }
}
