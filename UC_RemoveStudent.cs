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
    public partial class UC_RemoveStudent : UserControl
    {
        public event EventHandler StudentRemoved;

        public UC_RemoveStudent()
        {
            InitializeComponent();
        }

        private void btnRemove_MouseUp(object sender, MouseEventArgs e)
        {
            btnRemove.Image = Properties.Resources._1remove;
        }

        private void btnRemove_MouseDown(object sender, MouseEventArgs e)
        {
            btnRemove.Image = Properties.Resources._0remove;

        }

        private void btnCancel_MouseDown(object sender, MouseEventArgs e)
        {
            btnCancel.Image = Properties.Resources._0cancel;

        }

        private void btnCancel_MouseUp(object sender, MouseEventArgs e)
        {
            btnCancel.Image = Properties.Resources._1cancel;

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRemove.Text))
            {
                MessageBox.Show("Please enter a valid Student ID.");
                return;
            }
            string query = "Delete from Student where student_id = @Student_Id";

            SqlConnection sqlConnection = new SqlConnection(DatabaseConfig.ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
           
            sqlCommand.Parameters.AddWithValue("@Student_Id", txtRemove.Text);

            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Student Removed successfully.");
                StudentRemoved?.Invoke(this, EventArgs.Empty); // Notify parent


                this.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while removing the student: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void txtRemove_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}
