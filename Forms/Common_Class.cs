using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace Mobile_Shoppee_Management_System.Forms
{
    class Common_Class
    {
        public static int FormLoadBillHistory;
        public static int temp;
        static string path = Path.GetFullPath(Environment.CurrentDirectory);
        public static string databasename = "Mobile_Shoppee_DB.mdf";
        string connectionstring = (@"Data Source=(localdb)\v11.0;AttachDbFilename=" + path + @"\" + databasename + ";Integrated Security = true");
        public SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;AttachDbFilename=" + path + @"\" + databasename + ";Integrated Security = true");

        //string connectionstring = (@"Data Source=.\SQLEXPRESS;Initial Catalog=Mobile_Shoppee_DB;Integrated Security=True");
        //public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();


        public void openconnection()
        {
            if (con.State != ConnectionState.Open)
            {
                con = new SqlConnection(connectionstring);
                con.Open();
            }
           // con.Open();
        }
        public void closeconnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        public int globalVal_FormLoad(int get)
        {

            if (get == 0)
            {
                FormLoadBillHistory = 1;
                return 0;
            }
            if (FormLoadBillHistory == 1)
            {
                return -1;
            }
            return 0;
        }
        public int globalVal_Custid(int get ,int Cust_id)
        {

            if(get == 0)
            {
                temp = Cust_id;
                return 0;
            }
            else if (get == 1)
            {
                Cust_id = temp;
            }
            return temp;
        }


        public int Auto_Increment(string get_current_id, int start_no)
        {
            openconnection();
            int cnt = 0;
            SqlCommand cmd = new SqlCommand(get_current_id, con);
            cnt = (int)(cmd.ExecuteScalar());
            cnt = cnt + start_no;
            cmd.Dispose();
            closeconnection();
            return cnt;
        }
        //public void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        //{
        //    foreach (Control ctrl in ctrlCollection)
        //    {
        //        if (ctrl is TextBoxBase)
        //        {
        //            ctrl.Text = String.Empty;
        //        }
        //        else
        //        {
        //            ClearTextBoxes(ctrl.Controls);
        //        }
        //    }
        //}
        public void ClearAllCombobox(Form form)
        {
            foreach (Control control in form.Controls)
            {

                if (control.GetType() == typeof(ComboBox))
                {

                    control.Text = "";
                }

            }
        }
        public void ClearTextBoxes(Form form)
        {
            foreach (Control control in form.Controls)
            {

                if (control.GetType() == typeof(TextBox))
                {

                    control.Text = "";

                }

            }
        }
        public void ClearTabControl(TabPage form)
        {
            foreach (Control control in form.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {

                    control.Text = "";
                }

            }
        }
        public void ClearGroupBox(GroupBox form)
        {
            foreach (Control control in form.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {

                    control.Text = "";
                }

            }
        }
        public void charlock(KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        public void numlock(KeyPressEventArgs e)
        {
            if ((e.KeyChar < 65 || e.KeyChar > 90) && e.KeyChar != 8 && (e.KeyChar < 97 || e.KeyChar > 122) && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }
        public void charforpoint(KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }
        public void datagridview(string sqlcmd, DataGridView dgv)
        {
            openconnection();
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgv.DataSource = dt;
            da.Dispose();
            closeconnection();
        }
    }
}
