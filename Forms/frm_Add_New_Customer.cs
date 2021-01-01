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
    public partial class frm_Add_New_Customer : Form
    {
        double both_GST_Amount, Total_Amount_Without_GST;
        Common_Class obj = new Common_Class();

        public frm_Add_New_Customer()
        {
            InitializeComponent();
        }

        public SqlDataReader dr { get; set; }

        private void frm_Add_New_Customer_Load(object sender, EventArgs e)
        {

            int i = 0;
            i = obj.Auto_Increment("select count(Customer_ID) from Customer_Master", 1);
            tb_Customer_ID.Text = Convert.ToString(i);
            tb_Customer_Name.Focus();
            
        }

        private void tb_Quantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_Quantity.Text != "")
                {
                   // double GST = 0;
                     double TPrice= 0;
                TPrice = double.Parse(tb_Price.Text) * double.Parse(tb_Quantity.Text);    
                    //gst = (TPrice*18/100);
                   // TPrice = TPrice + GST;
                    tb_Total_Price.Text = Convert.ToString(TPrice);
                }
                btn_Add.Enabled = true;
                }
                catch (Exception ex)
                {
                    //  Block of code to handle errors
                    MessageBox.Show(ex.Message);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_Quantity.Text != "" && tb_Price.Text != "")
                {
                    dgv_new_bill.Rows.Add(tb_Customer_ID.Text, cb_Brand_Name.Text, cb_Model_Name.Text, tb_Description.Text, tb_Unit_price_without_gst.Text, tb_SGST.Text, tb_S_GST_Amount.Text, tb_CGST.Text, tb_C_GST_Amount.Text, tb_Quantity.Text, tb_Total_Price.Text);

                    double Total = double.Parse(tb_Bill.Text) + double.Parse(tb_Total_Price.Text);
                    tb_Bill.Text = Convert.ToString(Total);
             
                    goto nxt;
                }
                else
                {
                    MessageBox.Show("Please First Fill All Fields...");
                }
                nxt: ;

                tb_Total_Bill.Text = Convert.ToString(tb_Bill.Text);
                cb_Brand_Name.Text = "";
                cb_Model_Name.Text  = "";
                tb_Price.Text = "";
                tb_Quantity.Text = "";
                tb_Unit_price_without_gst.Text = "";
                tb_Total_Price.Text = "";
                tb_S_GST_Amount.Text = "";
                tb_C_GST_Amount.Text = "";
         
                btn_Save.Enabled = true;
            }
            catch (Exception ex)
            {
                //  Block of code to handle errors
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_Total_Bill.Text != "")
                {
                    obj.openconnection();
                    obj.globalVal_Custid (0,int.Parse(tb_Customer_ID.Text));
                    obj.cmd = new SqlCommand(" insert into Customer_Master values (" + tb_Customer_ID.Text + " , '" + tb_Customer_Name.Text + "' , '" + dtp_Bill_Date.Text + "' , " + tb_Customer_Mob_No.Text + ",'" + tb_Cust_GSTIN.Text + "' , " + tb_Bill.Text + " , " + tb_Discount.Text + " , " + tb_Total_Bill.Text + " )", obj.con);

                    if (obj.cmd.ExecuteNonQuery() > 0)
                    {
                     
                        goto nxtquery ;
                    }
                    else
                    {
                        MessageBox.Show("Record are Not saved Successfully");
                    }
                nxtquery: ;
                    obj.cmd.Dispose();

                    int i = 0;
                    foreach (DataGridViewRow row in dgv_new_bill.Rows)
                    {
                        if(i == (dgv_new_bill.Rows.Count - 1))
                        {
                            goto nxt;
                        }
                        //  int Mob_id = 0;
                        obj.cmd = new SqlCommand(" Insert into Customer_Purchase_Detail values(" + dgv_new_bill.Rows[i].Cells[0].Value + ",'" + dgv_new_bill.Rows[i].Cells[1].Value + "','" + dgv_new_bill.Rows[i].Cells[2].Value + "','" + dgv_new_bill.Rows[i].Cells[3].Value + "'," + dgv_new_bill.Rows[i].Cells[4].Value + "," + dgv_new_bill.Rows[i].Cells[5].Value + "," + dgv_new_bill.Rows[i].Cells[6].Value + " ," + dgv_new_bill.Rows[i].Cells[7].Value + "," + dgv_new_bill.Rows[i].Cells[8].Value + "," + dgv_new_bill.Rows[i].Cells[9].Value + "," + dgv_new_bill.Rows[i].Cells[10].Value + " )", obj.con);
                        obj.cmd.ExecuteNonQuery();
                        obj.cmd.Dispose();

                        i = i + 1;
                    
                    }
                nxt: ;

                        if (i > 0)
                        {
                            //obj.globalVal_Custid(0,int.Parse(tb_Customer_ID.Text));

                            MessageBox.Show("Record Added Successfully...");

                            frm_Bill_History_by_Cust_Name obj1 = new frm_Bill_History_by_Cust_Name();
                            obj1.Show();
                        }
                        else
                        {
                            MessageBox.Show("Server Error..");
                        }

                        tb_Customer_Name.Text = "";
                        tb_Customer_Mob_No.Text = "";
                        tb_Bill.Text = "";
                        tb_Discount.Text = "0";
                        tb_Price.Text = "";
                        tb_Quantity.Text = "";
                        tb_Total_Bill.Text = "";
                        tb_Customer_Mob_No.Text = "";
                        cb_Brand_Name.Text = "";
                        cb_Model_Name.Text = "";
                        tb_Total_Price.Text = "";
                        dgv_new_bill.DataSource = "";

                        int f = 0;
                        f = obj.Auto_Increment("select count(Customer_ID) from Customer_Master", 1);
                        tb_Customer_ID.Text = Convert.ToString(f);
                    }
                else
                {
                    MessageBox.Show("Please fill all fields");
                }
            }
            catch (Exception ex)
            {
                //  Block of code to handle errors
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            tb_Customer_Name.Text = "";
            tb_Customer_Mob_No.Text = "";
            tb_Bill.Text = "";
            tb_Discount.Text = "0";
            tb_Price.Text = "";
            tb_Quantity.Text = "";
            tb_Total_Bill.Text = "";
            cb_Brand_Name.Text = "";
            cb_Model_Name.Text = "";
            tb_Total_Price.Text = "";
            dgv_new_bill.DataSource = "";
        }

        private void tb_Discount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                    if (tb_Discount.Text != "" && tb_Bill.Text != "")
                    {
                        double dcnt;
                        dcnt = (double.Parse(tb_Discount.Text) * double.Parse(tb_Bill.Text)) / 100;
                        dcnt = double.Parse(tb_Bill.Text) - dcnt;
                        tb_Total_Bill.Text = Convert.ToString(dcnt);
                        return;
                    }
                    else if (tb_Discount.Text == "")
                    {
                        tb_Total_Bill.Text = Convert.ToString(tb_Bill.Text);
                        tb_Discount.Text = "0";
                    }
            }
            catch (Exception ex)
            {
                //  Block of code to handle errors
                MessageBox.Show(ex.Message);
            }
        }

        private void tb_Price_TextChanged(object sender, EventArgs e)
        {
            try
            {

                    if (tb_Price.Text != "")
                    {
                    Total_Amount_Without_GST = double.Parse(tb_Price.Text);
                    double temp = Total_Amount_Without_GST;
                    Total_Amount_Without_GST = (Total_Amount_Without_GST * 100) / 118;

                    both_GST_Amount = (temp - Total_Amount_Without_GST )/2;

                    tb_S_GST_Amount.Text = Convert.ToString(both_GST_Amount);
                    tb_C_GST_Amount.Text = Convert.ToString(both_GST_Amount);
                    tb_Unit_price_without_gst.Text = Convert.ToString(Total_Amount_Without_GST);
                    }
            }
            catch (Exception ex)
            {
                //  Block of code to handle errors
                MessageBox.Show(ex.Message);
            }
        }

        private void tb_Customer_Mob_No_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            obj.charlock(e);
        }

        private void tb_Customer_Name_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            obj.numlock(e);
        }

        private void tb_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.charlock(e);
        }

        private void tb_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.charlock(e);
        }

        private void tb_Discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.charlock(e);
        }

        private void tb_Customer_ID_Leave(object sender, EventArgs e)
        {
            try
            {
                obj.openconnection();
                obj.cmd = new SqlCommand("select * from Customer_Master where Customer_ID = " + tb_Customer_ID.Text + " ", obj.con);
                dr = obj.cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Customer ID is Alredy Exist please enter another cutsomer id...");
                    tb_Customer_ID.Focus();
                }
                obj.cmd.Dispose();
                obj.closeconnection();

            }
            catch (Exception ex)
            {
                //  Block of code to handle errors
                MessageBox.Show(ex.Message);
            }

        }

       

     }
}
