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

namespace StudentInfoSystem
{
    public partial class Admin : UserControl
    {
        public Admin()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            string query;
            if (CBshowNotActive.Checked)
            {

                 query = "select s.Student_id,s.First_name,s.Last_name,s.Date_of_Birth,g.Gender,u.Username,u.Password,s.Email,s.Phone,s.Address,s.Enrollment_date,s.Status,s.Role_id from Student as S left join Gender as g on g.gender_id = s.gender left join User_login as u on u.Uniq_id = s.student_id";
            }
            else
            {
                 query = "select s.Student_id,s.First_name,s.Last_name,s.Date_of_Birth,g.Gender,u.Username,u.Password,s.Email,s.Phone,s.Address,s.Enrollment_date,s.Status,s.Role_id from Student as S left join Gender as g on g.gender_id = s.gender left join User_login as u on u.Uniq_id = s.student_id where status = 'Active'";
            }
            using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        //SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString);
        //string query = "Insert into Course(course_name,description,credits) values(@course_name,@description,@credits)";
        //SqlCommand cmd = new SqlCommand(query, conn);
        //cmd.Parameters.AddWithValue("@course_name", textBox1.Text);
        //    cmd.Parameters.AddWithValue("@description", textBox2.Text);
        //    cmd.Parameters.AddWithValue("@credits", textBox3.Text);

        //    conn.Open();
        //    cmd.ExecuteNonQuery();
        //    conn.Close();


        //    CourseAdded?.Invoke(this, EventArgs.Empty);

        //    this.Dispose();
        private void Admin_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_MouseDown(object sender, MouseEventArgs e)
        {
            btnAdd.Image = Properties.Resources.add0;
        }

        private void btnAdd_MouseUp(object sender, MouseEventArgs e)
        {
            btnAdd.Image = Properties.Resources.add1;

        }

        private void btnRemove_MouseDown(object sender, MouseEventArgs e)
        {
            btnRemove.Image = Properties.Resources.remove0;
        }

        private void btnRemove_MouseUp(object sender, MouseEventArgs e)
        {
            btnRemove.Image = Properties.Resources.REMOVE1;

        }
        public event EventHandler StudentAdded;

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            UC_AddStudent addStudent = new UC_AddStudent();

            // Subscribe to the event
            addStudent.StudentAdded += (s, ev) =>
            {
                LoadData(); // Reload data in DataGridView
            };

            Controls.Add(addStudent);
            addStudent.BringToFront();
            addStudent.Location = new Point((this.ClientSize.Width - addStudent.Width) / 2, (this.ClientSize.Height - addStudent.Height) / 2);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            UC_RemoveStudent removestudent = new UC_RemoveStudent();

            removestudent.StudentRemoved += (s, ev) =>
            {
                LoadData(); // Reload data in DataGridView
            };

            Controls.Add(removestudent);
            removestudent.BringToFront();
            removestudent.Location = new Point((this.ClientSize.Width - removestudent.Width) / 2, (this.ClientSize.Height - removestudent.Height) / 2);
        }

        private void btnUpdate_MouseDown(object sender, MouseEventArgs e)
        {
            btnUpdate.Image = Properties.Resources.update0;
        }

        private void btnUpdate_MouseUp(object sender, MouseEventArgs e)
        {
            btnUpdate.Image = Properties.Resources.update1;
        }

        private void CBshowNotActive_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

