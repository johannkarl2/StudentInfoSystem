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
            string query = "select s.student_id,s.first_name,s.last_name,s.date_of_birth,g.Gender,s.email,s.phone,s.address,s.enrollment_date,s.status,s.role_id from Student as S\r\nleft join Gender as g on g.gender_id = s.gender";

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
    }
}

