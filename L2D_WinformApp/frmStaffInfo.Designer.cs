namespace L2D_WinformApp
{
    partial class frmStaffInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaffInfo));
            groupBox1 = new GroupBox();
            btnSave = new Button();
            txtRepass = new TextBox();
            txtPassword = new TextBox();
            txtContactNumber = new TextBox();
            txtEmail = new TextBox();
            txtFullName = new TextBox();
            lbRepass = new Label();
            lbPassword = new Label();
            lbContactNumber = new Label();
            lbEmail = new Label();
            lbFullName = new Label();
            btnClose = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(txtRepass);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtContactNumber);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(lbRepass);
            groupBox1.Controls.Add(lbPassword);
            groupBox1.Controls.Add(lbContactNumber);
            groupBox1.Controls.Add(lbEmail);
            groupBox1.Controls.Add(lbFullName);
            groupBox1.Location = new Point(32, 23);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(713, 434);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // btnSave
            // 
            btnSave.ForeColor = Color.Red;
            btnSave.Location = new Point(293, 347);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(106, 30);
            btnSave.TabIndex = 10;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtRepass
            // 
            txtRepass.Location = new Point(198, 289);
            txtRepass.Margin = new Padding(3, 4, 3, 4);
            txtRepass.Name = "txtRepass";
            txtRepass.PlaceholderText = "Xác nhận mật khẩu";
            txtRepass.Size = new Size(278, 28);
            txtRepass.TabIndex = 9;
            txtRepass.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(198, 236);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Nhập mật khẩu";
            txtPassword.Size = new Size(278, 28);
            txtPassword.TabIndex = 8;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Location = new Point(198, 177);
            txtContactNumber.Margin = new Padding(3, 4, 3, 4);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.PlaceholderText = "Nhập số điện thoại";
            txtContactNumber.Size = new Size(241, 28);
            txtContactNumber.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(198, 124);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Nhập email";
            txtEmail.Size = new Size(278, 28);
            txtEmail.TabIndex = 6;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(198, 68);
            txtFullName.Margin = new Padding(3, 4, 3, 4);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "Nhập họ và tên";
            txtFullName.Size = new Size(311, 28);
            txtFullName.TabIndex = 5;
            // 
            // lbRepass
            // 
            lbRepass.AutoSize = true;
            lbRepass.Location = new Point(27, 292);
            lbRepass.Name = "lbRepass";
            lbRepass.Size = new Size(152, 21);
            lbRepass.TabIndex = 4;
            lbRepass.Text = "Xác nhận mật khẩu";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(27, 236);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(78, 21);
            lbPassword.TabIndex = 3;
            lbPassword.Text = "Mật khẩu";
            // 
            // lbContactNumber
            // 
            lbContactNumber.AutoSize = true;
            lbContactNumber.Location = new Point(27, 177);
            lbContactNumber.Name = "lbContactNumber";
            lbContactNumber.Size = new Size(107, 21);
            lbContactNumber.TabIndex = 2;
            lbContactNumber.Text = "Số điện thoại";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(27, 124);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(51, 21);
            lbEmail.TabIndex = 1;
            lbEmail.Text = "Email";
            // 
            // lbFullName
            // 
            lbFullName.AutoSize = true;
            lbFullName.Location = new Point(27, 71);
            lbFullName.Name = "lbFullName";
            lbFullName.Size = new Size(81, 21);
            lbFullName.TabIndex = 0;
            lbFullName.Text = "Họ và tên";
            // 
            // btnClose
            // 
            btnClose.ForeColor = Color.Red;
            btnClose.Location = new Point(908, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 1;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // frmStaffInfo
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 531);
            Controls.Add(btnClose);
            Controls.Add(groupBox1);
            Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmStaffInfo";
            Text = "L2D - Thông tin nhân viên";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lbEmail;
        private Label lbFullName;
        private Button btnSave;
        private TextBox txtRepass;
        private TextBox txtPassword;
        private TextBox txtContactNumber;
        private TextBox txtEmail;
        private TextBox txtFullName;
        private Label lbRepass;
        private Label lbPassword;
        private Label lbContactNumber;
        private Button btnClose;
    }
}