using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Mobile_Shoppee_Management_System.Forms;
using System.Data.SqlClient;

namespace Mobile_Shoppee_Management_System
{
    public partial class frm_Login : Form
    {
         Common_Class obj = new Common_Class();
         public SqlDataReader dr;

        public frm_Login()
        {
            InitializeComponent();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            tb_Username.Focus();

        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {           
            
            if (tb_Username.Text != "" && tb_Password.Text != "")
            {

                obj.openconnection();
                SqlCommand cmd = new SqlCommand("select *  From Login Where Username = '" + this.tb_Username.Text + "' And Password = '" + this.tb_Password.Text + "' ", obj.con);
                //cmd.ExecuteScalar();
                //int i = Convert.ToInt32(cmd.ExecuteScalar());
                dr = cmd.ExecuteReader();
               if (dr.Read())
               {
                   dr.Close();
                   MessageBox.Show("Login Successfull...");
                   this.Hide();
                   MDI_Main_Menu obj1 = new MDI_Main_Menu();
                   obj1.Show();
                  
               }
               else
               {
                   MessageBox.Show("Login Filed..");
                   tb_Username.Text = "";
                   tb_Password.Text = "";
                   tb_Username.Focus();
                   tb_Password.Enabled = false;
                   btnLogin.Enabled = false;
               }
               dr.Close();
               cmd.Dispose();
               obj.closeconnection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
