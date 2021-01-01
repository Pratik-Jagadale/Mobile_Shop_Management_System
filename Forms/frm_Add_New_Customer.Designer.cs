namespace Mobile_Shoppee_Management_System.Forms
{
    partial class frm_Add_New_Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox9 = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.btn_Calculate_Total = new System.Windows.Forms.Button();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.tb_Bill = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.tb_Discount = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_Customer_ID = new System.Windows.Forms.TextBox();
            this.tb_Customer_Mob_No = new System.Windows.Forms.TextBox();
            this.dtp_Bill_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Cust_GSTIN = new System.Windows.Forms.TextBox();
            this.tb_Customer_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Total_Bill = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.tb_Total_Price = new System.Windows.Forms.TextBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.Label9 = new System.Windows.Forms.Label();
            this.tb_SGST = new System.Windows.Forms.TextBox();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_C_GST_Amount = new System.Windows.Forms.TextBox();
            this.tb_S_GST_Amount = new System.Windows.Forms.TextBox();
            this.tb_Unit_price_without_gst = new System.Windows.Forms.TextBox();
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.cb_Model_Name = new System.Windows.Forms.TextBox();
            this.cb_Brand_Name = new System.Windows.Forms.TextBox();
            this.dgv_new_bill = new System.Windows.Forms.DataGridView();
            this.Customer_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_GST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_GST_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_GST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_GST_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_CGST = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_new_bill)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox9
            // 
            this.TextBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox9.Location = new System.Drawing.Point(1369, 705);
            this.TextBox9.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox9.Name = "TextBox9";
            this.TextBox9.Size = new System.Drawing.Size(328, 30);
            this.TextBox9.TabIndex = 57;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(965, 463);
            this.Label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(38, 31);
            this.Label16.TabIndex = 104;
            this.Label16.Text = "%";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(676, 464);
            this.Label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(106, 29);
            this.Label14.TabIndex = 101;
            this.Label14.Text = "Discount";
            // 
            // btn_Calculate_Total
            // 
            this.btn_Calculate_Total.Enabled = false;
            this.btn_Calculate_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_Calculate_Total.ForeColor = System.Drawing.Color.SlateBlue;
            this.btn_Calculate_Total.Location = new System.Drawing.Point(27, 456);
            this.btn_Calculate_Total.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Calculate_Total.Name = "btn_Calculate_Total";
            this.btn_Calculate_Total.Size = new System.Drawing.Size(256, 43);
            this.btn_Calculate_Total.TabIndex = 12;
            this.btn_Calculate_Total.Text = "Calculate Total =>";
            this.btn_Calculate_Total.UseVisualStyleBackColor = true;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(1077, 706);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(80, 29);
            this.Label11.TabIndex = 69;
            this.Label11.Text = "Salary";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(947, 138);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(137, 29);
            this.Label4.TabIndex = 67;
            this.Label4.Text = "Mobile No :";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(968, 71);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(115, 29);
            this.Label2.TabIndex = 65;
            this.Label2.Text = "Bill Date :";
            // 
            // tb_Bill
            // 
            this.tb_Bill.Enabled = false;
            this.tb_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Bill.Location = new System.Drawing.Point(408, 463);
            this.tb_Bill.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Bill.MaxLength = 10;
            this.tb_Bill.Name = "tb_Bill";
            this.tb_Bill.Size = new System.Drawing.Size(213, 30);
            this.tb_Bill.TabIndex = 131;
            this.tb_Bill.Text = "0";
            this.tb_Bill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(300, 464);
            this.Label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(47, 29);
            this.Label15.TabIndex = 103;
            this.Label15.Text = "Bill";
            // 
            // tb_Discount
            // 
            this.tb_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Discount.Location = new System.Drawing.Point(842, 463);
            this.tb_Discount.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Discount.MaxLength = 3;
            this.tb_Discount.Name = "tb_Discount";
            this.tb_Discount.Size = new System.Drawing.Size(121, 30);
            this.tb_Discount.TabIndex = 10;
            this.tb_Discount.Text = "0";
            this.tb_Discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Discount.TextChanged += new System.EventHandler(this.tb_Discount_TextChanged);
            this.tb_Discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Discount_KeyPress);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.tb_Customer_ID);
            this.GroupBox1.Controls.Add(this.tb_Customer_Mob_No);
            this.GroupBox1.Controls.Add(this.dtp_Bill_Date);
            this.GroupBox1.Controls.Add(this.tb_Cust_GSTIN);
            this.GroupBox1.Controls.Add(this.tb_Customer_Name);
            this.GroupBox1.Controls.Add(this.TextBox9);
            this.GroupBox1.Controls.Add(this.Label11);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(60, 125);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(1760, 183);
            this.GroupBox1.TabIndex = 41;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Customer Details";
            // 
            // tb_Customer_ID
            // 
            this.tb_Customer_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_ID.Location = new System.Drawing.Point(444, 17);
            this.tb_Customer_ID.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Customer_ID.MaxLength = 51;
            this.tb_Customer_ID.Name = "tb_Customer_ID";
            this.tb_Customer_ID.Size = new System.Drawing.Size(122, 30);
            this.tb_Customer_ID.TabIndex = 216;
            this.tb_Customer_ID.Leave += new System.EventHandler(this.tb_Customer_ID_Leave);
            // 
            // tb_Customer_Mob_No
            // 
            this.tb_Customer_Mob_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_Mob_No.Location = new System.Drawing.Point(1183, 137);
            this.tb_Customer_Mob_No.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Customer_Mob_No.MaxLength = 10;
            this.tb_Customer_Mob_No.Name = "tb_Customer_Mob_No";
            this.tb_Customer_Mob_No.Size = new System.Drawing.Size(359, 30);
            this.tb_Customer_Mob_No.TabIndex = 215;
            this.tb_Customer_Mob_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Customer_Mob_No_KeyPress_1);
            // 
            // dtp_Bill_Date
            // 
            this.dtp_Bill_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtp_Bill_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Bill_Date.Location = new System.Drawing.Point(1182, 70);
            this.dtp_Bill_Date.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_Bill_Date.Name = "dtp_Bill_Date";
            this.dtp_Bill_Date.Size = new System.Drawing.Size(359, 30);
            this.dtp_Bill_Date.TabIndex = 214;
            // 
            // tb_Cust_GSTIN
            // 
            this.tb_Cust_GSTIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Cust_GSTIN.Location = new System.Drawing.Point(442, 137);
            this.tb_Cust_GSTIN.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Cust_GSTIN.MaxLength = 50;
            this.tb_Cust_GSTIN.Name = "tb_Cust_GSTIN";
            this.tb_Cust_GSTIN.Size = new System.Drawing.Size(359, 30);
            this.tb_Cust_GSTIN.TabIndex = 213;
            // 
            // tb_Customer_Name
            // 
            this.tb_Customer_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_Name.Location = new System.Drawing.Point(441, 70);
            this.tb_Customer_Name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Customer_Name.MaxLength = 50;
            this.tb_Customer_Name.Name = "tb_Customer_Name";
            this.tb_Customer_Name.Size = new System.Drawing.Size(359, 30);
            this.tb_Customer_Name.TabIndex = 212;
            this.tb_Customer_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Customer_Name_KeyPress_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 29);
            this.label3.TabIndex = 60;
            this.label3.Text = "Customer Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
            this.label1.TabIndex = 59;
            this.label1.Text = "Customer GSTIN :";
            // 
            // btn_Save
            // 
            this.btn_Save.Enabled = false;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Indigo;
            this.btn_Save.Location = new System.Drawing.Point(1177, 860);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(223, 70);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "Save &  Print";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Total_Bill
            // 
            this.tb_Total_Bill.Enabled = false;
            this.tb_Total_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Bill.ForeColor = System.Drawing.Color.Maroon;
            this.tb_Total_Bill.Location = new System.Drawing.Point(1369, 452);
            this.tb_Total_Bill.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Total_Bill.MaxLength = 10;
            this.tb_Total_Bill.Name = "tb_Total_Bill";
            this.tb_Total_Bill.Size = new System.Drawing.Size(232, 41);
            this.tb_Total_Bill.TabIndex = 151;
            this.tb_Total_Bill.Text = "0";
            this.tb_Total_Bill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.Color.Maroon;
            this.Label10.Location = new System.Drawing.Point(1081, 456);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(158, 39);
            this.Label10.TabIndex = 97;
            this.Label10.Text = "Total  Bill";
            // 
            // btn_Add
            // 
            this.btn_Add.Enabled = false;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_Add.ForeColor = System.Drawing.Color.Chocolate;
            this.btn_Add.Location = new System.Drawing.Point(1583, 43);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(139, 59);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(871, 27);
            this.Label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(85, 29);
            this.Label13.TabIndex = 93;
            this.Label13.Text = "S GST";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(633, 27);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(69, 29);
            this.Label8.TabIndex = 92;
            this.Label8.Text = "Price";
            // 
            // tb_Total_Price
            // 
            this.tb_Total_Price.Enabled = false;
            this.tb_Total_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Price.Location = new System.Drawing.Point(1315, 71);
            this.tb_Total_Price.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Total_Price.MaxLength = 10;
            this.tb_Total_Price.Name = "tb_Total_Price";
            this.tb_Total_Price.Size = new System.Drawing.Size(207, 34);
            this.tb_Total_Price.TabIndex = 101;
            this.tb_Total_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Palatino Linotype", 28.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_Title.Location = new System.Drawing.Point(822, 11);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(376, 65);
            this.lbl_Title.TabIndex = 33;
            this.lbl_Title.Text = "NEW INVOICE";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(39, 27);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(148, 29);
            this.Label6.TabIndex = 91;
            this.Label6.Text = "Brand Name";
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Quantity.Location = new System.Drawing.Point(1089, 71);
            this.tb_Quantity.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Quantity.MaxLength = 5;
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Size = new System.Drawing.Size(148, 30);
            this.tb_Quantity.TabIndex = 8;
            this.tb_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Quantity.TextChanged += new System.EventHandler(this.tb_Quantity_TextChanged);
            this.tb_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Quantity_KeyPress);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Indigo;
            this.btn_Refresh.Location = new System.Drawing.Point(689, 863);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(223, 70);
            this.btn_Refresh.TabIndex = 12;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(1103, 27);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(100, 29);
            this.Label9.TabIndex = 90;
            this.Label9.Text = "Quantity";
            // 
            // tb_SGST
            // 
            this.tb_SGST.Enabled = false;
            this.tb_SGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SGST.Location = new System.Drawing.Point(865, 71);
            this.tb_SGST.Margin = new System.Windows.Forms.Padding(4);
            this.tb_SGST.MaxLength = 3;
            this.tb_SGST.Name = "tb_SGST";
            this.tb_SGST.Size = new System.Drawing.Size(88, 30);
            this.tb_SGST.TabIndex = 81;
            this.tb_SGST.Text = "9";
            this.tb_SGST.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Price
            // 
            this.tb_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Price.Location = new System.Drawing.Point(623, 71);
            this.tb_Price.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Price.MaxLength = 10;
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(215, 30);
            this.tb_Price.TabIndex = 7;
            this.tb_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Price.TextChanged += new System.EventHandler(this.tb_Price_TextChanged);
            this.tb_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Price_KeyPress);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.label20);
            this.GroupBox2.Controls.Add(this.label19);
            this.GroupBox2.Controls.Add(this.label18);
            this.GroupBox2.Controls.Add(this.tb_C_GST_Amount);
            this.GroupBox2.Controls.Add(this.tb_S_GST_Amount);
            this.GroupBox2.Controls.Add(this.tb_Unit_price_without_gst);
            this.GroupBox2.Controls.Add(this.tb_Description);
            this.GroupBox2.Controls.Add(this.cb_Model_Name);
            this.GroupBox2.Controls.Add(this.cb_Brand_Name);
            this.GroupBox2.Controls.Add(this.dgv_new_bill);
            this.GroupBox2.Controls.Add(this.label17);
            this.GroupBox2.Controls.Add(this.tb_CGST);
            this.GroupBox2.Controls.Add(this.btn_Calculate_Total);
            this.GroupBox2.Controls.Add(this.Label16);
            this.GroupBox2.Controls.Add(this.tb_Bill);
            this.GroupBox2.Controls.Add(this.Label15);
            this.GroupBox2.Controls.Add(this.tb_Discount);
            this.GroupBox2.Controls.Add(this.Label14);
            this.GroupBox2.Controls.Add(this.tb_Total_Bill);
            this.GroupBox2.Controls.Add(this.Label10);
            this.GroupBox2.Controls.Add(this.btn_Add);
            this.GroupBox2.Controls.Add(this.Label13);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Controls.Add(this.tb_Total_Price);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Controls.Add(this.tb_Quantity);
            this.GroupBox2.Controls.Add(this.tb_SGST);
            this.GroupBox2.Controls.Add(this.Label9);
            this.GroupBox2.Controls.Add(this.tb_Price);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Controls.Add(this.Label12);
            this.GroupBox2.Controls.Add(this.TextBox3);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(60, 316);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Size = new System.Drawing.Size(1760, 520);
            this.GroupBox2.TabIndex = 42;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Purchase Details";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(977, 112);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(109, 18);
            this.label20.TabIndex = 116;
            this.label20.Text = "C GST Amount";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(852, 113);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(108, 18);
            this.label19.TabIndex = 115;
            this.label19.Text = "S GST Amount";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(624, 113);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(128, 18);
            this.label18.TabIndex = 114;
            this.label18.Text = "Price without GST";
            // 
            // tb_C_GST_Amount
            // 
            this.tb_C_GST_Amount.Enabled = false;
            this.tb_C_GST_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_C_GST_Amount.Location = new System.Drawing.Point(980, 134);
            this.tb_C_GST_Amount.Margin = new System.Windows.Forms.Padding(4);
            this.tb_C_GST_Amount.MaxLength = 5;
            this.tb_C_GST_Amount.Name = "tb_C_GST_Amount";
            this.tb_C_GST_Amount.Size = new System.Drawing.Size(88, 30);
            this.tb_C_GST_Amount.TabIndex = 113;
            this.tb_C_GST_Amount.Text = "9";
            // 
            // tb_S_GST_Amount
            // 
            this.tb_S_GST_Amount.Enabled = false;
            this.tb_S_GST_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_S_GST_Amount.Location = new System.Drawing.Point(865, 134);
            this.tb_S_GST_Amount.Margin = new System.Windows.Forms.Padding(4);
            this.tb_S_GST_Amount.MaxLength = 5;
            this.tb_S_GST_Amount.Name = "tb_S_GST_Amount";
            this.tb_S_GST_Amount.Size = new System.Drawing.Size(88, 30);
            this.tb_S_GST_Amount.TabIndex = 112;
            this.tb_S_GST_Amount.Text = "9";
            // 
            // tb_Unit_price_without_gst
            // 
            this.tb_Unit_price_without_gst.Enabled = false;
            this.tb_Unit_price_without_gst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Unit_price_without_gst.Location = new System.Drawing.Point(623, 134);
            this.tb_Unit_price_without_gst.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Unit_price_without_gst.MaxLength = 5;
            this.tb_Unit_price_without_gst.Name = "tb_Unit_price_without_gst";
            this.tb_Unit_price_without_gst.Size = new System.Drawing.Size(215, 30);
            this.tb_Unit_price_without_gst.TabIndex = 111;
            // 
            // tb_Description
            // 
            this.tb_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Description.Location = new System.Drawing.Point(72, 109);
            this.tb_Description.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Description.MaxLength = 50;
            this.tb_Description.Multiline = true;
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.Size = new System.Drawing.Size(482, 70);
            this.tb_Description.TabIndex = 6;
            this.tb_Description.Text = "IMEI No :";
            // 
            // cb_Model_Name
            // 
            this.cb_Model_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Model_Name.Location = new System.Drawing.Point(339, 71);
            this.cb_Model_Name.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Model_Name.MaxLength = 10;
            this.cb_Model_Name.Name = "cb_Model_Name";
            this.cb_Model_Name.Size = new System.Drawing.Size(215, 30);
            this.cb_Model_Name.TabIndex = 5;
            this.cb_Model_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_Brand_Name
            // 
            this.cb_Brand_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Brand_Name.Location = new System.Drawing.Point(81, 71);
            this.cb_Brand_Name.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Brand_Name.MaxLength = 10;
            this.cb_Brand_Name.Name = "cb_Brand_Name";
            this.cb_Brand_Name.Size = new System.Drawing.Size(215, 30);
            this.cb_Brand_Name.TabIndex = 4;
            this.cb_Brand_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgv_new_bill
            // 
            this.dgv_new_bill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_new_bill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_new_bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_new_bill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer_Id,
            this.Brand_Name,
            this.Model_Number,
            this.Description,
            this.Price,
            this.S_GST,
            this.S_GST_Amount,
            this.C_GST,
            this.C_GST_Amount,
            this.Quantity,
            this.Total_Price});
            this.dgv_new_bill.Location = new System.Drawing.Point(72, 186);
            this.dgv_new_bill.Name = "dgv_new_bill";
            this.dgv_new_bill.RowTemplate.Height = 24;
            this.dgv_new_bill.Size = new System.Drawing.Size(1650, 255);
            this.dgv_new_bill.TabIndex = 107;
            // 
            // Customer_Id
            // 
            this.Customer_Id.HeaderText = "Customer Id";
            this.Customer_Id.Name = "Customer_Id";
            this.Customer_Id.Visible = false;
            // 
            // Brand_Name
            // 
            this.Brand_Name.HeaderText = "Brand Name";
            this.Brand_Name.Name = "Brand_Name";
            // 
            // Model_Number
            // 
            this.Model_Number.HeaderText = "Model Number";
            this.Model_Number.Name = "Model_Number";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Price
            // 
            this.Price.HeaderText = "Unit Price";
            this.Price.Name = "Price";
            // 
            // S_GST
            // 
            this.S_GST.HeaderText = "S GST";
            this.S_GST.Name = "S_GST";
            // 
            // S_GST_Amount
            // 
            this.S_GST_Amount.HeaderText = "S GST Amount";
            this.S_GST_Amount.Name = "S_GST_Amount";
            // 
            // C_GST
            // 
            this.C_GST.HeaderText = "C GST";
            this.C_GST.Name = "C_GST";
            // 
            // C_GST_Amount
            // 
            this.C_GST_Amount.HeaderText = "C GST Amount";
            this.C_GST_Amount.Name = "C_GST_Amount";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Total_Price
            // 
            this.Total_Price.HeaderText = "Total Price";
            this.Total_Price.Name = "Total_Price";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(986, 30);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 29);
            this.label17.TabIndex = 106;
            this.label17.Text = "C GST";
            // 
            // tb_CGST
            // 
            this.tb_CGST.Enabled = false;
            this.tb_CGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CGST.Location = new System.Drawing.Point(980, 74);
            this.tb_CGST.Margin = new System.Windows.Forms.Padding(4);
            this.tb_CGST.MaxLength = 3;
            this.tb_CGST.Name = "tb_CGST";
            this.tb_CGST.Size = new System.Drawing.Size(88, 30);
            this.tb_CGST.TabIndex = 105;
            this.tb_CGST.Text = "9";
            this.tb_CGST.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(347, 27);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(152, 29);
            this.Label7.TabIndex = 88;
            this.Label7.Text = "Model Name";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(1339, 27);
            this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(144, 31);
            this.Label12.TabIndex = 87;
            this.Label12.Text = "Total Price";
            // 
            // TextBox3
            // 
            this.TextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox3.Location = new System.Drawing.Point(1369, 705);
            this.TextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(328, 30);
            this.TextBox3.TabIndex = 57;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(1077, 706);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(80, 29);
            this.Label5.TabIndex = 69;
            this.Label5.Text = "Salary";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Indigo;
            this.Panel1.Controls.Add(this.lbl_Title);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1902, 100);
            this.Panel1.TabIndex = 43;
            // 
            // frm_Add_New_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.Panel1);
            this.Name = "frm_Add_New_Customer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Add_New_Customer_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_new_bill)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox9;
        private System.Windows.Forms.Label Label16;
        private System.Windows.Forms.Label Label14;
        private System.Windows.Forms.Button btn_Calculate_Total;
        private System.Windows.Forms.Label Label11;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox tb_Bill;
        private System.Windows.Forms.Label Label15;
        private System.Windows.Forms.TextBox tb_Discount;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Total_Bill;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label Label13;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.TextBox tb_Total_Price;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.TextBox tb_Quantity;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.TextBox tb_SGST;
        private System.Windows.Forms.TextBox tb_Price;
        internal System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Label Label12;
        private System.Windows.Forms.TextBox TextBox3;
        private System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb_CGST;
        private System.Windows.Forms.DataGridView dgv_new_bill;
        private System.Windows.Forms.TextBox cb_Model_Name;
        private System.Windows.Forms.TextBox cb_Brand_Name;
        private System.Windows.Forms.TextBox tb_C_GST_Amount;
        private System.Windows.Forms.TextBox tb_S_GST_Amount;
        private System.Windows.Forms.TextBox tb_Unit_price_without_gst;
        private System.Windows.Forms.TextBox tb_Description;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_GST;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_GST_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_GST;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_GST_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Price;
        private System.Windows.Forms.TextBox tb_Customer_ID;
        private System.Windows.Forms.TextBox tb_Customer_Mob_No;
        internal System.Windows.Forms.DateTimePicker dtp_Bill_Date;
        private System.Windows.Forms.TextBox tb_Cust_GSTIN;
        private System.Windows.Forms.TextBox tb_Customer_Name;
    }
}