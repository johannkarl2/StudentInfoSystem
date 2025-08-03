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
    public partial class Admin_Teacher : UserControl
    {
        public Admin_Teacher()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            string query = "SELECT * FROM Teacher";

            using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void Admin_Teacher_Load(object sender, EventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
