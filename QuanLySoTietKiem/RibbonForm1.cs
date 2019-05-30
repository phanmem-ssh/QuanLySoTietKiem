using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using TabControl = System.Windows.Forms.TabControl;

namespace QuanLySoTietKiem
{
    public partial class RibbonForm1 : DevComponents.DotNetBar.RibbonForm
    {
        public RibbonForm1()
        {
            InitializeComponent();
           
        }
        
        private void addNewTab(string strTabName, string strName, UserControl ucContent)
        {
            foreach (TabItem tabPage in tabContent.Tabs)
                if (tabPage.Text == strTabName)
                {
                    tabContent.SelectedTab = tabPage;
                    return;
                }
            
            TabControlPanel newTabPanel = new DevComponents.DotNetBar.TabControlPanel();
            TabItem newTabPage = new TabItem(this.components);
            newTabPage.ImageIndex = 0;
            newTabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            newTabPanel.Location = new System.Drawing.Point(0, 26);
            newTabPanel.Name = "panel" + strTabName;
            newTabPanel.Padding = new System.Windows.Forms.Padding(1);
            newTabPanel.Size = new System.Drawing.Size(1230, 384);
            newTabPanel.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(000)))), ((int)(((byte)(231)))));
            newTabPanel.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            newTabPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            newTabPanel.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            newTabPanel.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            newTabPanel.Style.GradientAngle = 90;
            newTabPanel.TabIndex = 4;
            newTabPanel.TabItem = newTabPage;
            Random ran = new Random();
            newTabPage.Name = strName+ran.Next(100000) + ran.Next(22342); ;
            newTabPage.AttachedControl = newTabPanel;
            newTabPage.Text = strTabName;
            ucContent.Dock = DockStyle.Fill;
            newTabPanel.Controls.Add(ucContent);
            tabContent.Controls.Add(newTabPanel);
            tabContent.Tabs.Add(newTabPage);
            tabContent.SelectedTab = newTabPage;
        }
    
        private void buttonItem15_Click(object sender, EventArgs e)
        {
          
            //TAB1
        }
        private void btnRtien_Click(object sender, EventArgs e)
        {
         //TAB2
        }

        private void btnKhhang_Click(object sender, EventArgs e)
        {
            //TAB3
            UCKhachHang UCKHang = new UCKhachHang();
            addNewTab("Khách hàng","tab4",UCKHang);
        }

        private void btnPhGdich_Click(object sender, EventArgs e)
        {
            //TAB4
            UCPhongGiaoDich uCPhongGiaoDich = new UCPhongGiaoDich();
            addNewTab("Phòng giao dịch", "tab5", uCPhongGiaoDich);
        }

        private void btnQGdich_Click(object sender, EventArgs e)
        {
            //TAB5
            
       
        }

        private void btnNVien_Click(object sender, EventArgs e)
        {
            //TAB6
            UCNhanVien UCNV = new UCNhanVien();
            addNewTab("Nhân viên", "tab6", UCNV);
         
        }

        private void btnGDVien_Click(object sender, EventArgs e)
        {
            //TAB7
      
        }

        private void btnNhomNGDung_Click(object sender, EventArgs e)
        {
            //TAB8
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            //TAB9
        }

        private void btnPNhom_Click(object sender, EventArgs e)
        {
           //TAB10
        }

        private void btnPQuyen_Click(object sender, EventArgs e)
        {
           //TAB11
        }

        private void btnPSTKiem_Click(object sender, EventArgs e)
        {
         //TAB12

        }
        private void btnSDTKiem_Click(object sender, EventArgs e)
        {
          //TAB13

        }
        private void btnGtien_Click(object sender, EventArgs e)
        {
           //TAB14

        }
        private void btnLTKiem_Click(object sender, EventArgs e)
        {
        //TAB15

        }
        private void tabContent_TabItemClose(object sender, TabStripActionEventArgs e)
        {
            TabItem tab = tabContent.SelectedTab;
            tabContent.Tabs.Remove(tab);    
            
        }

        private void ribbonTabItem3_Click(object sender, EventArgs e)
        {

        }

        private void RibbonForm1_Load(object sender, EventArgs e)
        {

        }
    }
}