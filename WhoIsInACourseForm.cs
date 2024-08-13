using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace TinyCollegeGUI
{
    public partial class WhoIsInACourseForm : Form
    {
        public WhoIsInACourseForm()
        {
            InitializeComponent();
            LoadCourses();
        }

        // Get a connection to the database
        private SqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["TinyCollegeDB"].ConnectionString;
            return new SqlConnection(connectionString);
        }

        // Retrieve all courses from the database
        private List<Course> GetAllCourses()
        {
            var courses = new List<Course>();
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT CourseID, CourseName, Credits FROM Courses"; // Explicitly select columns
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var course = new Course
                            {
                                CourseID = reader.GetString(0),
                                CourseName = reader.GetString(1),
                                Credits = reader.GetInt32(2)
                            };
                            courses.Add(course);
                        }
                    }
                }
            }
            return courses;
        }

        // Display the list of courses in the DataGridView
        private void DisplayCourses(List<Course> courses)
        {
            // Clear existing columns
            dataGridViewCourses.Columns.Clear();

            // Set AutoGenerateColumns to false
            dataGridViewCourses.AutoGenerateColumns = false;

            // Define columns manually
            dataGridViewCourses.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CourseID",
                HeaderText = "Course ID"
            });
            dataGridViewCourses.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CourseName",
                HeaderText = "Course Name"
            });
            dataGridViewCourses.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Credits",
                HeaderText = "Credits"
            });

            // Bind the list of courses to the DataGridView
            dataGridViewCourses.DataSource = courses;
        }

        // Load courses from the database and display them in the DataGridView
        private void LoadCourses()
        {
            List<Course> courses = GetAllCourses();
            DisplayCourses(courses);
        }

        // Retrieve all students enrolled in a specific course
        private List<Student> GetStudentsByCourseID(string courseID)
        {
            var students = new List<Student>();
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = @"
                    SELECT s.StudentId, s.FirstName, s.LastName 
                    FROM Students s
                    JOIN Enrollments e ON s.StudentId = e.StudentID
                    WHERE e.CourseID = @CourseID";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CourseID", courseID);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            students.Add(new Student
                            {
                                StudentId = reader.GetInt32(0),
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2)
                            });
                        }
                    }
                }
            }
            return students;
        }

        // Display the list of students in the DataGridView
        private void DisplayStudents(List<Student> students)
        {
            dataGridViewStudents.DataSource = null;
            dataGridViewStudents.AutoGenerateColumns = false;
            dataGridViewStudents.Columns.Clear();

            dataGridViewStudents.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StudentId",
                HeaderText = "Student ID"
            });
            dataGridViewStudents.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FirstName",
                HeaderText = "First Name"
            });
            dataGridViewStudents.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LastName",
                HeaderText = "Last Name"
            });

            dataGridViewStudents.DataSource = students;
        }

        // Event handler for searching students by course ID
        private void btnSearchStudents_Click(object sender, EventArgs e)
        {
            string courseID = txtCourseID.Text.Trim();
            List<Student> students = GetStudentsByCourseID(courseID);
            DisplayStudents(students);
        }

        // Event handler for form load
        private void WhoIsInACourseForm_Load(object sender, EventArgs e)
        {
            LoadCourses();
        }

        // Close the form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
