using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoSystem
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            lblwelcome.Text = "Welcome, " + CurrentUser.Name;
        }
        private void Button_MouseHover(object sender, EventArgs e)
        {
            PictureBox ctrl = sender as PictureBox;

            if (ctrl != null)
            {
                ctrl.BorderStyle = BorderStyle.FixedSingle;
                ctrl.Cursor = Cursors.Hand;
            }

        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            PictureBox ctrl = sender as PictureBox;
            if (ctrl != null)
            {
                ctrl.BorderStyle = BorderStyle.Fixed3D;
                ctrl.Cursor = Cursors.Default;
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 loginForm = new Form1();
            loginForm.Show();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            admin1.BringToFront();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            dashboard1.BringToFront();

        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            admin_Teacher1.BringToFront();
        }
    }
}
