namespace L2D_WinformApp
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            panel_Login = new Panel();
            btn_ForgotPass = new Button();
            btn_ChangeSign = new Button();
            btn_Accept = new Button();
            btn_ShowHideReP = new Button();
            btn_ShowHideP = new Button();
            btn_clearE = new Button();
            btn_clearN = new Button();
            txt_Repass = new TextBox();
            txt_Email = new TextBox();
            txt_Fullname = new TextBox();
            btn_clearU = new Button();
            txt_Password = new TextBox();
            txt_Username = new TextBox();
            lab_Title = new Label();
            panel_Login.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Login
            // 
            panel_Login.Controls.Add(btn_ForgotPass);
            panel_Login.Controls.Add(btn_ChangeSign);
            panel_Login.Controls.Add(btn_Accept);
            panel_Login.Controls.Add(btn_ShowHideReP);
            panel_Login.Controls.Add(btn_ShowHideP);
            panel_Login.Controls.Add(btn_clearE);
            panel_Login.Controls.Add(btn_clearN);
            panel_Login.Controls.Add(txt_Repass);
            panel_Login.Controls.Add(txt_Email);
            panel_Login.Controls.Add(txt_Fullname);
            panel_Login.Controls.Add(btn_clearU);
            panel_Login.Controls.Add(txt_Password);
            panel_Login.Controls.Add(txt_Username);
            panel_Login.Controls.Add(lab_Title);
            panel_Login.Dock = DockStyle.Fill;
            panel_Login.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel_Login.Location = new Point(0, 0);
            panel_Login.Name = "panel_Login";
            panel_Login.Size = new Size(500, 555);
            panel_Login.TabIndex = 0;
            panel_Login.Click += Panel_Login_Click;
            // 
            // btn_ForgotPass
            // 
            btn_ForgotPass.BackgroundImageLayout = ImageLayout.None;
            btn_ForgotPass.Cursor = Cursors.Hand;
            btn_ForgotPass.FlatAppearance.BorderSize = 0;
            btn_ForgotPass.FlatStyle = FlatStyle.Flat;
            btn_ForgotPass.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ForgotPass.Location = new Point(177, 500);
            btn_ForgotPass.Name = "btn_ForgotPass";
            btn_ForgotPass.Size = new Size(145, 30);
            btn_ForgotPass.TabIndex = 13;
            btn_ForgotPass.TabStop = false;
            btn_ForgotPass.Text = "Quên mật khẩu?";
            btn_ForgotPass.UseVisualStyleBackColor = true;
            btn_ForgotPass.Visible = false;
            btn_ForgotPass.Click += Btn_ForgotPass_Click;
            // 
            // btn_ChangeSign
            // 
            btn_ChangeSign.Cursor = Cursors.Hand;
            btn_ChangeSign.FlatAppearance.BorderSize = 3;
            btn_ChangeSign.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ChangeSign.Location = new Point(95, 440);
            btn_ChangeSign.Name = "btn_ChangeSign";
            btn_ChangeSign.Size = new Size(180, 30);
            btn_ChangeSign.TabIndex = 12;
            btn_ChangeSign.TabStop = false;
            btn_ChangeSign.Text = "Đăng nhập tài khoản";
            btn_ChangeSign.UseVisualStyleBackColor = true;
            btn_ChangeSign.Click += Btn_ChangeSign_Click;
            // 
            // btn_Accept
            // 
            btn_Accept.Cursor = Cursors.Hand;
            btn_Accept.FlatAppearance.BorderColor = Color.Lime;
            btn_Accept.FlatAppearance.BorderSize = 3;
            btn_Accept.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Accept.Location = new Point(305, 440);
            btn_Accept.Name = "btn_Accept";
            btn_Accept.Size = new Size(100, 30);
            btn_Accept.TabIndex = 11;
            btn_Accept.TabStop = false;
            btn_Accept.Text = "Đăng kí";
            btn_Accept.UseVisualStyleBackColor = true;
            btn_Accept.Click += Btn_Accept_Click;
            // 
            // btn_ShowHideReP
            // 
            btn_ShowHideReP.Anchor = AnchorStyles.None;
            btn_ShowHideReP.BackColor = Color.White;
            btn_ShowHideReP.BackgroundImageLayout = ImageLayout.None;
            btn_ShowHideReP.Cursor = Cursors.Hand;
            btn_ShowHideReP.FlatAppearance.BorderSize = 0;
            btn_ShowHideReP.FlatStyle = FlatStyle.Flat;
            btn_ShowHideReP.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ShowHideReP.Location = new Point(379, 260);
            btn_ShowHideReP.Margin = new Padding(0);
            btn_ShowHideReP.Name = "btn_ShowHideReP";
            btn_ShowHideReP.Size = new Size(26, 29);
            btn_ShowHideReP.TabIndex = 10;
            btn_ShowHideReP.TabStop = false;
            btn_ShowHideReP.Text = "👁";
            btn_ShowHideReP.UseVisualStyleBackColor = false;
            btn_ShowHideReP.Visible = false;
            btn_ShowHideReP.Click += Btn_ShowHideReP_Click;
            // 
            // btn_ShowHideP
            // 
            btn_ShowHideP.Anchor = AnchorStyles.None;
            btn_ShowHideP.BackColor = Color.White;
            btn_ShowHideP.BackgroundImageLayout = ImageLayout.None;
            btn_ShowHideP.Cursor = Cursors.Hand;
            btn_ShowHideP.FlatAppearance.BorderSize = 0;
            btn_ShowHideP.FlatStyle = FlatStyle.Flat;
            btn_ShowHideP.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ShowHideP.Location = new Point(379, 200);
            btn_ShowHideP.Margin = new Padding(0);
            btn_ShowHideP.Name = "btn_ShowHideP";
            btn_ShowHideP.Size = new Size(26, 29);
            btn_ShowHideP.TabIndex = 9;
            btn_ShowHideP.TabStop = false;
            btn_ShowHideP.Text = "👁";
            btn_ShowHideP.UseVisualStyleBackColor = false;
            btn_ShowHideP.Visible = false;
            btn_ShowHideP.Click += Btn_ShowHideP_Click;
            // 
            // btn_clearE
            // 
            btn_clearE.Anchor = AnchorStyles.None;
            btn_clearE.BackColor = Color.White;
            btn_clearE.BackgroundImageLayout = ImageLayout.None;
            btn_clearE.Cursor = Cursors.Hand;
            btn_clearE.FlatAppearance.BorderSize = 0;
            btn_clearE.FlatStyle = FlatStyle.Flat;
            btn_clearE.ForeColor = SystemColors.ControlDarkDark;
            btn_clearE.Location = new Point(388, 381);
            btn_clearE.Margin = new Padding(0);
            btn_clearE.Name = "btn_clearE";
            btn_clearE.Size = new Size(17, 28);
            btn_clearE.TabIndex = 8;
            btn_clearE.TabStop = false;
            btn_clearE.Text = "x";
            btn_clearE.UseVisualStyleBackColor = false;
            btn_clearE.Visible = false;
            btn_clearE.Click += Btn_clearE_Click;
            // 
            // btn_clearN
            // 
            btn_clearN.Anchor = AnchorStyles.None;
            btn_clearN.BackColor = Color.White;
            btn_clearN.BackgroundImageLayout = ImageLayout.None;
            btn_clearN.Cursor = Cursors.Hand;
            btn_clearN.FlatAppearance.BorderSize = 0;
            btn_clearN.FlatStyle = FlatStyle.Flat;
            btn_clearN.ForeColor = SystemColors.ControlDarkDark;
            btn_clearN.Location = new Point(388, 321);
            btn_clearN.Margin = new Padding(0);
            btn_clearN.Name = "btn_clearN";
            btn_clearN.Size = new Size(17, 28);
            btn_clearN.TabIndex = 7;
            btn_clearN.TabStop = false;
            btn_clearN.Text = "x";
            btn_clearN.UseVisualStyleBackColor = false;
            btn_clearN.Visible = false;
            btn_clearN.Click += Btn_clearN_Click;
            // 
            // txt_Repass
            // 
            txt_Repass.Cursor = Cursors.IBeam;
            txt_Repass.Location = new Point(95, 260);
            txt_Repass.Name = "txt_Repass";
            txt_Repass.PlaceholderText = "Nhập lại mật khẩu";
            txt_Repass.Size = new Size(310, 32);
            txt_Repass.TabIndex = 6;
            txt_Repass.TabStop = false;
            txt_Repass.UseSystemPasswordChar = true;
            txt_Repass.TextChanged += Txt_Repass_TextChanged;
            txt_Repass.KeyDown += Txt_Repass_KeyDown;
            // 
            // txt_Email
            // 
            txt_Email.Cursor = Cursors.IBeam;
            txt_Email.Location = new Point(95, 380);
            txt_Email.Name = "txt_Email";
            txt_Email.PlaceholderText = "Email";
            txt_Email.Size = new Size(310, 32);
            txt_Email.TabIndex = 5;
            txt_Email.TabStop = false;
            txt_Email.TextChanged += Txt_Email_TextChanged;
            txt_Email.KeyDown += Txt_Email_KeyDown;
            // 
            // txt_Fullname
            // 
            txt_Fullname.Cursor = Cursors.IBeam;
            txt_Fullname.Location = new Point(95, 320);
            txt_Fullname.Name = "txt_Fullname";
            txt_Fullname.PlaceholderText = "Họ tên";
            txt_Fullname.Size = new Size(310, 32);
            txt_Fullname.TabIndex = 4;
            txt_Fullname.TabStop = false;
            txt_Fullname.TextChanged += Txt_Fullname_TextChanged;
            txt_Fullname.KeyDown += Txt_Fullname_KeyDown;
            // 
            // btn_clearU
            // 
            btn_clearU.Anchor = AnchorStyles.None;
            btn_clearU.BackColor = Color.White;
            btn_clearU.BackgroundImageLayout = ImageLayout.None;
            btn_clearU.Cursor = Cursors.Hand;
            btn_clearU.FlatAppearance.BorderSize = 0;
            btn_clearU.FlatStyle = FlatStyle.Flat;
            btn_clearU.ForeColor = SystemColors.ControlDarkDark;
            btn_clearU.Location = new Point(388, 141);
            btn_clearU.Margin = new Padding(0);
            btn_clearU.Name = "btn_clearU";
            btn_clearU.Size = new Size(17, 28);
            btn_clearU.TabIndex = 3;
            btn_clearU.TabStop = false;
            btn_clearU.Text = "x";
            btn_clearU.UseVisualStyleBackColor = false;
            btn_clearU.Visible = false;
            btn_clearU.Click += Btn_clearU_Click;
            // 
            // txt_Password
            // 
            txt_Password.Cursor = Cursors.IBeam;
            txt_Password.Location = new Point(95, 200);
            txt_Password.Name = "txt_Password";
            txt_Password.PlaceholderText = "Mật khẩu";
            txt_Password.Size = new Size(310, 32);
            txt_Password.TabIndex = 2;
            txt_Password.TabStop = false;
            txt_Password.UseSystemPasswordChar = true;
            txt_Password.TextChanged += Txt_Password_TextChanged;
            txt_Password.KeyDown += Txt_Password_Enter;
            // 
            // txt_Username
            // 
            txt_Username.Cursor = Cursors.IBeam;
            txt_Username.Location = new Point(95, 140);
            txt_Username.Name = "txt_Username";
            txt_Username.PlaceholderText = "Tài khoản";
            txt_Username.Size = new Size(310, 32);
            txt_Username.TabIndex = 1;
            txt_Username.TabStop = false;
            txt_Username.TextChanged += Txt_Username_TextChanged;
            txt_Username.KeyDown += Txt_Username_KeyDown;
            // 
            // lab_Title
            // 
            lab_Title.AutoSize = true;
            lab_Title.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lab_Title.Location = new Point(174, 55);
            lab_Title.Name = "lab_Title";
            lab_Title.Size = new Size(151, 41);
            lab_Title.TabIndex = 0;
            lab_Title.Text = "Đăng Kí";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 555);
            Controls.Add(panel_Login);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLogin";
            Text = "Learn2Drive - Login";
            Load += FrmLogin_Load;
            Shown += FrmLogin_Shown;
            panel_Login.ResumeLayout(false);
            panel_Login.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Login;
        private Label lab_Title;
        private TextBox txt_Password;
        private TextBox txt_Username;
        private Button btn_clearU;
        private TextBox txt_Email;
        private TextBox txt_Fullname;
        private TextBox txt_Repass;
        private Button btn_clearE;
        private Button btn_clearN;
        private Button btn_Accept;
        private Button btn_ShowHideReP;
        private Button btn_ShowHideP;
        private Button btn_ChangeSign;
        private Button btn_ForgotPass;
    }
}