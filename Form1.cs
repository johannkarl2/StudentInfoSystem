using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentInfoSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.Image = Properties.Resources.hoverlogin;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.Image = Properties.Resources.loginbtn;

        }

        private void btnLogin_MouseDown(object sender, MouseEventArgs e)
        {
            btnLogin.Image = Properties.Resources.pressedLogin;

        }

        private void btnLogin_MouseUp(object sender, MouseEventArgs e)
        {
            btnLogin.Image = Properties.Resources.loginbtn;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       /* private void LogIn(string user)
        {
            SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString);
            string query = "INSERT INTO Logs (Date,Name, Time_LI) VALUES (GETDATE(),@username, CONVERT(TIME(0), GETDATE()));";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", user);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while logging in: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }*/
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString);
            string query = @"
                                SELECT *
                                FROM User_login AS ul
                                INNER JOIN Admin AS a ON ul.uniq_id = a.admin_id
                                WHERE ul.Username = @username AND ul.Password = @password"; 
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            try
            {
                conn.Open();
                SqlDataReader result = cmd.ExecuteReader();

                if (result.Read())
                {

                    int roleId = Convert.ToInt32(result["role_id"]);
                    //LogIn(username);
                    CurrentUser.Name = result["full_name"].ToString();
                    if (roleId == 1)
                    {
                        AdminForm adminform = new AdminForm();
                        this.Hide();
                        adminform.ShowDialog();

                    }
                    else if (roleId == 2)
                    {
                        TeacherForm teacherform = new TeacherForm();
                        this.Hide();
                        teacherform.ShowDialog();
                    }
                    else if (roleId == 3)
                    {
                        StudentForm studentform = new StudentForm();
                        this.Hide();
                        studentform.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }
    }
}
