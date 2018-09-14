using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_System
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void btnPasswordChange_Click(object sender, EventArgs e)
        {
            frmPasswordChange passwordchange = new frmPasswordChange();
            passwordchange.Show();
            this.Hide();
        }

        private void btnRelogin_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblCurrentUser.Text = "ただいまのユーザーは  "+Form1.Uid+" "+"ログイン時間は  "+Form1.Time;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            frmLog log = new frmLog();
            log.Show();
            this.Hide();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            frmRegistration registration = new frmRegistration();
            registration.Show();
            this.Hide();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
