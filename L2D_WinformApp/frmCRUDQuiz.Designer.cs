namespace L2D_WinformApp
{
    partial class frmCRUDQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCRUDQuiz));
            pic_logo = new PictureBox();
            gbQuizDetails = new GroupBox();
            txtLicense = new TextBox();
            txtQuizName = new TextBox();
            lbLicense = new Label();
            lbQuizName = new Label();
            lbDescription = new Label();
            txtDescription = new TextBox();
            gbSearch = new GroupBox();
            btnClearFilter = new Button();
            btnSearch = new Button();
            cbLicense = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            txtKeyword = new TextBox();
            gbQuizList = new GroupBox();
            dgvQuizzes = new DataGridView();
            gbFunctions = new GroupBox();
            btnDelete = new Button();
            btnAdd = new Button();
            tcQuizControl = new TabControl();
            tpQuiz = new TabPage();
            tpQuestions = new TabPage();
            gbQuizTask = new GroupBox();
            cbQuestionLicense = new ComboBox();
            label3 = new Label();
            lbQuestionKeyword = new Label();
            txtQuestionKeyword = new TextBox();
            btnRemoveQuestion = new Button();
            btnAddQuestion = new Button();
            gbQuestions = new GroupBox();
            dgvQuestions = new DataGridView();
            btnSearchQuestions = new Button();
            gbFilterQuestions = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pic_logo).BeginInit();
            gbQuizDetails.SuspendLayout();
            gbSearch.SuspendLayout();
            gbQuizList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQuizzes).BeginInit();
            gbFunctions.SuspendLayout();
            tcQuizControl.SuspendLayout();
            tpQuiz.SuspendLayout();
            tpQuestions.SuspendLayout();
            gbQuizTask.SuspendLayout();
            gbQuestions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQuestions).BeginInit();
            gbFilterQuestions.SuspendLayout();
            SuspendLayout();
            // 
            // pic_logo
            // 
            pic_logo.BackgroundImageLayout = ImageLayout.None;
            pic_logo.Image = (Image)resources.GetObject("pic_logo.Image");
            pic_logo.Location = new Point(14, 13);
            pic_logo.Margin = new Padding(3, 4, 3, 4);
            pic_logo.Name = "pic_logo";
            pic_logo.Size = new Size(172, 43);
            pic_logo.SizeMode = PictureBoxSizeMode.AutoSize;
            pic_logo.TabIndex = 6;
            pic_logo.TabStop = false;
            // 
            // gbQuizDetails
            // 
            gbQuizDetails.Controls.Add(txtLicense);
            gbQuizDetails.Controls.Add(txtQuizName);
            gbQuizDetails.Controls.Add(lbLicense);
            gbQuizDetails.Controls.Add(lbQuizName);
            gbQuizDetails.Controls.Add(lbDescription);
            gbQuizDetails.Controls.Add(txtDescription);
            gbQuizDetails.Location = new Point(33, 8);
            gbQuizDetails.Margin = new Padding(3, 5, 3, 5);
            gbQuizDetails.Name = "gbQuizDetails";
            gbQuizDetails.Padding = new Padding(3, 5, 3, 5);
            gbQuizDetails.Size = new Size(705, 275);
            gbQuizDetails.TabIndex = 5;
            gbQuizDetails.TabStop = false;
            gbQuizDetails.Text = "Thông tin đề";
            // 
            // txtLicense
            // 
            txtLicense.Location = new Point(171, 113);
            txtLicense.Margin = new Padding(3, 5, 3, 5);
            txtLicense.Name = "txtLicense";
            txtLicense.ReadOnly = true;
            txtLicense.Size = new Size(157, 28);
            txtLicense.TabIndex = 5;
            // 
            // txtQuizName
            // 
            txtQuizName.Location = new Point(171, 58);
            txtQuizName.Margin = new Padding(3, 5, 3, 5);
            txtQuizName.Name = "txtQuizName";
            txtQuizName.ReadOnly = true;
            txtQuizName.Size = new Size(466, 28);
            txtQuizName.TabIndex = 4;
            // 
            // lbLicense
            // 
            lbLicense.AutoSize = true;
            lbLicense.Location = new Point(22, 114);
            lbLicense.Name = "lbLicense";
            lbLicense.Size = new Size(111, 21);
            lbLicense.TabIndex = 3;
            lbLicense.Text = "Hạng bằng lái";
            // 
            // lbQuizName
            // 
            lbQuizName.AutoSize = true;
            lbQuizName.Location = new Point(22, 58);
            lbQuizName.Name = "lbQuizName";
            lbQuizName.Size = new Size(85, 21);
            lbQuizName.TabIndex = 2;
            lbQuizName.Text = "Tên bộ đề";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(22, 178);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(52, 21);
            lbDescription.TabIndex = 1;
            lbDescription.Text = "Mô tả";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(171, 174);
            txtDescription.Margin = new Padding(3, 5, 3, 5);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(466, 84);
            txtDescription.TabIndex = 0;
            // 
            // gbSearch
            // 
            gbSearch.Controls.Add(btnClearFilter);
            gbSearch.Controls.Add(btnSearch);
            gbSearch.Controls.Add(cbLicense);
            gbSearch.Controls.Add(label2);
            gbSearch.Controls.Add(label1);
            gbSearch.Controls.Add(txtKeyword);
            gbSearch.ForeColor = SystemColors.ActiveCaptionText;
            gbSearch.Location = new Point(224, 293);
            gbSearch.Margin = new Padding(3, 5, 3, 5);
            gbSearch.Name = "gbSearch";
            gbSearch.Padding = new Padding(3, 5, 3, 5);
            gbSearch.Size = new Size(514, 261);
            gbSearch.TabIndex = 4;
            gbSearch.TabStop = false;
            gbSearch.Text = "Bộ lọc";
            // 
            // btnClearFilter
            // 
            btnClearFilter.ForeColor = Color.Red;
            btnClearFilter.Location = new Point(370, 168);
            btnClearFilter.Margin = new Padding(3, 5, 3, 5);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(119, 31);
            btnClearFilter.TabIndex = 6;
            btnClearFilter.Text = "Xóa bộ lọc";
            btnClearFilter.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(153, 168);
            btnSearch.Margin = new Padding(3, 5, 3, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(191, 31);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // cbLicense
            // 
            cbLicense.FormattingEnabled = true;
            cbLicense.Items.AddRange(new object[] { "A1", "A2", "A3", "A4", "B1", "B2" });
            cbLicense.Location = new Point(154, 105);
            cbLicense.Margin = new Padding(3, 5, 3, 5);
            cbLicense.Name = "cbLicense";
            cbLicense.Size = new Size(190, 29);
            cbLicense.TabIndex = 3;
            cbLicense.Text = "Chọn loại bằng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 114);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 2;
            label2.Text = "Loại bằng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 50);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 1;
            label1.Text = "Tên bộ đề";
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(154, 49);
            txtKeyword.Margin = new Padding(3, 5, 3, 5);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.PlaceholderText = "Nhập tên bộ đề cần tìm";
            txtKeyword.Size = new Size(348, 28);
            txtKeyword.TabIndex = 0;
            // 
            // gbQuizList
            // 
            gbQuizList.Controls.Add(dgvQuizzes);
            gbQuizList.Location = new Point(14, 80);
            gbQuizList.Margin = new Padding(3, 4, 3, 4);
            gbQuizList.Name = "gbQuizList";
            gbQuizList.Padding = new Padding(3, 4, 3, 4);
            gbQuizList.Size = new Size(557, 698);
            gbQuizList.TabIndex = 7;
            gbQuizList.TabStop = false;
            gbQuizList.Text = "Danh sách đề";
            // 
            // dgvQuizzes
            // 
            dgvQuizzes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvQuizzes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuizzes.Location = new Point(19, 51);
            dgvQuizzes.Margin = new Padding(3, 4, 3, 4);
            dgvQuizzes.Name = "dgvQuizzes";
            dgvQuizzes.ReadOnly = true;
            dgvQuizzes.RowHeadersWidth = 51;
            dgvQuizzes.RowTemplate.Height = 29;
            dgvQuizzes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQuizzes.Size = new Size(518, 628);
            dgvQuizzes.TabIndex = 0;
            // 
            // gbFunctions
            // 
            gbFunctions.Controls.Add(btnDelete);
            gbFunctions.Controls.Add(btnAdd);
            gbFunctions.Location = new Point(33, 293);
            gbFunctions.Margin = new Padding(3, 4, 3, 4);
            gbFunctions.Name = "gbFunctions";
            gbFunctions.Padding = new Padding(3, 4, 3, 4);
            gbFunctions.Size = new Size(171, 261);
            gbFunctions.TabIndex = 8;
            gbFunctions.TabStop = false;
            gbFunctions.Text = "Chức năng";
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(30, 169);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(106, 30);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa đề";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(30, 63);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(106, 30);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm đề";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // tcQuizControl
            // 
            tcQuizControl.Controls.Add(tpQuiz);
            tcQuizControl.Controls.Add(tpQuestions);
            tcQuizControl.Location = new Point(590, 80);
            tcQuizControl.Name = "tcQuizControl";
            tcQuizControl.SelectedIndex = 0;
            tcQuizControl.Size = new Size(840, 698);
            tcQuizControl.TabIndex = 9;
            // 
            // tpQuiz
            // 
            tpQuiz.Controls.Add(gbFunctions);
            tpQuiz.Controls.Add(gbQuizDetails);
            tpQuiz.Controls.Add(gbSearch);
            tpQuiz.Location = new Point(4, 30);
            tpQuiz.Name = "tpQuiz";
            tpQuiz.Padding = new Padding(3);
            tpQuiz.Size = new Size(832, 664);
            tpQuiz.TabIndex = 0;
            tpQuiz.Text = "Đề";
            tpQuiz.UseVisualStyleBackColor = true;
            // 
            // tpQuestions
            // 
            tpQuestions.Controls.Add(gbFilterQuestions);
            tpQuestions.Controls.Add(gbQuizTask);
            tpQuestions.Controls.Add(gbQuestions);
            tpQuestions.Location = new Point(4, 30);
            tpQuestions.Name = "tpQuestions";
            tpQuestions.Padding = new Padding(3);
            tpQuestions.Size = new Size(832, 664);
            tpQuestions.TabIndex = 1;
            tpQuestions.Text = "Câu hỏi";
            tpQuestions.UseVisualStyleBackColor = true;
            // 
            // gbQuizTask
            // 
            gbQuizTask.Controls.Add(btnRemoveQuestion);
            gbQuizTask.Controls.Add(btnAddQuestion);
            gbQuizTask.Location = new Point(28, 357);
            gbQuizTask.Name = "gbQuizTask";
            gbQuizTask.Size = new Size(182, 222);
            gbQuizTask.TabIndex = 2;
            gbQuizTask.TabStop = false;
            gbQuizTask.Text = "Thao tác";
            // 
            // cbQuestionLicense
            // 
            cbQuestionLicense.FormattingEnabled = true;
            cbQuestionLicense.Items.AddRange(new object[] { "A1", "A2", "A3", "A4", "B1", "B2" });
            cbQuestionLicense.Location = new Point(154, 88);
            cbQuestionLicense.Name = "cbQuestionLicense";
            cbQuestionLicense.Size = new Size(137, 29);
            cbQuestionLicense.TabIndex = 5;
            cbQuestionLicense.Text = "Chọn loại bằng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 96);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 4;
            label3.Text = "Hạng bằng";
            // 
            // lbQuestionKeyword
            // 
            lbQuestionKeyword.AutoSize = true;
            lbQuestionKeyword.Location = new Point(15, 36);
            lbQuestionKeyword.Name = "lbQuestionKeyword";
            lbQuestionKeyword.Size = new Size(133, 21);
            lbQuestionKeyword.TabIndex = 3;
            lbQuestionKeyword.Text = "Nội dung câu hỏi";
            // 
            // txtQuestionKeyword
            // 
            txtQuestionKeyword.Location = new Point(154, 32);
            txtQuestionKeyword.Name = "txtQuestionKeyword";
            txtQuestionKeyword.PlaceholderText = "Nhập nội dung câu hỏi cần tìm";
            txtQuestionKeyword.Size = new Size(318, 28);
            txtQuestionKeyword.TabIndex = 2;
            // 
            // btnRemoveQuestion
            // 
            btnRemoveQuestion.ForeColor = Color.Red;
            btnRemoveQuestion.Location = new Point(13, 125);
            btnRemoveQuestion.Name = "btnRemoveQuestion";
            btnRemoveQuestion.Size = new Size(155, 29);
            btnRemoveQuestion.TabIndex = 1;
            btnRemoveQuestion.Text = "Xóa câu hỏi";
            btnRemoveQuestion.UseVisualStyleBackColor = true;
            // 
            // btnAddQuestion
            // 
            btnAddQuestion.Location = new Point(13, 65);
            btnAddQuestion.Name = "btnAddQuestion";
            btnAddQuestion.Size = new Size(155, 29);
            btnAddQuestion.TabIndex = 0;
            btnAddQuestion.Text = "Thêm câu hỏi";
            btnAddQuestion.UseVisualStyleBackColor = true;
            // 
            // gbQuestions
            // 
            gbQuestions.Controls.Add(dgvQuestions);
            gbQuestions.Location = new Point(28, 21);
            gbQuestions.Name = "gbQuestions";
            gbQuestions.Size = new Size(709, 312);
            gbQuestions.TabIndex = 1;
            gbQuestions.TabStop = false;
            gbQuestions.Text = "Danh sách câu hỏi đề ...";
            // 
            // dgvQuestions
            // 
            dgvQuestions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvQuestions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuestions.Location = new Point(13, 29);
            dgvQuestions.Name = "dgvQuestions";
            dgvQuestions.ReadOnly = true;
            dgvQuestions.RowHeadersWidth = 51;
            dgvQuestions.RowTemplate.Height = 29;
            dgvQuestions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQuestions.Size = new Size(683, 267);
            dgvQuestions.TabIndex = 0;
            // 
            // btnSearchQuestions
            // 
            btnSearchQuestions.Location = new Point(154, 148);
            btnSearchQuestions.Name = "btnSearchQuestions";
            btnSearchQuestions.Size = new Size(137, 29);
            btnSearchQuestions.TabIndex = 6;
            btnSearchQuestions.Text = "Tìm câu hỏi";
            btnSearchQuestions.UseVisualStyleBackColor = true;
            // 
            // gbFilterQuestions
            // 
            gbFilterQuestions.Controls.Add(lbQuestionKeyword);
            gbFilterQuestions.Controls.Add(btnSearchQuestions);
            gbFilterQuestions.Controls.Add(txtQuestionKeyword);
            gbFilterQuestions.Controls.Add(label3);
            gbFilterQuestions.Controls.Add(cbQuestionLicense);
            gbFilterQuestions.Location = new Point(225, 357);
            gbFilterQuestions.Name = "gbFilterQuestions";
            gbFilterQuestions.Size = new Size(512, 222);
            gbFilterQuestions.TabIndex = 7;
            gbFilterQuestions.TabStop = false;
            gbFilterQuestions.Text = "Bộ lọc";
            // 
            // frmCRUDQuiz
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1442, 791);
            Controls.Add(tcQuizControl);
            Controls.Add(gbQuizList);
            Controls.Add(pic_logo);
            Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCRUDQuiz";
            Text = "L2D - Quản lý bộ đề";
            ((System.ComponentModel.ISupportInitialize)pic_logo).EndInit();
            gbQuizDetails.ResumeLayout(false);
            gbQuizDetails.PerformLayout();
            gbSearch.ResumeLayout(false);
            gbSearch.PerformLayout();
            gbQuizList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQuizzes).EndInit();
            gbFunctions.ResumeLayout(false);
            tcQuizControl.ResumeLayout(false);
            tpQuiz.ResumeLayout(false);
            tpQuestions.ResumeLayout(false);
            gbQuizTask.ResumeLayout(false);
            gbQuestions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQuestions).EndInit();
            gbFilterQuestions.ResumeLayout(false);
            gbFilterQuestions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pic_logo;
        private GroupBox gbQuizDetails;
        private TextBox txtLicense;
        private TextBox txtQuizName;
        private Label lbLicense;
        private Label lbQuizName;
        private Label lbDescription;
        private TextBox txtDescription;
        private GroupBox gbSearch;
        private Button btnClearFilter;
        private Button btnSearch;
        private ComboBox cbLicense;
        private Label label2;
        private Label label1;
        private TextBox txtKeyword;
        private GroupBox gbQuizList;
        private DataGridView dgvQuizzes;
        private GroupBox gbFunctions;
        private Button btnDelete;
        private Button btnAdd;
        private TabControl tcQuizControl;
        private TabPage tpQuiz;
        private TabPage tpQuestions;
        private GroupBox gbQuestions;
        private DataGridView dgvQuestions;
        private GroupBox gbQuizTask;
        private Button btnAddQuestion;
        private Button btnRemoveQuestion;
        private TextBox txtQuestionKeyword;
        private Label lbQuestionKeyword;
        private ComboBox cbQuestionLicense;
        private Label label3;
        private Button btnSearchQuestions;
        private GroupBox gbFilterQuestions;
    }
}