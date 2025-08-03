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
    public partial class UC_AddStudent : UserControl
    {
        public UC_AddStudent()
        {
            InitializeComponent();
           

          

        }

        private void btnAdd_MouseDown(object sender, MouseEventArgs e)
        {
            btnAdd.Image = Properties.Resources.add0;
        }

        private void btnAdd_MouseUp(object sender, MouseEventArgs e)
        {
            btnAdd.Image = Properties.Resources.add1;

        }

        private void btnCancel_MouseDown(object sender, MouseEventArgs e)
        {
            btnCancel.Image = Properties.Resources.Cancel0;
        }

        private void btnCancel_MouseUp(object sender, MouseEventArgs e)
        {
            btnCancel.Image = Properties.Resources.Cancel1;

        }
        public void ClearFields()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.SelectedIndex = 0;
            txtPhone.Clear();
            txtEmail.Clear();
        }
        public event EventHandler StudentAdded;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!(txtEmail.Text.Contains("@") && txtEmail.Text.EndsWith(".com")))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }else if (!string.IsNullOrWhiteSpace(txtFirstName.Text) &&
        !string.IsNullOrWhiteSpace(txtLastName.Text) &&
        !string.IsNullOrWhiteSpace(comboBox1.Text) &&
        !string.IsNullOrWhiteSpace(txtEmail.Text) &&
        !string.IsNullOrWhiteSpace(txtPhone.Text) &&
        !string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                int gender = comboBox1.SelectedIndex + 1;
                string formattedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string query = "INSERT INTO Student (first_name,last_name,date_of_birth,gender,phone,email,enrollment_date,role_id,status,address) VALUES (@first_name, @last_name, @date_of_birth, @gender, @phone_number, @email,GETDATE(),3,'Active',@address)";
                SqlConnection sqlConnection = new SqlConnection(DatabaseConfig.ConnectionString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@first_name", txtFirstName.Text);
                sqlCommand.Parameters.AddWithValue("@last_name", txtLastName.Text);
                sqlCommand.Parameters.AddWithValue("@date_of_birth", formattedDate);
                sqlCommand.Parameters.AddWithValue("@gender", gender);
                sqlCommand.Parameters.AddWithValue("@phone_number", txtPhone.Text);
                sqlCommand.Parameters.AddWithValue("@email", txtEmail.Text);
                sqlCommand.Parameters.AddWithValue("@address", txtAddress.Text);

                try
                {
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Student added successfully.");
                    ClearFields();
                    StudentAdded?.Invoke(this, EventArgs.Empty); // Notify parent


                    this.Dispose();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while adding the student: " + ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("Fill all the boxes");
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
            
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
