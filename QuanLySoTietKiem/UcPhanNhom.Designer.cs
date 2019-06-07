namespace QuanLySoTietKiem
{
    partial class UcPhanNhom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbbNhomNguoiDung = new System.Windows.Forms.ComboBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridPhanNhom = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhomNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPhanNhom)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.cbbNhomNguoiDung);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(612, 597);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phân nhóm";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(310, 221);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(95, 28);
            this.btnLuu.TabIndex = 122;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Visible = false;
            this.btnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(484, 189);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 28);
            this.btnXoa.TabIndex = 121;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(484, 221);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(92, 28);
            this.btnHuy.TabIndex = 120;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Visible = false;
            this.btnHuy.Click += new System.EventHandler(this.BtnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(310, 189);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(95, 28);
            this.btnSua.TabIndex = 119;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(146, 190);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 28);
            this.btnThem.TabIndex = 118;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // cbbNhomNguoiDung
            // 
            this.cbbNhomNguoiDung.FormattingEnabled = true;
            this.cbbNhomNguoiDung.Location = new System.Drawing.Point(252, 115);
            this.cbbNhomNguoiDung.Name = "cbbNhomNguoiDung";
            this.cbbNhomNguoiDung.Size = new System.Drawing.Size(197, 24);
            this.cbbNhomNguoiDung.TabIndex = 107;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Enabled = false;
            this.txtTenNV.Location = new System.Drawing.Point(252, 78);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(197, 22);
            this.txtTenNV.TabIndex = 6;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(252, 38);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(197, 22);
            this.txtMaNV.TabIndex = 5;
            this.txtMaNV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtMaNV_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhóm người dùng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.textBox17);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(730, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(285, 597);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tìm kiếm";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(102, 202);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 28);
            this.button7.TabIndex = 107;
            this.button7.Text = "Tìm kiếm";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(45, 155);
            this.textBox17.Margin = new System.Windows.Forms.Padding(2);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(185, 22);
            this.textBox17.TabIndex = 106;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(53, 115);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(119, 21);
            this.checkBox2.TabIndex = 105;
            this.checkBox2.Text = "Tìm mã nhóm ";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(53, 81);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(142, 21);
            this.checkBox1.TabIndex = 104;
            this.checkBox1.Text = "Tìm mã nhân viên";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nhập thông tin cần tìm kiếm";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox3.Controls.Add(this.dataGridPhanNhom);
            this.groupBox3.Location = new System.Drawing.Point(18, 295);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(982, 262);
            this.groupBox3.TabIndex = 109;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bảng thông tin";
            // 
            // dataGridPhanNhom
            // 
            this.dataGridPhanNhom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPhanNhom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.MaNhomNguoiDung,
            this.MaNhom});
            this.dataGridPhanNhom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridPhanNhom.Location = new System.Drawing.Point(2, 17);
            this.dataGridPhanNhom.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridPhanNhom.Name = "dataGridPhanNhom";
            this.dataGridPhanNhom.RowHeadersWidth = 51;
            this.dataGridPhanNhom.RowTemplate.Height = 24;
            this.dataGridPhanNhom.Size = new System.Drawing.Size(978, 243);
            this.dataGridPhanNhom.TabIndex = 0;
            this.dataGridPhanNhom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridPhanNhom_CellClick);
            this.dataGridPhanNhom.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridPhanNhom_CellLeave);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 200;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên nhân viên";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.Width = 250;
            // 
            // MaNhomNguoiDung
            // 
            this.MaNhomNguoiDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaNhomNguoiDung.DataPropertyName = "MaNhomNguoiDung";
            this.MaNhomNguoiDung.HeaderText = "Nhóm";
            this.MaNhomNguoiDung.MinimumWidth = 6;
            this.MaNhomNguoiDung.Name = "MaNhomNguoiDung";
            // 
            // MaNhom
            // 
            this.MaNhom.DataPropertyName = "MaPhongGiaoDich";
            this.MaNhom.HeaderText = "Mã nhóm";
            this.MaNhom.MinimumWidth = 6;
            this.MaNhom.Name = "MaNhom";
            this.MaNhom.Visible = false;
            this.MaNhom.Width = 125;
            // 
            // UcPhanNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UcPhanNhom";
            this.Size = new System.Drawing.Size(1015, 597);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPhanNhom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridPhanNhom;
        private System.Windows.Forms.ComboBox cbbNhomNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhomNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhom;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}
