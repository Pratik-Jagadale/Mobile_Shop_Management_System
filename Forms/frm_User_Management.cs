using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mobile_Shoppee_Management_System.Forms
{
    public partial class frm_User_Management : Form
    {
        public SqlDataReader dr;
        Common_Class obj = new Common_Class();
        public frm_User_Management()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (tb_Password.Text == tb_C_Password.Text)
            {
                obj.openconnection();
                obj.cmd = new SqlCommand("insert into Login Values ( '" + tb_Username.Text + "' , '" + tb_Password.Text + "' ) ", obj.con);

                if (Convert.ToInt32(obj.cmd.ExecuteNonQuery()) > 0)
                {
                    MessageBox.Show("User Added Succefully...");
                    obj.cmd.Dispose();
                    obj.closeconnection();
                    obj.ClearTextBoxes(this);
                }
                else
                {
                    MessageBox.Show("ReEnter Correct Password...");
                }
            }
        }

        private void tb_C_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            obj.openconnection();
            SqlCommand cmd = new SqlCommand("select *  From Login Where Username = '" + this.tb_Username_CP.Text + "' And Password = '" + this.tb_Current_Password.Text + "' ", obj.con);

            dr = cmd.ExecuteReader();
            cmd.Dispose();
            if (dr.Read())
            {
                if (tb_Current_Password.Text != tb_New_Password.Text)
                {
                    obj.openconnection();
                    obj.cmd = new SqlCommand("Update Login set Password = '" + tb_New_Password.Text + "' where Username ='" + tb_Username_CP.Text + "' ", obj.con);

                    if (Convert.ToInt32(obj.cmd.ExecuteNonQuery()) > 0)
                    {
                        MessageBox.Show("Password Updated Succefully...");
                        tb_Username_CP.Text = "";
                        tb_Username_CP.Focus();
                        tb_Current_Password.Text = "";
                        tb_New_Password.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Password Updating Failed ...");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Diffrent Password");
                }
            }
            else
            {
                MessageBox.Show("Enter Valid User Name or Password");
            }
            obj.cmd.Dispose();
            obj.closeconnection();
            dr.Close();
        }

        private void tb_New_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Update.Enabled = true;
        }

        private void tb_D_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Delete_User.Enabled = true;
        }

        private void btn_Delete_User_Click(object sender, EventArgs e)
        {
            obj.openconnection();
            SqlCommand cmd = new SqlCommand("select *  From Login Where Username = '" + this.tb_D_Username.Text + "' And Password = '" + this.tb_D_Password.Text + "' ", obj.con);

            dr = cmd.ExecuteReader();
            cmd.Dispose();
            if (dr.Read())
            {
                dr.Close();
                obj.cmd = new SqlCommand("Delete from Login where Username = '" + tb_D_Username.Text + "' and Password = " + tb_D_Password.Text + "", obj.con);
                if (obj.cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Record Deleted Successfully");
                    tb_D_Username.Text = "";
                    tb_D_Password.Text = "";
                    tb_D_Username.Focus();
                }
                else
                {
                    MessageBox.Show("Record Are Not Deleted");
                }
            }
            obj.cmd.Dispose();
            dr.Close();
            obj.closeconnection();
        }
    }
}
