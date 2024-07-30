using System.Data.SQLite;

uusing System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TinyCollegeGUI
{
    public partial class AddCourseForm : Form
    {
        private string connectionString = "Data Source=TinyCollege.db;Version=3;";

        public AddCourseForm()
        {
            InitializeComponent();
        }

        private SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }

        private void btnSaveCourse_Click(object sender, EventArgs e)
        {
            string courseName = txtCourseName.Text;
            string courseCode = txtCourseCode.Text;
            int credits;
            if (int.TryParse(txtCredits.Text, out credits))
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    string query = "INSERT INTO Courses (CourseName, CourseCode, Credits) VALUES (@CourseName, @CourseCode, @Credits)";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CourseName", courseName);
                        command.Parameters.AddWithValue("@CourseCode", courseCode);
                        command.Parameters.AddWithValue("@Credits", credits);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Course added successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter valid credits.");
            }
        }
    }
}

