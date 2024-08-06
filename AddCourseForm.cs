using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TinyCollegeGUI
{
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
        }

        // Event handler for form load
        private void AddCourseForm_Load(object sender, EventArgs e)
        {
            // Code to execute when the form loads
        }

        // Method to add a new course to the database
        private void AddCourse(string courseId, string courseName, int credits)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Courses (CourseID, CourseName, Credits) VALUES (@CourseID, @CourseName, @Credits)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CourseID", courseId);
                    command.Parameters.AddWithValue("@CourseName", courseName);
                    command.Parameters.AddWithValue("@Credits", credits);

                    // Log for debugging
                    Console.WriteLine($"Inserting Course: CourseID={courseId}, CourseName={courseName}, Credits={credits}");

                    command.ExecuteNonQuery();
                }
            }
        }

        // Get a connection to the database
        private SQLiteConnection GetConnection()
        {
            string connectionString = "Data Source=TinyCollege.db;Version=3;";
            return new SQLiteConnection(connectionString);
        }

        // Event handler for the Add Course button
        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            string courseId = txtCourseID.Text;
            string courseName = txtCourseName.Text;

            // Ensure Credits is a valid integer
            if (!int.TryParse(txtCredits.Text, out int credits))
            {
                MessageBox.Show("Credits must be a valid integer.");
                return;
            }

            // Log for debugging
            Console.WriteLine($"btnAddCourse_Click: CourseID={courseId}, CourseName={courseName}, Credits={credits}");

            try
            {
                AddCourse(courseId, courseName, credits);
                MessageBox.Show("Course added successfully!");

                // Optionally, clear the text fields after adding the course
                txtCourseID.Clear();
                txtCourseName.Clear();
                txtCredits.Clear();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Error adding course: {ex.Message}");
                Console.WriteLine($"SQLiteException: {ex.Message}");
            }
        }

        // Event handler for the Close button
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handler for the Manage Courses button
        private void btnManageCourses_Click(object sender, EventArgs e)
        {
            ManageCoursesForm manageCoursesForm = new ManageCoursesForm();
            manageCoursesForm.Show();
        }
    }
}
