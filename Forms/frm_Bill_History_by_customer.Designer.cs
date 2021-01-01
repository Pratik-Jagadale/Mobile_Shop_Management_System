namespace Mobile_Shoppee_Management_System.Forms
{
    partial class frm_Bill_History_by_Cust_Name
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.tb_Category = new System.Windows.Forms.ComboBox();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.crv_bill_history_Cust = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Indigo;
            this.btn_Search.Location = new System.Drawing.Point(1170, 24);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(138, 51);
            this.btn_Search.TabIndex = 105;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(507, 31);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(128, 29);
            this.lbl.TabIndex = 107;
            this.lbl.Text = "Search By:";
            // 
            // tb_Category
            // 
            this.tb_Category.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Category.FormattingEnabled = true;
            this.tb_Category.Items.AddRange(new object[] {
            "Name",
            "Mobile_No"});
            this.tb_Category.Location = new System.Drawing.Point(650, 34);
            this.tb_Category.Name = "tb_Category";
            this.tb_Category.Size = new System.Drawing.Size(247, 28);
            this.tb_Category.TabIndex = 108;
            this.tb_Category.SelectedIndexChanged += new System.EventHandler(this.tb_Category_SelectedIndexChanged);
            // 
            // tb_search
            // 
            this.tb_search.Enabled = false;
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(921, 34);
            this.tb_search.Margin = new System.Windows.Forms.Padding(4);
            this.tb_search.MaxLength = 50;
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(213, 30);
            this.tb_search.TabIndex = 109;
            this.tb_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // crv_bill_history_Cust
            // 
            this.crv_bill_history_Cust.ActiveViewIndex = -1;
            this.crv_bill_history_Cust.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.crv_bill_history_Cust.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.crv_bill_history_Cust.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_bill_history_Cust.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_bill_history_Cust.Location = new System.Drawing.Point(0, 0);
            this.crv_bill_history_Cust.Name = "crv_bill_history_Cust";
            this.crv_bill_history_Cust.Size = new System.Drawing.Size(1902, 805);
            this.crv_bill_history_Cust.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.crv_bill_history_Cust);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1902, 805);
            this.panel1.TabIndex = 110;
            // 
            // frm_Bill_History_by_Cust_Name
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.tb_Category);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btn_Search);
            this.Name = "frm_Bill_History_by_Cust_Name";
            this.Load += new System.EventHandler(this.frm_Bill_History_by_Cust_Name_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ComboBox tb_Category;
        private System.Windows.Forms.TextBox tb_search;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_bill_history_Cust;
        private System.Windows.Forms.Panel panel1;
    }
}