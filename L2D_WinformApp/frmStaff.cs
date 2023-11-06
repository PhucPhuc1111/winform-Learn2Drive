using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L2D_WinformApp
{
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
            RaiseEvent();
        }

        private void RaiseEvent()
        {
            InfoToolStripMenuItem.Click += infoToolStripMenuItem_Click;
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var staffInfoForm = new frmStaffInfo();
            staffInfoForm.MdiParent = this;
            staffInfoForm.Show();
        }
    }
}
