using System;
using System.Linq;
using System.Windows.Forms;
using UMC.Data;
using UMC.Model.Entity;
using UMC.WApp.Infrastructure.Extensions;
using UMC.WApp.ViewModel;

namespace UMC.WApp
{
    public partial class frmUpdateLineStation : Form
    {
        public string _textBoxValue;
        public int _idLine;
        HLDSDbContext db = null;
        public frmUpdateLineStation()
        {
            InitializeComponent();
        }
        public frmUpdateLineStation(string textBoxValue, int idLine)
        {
            InitializeComponent();
            db = new HLDSDbContext();
            this._textBoxValue = textBoxValue;
            this._idLine = idLine;
        }

        private void frmUpdateLineStation_Load(object sender, EventArgs e)
        {
            LoadCheckListBox();
        }
        public void LoadCheckListBox()
        {
            var model = db.Stations.ToList();
            ((ListBox)clbStationUpdate).DataSource = model;
            ((ListBox)clbStationUpdate).DisplayMember = "Name";
            ((ListBox)clbStationUpdate).ValueMember = "ID";
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(this._textBoxValue))
                {

                    foreach (var itemChecked in clbStationUpdate.CheckedItems)
                    {
                        var station = (Station)itemChecked;
                        LineStation lineStation = new LineStation();
                        lineStation.LineId = _idLine;
                        lineStation.StationId = station.ID;
                        db.LineStations.Add(lineStation);
                        db.SaveChanges();
                    }

                    //ClearData();
                    //LoadData();
                    MessageBox.Show("Thêm mới thành công!");
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn dữ liệu Update", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thêm được dữ liệu", "Error" + ex.Message,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
