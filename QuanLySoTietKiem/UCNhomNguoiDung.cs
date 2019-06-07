using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySoTietKiem
{
    public partial class UCNhomNguoiDung : UserControl
    {
        public UCNhomNguoiDung()
        {
            InitializeComponent();

            LamMoi();
        }

        private void Button7_Click(object sender, EventArgs e)
        {

        }

        private void DataGridNhomNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Object.NhomNguoiDung nND = new Object.NhomNguoiDung();
            nND.MaNhomNguoiDung = dataGridNhomNguoiDung.Rows[e.RowIndex].Cells[0].Value.ToString();
            nND.TenNhomNguoiDung = dataGridNhomNguoiDung.Rows[e.RowIndex].Cells[1].Value.ToString();
            nND.XuatNhapLieu(ref txtMaNhom, ref txtTenNhomNguoiDung);
        }

        private void LamMoi()
        {
            dataGridNhomNguoiDung.DataSource = Data.Query.LayDuLieu("NHOM_NGUOI_DUNG");
        }
        private void BtnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Visible = true;
            btnHuy.Visible = true;
            btnSua.Visible = false;
            btnXoa.Visible = false;
        }
        private void BtnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Visible = true;
            btnHuy.Visible = true;
            btnThem.Visible = false;
            btnXoa.Visible = false;

        }
        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (btnSua.Visible == false)
            {
                Object.NhomNguoiDung nND = new Object.NhomNguoiDung();
                nND.MaNhomNguoiDung = txtMaNhom.Text;
                nND.TenNhomNguoiDung = txtTenNhomNguoiDung.Text;
                nND.ThemData();
            }

            if (btnThem.Visible == false)
            {
                Object.NhomNguoiDung nND = new Object.NhomNguoiDung();
                nND.MaNhomNguoiDung = txtMaNhom.Text;
                nND.TenNhomNguoiDung = txtTenNhomNguoiDung.Text;
                nND.SuaData();
            }
            LamMoi();
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            btnSua.Visible = true;
            btnThem.Visible = true;
            btnXoa.Visible = true;
            btnLuu.Visible = false;
            btnHuy.Visible = false;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn thực sự muốn xóa?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Object.NhomNguoiDung nND = new Object.NhomNguoiDung();
                nND.MaNhomNguoiDung = txtMaNhom.Text;
                nND.TenNhomNguoiDung = txtTenNhomNguoiDung.Text;
                nND.XoaData();

                LamMoi();
            }
            else if (dialogResult == DialogResult.No)
            {

            }

        }
    }
}
