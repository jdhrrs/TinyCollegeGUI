using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace TinyCollegeGUI
{
    public partial class EnrollAStudentInACourseForm : Form
    {
        private string connectionString; // Connection string for the SQL Server database

        public EnrollAStudentInACourseForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["TinyCollegeDB"].ConnectionString; // Initialize the connection string from the configuration file
            LoadCourses(); // Load the courses into the combo box
            LoadStudents(); // Load the students into the combo box
        }

        // Method to get a connection to the database
        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Method to load courses into the combo box
        private void LoadCourses()
        {
            using (var connection = GetConnection())
            {
                connection.Open(); // Open the database connection
                string query = "SELECT CourseID, CourseName FROM Courses";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CoursecomboBox.Items.Add(new { Text = reader["CourseName"].ToString(), Value = reader["CourseID"].ToString() }); // Add course name and ID to combo box
                        }
                    }
                }
            }
            CoursecomboBox.DisplayMember = "Text"; // Display course name in combo box
            CoursecomboBox.ValueMember = "Value"; // Use course ID as value in combo box
        }

        // Method to load students into the combo box
        private void LoadStudents()
        {
            using (var connection = GetConnection())
            {
                connection.Open(); // Open the database connection
                string query = "SELECT StudentID, FirstName + ' ' + LastName AS FullName FROM Students";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            StudentcomboBox.Items.Add(new { Text = reader["FullName"].ToString(), Value = reader["StudentID"].ToString() }); // Add student full name and ID to combo box
                        }
                    }
                }
            }
            StudentcomboBox.DisplayMember = "Text"; // Display student name in combo box
            StudentcomboBox.ValueMember = "Value"; // Use student ID as value in combo box
        }

        // Event handler for the "Add" button click
        private void button1_Click(object sender, EventArgs e)
        {
            if (CoursecomboBox.SelectedItem == null || StudentcomboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select both a course and a student."); // Show error if either combo box is not selected
                return;
            }

            var selectedCourse = (dynamic)CoursecomboBox.SelectedItem;
            var selectedStudent = (dynamic)StudentcomboBox.SelectedItem;

            using (var connection = GetConnection())
            {
                connection.Open(); // Open the database connection
                string query = "INSERT INTO Enrollments (StudentID, CourseID) VALUES (@StudentID, @CourseID)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentID", selectedStudent.Value); // Add student ID parameter
                    command.Parameters.AddWithValue("@CourseID", selectedCourse.Value); // Add course ID parameter
                    command.ExecuteNonQuery(); // Execute the insert query
                }
            }

            MessageBox.Show("Student enrolled in course successfully."); // Show success message
        }

        // Event handler for the "Close" button click
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form
        }
    }
}
