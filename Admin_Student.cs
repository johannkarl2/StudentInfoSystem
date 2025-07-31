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
        private void LoadData()
        {
            string query = "SELECT * FROM Student";

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
            btnAdd.Image = Properties.Resources._1add;
        }

        private void btnAdd_MouseUp(object sender, MouseEventArgs e)
        {
            btnAdd.Image = Properties.Resources._0add;

        }
    }
}
