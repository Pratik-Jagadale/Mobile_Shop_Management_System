namespace Mobile_Shoppee_Management_System.Forms
{
    partial class frm_User_Management
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
            this.btn_Submit = new System.Windows.Forms.Button();
            this.tab_Add_New_User = new System.Windows.Forms.TabPage();
            this.tb_C_Password = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_New_Password = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.tb_Current_Password = new System.Windows.Forms.TextBox();
            this.UserMgt = new System.Windows.Forms.TabControl();
            this.tab_Change_Password = new System.Windows.Forms.TabPage();
            this.tb_Username_CP = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.tab_Delete_User = new System.Windows.Forms.TabPage();
            this.btn_Delete_User = new System.Windows.Forms.Button();
            this.tb_D_Password = new System.Windows.Forms.TextBox();
            this.tb_D_Username = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.tab_Add_New_User.SuspendLayout();
            this.UserMgt.SuspendLayout();
            this.tab_Change_Password.SuspendLayout();
            this.tab_Delete_User.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Submit
            // 
            this.btn_Submit.Enabled = false;
            this.btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_Submit.Location = new System.Drawing.Point(752, 571);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(288, 86);
            this.btn_Submit.TabIndex = 4;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // tab_Add_New_User
            // 
            this.tab_Add_New_User.BackColor = System.Drawing.Color.Transparent;
            this.tab_Add_New_User.Controls.Add(this.btn_Submit);
            this.tab_Add_New_User.Controls.Add(this.tb_C_Password);
            this.tab_Add_New_User.Controls.Add(this.Label7);
            this.tab_Add_New_User.Controls.Add(this.tb_Password);
            this.tab_Add_New_User.Controls.Add(this.tb_Username);
            this.tab_Add_New_User.Controls.Add(this.Label5);
            this.tab_Add_New_User.Controls.Add(this.Label6);
            this.tab_Add_New_User.Controls.Add(this.Label2);
            this.tab_Add_New_User.Location = new System.Drawing.Point(4, 34);
            this.tab_Add_New_User.Margin = new System.Windows.Forms.Padding(4);
            this.tab_Add_New_User.Name = "tab_Add_New_User";
            this.tab_Add_New_User.Padding = new System.Windows.Forms.Padding(4);
            this.tab_Add_New_User.Size = new System.Drawing.Size(1894, 869);
            this.tab_Add_New_User.TabIndex = 0;
            this.tab_Add_New_User.Text = "Add New User";
            // 
            // tb_C_Password
            // 
            this.tb_C_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_C_Password.Location = new System.Drawing.Point(1032, 422);
            this.tb_C_Password.Margin = new System.Windows.Forms.Padding(4);
            this.tb_C_Password.MaxLength = 20;
            this.tb_C_Password.Name = "tb_C_Password";
            this.tb_C_Password.Size = new System.Drawing.Size(400, 34);
            this.tb_C_Password.TabIndex = 3;
            this.tb_C_Password.TextChanged += new System.EventHandler(this.tb_C_Password_TextChanged);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(368, 423);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(210, 29);
            this.Label7.TabIndex = 30;
            this.Label7.Text = "Confirm Password";
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(1032, 292);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Password.MaxLength = 20;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(400, 34);
            this.tb_Password.TabIndex = 2;
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(1032, 169);
            this.tb_Username.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Username.MaxLength = 20;
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(400, 34);
            this.tb_Username.TabIndex = 1;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(368, 170);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(124, 29);
            this.Label5.TabIndex = 28;
            this.Label5.Text = "Username";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(368, 293);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(183, 29);
            this.Label6.TabIndex = 27;
            this.Label6.Text = "Enter Password";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.Label2.Location = new System.Drawing.Point(651, 13);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(552, 94);
            this.Label2.TabIndex = 22;
            this.Label2.Text = "Add New User";
            // 
            // btn_Update
            // 
            this.btn_Update.Enabled = false;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_Update.Location = new System.Drawing.Point(752, 571);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(362, 90);
            this.btn_Update.TabIndex = 8;
            this.btn_Update.Text = "Update Password";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 28.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(684, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 65);
            this.label1.TabIndex = 39;
            this.label1.Text = "User Management";
            // 
            // tb_New_Password
            // 
            this.tb_New_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_New_Password.Location = new System.Drawing.Point(1037, 423);
            this.tb_New_Password.Margin = new System.Windows.Forms.Padding(4);
            this.tb_New_Password.Name = "tb_New_Password";
            this.tb_New_Password.PasswordChar = '*';
            this.tb_New_Password.Size = new System.Drawing.Size(400, 34);
            this.tb_New_Password.TabIndex = 7;
            this.tb_New_Password.TextChanged += new System.EventHandler(this.tb_New_Password_TextChanged);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(373, 427);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(176, 29);
            this.Label10.TabIndex = 49;
            this.Label10.Text = "New Password";
            // 
            // tb_Current_Password
            // 
            this.tb_Current_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Current_Password.Location = new System.Drawing.Point(1037, 293);
            this.tb_Current_Password.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Current_Password.Name = "tb_Current_Password";
            this.tb_Current_Password.PasswordChar = '*';
            this.tb_Current_Password.Size = new System.Drawing.Size(400, 34);
            this.tb_Current_Password.TabIndex = 6;
            // 
            // UserMgt
            // 
            this.UserMgt.Controls.Add(this.tab_Add_New_User);
            this.UserMgt.Controls.Add(this.tab_Change_Password);
            this.UserMgt.Controls.Add(this.tab_Delete_User);
            this.UserMgt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UserMgt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserMgt.Location = new System.Drawing.Point(0, 126);
            this.UserMgt.Margin = new System.Windows.Forms.Padding(4);
            this.UserMgt.Name = "UserMgt";
            this.UserMgt.SelectedIndex = 0;
            this.UserMgt.Size = new System.Drawing.Size(1902, 907);
            this.UserMgt.TabIndex = 42;
            // 
            // tab_Change_Password
            // 
            this.tab_Change_Password.BackColor = System.Drawing.Color.Transparent;
            this.tab_Change_Password.Controls.Add(this.btn_Update);
            this.tab_Change_Password.Controls.Add(this.tb_New_Password);
            this.tab_Change_Password.Controls.Add(this.Label10);
            this.tab_Change_Password.Controls.Add(this.tb_Current_Password);
            this.tab_Change_Password.Controls.Add(this.tb_Username_CP);
            this.tab_Change_Password.Controls.Add(this.Label8);
            this.tab_Change_Password.Controls.Add(this.Label9);
            this.tab_Change_Password.Controls.Add(this.Label3);
            this.tab_Change_Password.Location = new System.Drawing.Point(4, 34);
            this.tab_Change_Password.Margin = new System.Windows.Forms.Padding(4);
            this.tab_Change_Password.Name = "tab_Change_Password";
            this.tab_Change_Password.Padding = new System.Windows.Forms.Padding(4);
            this.tab_Change_Password.Size = new System.Drawing.Size(1894, 869);
            this.tab_Change_Password.TabIndex = 1;
            this.tab_Change_Password.Text = "Change Password";
            // 
            // tb_Username_CP
            // 
            this.tb_Username_CP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username_CP.Location = new System.Drawing.Point(1037, 170);
            this.tb_Username_CP.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Username_CP.Name = "tb_Username_CP";
            this.tb_Username_CP.Size = new System.Drawing.Size(400, 34);
            this.tb_Username_CP.TabIndex = 5;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(373, 171);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(124, 29);
            this.Label8.TabIndex = 47;
            this.Label8.Text = "Username";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(373, 294);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(205, 29);
            this.Label9.TabIndex = 46;
            this.Label9.Text = "Current Password";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Bold);
            this.Label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.Label3.Location = new System.Drawing.Point(651, 13);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(683, 94);
            this.Label3.TabIndex = 23;
            this.Label3.Text = "Change Password";
            // 
            // tab_Delete_User
            // 
            this.tab_Delete_User.BackColor = System.Drawing.Color.Transparent;
            this.tab_Delete_User.Controls.Add(this.btn_Delete_User);
            this.tab_Delete_User.Controls.Add(this.tb_D_Password);
            this.tab_Delete_User.Controls.Add(this.tb_D_Username);
            this.tab_Delete_User.Controls.Add(this.Label11);
            this.tab_Delete_User.Controls.Add(this.Label12);
            this.tab_Delete_User.Controls.Add(this.Label4);
            this.tab_Delete_User.Location = new System.Drawing.Point(4, 34);
            this.tab_Delete_User.Margin = new System.Windows.Forms.Padding(4);
            this.tab_Delete_User.Name = "tab_Delete_User";
            this.tab_Delete_User.Padding = new System.Windows.Forms.Padding(4);
            this.tab_Delete_User.Size = new System.Drawing.Size(1894, 869);
            this.tab_Delete_User.TabIndex = 2;
            this.tab_Delete_User.Text = "Delete User";
            // 
            // btn_Delete_User
            // 
            this.btn_Delete_User.Enabled = false;
            this.btn_Delete_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete_User.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_Delete_User.Location = new System.Drawing.Point(708, 532);
            this.btn_Delete_User.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Delete_User.Name = "btn_Delete_User";
            this.btn_Delete_User.Size = new System.Drawing.Size(288, 86);
            this.btn_Delete_User.TabIndex = 11;
            this.btn_Delete_User.Text = "Delete User";
            this.btn_Delete_User.UseVisualStyleBackColor = true;
            this.btn_Delete_User.Click += new System.EventHandler(this.btn_Delete_User_Click);
            // 
            // tb_D_Password
            // 
            this.tb_D_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_D_Password.Location = new System.Drawing.Point(1025, 377);
            this.tb_D_Password.Margin = new System.Windows.Forms.Padding(4);
            this.tb_D_Password.Name = "tb_D_Password";
            this.tb_D_Password.PasswordChar = '*';
            this.tb_D_Password.Size = new System.Drawing.Size(400, 34);
            this.tb_D_Password.TabIndex = 10;
            this.tb_D_Password.TextChanged += new System.EventHandler(this.tb_D_Password_TextChanged);
            // 
            // tb_D_Username
            // 
            this.tb_D_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_D_Username.Location = new System.Drawing.Point(1025, 171);
            this.tb_D_Username.Margin = new System.Windows.Forms.Padding(4);
            this.tb_D_Username.Name = "tb_D_Username";
            this.tb_D_Username.Size = new System.Drawing.Size(400, 34);
            this.tb_D_Username.TabIndex = 9;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(361, 172);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(124, 29);
            this.Label11.TabIndex = 55;
            this.Label11.Text = "Username";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(361, 378);
            this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(183, 29);
            this.Label12.TabIndex = 54;
            this.Label12.Text = "Enter Password";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Bold);
            this.Label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.Label4.Location = new System.Drawing.Point(651, 13);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(463, 94);
            this.Label4.TabIndex = 24;
            this.Label4.Text = "Delete User";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Indigo;
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1902, 100);
            this.Panel1.TabIndex = 43;
            // 
            // frm_User_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.UserMgt);
            this.Controls.Add(this.Panel1);
            this.HelpButton = true;
            this.Name = "frm_User_Management";
            this.Text = "frm_User_Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tab_Add_New_User.ResumeLayout(false);
            this.tab_Add_New_User.PerformLayout();
            this.UserMgt.ResumeLayout(false);
            this.tab_Change_Password.ResumeLayout(false);
            this.tab_Change_Password.PerformLayout();
            this.tab_Delete_User.ResumeLayout(false);
            this.tab_Delete_User.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Submit;
        internal System.Windows.Forms.TabPage tab_Add_New_User;
        private System.Windows.Forms.TextBox tb_C_Password;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_New_Password;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.TextBox tb_Current_Password;
        internal System.Windows.Forms.TabControl UserMgt;
        internal System.Windows.Forms.TabPage tab_Change_Password;
        private System.Windows.Forms.TextBox tb_Username_CP;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TabPage tab_Delete_User;
        private System.Windows.Forms.Button btn_Delete_User;
        private System.Windows.Forms.TextBox tb_D_Password;
        private System.Windows.Forms.TextBox tb_D_Username;
        private System.Windows.Forms.Label Label11;
        private System.Windows.Forms.Label Label12;
        private System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Panel Panel1;
    }
}