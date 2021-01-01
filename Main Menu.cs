using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Mobile_Shoppee_Management_System.Forms;

namespace Mobile_Shoppee_Management_System
{
    public partial class MDI_Main_Menu : Form
    {
        Common_Class obj1 = new Common_Class();
        public MDI_Main_Menu()
        {
            InitializeComponent();
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frm_Add_New_Customer obj = new frm_Add_New_Customer();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_User_Management obj = new frm_User_Management();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void customerMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchBillByMobileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Bill_History_by_Product obj = new frm_Bill_History_by_Product();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void searchBillByCustomerNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obj1.globalVal_FormLoad(0);
            frm_Bill_History_by_Cust_Name obj = new frm_Bill_History_by_Cust_Name();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void MDI_Main_Menu_Load(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

    }
}
