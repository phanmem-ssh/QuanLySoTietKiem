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
    public partial class UCNhanVien : UserControl
    {
        public UCNhanVien()
        {
            InitializeComponent();

            DataTable dataPGD = Data.Query.LayDuLieu("PHONG_GIAO_DICH");
            DataTable dataNV = Data.Query.LayDuLieu("NHAN_VIEN");

            dataGridViewNhanVien.DataSource = dataNV;

            for (int i = 0; i < dataNV.Rows.Count; i++)
            {
                for (int j = 0; j < dataPGD.Rows.Count; j++)
                {
                    if(dataNV.Rows[i].ItemArray[5].Equals(dataPGD.Rows[j].ItemArray[0]))
                    {

                        dataGridViewNhanVien.Rows[i].Cells[5].Value = dataPGD.Rows[j].ItemArray[1].ToString();
                        break;
                    }
                        
                }
            }
            MessageBox.Show(dataPGD.Rows[0].ItemArray[0].ToString());

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }
    }
}
