/* 
    Tiny College Student and Course Management System
    
    This program is designed to manage student and course information for Tiny College.
    It provides a graphical user interface (GUI) for performing various operations such as:
    - Adding new students
    - Displaying all students
    - Adding new courses
    - Displaying all courses
    - Enrolling a student in a course
    - Displaying all students in a course
    - Displaying all courses taken by a student
    - Deleting a course
    - Deleting a student
    - Editing student information
    
    The program connects to a SQL Server database to store and retrieve information.
    It uses various forms to provide a user-friendly way to interact with the data.
    
    Key Features:
    - DataGridView for displaying data
    - TextBox and Button controls for searching and performing actions
    - Event handlers for handling user interactions
    - Exception handling for database operations
    
    Delete Student Functionality:
    The program allows users to delete a student from the database. When a student is deleted,
    all related records such as course enrollments are also removed to maintain database integrity.
    
    Edit Student Functionality:
    The program allows users to edit existing student information such as first name, last name,
    and GPA. A form is provided to select a student, load their information, and save any updates.
*/





using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

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

            try
            {
                connectionString = ConfigurationManager.ConnectionStrings["TinyCollegeDB"].ConnectionString;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading connection string: " + ex.Message);
                return;
            }

            try
            {
                CreateTables(); // Make sure tables are created when the application starts
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing the database: " + ex.Message);
            }
        }

        // Event handler for form load
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadStudents(); // Load students from the database when the form loads
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message);
            }
        }

        // Method to get a connection to the database
        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Method to create tables if they do not exist
        private void CreateTables()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string createStudentsTableQuery = @"
                    IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Students' AND xtype='U')
                    CREATE TABLE Students (
                        StudentID INT PRIMARY KEY IDENTITY,
                        FirstName NVARCHAR(50) NOT NULL,
                        LastName NVARCHAR(50) NOT NULL,
                        GPA FLOAT
                    );";

                string createCoursesTableQuery = @"
                    IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Courses' AND xtype='U')
                    CREATE TABLE Courses (
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

        // Method to retrieve all courses from the database
        public List<Course> GetAllCourses()
        {
            var courses = new List<Course>();
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT CourseID, CourseName, Credits FROM Courses";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            courses.Add(new Course
                            {
                                CourseID = reader.GetString(0),
                                CourseName = reader.GetString(1),
                                Credits = reader.GetInt32(2)
                            });
                        }
                    }
                }
            }
            return courses;
        }

        // Method to load students into the local list
        private void LoadStudents()
        {
            students = GetAllStudents();
        }

        // Method to load courses into the local list (not used currently)
        private void LoadCourses()
        {
            var courses = GetAllCourses();
        }

        // Event handler for the Add Student button
        private void button1_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.StudentAdded += AddStudentForm_StudentAdded;
            addStudentForm.ShowDialog(this); // Pass the main form as owner
        }

        // Event handler when a student is added from the AddStudentForm
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

        // Event handler for the Display All Students button
        private void button2_Click(object sender, EventArgs e)
        {
            DisplayAllStudentsForm displayStudentsForm = new DisplayAllStudentsForm();
            displayStudentsForm.ShowDialog(this); // Open the new form
        }

        // Event handler for the Enroll a Student in a Course button
        private void button3_Click(object sender, EventArgs e)
        {
            EnrollAStudentInACourseForm enrollStudentForm = new EnrollAStudentInACourseForm();
            enrollStudentForm.ShowDialog(this);
        }

        // Event handler for the Add a Course button
        private void button5_Click(object sender, EventArgs e)
        {
            AddCourseForm addCourseForm = new AddCourseForm();
            addCourseForm.ShowDialog(this);
        }

        // Event handler for the Display All Courses button
        private void button6_Click(object sender, EventArgs e)
        {
            DisplayAllCoursesForm displayAllCoursesForm = new DisplayAllCoursesForm();
            displayAllCoursesForm.ShowDialog(this);
        }

        // Event handler for the Who Is In A Course button
        private void button7_Click(object sender, EventArgs e)
        {
            WhoIsInACourseForm whoIsInACourseForm = new WhoIsInACourseForm();
            whoIsInACourseForm.ShowDialog(this);
        }

        // Event handler for the Exit button
        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handler for the Edit Student button
        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            SelectStudentForm selectStudentForm = new SelectStudentForm();
            selectStudentForm.ShowDialog();
        }
    }
}
