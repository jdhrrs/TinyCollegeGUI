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

        // Method to get the next student ID
        public int GetNextStudentId()
        {
            int nextId = 1; // Default ID
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT MAX(StudentID) FROM Students";
                using (var command = new SqlCommand(query, connection))
                {
                    var result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        nextId = Convert.ToInt32(result) + 1;
                    }
                }
            }
            return nextId;
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
                string query = "SELECT CourseID, CourseName, Credits FROM Courses"; // Explicitly select columns
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                // Read the data
                                var course = new Course
                                {
                                    CourseID = reader.GetString(0),  // Ensure CourseID is retrieved as a string
                                    CourseName = reader.GetString(1),
                                    Credits = reader.GetInt32(2)
                                };
                                courses.Add(course);
                            }
                            catch (InvalidCastException e)
                            {
                                // Log the error and the state of the reader
                                MessageBox.Show($"Error reading course data: {e.Message}\nColumn Index: {reader.Depth}\nValue: {reader.GetValue(reader.Depth)}");
                            }
                            catch (Exception e)
                            {
                                // Handle any other potential exceptions
                                MessageBox.Show($"Unexpected error: {e.Message}");
                            }
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
            DisplayStudentsForm displayStudentsForm = new DisplayStudentsForm();
            displayStudentsForm.ShowDialog(this); // Open the new form
        }

        // Event handler for the Add Course button
        private void buttonAddCourse_Click(object sender, EventArgs e)
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

        // Event handler for the Delete Course button
        private void buttonDeleteCourse_Click(object sender, EventArgs e)
        {
            DeleteCourse deleteCourse = new DeleteCourse();
            deleteCourse.ShowDialog(this);
        }

        // Event handler for the Find Student button
        private void buttonFindStudent_Click(object sender, EventArgs e)
        {
            SearchStudent searchStudent = new SearchStudent();
            searchStudent.ShowDialog(this);
        }

        // Event handler for the Find Course button
        private void buttonFindCourse_Click(object sender, EventArgs e)
        {
            SearchCourse searchCourse = new SearchCourse();
            searchCourse.ShowDialog(this);
        }

        // Event handler for the Exit button
        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
