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

    public partial class frm_Bill_History_by_Product : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Mobile_Shoppee_DB;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public int tempid;

        public frm_Bill_History_by_Product()
        {
            InitializeComponent();
        }

        private void frm_Bill_History_by_Product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mobile_Shoppee_DBDataSet.Customer_Purchase_Detail' table. You can move, or remove it, as needed.
            this.customer_Purchase_DetailTableAdapter.Fill(this.mobile_Shoppee_DBDataSet.Customer_Purchase_Detail);
            // TODO: This line of code loads data into the 'mobile_Shoppee_DBDataSet.Customer_Master' table. You can move, or remove it, as needed.
            this.customer_MasterTableAdapter.Fill(this.mobile_Shoppee_DBDataSet.Customer_Master);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.customer_MasterTableAdapter.FillBy(this.mobile_Shoppee_DBDataSet.Customer_Master);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {

                if (tb_search.Text != "") //when user come through new invice
                {
                    if (tb_categ.Text == "Name")
                    {
                        con.Open();

                        SqlDataReader dr;

                        DataTable dt = new DataTable();

                        cmd = new SqlCommand();
                        cmd.Connection = con;

                        cmd = new SqlCommand("select * from Customer_Master where Name = '" + tb_search.Text + "' ", con);
                        dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            tempid = (int)dr["Customer_ID"];

                        }
                        dr.Close();

                        cmd = new SqlCommand("select * from Customer_Master where Name = '" + tb_search.Text + "' ", con);
                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        adp.Fill(dt);

                        // obj.cmd.Dispose();hold

                        DataTable dt1 = new DataTable();
                        cmd = new SqlCommand("select * from Customer_Purchase_Detail where Customer_ID = " + tempid + " ", con);
                        adp = new SqlDataAdapter(cmd);
                        adp.Fill(dt1);

                        dgv_cust_master.DataSource = dt;
                        dgv_custmer_details.DataSource = dt1;
                        con.Close();
                        cmd.Dispose();
                    }
                    else if (tb_categ.Text == "Mobile_No")
                    {
                        con.Open();

                        SqlDataReader dr;

                        DataTable dt = new DataTable();

                        cmd = new SqlCommand();
                        cmd.Connection = con;

                        cmd = new SqlCommand("select * from Customer_Master where Mobile_No = " + tb_search.Text + " ", con);
                        dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            tempid = (int)dr["Customer_ID"];

                        }
                        dr.Close();

                        cmd = new SqlCommand("select * from Customer_Master where Mobile_No = " + tb_search.Text + " ", con);
                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        adp.Fill(dt);

                        // obj.cmd.Dispose();hold

                        DataTable dt1 = new DataTable();
                        cmd = new SqlCommand("select * from Customer_Purchase_Detail where Customer_ID = " + tempid + " ", con);
                        adp = new SqlDataAdapter(cmd);
                        adp.Fill(dt1);

                        dgv_cust_master.DataSource = dt;
                        dgv_custmer_details.DataSource = dt1;
                        con.Close();
                        cmd.Dispose();
                    }

                }
                else
                {
                    MessageBox.Show("Please fill the All Fields...");
                }
                



            }
            catch (Exception ex)
            {
                //  Block of code to handle errors
                MessageBox.Show(ex.Message);
            }
        }

        private void tb_categ_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_search.Enabled = true;
            btn_Search.Enabled = true;
        }

        private void dgv_cust_master_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
                
        }

     

        private void dgv_cust_master_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void btn_delete_row_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you want to delete these entry...?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    //...
                    SqlDataReader dr;
                    Common_Class obj = new Common_Class();
                    obj.openconnection();


                    int i;
                    i = dgv_cust_master.SelectedCells[0].RowIndex;

                        obj.cmd = new SqlCommand("Select * from Customer_Master where Customer_ID = " + dgv_cust_master.SelectedRows[i].Cells[0].Value.ToString() + " ", obj.con);

                        dr = obj.cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            tempid = (int)dr["Customer_ID"];
                            dr.Close();
                        }
                        obj.cmd = new SqlCommand("Delete from Customer_Purchase_Detail where Customer_ID = " + tempid + " ", obj.con);
                        obj.cmd.ExecuteNonQuery();

                        obj.cmd = new SqlCommand("Delete from Customer_Master where Customer_ID = " + tempid + " ", obj.con);
                        if (obj.cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Row Deleted");
                            // TODO: This line of code loads data into the 'mobile_Shoppee_DBDataSet.Customer_Purchase_Detail' table. You can move, or remove it, as needed.
                            this.customer_Purchase_DetailTableAdapter.Fill(this.mobile_Shoppee_DBDataSet.Customer_Purchase_Detail);
                            // TODO: This line of code loads data into the 'mobile_Shoppee_DBDataSet.Customer_Master' table. You can move, or remove it, as needed.
                            this.customer_MasterTableAdapter.Fill(this.mobile_Shoppee_DBDataSet.Customer_Master);
                        }
                        else
                        {
                            MessageBox.Show("Record Are Not Deleted");
                        }
                        obj.closeconnection();
                        obj.cmd.Dispose();
                        dr.Close();
                    }

            }
            catch (Exception ex)
            {
                //  Block of code to handle errors
                MessageBox.Show(ex.Message);
            }

        }
     

    }
}
