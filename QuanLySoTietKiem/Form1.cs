using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLySoTietKiem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

           

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "fgdf";
            textBox1.Text = "Getting Connection ...";
            textBox1.Text = Data.ReadInfoData.StringData();
            SqlConnection conn = Data.DataUtis.GetDBConnection();

            try
            {
                textBox1.Text = "Openning Connection ...";

                conn.Open();

                textBox1.Text = "Connection successful!";
            }
            catch (Exception x)
            {
                textBox1.Text = "Error: " + x.Message;
            }
        }
    }
}
