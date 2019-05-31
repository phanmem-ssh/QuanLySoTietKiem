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
            DataTable dataPN = Data.Query.LayDuLieu("PHAN_NHOM");
            DataTable dataNV = Data.Query.LayDuLieu("NHAN_VIEN");
            dataGridPhanNhom.DataSource = dataPN;
   
            for (int i=0;i< dataPN.Rows.Count;i++)
            {
                dataGridPhanNhom.Rows[i].Cells[0].Value = 
                    Data.Query.TenTraVe(dataPN.Rows[i].ItemArray[0].ToString(), "MaNV", "PHAN_NHOM", "NHAN_VIEN", "HoTen");
                dataGridPhanNhom.Rows[i].Cells[1].Value =
                    Data.Query.TenTraVe(dataPN.Rows[i].ItemArray[1].ToString(), "MaNhomNguoiDung", "PHAN_NHOM", "NHOM_NGUOI_DUNG", "TenNhomNguoiDung");

            }

        }
    }
}
