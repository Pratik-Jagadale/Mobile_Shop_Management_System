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
    public partial class frm_Bill_History_by_Cust_Name : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Mobile_Shoppee_DB;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        int tempid;
        Common_Class obj = new Common_Class();
        

        public frm_Bill_History_by_Cust_Name()
        {
            InitializeComponent();
        }

        private void frm_Bill_History_by_Cust_Name_Load(object sender, EventArgs e)
        {
            try
            {

                int iFormLoad = obj.globalVal_FormLoad(1);
                if (iFormLoad == -1)
                {
                    goto nxt;
                }
                int temp;
                temp = obj.globalVal_Custid(1, 0);
                tb_search.Text = Convert.ToString(temp);


                if (tb_search.Text != "") //when user come through new invice
                {
                    lbl.Visible = false;
                    tb_Category.Visible = false;
                    btn_Search.Visible = false;
                    con.Open();

                    DataTable dt = new DataTable();
                    DataTable dt1 = new DataTable();

                    cmd.Connection = con;

                    cmd = new SqlCommand("select * from Customer_Master where Customer_ID = " + tb_search.Text + " ", con);
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(dt);

                    // obj.cmd.Dispose();



                    cmd = new SqlCommand("select * from Customer_Purchase_Detail where Customer_ID = " + tb_search.Text + " ", con);
                    adp = new SqlDataAdapter(cmd);
                    adp.Fill(dt1);


                    Report.rpt_1 rpt = new Report.rpt_1();
                    rpt.Database.Tables["Customer_Master"].SetDataSource(dt);
                    rpt.Database.Tables["Customer_Purchase_Detail"].SetDataSource(dt1);
                    crv_bill_history_Cust.ReportSource = null;
                    crv_bill_history_Cust.ReportSource = rpt;

                    obj.cmd.Dispose();
                }
                else
                {
                    MessageBox.Show("Please fill the All Fields...");
                }

            nxt: ;
           // this.crv_bill_history_Cust.RefreshReport();
            }
            catch (Exception ex)
            {
                //  Block of code to handle errors
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {

                if (tb_Category.Text != "" && tb_search.Text != "")
                {

                    if (tb_Category.Text == "Name")
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


                        Report.rpt_1 rpt = new Report.rpt_1();
                        rpt.Database.Tables["Customer_Master"].SetDataSource(dt);
                        rpt.Database.Tables["Customer_Purchase_Detail"].SetDataSource(dt1);
                        crv_bill_history_Cust.ReportSource = null;
                        crv_bill_history_Cust.ReportSource = rpt;

                        obj.cmd.Dispose();
                        adp.Dispose();

                    }

                }
                if (tb_Category.Text == "Mobile_No")
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

                    Report.rpt_1 rpt = new Report.rpt_1();
                    rpt.Database.Tables["Customer_Master"].SetDataSource(dt);
                    rpt.Database.Tables["Customer_Purchase_Detail"].SetDataSource(dt1);
                    crv_bill_history_Cust.ReportSource = null;
                    crv_bill_history_Cust.ReportSource = rpt;

                    obj.cmd.Dispose();
                    adp.Dispose();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                //  Block of code to handle errors
                MessageBox.Show(ex.Message);
            }
        }

        private void tb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_search.Enabled = true;
            btn_Search.Enabled = true;
        }
    }
}
