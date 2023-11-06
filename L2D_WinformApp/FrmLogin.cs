using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObjects.Models;
using DataAccess.Repository;
using Microsoft.IdentityModel.Tokens;

namespace L2D_WinformApp
{
    public partial class FrmLogin : Form
    {
        //==================================[ Declare ]==================================
        public event EventHandler CloseFormEvent;
        public User SessionUser { get; set; }
        public Teacher SessionLecturer { get; set; }
        public Staff SessionStaff { get; set; }
        public Admin SessionAdmin { get; set; }

        private IAccountRepository RepositoryAccount = new AccountRepository();
        private IUserRepository RepositoryUser = new UserRepository();
        private ILecturerRepository RepositoryLecturer = new LecturerRepository();
        private IStaffRepository RepositoryStaff = new StaffRepository();
        private IAdminRepository RepositoryAdmin = new AdminRepository();

        private bool isLoginUI;

        //===============================[ Form Settings ]===============================
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
        private void FrmLogin_Shown(object sender, EventArgs e)
        {
            DisplayUI("login");
            isLoginUI = true;
        }

        //==================================[ Buttons ]==================================
        private void Btn_Accept_Click(object sender, EventArgs e)
        {
            if (btn_Accept.Text.Equals("Đăng nhập"))
            {
                Login();
            }
            else//Sign Up
            {
                Signup();
            }
            panel_Login.Focus();
        }
        private void Btn_ShowHideP_Click(object sender, EventArgs e)
        {
            bool isHidingPassword = txt_Password.UseSystemPasswordChar;
            if (isHidingPassword)
            {
                btn_ShowHideP.Text = "𓁺";
            }
            else
            {
                btn_ShowHideP.Text = "👁";
            }
            txt_Password.UseSystemPasswordChar = !isHidingPassword;
        }

        private void Btn_ShowHideReP_Click(object sender, EventArgs e)
        {
            bool isHidingPassword = txt_Repass.UseSystemPasswordChar;
            if (isHidingPassword)
            {
                btn_ShowHideReP.Text = "𓁺";
            }
            else
            {
                btn_ShowHideReP.Text = "👁";
            }
            txt_Repass.UseSystemPasswordChar = !isHidingPassword;
        }

        private void Btn_clearU_Click(object sender, EventArgs e)
        {
            txt_Username.Clear();
        }

        private void Btn_clearN_Click(object sender, EventArgs e)
        {
            txt_Fullname.Clear();
        }

        private void Btn_clearE_Click(object sender, EventArgs e)
        {
            txt_Email.Clear();
        }

        private void Btn_ForgotPass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xóa ứng dụng! :)", "Gợi Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Btn_ChangeSign_Click(object sender, EventArgs e)
        {
            ResetInputExcept("none");
            changeUI();
            panel_Login.Focus();
        }

        //===============================[ Other Events ]================================
        private void Txt_Username_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Username.Text))
            {
                btn_clearU.Visible = false;
            }
            else
            {
                btn_clearU.Visible = true;
            }
        }

        private void Txt_Password_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Password.Text))
            {
                btn_ShowHideP.Visible = false;
            }
            else
            {
                btn_ShowHideP.Visible = true;
            }
        }

        private void Txt_Repass_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Repass.Text))
            {
                btn_ShowHideReP.Visible = false;
            }
            else
            {
                btn_ShowHideReP.Visible = true;
            }
        }
        private void Txt_Fullname_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Fullname.Text))
            {
                btn_clearN.Visible = false;
            }
            else
            {
                btn_clearN.Visible = true;
            }
        }
        private void Txt_Email_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Email.Text))
            {
                btn_clearE.Visible = false;
            }
            else
            {
                btn_clearE.Visible = true;
            }
        }

        private void Txt_Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Password.Focus();
            }
        }
        private void Txt_Password_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (btn_Accept.Text.Equals("Đăng nhập"))
                {
                    btn_Accept.PerformClick();
                }
                else
                {
                    txt_Repass.Focus();
                }
            }
        }

        private void Txt_Repass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Fullname.Focus();
            }
        }

        private void Txt_Fullname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Email.Focus();
            }
        }

        private void Txt_Email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Accept.PerformClick();
                panel_Login.Focus();
            }
        }
        private void Panel_Login_Click(object sender, EventArgs e)
        {
            panel_Login.Focus();
        }


        //==================================[ Others ]===================================
        private void Login()
        {
            if (InputIsNull("Login") == true)
            {
                MessageBox.Show("Có ô dữ liệu chưa điền!\nXin vui lòng thử lại và điền đầy đủ các ô!", "Lỗi Điền Đơn", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Account account = RepositoryAccount.Login(txt_Username.Text, txt_Password.Text);
            if (account != null)
            {
                RoleDivision(account);
                //ResetInputExcept("username");
                this.Close();
                this.CloseFormEvent?.Invoke(this, EventArgs.Empty);
                return;
            }
            MessageBox.Show("Sai thông tin đăng nhập!\nXin vui lòng thử lại hoặc bấm \"Quên mật khẩu?\" để gợi ý!", "Lỗi Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void Signup()
        {
            if (InputIsNull("SignUp") == true)
            {
                MessageBox.Show("Có ô dữ liệu chưa điền!\nXin vui lòng thử lại và điền đầy đủ các ô!", "Lỗi Điền Đơn", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!txt_Repass.Text.Equals(txt_Password.Text))
            {
                MessageBox.Show("Mật khẩu điền lại chưa khớp!\nXin vui lòng thử lại và đảm bảo nhập mật khẩu\nkhớp với mật khẩu xác nhận lại!", "Lỗi Cài Mật Khẩu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (RepositoryAccount.CheckExistUsername(txt_Username.Text) == false)
            {
                RepositoryAccount.SignUp(txt_Username.Text, txt_Password.Text, txt_Email.Text, txt_Fullname.Text);
                return;
            }
            MessageBox.Show("Tài khoản đã tồn tại!\nXin vui lòng thử lại với tên tài khoản khác!", "Lỗi Trùng Tài Khoản", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void RoleDivision(Account acc)
        {
            SessionUser = null;
            SessionLecturer = null;
            SessionStaff = null;
            SessionAdmin = null;

            switch (acc.Role)
            {
                case "user":
                    SessionUser = RepositoryUser.GetUserById(Guid.Empty, acc.AccountId);
                    break;
                case "lecturer":
                    SessionLecturer = RepositoryLecturer.GetLecturerById(Guid.Empty, acc.AccountId);
                    break;
                case "staff":
                    break;
                case "admin":
                    break;
            }
        }

        private void ResetInputExcept(string whichTXT)
        {
            if (!whichTXT.Equals("username"))
            {
                txt_Username.Clear();
            }
            txt_Password.Clear();
            txt_Repass.Clear();
            txt_Fullname.Clear();
            txt_Email.Clear();
        }

        private bool InputIsNull(string Sign_Up_In)
        {
            if (txt_Username.Text.IsNullOrEmpty() || txt_Password.Text.IsNullOrEmpty())
            {
                return true;
            }

            if (Sign_Up_In.Equals("SignUp"))
            {
                if (txt_Repass.Text.IsNullOrEmpty() || txt_Fullname.Text.IsNullOrEmpty() || txt_Email.Text.IsNullOrEmpty())
                {
                    return true;
                }
            }
            return false;

        }

        private void DisplayUI(string UI)
        {
            if (UI.Equals("login"))
            {
                lab_Title.Text = "Đăng Nhập";
                lab_Title.Location = new Point(147, 55);

                btn_Accept.Text = "Đăng nhập";
                btn_Accept.Size = new Size(140, 30);
                btn_Accept.Location = new Point(265, 260);

                btn_ChangeSign.Text = "Tạo tài khoản";
                btn_ChangeSign.Size = new Size(140, 30);
                btn_ChangeSign.Location = new Point(95, 260);

                txt_Repass.Visible = false;
                txt_Fullname.Visible = false;
                txt_Email.Visible = false;

                btn_ForgotPass.Visible = true;
                btn_ForgotPass.Location = new Point(177, 320);
                return;
            }

            lab_Title.Text = "Đăng Kí";
            lab_Title.Location = new Point(174, 55);

            btn_Accept.Text = "Đăng kí";
            btn_Accept.Size = new Size(100, 30);
            btn_Accept.Location = new Point(305, 440);

            btn_ChangeSign.Text = "Đăng nhập tài khoản";
            btn_ChangeSign.Size = new Size(180, 30);
            btn_ChangeSign.Location = new Point(95, 440);

            txt_Repass.Visible = true;
            txt_Fullname.Visible = true;
            txt_Email.Visible = true;

            btn_ForgotPass.Visible = false;
            btn_ForgotPass.Location = new Point(177, 320);

        }

        private void changeUI()
        {
            isLoginUI = !isLoginUI;
            if (isLoginUI)
            {
                DisplayUI("login");
            }
            else
            {
                DisplayUI("signup");
            }
        }
    }
}
