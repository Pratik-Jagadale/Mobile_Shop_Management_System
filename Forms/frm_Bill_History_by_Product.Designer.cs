namespace Mobile_Shoppee_Management_System.Forms
{
    partial class frm_Bill_History_by_Product
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
            this.components = new System.ComponentModel.Container();
            this.tb_categ = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dgv_cust_master = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gSTINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calculateBillDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalBillDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mobileShoppeeDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mobile_Shoppee_DBDataSet = new Mobile_Shoppee_Management_System.Mobile_Shoppee_DBDataSet();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgv_custmer_details = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGSTAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGSTAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPurchaseDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customer_MasterTableAdapter = new Mobile_Shoppee_Management_System.Mobile_Shoppee_DBDataSetTableAdapters.Customer_MasterTableAdapter();
            this.customer_Purchase_DetailTableAdapter = new Mobile_Shoppee_Management_System.Mobile_Shoppee_DBDataSetTableAdapters.Customer_Purchase_DetailTableAdapter();
            this.btn_delete_row = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cust_master)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileShoppeeDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobile_Shoppee_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_custmer_details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerPurchaseDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_categ
            // 
            this.tb_categ.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_categ.FormattingEnabled = true;
            this.tb_categ.Items.AddRange(new object[] {
            "Name",
            "Mobile_No"});
            this.tb_categ.Location = new System.Drawing.Point(490, 29);
            this.tb_categ.Name = "tb_categ";
            this.tb_categ.Size = new System.Drawing.Size(247, 28);
            this.tb_categ.TabIndex = 112;
            this.tb_categ.SelectedIndexChanged += new System.EventHandler(this.tb_categ_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 111;
            this.label1.Text = "Category:";
            // 
            // tb_search
            // 
            this.tb_search.Enabled = false;
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(852, 26);
            this.tb_search.Margin = new System.Windows.Forms.Padding(4);
            this.tb_search.MaxLength = 50;
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(312, 30);
            this.tb_search.TabIndex = 109;
            this.tb_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Search
            // 
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Indigo;
            this.btn_Search.Location = new System.Drawing.Point(1188, 14);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(135, 47);
            this.btn_Search.TabIndex = 110;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dgv_cust_master
            // 
            this.dgv_cust_master.AllowUserToAddRows = false;
            this.dgv_cust_master.AutoGenerateColumns = false;
            this.dgv_cust_master.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgv_cust_master.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cust_master.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.billDateDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.gSTINDataGridViewTextBoxColumn,
            this.calculateBillDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.totalBillDataGridViewTextBoxColumn});
            this.dgv_cust_master.DataSource = this.customerMasterBindingSource;
            this.dgv_cust_master.GridColor = System.Drawing.Color.LightSalmon;
            this.dgv_cust_master.Location = new System.Drawing.Point(3, 146);
            this.dgv_cust_master.Name = "dgv_cust_master";
            this.dgv_cust_master.RowTemplate.Height = 24;
            this.dgv_cust_master.Size = new System.Drawing.Size(635, 544);
            this.dgv_cust_master.TabIndex = 115;
            this.dgv_cust_master.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cust_master_CellContentDoubleClick);
            this.dgv_cust_master.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_cust_master_ColumnHeaderMouseClick);
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // billDateDataGridViewTextBoxColumn
            // 
            this.billDateDataGridViewTextBoxColumn.DataPropertyName = "Bill_Date";
            this.billDateDataGridViewTextBoxColumn.HeaderText = "Bill_Date";
            this.billDateDataGridViewTextBoxColumn.Name = "billDateDataGridViewTextBoxColumn";
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            // 
            // gSTINDataGridViewTextBoxColumn
            // 
            this.gSTINDataGridViewTextBoxColumn.DataPropertyName = "GSTIN";
            this.gSTINDataGridViewTextBoxColumn.HeaderText = "GSTIN";
            this.gSTINDataGridViewTextBoxColumn.Name = "gSTINDataGridViewTextBoxColumn";
            // 
            // calculateBillDataGridViewTextBoxColumn
            // 
            this.calculateBillDataGridViewTextBoxColumn.DataPropertyName = "Calculate_Bill";
            this.calculateBillDataGridViewTextBoxColumn.HeaderText = "Calculate_Bill";
            this.calculateBillDataGridViewTextBoxColumn.Name = "calculateBillDataGridViewTextBoxColumn";
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            // 
            // totalBillDataGridViewTextBoxColumn
            // 
            this.totalBillDataGridViewTextBoxColumn.DataPropertyName = "Total_Bill";
            this.totalBillDataGridViewTextBoxColumn.HeaderText = "Total_Bill";
            this.totalBillDataGridViewTextBoxColumn.Name = "totalBillDataGridViewTextBoxColumn";
            // 
            // customerMasterBindingSource
            // 
            this.customerMasterBindingSource.DataMember = "Customer_Master";
            this.customerMasterBindingSource.DataSource = this.mobileShoppeeDBDataSetBindingSource;
            // 
            // mobileShoppeeDBDataSetBindingSource
            // 
            this.mobileShoppeeDBDataSetBindingSource.DataSource = this.mobile_Shoppee_DBDataSet;
            this.mobileShoppeeDBDataSetBindingSource.Position = 0;
            // 
            // mobile_Shoppee_DBDataSet
            // 
            this.mobile_Shoppee_DBDataSet.DataSetName = "Mobile_Shoppee_DBDataSet";
            this.mobile_Shoppee_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 74);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_delete_row);
            this.splitContainer1.Panel1.Controls.Add(this.dgv_cust_master);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_custmer_details);
            this.splitContainer1.Size = new System.Drawing.Size(1903, 838);
            this.splitContainer1.SplitterDistance = 634;
            this.splitContainer1.TabIndex = 116;
            // 
            // dgv_custmer_details
            // 
            this.dgv_custmer_details.AutoGenerateColumns = false;
            this.dgv_custmer_details.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_custmer_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_custmer_details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn1,
            this.brandNameDataGridViewTextBoxColumn,
            this.modelNameDataGridViewTextBoxColumn,
            this.discriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.sGSTDataGridViewTextBoxColumn,
            this.sGSTAmountDataGridViewTextBoxColumn,
            this.cGSTDataGridViewTextBoxColumn,
            this.cGSTAmountDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.dgv_custmer_details.DataSource = this.customerPurchaseDetailBindingSource;
            this.dgv_custmer_details.GridColor = System.Drawing.Color.Salmon;
            this.dgv_custmer_details.Location = new System.Drawing.Point(55, 32);
            this.dgv_custmer_details.Name = "dgv_custmer_details";
            this.dgv_custmer_details.RowTemplate.Height = 24;
            this.dgv_custmer_details.Size = new System.Drawing.Size(1203, 777);
            this.dgv_custmer_details.TabIndex = 0;
            // 
            // customerIDDataGridViewTextBoxColumn1
            // 
            this.customerIDDataGridViewTextBoxColumn1.DataPropertyName = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn1.HeaderText = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn1.Name = "customerIDDataGridViewTextBoxColumn1";
            // 
            // brandNameDataGridViewTextBoxColumn
            // 
            this.brandNameDataGridViewTextBoxColumn.DataPropertyName = "Brand_Name";
            this.brandNameDataGridViewTextBoxColumn.HeaderText = "Brand_Name";
            this.brandNameDataGridViewTextBoxColumn.Name = "brandNameDataGridViewTextBoxColumn";
            // 
            // modelNameDataGridViewTextBoxColumn
            // 
            this.modelNameDataGridViewTextBoxColumn.DataPropertyName = "Model_Name";
            this.modelNameDataGridViewTextBoxColumn.HeaderText = "Model_Name";
            this.modelNameDataGridViewTextBoxColumn.Name = "modelNameDataGridViewTextBoxColumn";
            // 
            // discriptionDataGridViewTextBoxColumn
            // 
            this.discriptionDataGridViewTextBoxColumn.DataPropertyName = "Discription";
            this.discriptionDataGridViewTextBoxColumn.HeaderText = "Discription";
            this.discriptionDataGridViewTextBoxColumn.Name = "discriptionDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // sGSTDataGridViewTextBoxColumn
            // 
            this.sGSTDataGridViewTextBoxColumn.DataPropertyName = "S GST";
            this.sGSTDataGridViewTextBoxColumn.HeaderText = "S GST";
            this.sGSTDataGridViewTextBoxColumn.Name = "sGSTDataGridViewTextBoxColumn";
            // 
            // sGSTAmountDataGridViewTextBoxColumn
            // 
            this.sGSTAmountDataGridViewTextBoxColumn.DataPropertyName = "S_GST_Amount";
            this.sGSTAmountDataGridViewTextBoxColumn.HeaderText = "S_GST_Amount";
            this.sGSTAmountDataGridViewTextBoxColumn.Name = "sGSTAmountDataGridViewTextBoxColumn";
            // 
            // cGSTDataGridViewTextBoxColumn
            // 
            this.cGSTDataGridViewTextBoxColumn.DataPropertyName = "C GST";
            this.cGSTDataGridViewTextBoxColumn.HeaderText = "C GST";
            this.cGSTDataGridViewTextBoxColumn.Name = "cGSTDataGridViewTextBoxColumn";
            // 
            // cGSTAmountDataGridViewTextBoxColumn
            // 
            this.cGSTAmountDataGridViewTextBoxColumn.DataPropertyName = "C_GST_Amount";
            this.cGSTAmountDataGridViewTextBoxColumn.HeaderText = "C_GST_Amount";
            this.cGSTAmountDataGridViewTextBoxColumn.Name = "cGSTAmountDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "Total_Price";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "Total_Price";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            // 
            // customerPurchaseDetailBindingSource
            // 
            this.customerPurchaseDetailBindingSource.DataMember = "Customer_Purchase_Detail";
            this.customerPurchaseDetailBindingSource.DataSource = this.mobileShoppeeDBDataSetBindingSource;
            // 
            // customer_MasterTableAdapter
            // 
            this.customer_MasterTableAdapter.ClearBeforeFill = true;
            // 
            // customer_Purchase_DetailTableAdapter
            // 
            this.customer_Purchase_DetailTableAdapter.ClearBeforeFill = true;
            // 
            // btn_delete_row
            // 
            this.btn_delete_row.BackColor = System.Drawing.Color.Orange;
            this.btn_delete_row.FlatAppearance.BorderSize = 0;
            this.btn_delete_row.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_row.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_row.ForeColor = System.Drawing.Color.White;
            this.btn_delete_row.Location = new System.Drawing.Point(452, 711);
            this.btn_delete_row.Name = "btn_delete_row";
            this.btn_delete_row.Size = new System.Drawing.Size(129, 31);
            this.btn_delete_row.TabIndex = 117;
            this.btn_delete_row.Text = "Delete Entry ";
            this.btn_delete_row.UseVisualStyleBackColor = false;
            this.btn_delete_row.Click += new System.EventHandler(this.btn_delete_row_Click);
            // 
            // frm_Bill_History_by_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 925);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tb_categ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.btn_Search);
            this.Location = new System.Drawing.Point(0, 36);
            this.Name = "frm_Bill_History_by_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Bill_History_by_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cust_master)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileShoppeeDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobile_Shoppee_DBDataSet)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_custmer_details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerPurchaseDetailBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tb_categ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dgv_cust_master;
        private System.Windows.Forms.BindingSource mobileShoppeeDBDataSetBindingSource;
        private Mobile_Shoppee_DBDataSet mobile_Shoppee_DBDataSet;
        private System.Windows.Forms.BindingSource customerMasterBindingSource;
        private Mobile_Shoppee_DBDataSetTableAdapters.Customer_MasterTableAdapter customer_MasterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gSTINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calculateBillDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalBillDataGridViewTextBoxColumn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgv_custmer_details;
        private System.Windows.Forms.BindingSource customerPurchaseDetailBindingSource;
        private Mobile_Shoppee_DBDataSetTableAdapters.Customer_Purchase_DetailTableAdapter customer_Purchase_DetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGSTAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGSTAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_delete_row;
    }
}