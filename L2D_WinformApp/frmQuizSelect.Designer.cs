namespace L2D_WinformApp
{
    partial class frmQuizSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuizSelect));
            gbSearch = new GroupBox();
            btnClearFilter = new Button();
            cbDone = new CheckBox();
            btnSearch = new Button();
            cbLicense = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            txtKeyword = new TextBox();
            gbQuizList = new GroupBox();
            btnAttempt = new Button();
            dgvQuizzes = new DataGridView();
            gbQuizDetails = new GroupBox();
            txtLicense = new TextBox();
            txtQuizName = new TextBox();
            lbLicense = new Label();
            lbQuizName = new Label();
            lbDescription = new Label();
            txtDescription = new TextBox();
            pic_logo = new PictureBox();
            gbSearch.SuspendLayout();
            gbQuizList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQuizzes).BeginInit();
            gbQuizDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_logo).BeginInit();
            SuspendLayout();
            // 
            // gbSearch
            // 
            gbSearch.Controls.Add(btnClearFilter);
            gbSearch.Controls.Add(cbDone);
            gbSearch.Controls.Add(btnSearch);
            gbSearch.Controls.Add(cbLicense);
            gbSearch.Controls.Add(label2);
            gbSearch.Controls.Add(label1);
            gbSearch.Controls.Add(txtKeyword);
            gbSearch.ForeColor = SystemColors.ActiveCaptionText;
            gbSearch.Location = new Point(24, 62);
            gbSearch.Margin = new Padding(3, 4, 3, 4);
            gbSearch.Name = "gbSearch";
            gbSearch.Padding = new Padding(3, 4, 3, 4);
            gbSearch.Size = new Size(594, 295);
            gbSearch.TabIndex = 0;
            gbSearch.TabStop = false;
            gbSearch.Text = "Tìm kiếm";
            // 
            // btnClearFilter
            // 
            btnClearFilter.ForeColor = Color.Red;
            btnClearFilter.Location = new Point(352, 206);
            btnClearFilter.Margin = new Padding(3, 4, 3, 4);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(106, 30);
            btnClearFilter.TabIndex = 6;
            btnClearFilter.Text = "Xóa bộ lọc";
            btnClearFilter.UseVisualStyleBackColor = true;
            // 
            // cbDone
            // 
            cbDone.AutoSize = true;
            cbDone.Location = new Point(137, 154);
            cbDone.Margin = new Padding(3, 4, 3, 4);
            cbDone.Name = "cbDone";
            cbDone.Size = new Size(85, 25);
            cbDone.TabIndex = 5;
            cbDone.Text = "Đã làm";
            cbDone.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(137, 206);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(170, 30);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // cbLicense
            // 
            cbLicense.FormattingEnabled = true;
            cbLicense.Items.AddRange(new object[] { "A1", "A2", "A3", "A4", "B1", "B2" });
            cbLicense.Location = new Point(137, 100);
            cbLicense.Margin = new Padding(3, 4, 3, 4);
            cbLicense.Name = "cbLicense";
            cbLicense.Size = new Size(169, 29);
            cbLicense.TabIndex = 3;
            cbLicense.Text = "Chọn loại bằng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 108);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 2;
            label2.Text = "Loại bằng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 47);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 1;
            label1.Text = "Tên bộ đề";
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(137, 47);
            txtKeyword.Margin = new Padding(3, 4, 3, 4);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.PlaceholderText = "Nhập tên bộ đề cần tìm";
            txtKeyword.Size = new Size(409, 28);
            txtKeyword.TabIndex = 0;
            // 
            // gbQuizList
            // 
            gbQuizList.Controls.Add(btnAttempt);
            gbQuizList.Controls.Add(dgvQuizzes);
            gbQuizList.Location = new Point(24, 381);
            gbQuizList.Margin = new Padding(3, 4, 3, 4);
            gbQuizList.Name = "gbQuizList";
            gbQuizList.Padding = new Padding(3, 4, 3, 4);
            gbQuizList.Size = new Size(1188, 516);
            gbQuizList.TabIndex = 1;
            gbQuizList.TabStop = false;
            gbQuizList.Text = "Danh sách đề";
            // 
            // btnAttempt
            // 
            btnAttempt.Font = new Font("Tahoma", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnAttempt.ForeColor = Color.Red;
            btnAttempt.Location = new Point(1035, 214);
            btnAttempt.Margin = new Padding(3, 4, 3, 4);
            btnAttempt.Name = "btnAttempt";
            btnAttempt.Size = new Size(106, 83);
            btnAttempt.TabIndex = 1;
            btnAttempt.Text = "Làm";
            btnAttempt.UseVisualStyleBackColor = true;
            // 
            // dgvQuizzes
            // 
            dgvQuizzes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvQuizzes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuizzes.Location = new Point(17, 37);
            dgvQuizzes.Margin = new Padding(3, 4, 3, 4);
            dgvQuizzes.Name = "dgvQuizzes";
            dgvQuizzes.ReadOnly = true;
            dgvQuizzes.RowHeadersWidth = 51;
            dgvQuizzes.RowTemplate.Height = 29;
            dgvQuizzes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQuizzes.Size = new Size(982, 441);
            dgvQuizzes.TabIndex = 0;
            // 
            // gbQuizDetails
            // 
            gbQuizDetails.Controls.Add(txtLicense);
            gbQuizDetails.Controls.Add(txtQuizName);
            gbQuizDetails.Controls.Add(lbLicense);
            gbQuizDetails.Controls.Add(lbQuizName);
            gbQuizDetails.Controls.Add(lbDescription);
            gbQuizDetails.Controls.Add(txtDescription);
            gbQuizDetails.Location = new Point(650, 62);
            gbQuizDetails.Margin = new Padding(3, 4, 3, 4);
            gbQuizDetails.Name = "gbQuizDetails";
            gbQuizDetails.Padding = new Padding(3, 4, 3, 4);
            gbQuizDetails.Size = new Size(893, 295);
            gbQuizDetails.TabIndex = 2;
            gbQuizDetails.TabStop = false;
            gbQuizDetails.Text = "Thông tin đề";
            // 
            // txtLicense
            // 
            txtLicense.Location = new Point(152, 108);
            txtLicense.Margin = new Padding(3, 4, 3, 4);
            txtLicense.Name = "txtLicense";
            txtLicense.ReadOnly = true;
            txtLicense.Size = new Size(140, 28);
            txtLicense.TabIndex = 5;
            // 
            // txtQuizName
            // 
            txtQuizName.Location = new Point(152, 55);
            txtQuizName.Margin = new Padding(3, 4, 3, 4);
            txtQuizName.Name = "txtQuizName";
            txtQuizName.ReadOnly = true;
            txtQuizName.Size = new Size(415, 28);
            txtQuizName.TabIndex = 4;
            // 
            // lbLicense
            // 
            lbLicense.AutoSize = true;
            lbLicense.Location = new Point(20, 108);
            lbLicense.Name = "lbLicense";
            lbLicense.Size = new Size(111, 21);
            lbLicense.TabIndex = 3;
            lbLicense.Text = "Hạng bằng lái";
            // 
            // lbQuizName
            // 
            lbQuizName.AutoSize = true;
            lbQuizName.Location = new Point(20, 55);
            lbQuizName.Name = "lbQuizName";
            lbQuizName.Size = new Size(85, 21);
            lbQuizName.TabIndex = 2;
            lbQuizName.Text = "Tên bộ đề";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(20, 169);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(52, 21);
            lbDescription.TabIndex = 1;
            lbDescription.Text = "Mô tả";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(152, 166);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(696, 111);
            txtDescription.TabIndex = 0;
            // 
            // pic_logo
            // 
            pic_logo.BackgroundImageLayout = ImageLayout.None;
            pic_logo.Image = (Image)resources.GetObject("pic_logo.Image");
            pic_logo.Location = new Point(24, 12);
            pic_logo.Name = "pic_logo";
            pic_logo.Size = new Size(172, 43);
            pic_logo.SizeMode = PictureBoxSizeMode.AutoSize;
            pic_logo.TabIndex = 3;
            pic_logo.TabStop = false;
            // 
            // frmQuizSelect
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1555, 896);
            Controls.Add(pic_logo);
            Controls.Add(gbQuizDetails);
            Controls.Add(gbQuizList);
            Controls.Add(gbSearch);
            Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmQuizSelect";
            Text = "L2D - Thi thử";
            gbSearch.ResumeLayout(false);
            gbSearch.PerformLayout();
            gbQuizList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQuizzes).EndInit();
            gbQuizDetails.ResumeLayout(false);
            gbQuizDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbSearch;
        private TextBox txtKeyword;
        private Label label2;
        private Label label1;
        private ComboBox cbLicense;
        private Button btnSearch;
        private GroupBox gbQuizList;
        private Button btnAttempt;
        private DataGridView dgvQuizzes;
        private GroupBox gbQuizDetails;
        private TextBox txtQuizName;
        private Label lbLicense;
        private Label lbQuizName;
        private Label lbDescription;
        private TextBox txtDescription;
        private CheckBox cbDone;
        private TextBox txtLicense;
        private Button btnClearFilter;
        private PictureBox pic_logo;
    }
}