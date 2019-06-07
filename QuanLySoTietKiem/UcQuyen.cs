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
    public partial class UCQuyen : UserControl
    {
        public UCQuyen()
        {
            InitializeComponent();

            dataGridQuyen.DataSource = Data.Query.LayDuLieu("QUYEN");


        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridQuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Object.Quyen quyen = new Object.Quyen();
            quyen.MaQuyen = dataGridQuyen.Rows[e.RowIndex].Cells[0].Value.ToString();
            quyen.TenQuyen = dataGridQuyen.Rows[e.RowIndex].Cells[1].Value.ToString();

            quyen.XuatNhapLieu(ref txtMaQuyen, ref txtTenQuyen);
        }
        private void LamMoi()
        {
            dataGridQuyen.DataSource = Data.Query.LayDuLieu("QUYEN");
            dataGridQuyen.Update();
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
            if(btnSua.Visible == false)
            {
                Object.Quyen quyen = new Object.Quyen();
                quyen.MaQuyen = txtMaQuyen.Text;
                quyen.TenQuyen = txtTenQuyen.Text;
                quyen.ThemData();
            }

            if (btnThem.Visible == false)
            {
                Object.Quyen quyen = new Object.Quyen();
                quyen.MaQuyen = txtMaQuyen.Text;
                quyen.TenQuyen = txtTenQuyen.Text;
                quyen.SuaData();
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
                Object.Quyen quyen = new Object.Quyen();
                quyen.MaQuyen = txtMaQuyen.Text;
                quyen.XoaData();
                LamMoi();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}
