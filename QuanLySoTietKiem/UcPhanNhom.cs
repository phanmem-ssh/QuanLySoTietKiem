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
    public partial class UcPhanNhom : UserControl
    {
        public UcPhanNhom()
        {
            InitializeComponent();

            LamMoi();
        }

        private void UcPhanNhom_Load(object sender, EventArgs e)
        {

        }

        private void DataGridPhanNhom_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtMaNV_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void DataGridPhanNhom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Object.PhanNhom pN = new Object.PhanNhom();

            pN.MaNV = dataGridPhanNhom.Rows[e.RowIndex].Cells[0].Value.ToString();
            pN.MaNhomNguoiDung = dataGridPhanNhom.Rows[e.RowIndex].Cells[3].Value.ToString();

            pN.XuatNhapLieu(ref txtMaNV, ref txtTenNV, ref cbbNhomNguoiDung);
        }

        private void LamMoi()
        {
            DataTable dataPN = Data.Query.LayDuLieu("PHAN_NHOM");
            dataPN.Columns.Add("TenNV", typeof(String));
            dataPN.Columns.Add("MaPhongGiaoDich", typeof(String));

            Object.PhanNhom pN = new Object.PhanNhom();
            for (int i = 0; i < dataPN.Rows.Count; i++)
            {
                pN.MaNV = dataPN.Rows[i].ItemArray[0].ToString();
                pN.MaNhomNguoiDung = dataPN.Rows[i].ItemArray[1].ToString();

                dataPN.Rows[i][3] = pN.MaNhomNguoiDung;
                dataPN.Rows[i][2] = pN.getHoTen();
                dataPN.Rows[i][1] = pN.getNhomNguoiDung();

            }
            dataGridPhanNhom.DataSource = dataPN;
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
                Object.PhanNhom pN = new Object.PhanNhom();
                pN.MaNV = txtMaNV.Text;
                pN.MaNhomNguoiDung = cbbNhomNguoiDung.SelectedValue.ToString();
                pN.ThemData();
            }

            if (btnThem.Visible == false)
            {
                Object.PhanNhom pN = new Object.PhanNhom();
                pN.MaNV = txtMaNV.Text;
                pN.MaNhomNguoiDung = cbbNhomNguoiDung.SelectedValue.ToString();
                pN.SuaData();
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
            DialogResult dialogResult = MessageBox.Show("Bạn thực sự muốn xóa?", "Cảnh báo!", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Object.PhanNhom pN = new Object.PhanNhom();
                pN.MaNV = txtMaNV.Text;
                pN.MaNhomNguoiDung = cbbNhomNguoiDung.SelectedValue.ToString();
                pN.XoaData();

                LamMoi();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
            
        }
    }
}
