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
            btnLogout.Image = Properties.Resources._1logout;
            this.Hide();
            Form1 loginForm = new Form1();
            loginForm.Show();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            btnColorChange_Click("Student");
            admin1.BringToFront();
        }



        private void btnTeacher_Click(object sender, EventArgs e)
        {
            btnColorChange_Click("Teacher");
            admin_Teacher1.BringToFront();

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            btnColorChange_Click("Dashboard");

        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            btnColorChange_Click("Subject");
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            btnColorChange_Click("Logs");
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            btnColorChange_Click("Reports");

        }
        private void btnColorChange_Click(string Clicked)
        {
            switch (Clicked)
            {
                case "Dashboard":
                    btnDashboard.Image = Properties.Resources._1dashboard;
                    btnTeacher.Image = Properties.Resources._0teachers;
                    btnLogs.Image = Properties.Resources._0logs;
                    btnReports.Image = Properties.Resources._0reports;
                    btnStudent.Image = Properties.Resources._00students;
                    btnSubject.Image = Properties.Resources._0subjects;
                    break;
                case "Teacher":
                    btnDashboard.Image = Properties.Resources._0dashboard;
                    btnTeacher.Image = Properties.Resources._1teachers;
                    btnLogs.Image = Properties.Resources._0logs;
                    btnReports.Image = Properties.Resources._0reports;
                    btnStudent.Image = Properties.Resources._00students;
                    btnSubject.Image = Properties.Resources._0subjects;
                    break;
                case "Logs":
                    btnDashboard.Image = Properties.Resources._0dashboard;
                    btnTeacher.Image = Properties.Resources._0teachers;
                    btnLogs.Image = Properties.Resources._1logs;
                    btnReports.Image = Properties.Resources._0reports;
                    btnStudent.Image = Properties.Resources._00students;
                    btnSubject.Image = Properties.Resources._0subjects;
                    break;
                case "Reports":
                    btnDashboard.Image = Properties.Resources._0dashboard;
                    btnTeacher.Image = Properties.Resources._0teachers;
                    btnLogs.Image = Properties.Resources._0logs;
                    btnReports.Image = Properties.Resources._1reports;
                    btnStudent.Image = Properties.Resources._00students;
                    btnSubject.Image = Properties.Resources._0subjects;
                    break;
                case "Student":
                    btnDashboard.Image = Properties.Resources._0dashboard;
                    btnTeacher.Image = Properties.Resources._0teachers;
                    btnLogs.Image = Properties.Resources._0logs;
                    btnReports.Image = Properties.Resources._0reports;
                    btnStudent.Image = Properties.Resources._1students;
                    btnSubject.Image = Properties.Resources._0subjects;
                    break;
                case "Subject":
                    btnDashboard.Image = Properties.Resources._0dashboard;
                    btnTeacher.Image = Properties.Resources._0teachers;
                    btnLogs.Image = Properties.Resources._0logs;
                    btnReports.Image = Properties.Resources._0reports;
                    btnStudent.Image = Properties.Resources._00students;
                    btnSubject.Image = Properties.Resources._1subjects;
                    break;
            }
            
        }
    }
}
