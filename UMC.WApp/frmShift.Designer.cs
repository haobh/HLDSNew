namespace UMC.WApp
{
    partial class frmShift
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShift));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbEndMinute = new System.Windows.Forms.ComboBox();
            this.cbbEndHour = new System.Windows.Forms.ComboBox();
            this.cbbStartMinute = new System.Windows.Forms.ComboBox();
            this.cbbStartHour = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvShift = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartMinute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndMinute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShift)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbbEndMinute);
            this.groupBox1.Controls.Add(this.cbbEndHour);
            this.groupBox1.Controls.Add(this.cbbStartMinute);
            this.groupBox1.Controls.Add(this.cbbStartHour);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAddNew);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infor Shift Input";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(444, 68);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = ":";
            // 
            // cbbEndMinute
            // 
            this.cbbEndMinute.FormattingEnabled = true;
            this.cbbEndMinute.Items.AddRange(new object[] {
            "00",
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.cbbEndMinute.Location = new System.Drawing.Point(300, 104);
            this.cbbEndMinute.Name = "cbbEndMinute";
            this.cbbEndMinute.Size = new System.Drawing.Size(85, 21);
            this.cbbEndMinute.TabIndex = 3;
            // 
            // cbbEndHour
            // 
            this.cbbEndHour.FormattingEnabled = true;
            this.cbbEndHour.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cbbEndHour.Location = new System.Drawing.Point(168, 104);
            this.cbbEndHour.Name = "cbbEndHour";
            this.cbbEndHour.Size = new System.Drawing.Size(111, 21);
            this.cbbEndHour.TabIndex = 3;
            // 
            // cbbStartMinute
            // 
            this.cbbStartMinute.FormattingEnabled = true;
            this.cbbStartMinute.Items.AddRange(new object[] {
            "00",
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.cbbStartMinute.Location = new System.Drawing.Point(300, 67);
            this.cbbStartMinute.Name = "cbbStartMinute";
            this.cbbStartMinute.Size = new System.Drawing.Size(85, 21);
            this.cbbStartMinute.TabIndex = 3;
            // 
            // cbbStartHour
            // 
            this.cbbStartHour.FormattingEnabled = true;
            this.cbbStartHour.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cbbStartHour.Location = new System.Drawing.Point(168, 67);
            this.cbbStartHour.Name = "cbbStartHour";
            this.cbbStartHour.Size = new System.Drawing.Size(111, 21);
            this.cbbStartHour.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(444, 105);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNew.Location = new System.Drawing.Point(444, 34);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(168, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(217, 20);
            this.txtName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "End Hour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Start Hour";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvShift);
            this.groupBox2.Location = new System.Drawing.Point(26, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 284);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Infor Shift Result";
            // 
            // dgvShift
            // 
            this.dgvShift.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShift.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.StartHour,
            this.StartMinute,
            this.EndHour,
            this.EndMinute});
            this.dgvShift.Location = new System.Drawing.Point(6, 19);
            this.dgvShift.Name = "dgvShift";
            this.dgvShift.Size = new System.Drawing.Size(547, 259);
            this.dgvShift.TabIndex = 0;
            this.dgvShift.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvShift_RowHeaderMouseClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // StartHour
            // 
            this.StartHour.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.StartHour.DataPropertyName = "StartHour";
            dataGridViewCellStyle1.Format = "00";
            dataGridViewCellStyle1.NullValue = null;
            this.StartHour.DefaultCellStyle = dataGridViewCellStyle1;
            this.StartHour.HeaderText = "StartHour";
            this.StartHour.Name = "StartHour";
            this.StartHour.Width = 77;
            // 
            // StartMinute
            // 
            this.StartMinute.DataPropertyName = "StartMinute";
            dataGridViewCellStyle2.Format = "00";
            dataGridViewCellStyle2.NullValue = null;
            this.StartMinute.DefaultCellStyle = dataGridViewCellStyle2;
            this.StartMinute.HeaderText = "StartMinute";
            this.StartMinute.Name = "StartMinute";
            // 
            // EndHour
            // 
            this.EndHour.DataPropertyName = "EndHour";
            dataGridViewCellStyle3.Format = "00";
            dataGridViewCellStyle3.NullValue = null;
            this.EndHour.DefaultCellStyle = dataGridViewCellStyle3;
            this.EndHour.HeaderText = "EndHour";
            this.EndHour.Name = "EndHour";
            // 
            // EndMinute
            // 
            this.EndMinute.DataPropertyName = "EndMinute";
            dataGridViewCellStyle4.Format = "00";
            dataGridViewCellStyle4.NullValue = null;
            this.EndMinute.DefaultCellStyle = dataGridViewCellStyle4;
            this.EndMinute.HeaderText = "EndMinute";
            this.EndMinute.Name = "EndMinute";
            // 
            // frmShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 500);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Text = "Shift";
            this.Load += new System.EventHandler(this.frmShift_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShift)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbEndMinute;
        private System.Windows.Forms.ComboBox cbbEndHour;
        private System.Windows.Forms.ComboBox cbbStartMinute;
        private System.Windows.Forms.ComboBox cbbStartHour;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvShift;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartMinute;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndMinute;
    }
}