namespace L2D_WinformApp
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            panel_Home = new Panel();
            pic_logo = new PictureBox();
            navbar = new MenuStrip();
            nav_Home = new ToolStripMenuItem();
            nav_Intro = new ToolStripMenuItem();
            nav_License = new ToolStripMenuItem();
            nav_LicenseA1 = new ToolStripMenuItem();
            nav_LicenseA2 = new ToolStripMenuItem();
            nav_LicenseA3 = new ToolStripMenuItem();
            nav_LicenseA4 = new ToolStripMenuItem();
            nav_LicenseB1 = new ToolStripMenuItem();
            nav_LicenseB2 = new ToolStripMenuItem();
            nav_LicenseC = new ToolStripMenuItem();
            nav_LicenseD = new ToolStripMenuItem();
            nav_LicenseE = new ToolStripMenuItem();
            nav_LicenseFB2 = new ToolStripMenuItem();
            nav_LicenseFC = new ToolStripMenuItem();
            nav_LicenseFD = new ToolStripMenuItem();
            nav_LicenseFE = new ToolStripMenuItem();
            nav_Quiz = new ToolStripMenuItem();
            nav_Rent = new ToolStripMenuItem();
            nav_Session = new ToolStripMenuItem();
            nav_Session_Logout = new ToolStripMenuItem();
            pic_bgHome = new PictureBox();
            exitToolStripMenuItem = new ToolStripMenuItem();
            panel_Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_logo).BeginInit();
            navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_bgHome).BeginInit();
            SuspendLayout();
            // 
            // panel_Home
            // 
            panel_Home.Controls.Add(pic_logo);
            panel_Home.Controls.Add(navbar);
            panel_Home.Controls.Add(pic_bgHome);
            panel_Home.Dock = DockStyle.Fill;
            panel_Home.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            panel_Home.Location = new Point(0, 0);
            panel_Home.Name = "panel_Home";
            panel_Home.Size = new Size(1422, 853);
            panel_Home.TabIndex = 0;
            // 
            // pic_logo
            // 
            pic_logo.BackgroundImageLayout = ImageLayout.None;
            pic_logo.Image = (Image)resources.GetObject("pic_logo.Image");
            pic_logo.Location = new Point(17, 16);
            pic_logo.Name = "pic_logo";
            pic_logo.Size = new Size(172, 43);
            pic_logo.SizeMode = PictureBoxSizeMode.AutoSize;
            pic_logo.TabIndex = 1;
            pic_logo.TabStop = false;
            // 
            // navbar
            // 
            navbar.AutoSize = false;
            navbar.BackColor = Color.Snow;
            navbar.BackgroundImageLayout = ImageLayout.None;
            navbar.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            navbar.ImageScalingSize = new Size(20, 20);
            navbar.Items.AddRange(new ToolStripItem[] { nav_Home, nav_Intro, nav_License, nav_Quiz, nav_Rent, nav_Session, exitToolStripMenuItem });
            navbar.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            navbar.Location = new Point(0, 0);
            navbar.Name = "navbar";
            navbar.Padding = new Padding(0);
            navbar.Size = new Size(1422, 74);
            navbar.TabIndex = 1;
            navbar.Text = "NavBar";
            // 
            // nav_Home
            // 
            nav_Home.Margin = new Padding(200, 0, 50, 0);
            nav_Home.Name = "nav_Home";
            nav_Home.Size = new Size(67, 74);
            nav_Home.Text = "Home";
            // 
            // nav_Intro
            // 
            nav_Intro.Margin = new Padding(0, 0, 50, 0);
            nav_Intro.Name = "nav_Intro";
            nav_Intro.Size = new Size(98, 74);
            nav_Intro.Text = "Giới Thiệu";
            // 
            // nav_License
            // 
            nav_License.DropDownItems.AddRange(new ToolStripItem[] { nav_LicenseA1, nav_LicenseA2, nav_LicenseA3, nav_LicenseA4, nav_LicenseB1, nav_LicenseB2, nav_LicenseC, nav_LicenseD, nav_LicenseE, nav_LicenseFB2, nav_LicenseFC, nav_LicenseFD, nav_LicenseFE });
            nav_License.Margin = new Padding(0, 0, 50, 0);
            nav_License.Name = "nav_License";
            nav_License.Size = new Size(137, 74);
            nav_License.Text = "Đào Tạo Lái Xe";
            // 
            // nav_LicenseA1
            // 
            nav_LicenseA1.Name = "nav_LicenseA1";
            nav_LicenseA1.Size = new Size(122, 26);
            nav_LicenseA1.Text = "A1";
            // 
            // nav_LicenseA2
            // 
            nav_LicenseA2.Name = "nav_LicenseA2";
            nav_LicenseA2.Size = new Size(122, 26);
            nav_LicenseA2.Text = "A2";
            // 
            // nav_LicenseA3
            // 
            nav_LicenseA3.Name = "nav_LicenseA3";
            nav_LicenseA3.Size = new Size(122, 26);
            nav_LicenseA3.Text = "A3";
            // 
            // nav_LicenseA4
            // 
            nav_LicenseA4.Name = "nav_LicenseA4";
            nav_LicenseA4.Size = new Size(122, 26);
            nav_LicenseA4.Text = "A4";
            // 
            // nav_LicenseB1
            // 
            nav_LicenseB1.Name = "nav_LicenseB1";
            nav_LicenseB1.Size = new Size(122, 26);
            nav_LicenseB1.Text = "B1";
            // 
            // nav_LicenseB2
            // 
            nav_LicenseB2.Name = "nav_LicenseB2";
            nav_LicenseB2.Size = new Size(122, 26);
            nav_LicenseB2.Text = "B2";
            // 
            // nav_LicenseC
            // 
            nav_LicenseC.Name = "nav_LicenseC";
            nav_LicenseC.Size = new Size(122, 26);
            nav_LicenseC.Text = "C";
            // 
            // nav_LicenseD
            // 
            nav_LicenseD.Name = "nav_LicenseD";
            nav_LicenseD.Size = new Size(122, 26);
            nav_LicenseD.Text = "D";
            // 
            // nav_LicenseE
            // 
            nav_LicenseE.Name = "nav_LicenseE";
            nav_LicenseE.Size = new Size(122, 26);
            nav_LicenseE.Text = "E";
            // 
            // nav_LicenseFB2
            // 
            nav_LicenseFB2.Name = "nav_LicenseFB2";
            nav_LicenseFB2.Size = new Size(122, 26);
            nav_LicenseFB2.Text = "FB2";
            // 
            // nav_LicenseFC
            // 
            nav_LicenseFC.Name = "nav_LicenseFC";
            nav_LicenseFC.Size = new Size(122, 26);
            nav_LicenseFC.Text = "FC";
            // 
            // nav_LicenseFD
            // 
            nav_LicenseFD.Name = "nav_LicenseFD";
            nav_LicenseFD.Size = new Size(122, 26);
            nav_LicenseFD.Text = "FD";
            // 
            // nav_LicenseFE
            // 
            nav_LicenseFE.Name = "nav_LicenseFE";
            nav_LicenseFE.Size = new Size(122, 26);
            nav_LicenseFE.Text = "FE";
            // 
            // nav_Quiz
            // 
            nav_Quiz.Margin = new Padding(0, 0, 50, 0);
            nav_Quiz.Name = "nav_Quiz";
            nav_Quiz.Size = new Size(77, 74);
            nav_Quiz.Text = "Thi thử";
            // 
            // nav_Rent
            // 
            nav_Rent.Margin = new Padding(0, 0, 50, 0);
            nav_Rent.Name = "nav_Rent";
            nav_Rent.Size = new Size(85, 74);
            nav_Rent.Text = "Thuê Xe";
            // 
            // nav_Session
            // 
            nav_Session.Alignment = ToolStripItemAlignment.Right;
            nav_Session.DropDownItems.AddRange(new ToolStripItem[] { nav_Session_Logout });
            nav_Session.Margin = new Padding(50, 0, 10, 0);
            nav_Session.Name = "nav_Session";
            nav_Session.Size = new Size(106, 74);
            nav_Session.Text = "Đăng Nhập";
            nav_Session.Click += Nav_Session_Click;
            // 
            // nav_Session_Logout
            // 
            nav_Session_Logout.Name = "nav_Session_Logout";
            nav_Session_Logout.Size = new Size(172, 26);
            nav_Session_Logout.Text = "Đăng Xuất";
            nav_Session_Logout.Click += Nav_Session_Logout_Click;
            // 
            // pic_bgHome
            // 
            pic_bgHome.Dock = DockStyle.Fill;
            pic_bgHome.Image = (Image)resources.GetObject("pic_bgHome.Image");
            pic_bgHome.Location = new Point(0, 0);
            pic_bgHome.Name = "pic_bgHome";
            pic_bgHome.Size = new Size(1422, 853);
            pic_bgHome.SizeMode = PictureBoxSizeMode.CenterImage;
            pic_bgHome.TabIndex = 1;
            pic_bgHome.TabStop = false;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.ForeColor = Color.Red;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(67, 74);
            exitToolStripMenuItem.Text = "Thoát";
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 853);
            Controls.Add(panel_Home);
            Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = navbar;
            Name = "FrmHome";
            Text = "Learn2Drive - Home";
            Load += FrmHome_Load;
            Resize += FrmHome_Resize;
            panel_Home.ResumeLayout(false);
            panel_Home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_logo).EndInit();
            navbar.ResumeLayout(false);
            navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_bgHome).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Home;
        private PictureBox pic_bgHome;
        private MenuStrip navbar;
        private ToolStripMenuItem nav_Home;
        private ToolStripMenuItem nav_Intro;
        private ToolStripMenuItem nav_License;
        private ToolStripMenuItem nav_LicenseA1;
        private ToolStripMenuItem nav_LicenseA2;
        private ToolStripMenuItem nav_LicenseA3;
        private ToolStripMenuItem nav_LicenseA4;
        private ToolStripMenuItem nav_LicenseB1;
        private ToolStripMenuItem nav_LicenseB2;
        private ToolStripMenuItem nav_LicenseC;
        private ToolStripMenuItem nav_LicenseD;
        private ToolStripMenuItem nav_LicenseE;
        private ToolStripMenuItem nav_LicenseFB2;
        private ToolStripMenuItem nav_Quiz;
        private ToolStripMenuItem nav_Rent;
        private ToolStripMenuItem nav_Session;
        private PictureBox pic_logo;
        private ToolStripMenuItem nav_Session_Logout;
        private ToolStripMenuItem nav_LicenseFC;
        private ToolStripMenuItem nav_LicenseFD;
        private ToolStripMenuItem nav_LicenseFE;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}