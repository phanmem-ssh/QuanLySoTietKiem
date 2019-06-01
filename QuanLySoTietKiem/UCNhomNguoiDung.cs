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

            dataGridNhomNguoiDung.DataSource = Data.Query.LayDuLieu("NHOM_NGUOI_DUNG");
        }

        private void Button7_Click(object sender, EventArgs e)
        {

        }

        private void DataGridNhomNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Object.NhomNguoiDung nND = new Object.NhomNguoiDung();
            nND.MaNhomNguoiDung = dataGridNhomNguoiDung.Rows[e.RowIndex].Cells[0].Value.ToString();
            nND.TenNhomNguoiDung = dataGridNhomNguoiDung.Rows[e.RowIndex].Cells[1].Value.ToString();
            nND.XuatNhapLieu(ref txtMaNhom,ref txtTenNhomNguoiDung);
        }
    }
}
