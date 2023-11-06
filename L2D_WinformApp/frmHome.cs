using BusinessObjects.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace L2D_WinformApp
{
    public partial class FrmHome : Form
    {
        //==================================[ Declare ]==================================
        private FrmLogin Authen;

        private User SessionUser;
        private Teacher SessionLecturer;

        //===============================[ Form Settings ]===============================
        public FrmHome()
        {
            InitializeComponent();
            RaiseEvent();
        }

        private void RaiseEvent()
        {
            this.nav_Quiz.Click += new System.EventHandler(nav_Quiz_Click);
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Xác nhận thoát?", "L2D", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Good bye!", "L2D", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void nav_Quiz_Click(object sender, EventArgs e)
        {
            try
            {
                var quizSelectForm = new frmQuizSelect(this.SessionUser);
                quizSelectForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "L2D", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            ReloadForm();
            MaximizeScreenMode(this);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public static void MaximizeScreenMode(Form targetForm)
        {
            targetForm.WindowState = FormWindowState.Maximized;
        }

        private void FrmHome_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) { MaximizeScreenMode(this); }
        }

        //==================================[ Buttons ]==================================
        private void Nav_Session_Click(object sender, EventArgs e)
        {
            if (nav_Session.Text.Equals("Đăng Nhập"))
            {
                if (this.Authen == null || this.Authen.IsDisposed)
                {
                    this.Authen = new FrmLogin();
                }
                this.Authen.ShowDialog();

                SessionUser = this.Authen.SessionUser;
                SessionLecturer = this.Authen.SessionLecturer;
                ReloadForm();
                return;
            }
        }

        private void Nav_Session_Logout_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn sắp đăng xuất khỏi phiên làm việc này!\nBạn có chắc muốn đăng xuất?", "Xác Nhận Đăng Xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Authen = null;
                SessionUser = null;
                SessionLecturer = null;
                ReloadForm();
            }
        }

        //==================================[ Others ]==================================
        private void ReloadForm()
        {
            if (SessionUser == null && SessionLecturer == null)
            {
                nav_Session.Text = "Đăng Nhập";
                nav_Session_Logout.Visible = false;
                return;
            }
            if (SessionUser != null)
            {
                nav_Session.Text = SessionUser.FullName;
                nav_Session_Logout.Visible = true;
                return;
            }
            if (SessionLecturer != null)
            {
                nav_Session.Text = SessionLecturer.FullName;
                nav_Session_Logout.Visible = true;
                return;
            }
        }
    }
}
