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
                // Tells system to SELECT info FROM the Students table 
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
        // Saves valid student info onto database; makes "Save" button functional for user
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
            // Displays message box to prompt user to fill in name text boxes in order to execute command 
                MessageBox.Show("Name fields cannot be empty.");
                return false;
            }

            if (!double.TryParse(txtGPA.Text, out _))
            {
            // Displays message box to promp user to ensure they provided the GPA number in the correct format to the system
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
                // UPDATES student information in the database 
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
            // Displays message box to inform user when the student information that was changed by the user has been successfully updated in the database
            MessageBox.Show("Student information updated successfully.");
            this.Close();
        }
    }
}
