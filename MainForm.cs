using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using TinyCollege;

namespace TinyCollegeGUI
{
    public partial class MainForm : Form
    {
        private List<Student> students; // List to hold student data
        private string connectionString; // Connection string for SQL Server

        public MainForm()
        {
            InitializeComponent();
            students = new List<Student>();
            connectionString = ConfigurationManager.ConnectionStrings["TinyCollegeDB"].ConnectionString;
            CreateTables(); // Make sure tables are created when the application starts
        }

        // Event handler for form load
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadStudents(); // Load students from the database when the form loads
        }

        // Method to get a connection to the database
        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Method to create tables if they do not exist
        public void CreateTables()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string createStudentsTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Students (
                        StudentID INT PRIMARY KEY IDENTITY,
                        FirstName NVARCHAR(50) NOT NULL,
                        LastName NVARCHAR(50) NOT NULL,
                        GPA FLOAT
                    );";

                string createCoursesTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Courses (
                        CourseID NVARCHAR(50) PRIMARY KEY,
                        CourseName NVARCHAR(100) NOT NULL,
                        Credits INT NOT NULL
                    );";

                using (var command = new SqlCommand(createStudentsTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                using (var command = new SqlCommand(createCoursesTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        // Method to add a student to the database
        public void AddStudent(string firstName, string lastName, double gpa)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Students (FirstName, LastName, GPA) VALUES (@FirstName, @LastName, @GPA)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@GPA", gpa);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Method to retrieve all students from the database
        public List<Student> GetAllStudents()
        {
            var students = new List<Student>();
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Students";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            students.Add(new Student
                            {
                                StudentId = reader.GetInt32(0),
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2),
                                GPA = reader.GetDouble(3)
                            });
                        }
                    }
                }
            }
            return students;
        }

        // Event handlers for the buttons
        private void button1_Click(object sender, EventArgs e) // Add a Student
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.StudentAdded += AddStudentForm_StudentAdded;
            addStudentForm.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e) // Display All Students
        {
            DisplayStudentsForm displayStudentsForm = new DisplayStudentsForm();
            displayStudentsForm.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e) // Find Student
        {
            SearchStudent searchStudent = new SearchStudent();
            searchStudent.ShowDialog(this);
        }

        private void button5_Click(object sender, EventArgs e) // Add a Course
        {
            AddCourseForm addCourseForm = new AddCourseForm();
            addCourseForm.ShowDialog(this);
        }

        private void button6_Click(object sender, EventArgs e) // Display All Courses
        {
            DisplayAllCoursesForm displayAllCoursesForm = new DisplayAllCoursesForm();
            displayAllCoursesForm.ShowDialog(this);
        }

        private void button7_Click(object sender, EventArgs e) // Who is in a Course
        {
            WhoIsInACourseForm whoIsInACourseForm = new WhoIsInACourseForm();
            whoIsInACourseForm.ShowDialog(this);
        }

        private void button8_Click(object sender, EventArgs e) // Exit
        {
            this.Close();
        }

        // When a student is added, update the UI
        private void AddStudentForm_StudentAdded(object sender, EventArgs e)
        {
            if (sender is AddStudentForm addStudentForm && addStudentForm.NewStudent != null)
            {
                AddStudent(addStudentForm.NewStudent.FirstName, addStudentForm.NewStudent.LastName, addStudentForm.NewStudent.GPA); // Save to database
                students.Add(addStudentForm.NewStudent); // Add to local list
                toolStripStatusLabel.Text = $"Student {addStudentForm.NewStudent.FirstName} {addStudentForm.NewStudent.LastName} added successfully!";
                LoadStudents(); // Refresh UI
            }
        }
    }
}
