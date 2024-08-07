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
        private List<Student> students;
        private string connectionString;

        public MainForm()
        {
            InitializeComponent();
            students = new List<Student>();
            connectionString = ConfigurationManager.ConnectionStrings["TinyCollegeDB"].ConnectionString;
            CreateTables(); // Make sure tables are created when the application starts
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadStudents(); // Load students from the database when the form loads
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public void CreateTables()
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

        private void LoadStudents()
        {
            students = GetAllStudents();
        }

        private void LoadCourses()
        {
            var courses = GetAllCourses();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.StudentAdded += AddStudentForm_StudentAdded;
            addStudentForm.ShowDialog(this); // Pass the main form as owner
        }

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

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayStudentsForm displayStudentsForm = new DisplayStudentsForm();
            displayStudentsForm.ShowDialog(this); // Open the new form
        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            AddCourseForm addCourseForm = new AddCourseForm();
            addCourseForm.ShowDialog(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DisplayAllCoursesForm displayAllCoursesForm = new DisplayAllCoursesForm();
            displayAllCoursesForm.ShowDialog(this);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
