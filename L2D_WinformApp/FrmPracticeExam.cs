using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L2D_WinformApp
{
    public partial class FrmPracticeExam : Form
    {
        //==================================[ Declare ]==================================
        private User SessionUser;
        private Quiz QuizChose;
        private int durationTime = 5;
        //===============================[ Form Settings ]===============================
        public FrmPracticeExam()
        {
            InitializeComponent();
        }
        private void FrmPracticeExam_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            MaximizeScreenMode(this);
            //SetDuration("motor");
            timerPE.Start();
        }
        public static void MaximizeScreenMode(Form targetForm)
        {
            targetForm.WindowState = FormWindowState.Maximized;
        }

        //==================================[ Buttons ]==================================
        private void Btn_Finish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TimerPE_Tick(object sender, EventArgs e)
        {
            durationTime--;
            UpdateTextTime();
            if (durationTime == 0)
            {
                timerPE.Stop();
                return;
            }
        }
        private void SetDuration(string LicenseType)
        {
            if (LicenseType.Equals("motor"))
            {
                durationTime = 1200;//20 minutes
                return;
            }
            durationTime = 1320;//22 minutes
        }
        private void UpdateTextTime()
        {
            int minutes = durationTime / 60;
            int seconds = durationTime % 60;

            txt_Time.Text = $"{minutes.ToString("D2")}:{seconds.ToString("D2")}";
        }

        private void btn_37_Click(object sender, EventArgs e)
        {

        }

        private void label115_Click(object sender, EventArgs e)
        {

        }
    }
}
