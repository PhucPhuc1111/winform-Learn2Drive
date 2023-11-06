using BusinessObjects.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L2D_WinformApp
{
    public partial class frmQuizSelect : Form
    {
        //Fields
        private readonly IQuizRepository quizRepository = new QuizRepository();
        public User UserSession { get; set; } = null;
        private Guid UserId = Guid.Empty;

        string keyword
        {
            get => txtKeyword.Text;
            set => txtKeyword.Text = value;
        }

        string licenseid
        {
            get => cbLicense.SelectedItem?.ToString();
            set => cbLicense.SelectedValue = value;
        }

        bool isDone
        {
            get => cbDone.Checked;
            set => cbDone.Checked = value;
        }

        //Constructor
        public frmQuizSelect(User sessionUser)
        {
            this.UserSession = sessionUser;
            InitializeComponent();
            AddAuthorization();
            RaiseEvent();
        }

        private void AddAuthorization()
        {
            if (UserSession is null)
            {
                cbDone.Visible = false;
                return;
            }
        }

        private void RaiseEvent()
        {
            this.Load += frmQuizSelect_Load;
            btnSearch.Click += btnSearch_Click;
            btnClearFilter.Click += btnClearFilter_Click;
            cbLicense.KeyPress += cbLicense_KeyPress;

            cbLicense.SelectedIndexChanged += cbLicense_SelectedIndexChanged;
            btnAttempt.Click += btnAttempt_Click;
        }

        private void btnAttempt_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Xác nhận vào làm đề này?", "L2D - Thi Thử", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Call attempt quiz here
            }
        }

        private void cbLicense_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadQuizList();
        }

        private void cbLicense_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Xóa bộ lọc?", "Xóa bộ lọc", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (result == DialogResult.Yes)
            {
                ClearFilter();
            }
        }

        private void ClearFilter()
        {
            txtKeyword.Clear();
            cbLicense.SelectedIndex = -1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadQuizList();
        }

        private void frmQuizSelect_Load(object sender, EventArgs e)
        {
            LoadQuizList();
        }

        private void LoadQuizList()
        {
            try
            {
                UserId = (UserSession is not null) ? UserSession.UserId : Guid.Empty;
                var dataSource = quizRepository.GetAllQuizzes(isDone, UserId, keyword, licenseid)
                    .Select(quiz => new
                    {
                        QuizId = quiz.QuizId,
                        Name = quiz.Name,
                        LicenseId = quiz.LicenseId,
                        Description = quiz.Description
                    }).ToList();
                if (dataSource.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy đề", "L2D - Thi thử", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvQuizzes.DataSource = null;
                    return;
                }
                txtQuizName.DataBindings.Clear();
                txtLicense.DataBindings.Clear();
                txtDescription.DataBindings.Clear();

                txtQuizName.DataBindings.Add("Text", dataSource, "Name");
                txtLicense.DataBindings.Add("Text", dataSource, "LicenseId");
                txtDescription.DataBindings.Add("Text", dataSource, "Description");

                dgvQuizzes.DataSource = null;
                dgvQuizzes.DataSource = dataSource;

                dgvQuizzes.Columns["QuizId"].Visible = false;
                dgvQuizzes.Columns["Name"].HeaderText = "Tên bộ đề";
                dgvQuizzes.Columns["LicenseId"].HeaderText = "Bằng lái";
                dgvQuizzes.Columns["Description"].HeaderText = "Mô tả";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Quizzes Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
