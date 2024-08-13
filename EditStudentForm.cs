using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace TinyCollegeGUI
{
    public partial class EditStudentForm : Form
    {
        private string studentId;

        public EditStudentForm(string studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            LoadStudentInformation();
        }

        private void LoadStudentInformation()
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TinyCollegeDB"].ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Students WHERE StudentID = @StudentID";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentID", studentId);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtFirstName.Text = reader["FirstName"].ToString();
                            txtLastName.Text = reader["LastName"].ToString();
                            txtGPA.Text = reader["GPA"].ToString();
                        }
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateStudentInformation())
            {
                SaveStudentInformation();
            }
        }

        private bool ValidateStudentInformation()
        {
            if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Name fields cannot be empty.");
                return false;
            }

            if (!double.TryParse(txtGPA.Text, out _))
            {
                MessageBox.Show("GPA must be a valid number.");
                return false;
            }

            return true;
        }

        private void SaveStudentInformation()
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TinyCollegeDB"].ConnectionString))
            {
                connection.Open();
                string query = "UPDATE Students SET FirstName = @FirstName, LastName = @LastName, GPA = @GPA WHERE StudentID = @StudentID";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    command.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    command.Parameters.AddWithValue("@GPA", double.Parse(txtGPA.Text));
                    command.Parameters.AddWithValue("@StudentID", studentId);

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Student information updated successfully.");
            this.Close();
        }
    }
}
