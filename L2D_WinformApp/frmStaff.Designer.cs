namespace L2D_WinformApp
{
    partial class frmStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaff));
            staffMenuStrip = new MenuStrip();
            InfoToolStripMenuItem = new ToolStripMenuItem();
            QuestionsToolStripMenuItem = new ToolStripMenuItem();
            QuizzesToolStripMenuItem = new ToolStripMenuItem();
            staffMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // staffMenuStrip
            // 
            staffMenuStrip.ImageScalingSize = new Size(20, 20);
            staffMenuStrip.Items.AddRange(new ToolStripItem[] { InfoToolStripMenuItem, QuestionsToolStripMenuItem, QuizzesToolStripMenuItem });
            staffMenuStrip.Location = new Point(0, 0);
            staffMenuStrip.Name = "staffMenuStrip";
            staffMenuStrip.Padding = new Padding(7, 2, 0, 2);
            staffMenuStrip.Size = new Size(1555, 28);
            staffMenuStrip.TabIndex = 0;
            staffMenuStrip.Text = "menuStrip1";
            // 
            // InfoToolStripMenuItem
            // 
            InfoToolStripMenuItem.Name = "InfoToolStripMenuItem";
            InfoToolStripMenuItem.Size = new Size(86, 24);
            InfoToolStripMenuItem.Text = "Thông tin";
            // 
            // QuestionsToolStripMenuItem
            // 
            QuestionsToolStripMenuItem.Name = "QuestionsToolStripMenuItem";
            QuestionsToolStripMenuItem.Size = new Size(148, 24);
            QuestionsToolStripMenuItem.Text = "Ngân hàng câu hỏi";
            // 
            // QuizzesToolStripMenuItem
            // 
            QuizzesToolStripMenuItem.Name = "QuizzesToolStripMenuItem";
            QuizzesToolStripMenuItem.Size = new Size(62, 24);
            QuizzesToolStripMenuItem.Text = "Bộ đề";
            // 
            // frmStaff
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1555, 896);
            Controls.Add(staffMenuStrip);
            Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = staffMenuStrip;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmStaff";
            Text = "L2D - Nhân Viên";
            staffMenuStrip.ResumeLayout(false);
            staffMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip staffMenuStrip;
        private ToolStripMenuItem InfoToolStripMenuItem;
        private ToolStripMenuItem QuestionsToolStripMenuItem;
        private ToolStripMenuItem QuizzesToolStripMenuItem;
    }
}