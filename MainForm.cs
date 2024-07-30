using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;
using TinyCollege;

namespace TinyCollegeGUI
{
    public partial class MainForm : Form
    {
        private List<Student> students;
        private string connectionString = "Data Source=TinyCollege.db;Version=3;";

        public MainForm()
        {
            InitializeComponent();
            students = new List<Student>();
            CreateTables(); // Ensure tables are created when the application starts
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadStudents(); // Load students from the database when the form loads
        }

        private SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }

        public void CreateTables()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string createStudentsTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Students (
                        StudentID INTEGER PRIMARY KEY AUTOINCREMENT,
                        FirstName TEXT NOT NULL,
                        LastName TEXT NOT NULL,
                        GPA REAL
                    );";

                string createCoursesTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Courses (
                        CourseID INTEGER PRIMARY KEY AUTOINCREMENT,
                        CourseName TEXT NOT NULL,
                        CourseCode TEXT NOT NULL,
                        Credits INTEGER
                    );";

                using (var command = new SQLiteCommand(createStudentsTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                using (var command = new SQLiteCommand(createCoursesTableQuery, connection))
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
                using (var command = new SQLiteCommand(query, connection))
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
                using (var command = new SQLiteCommand(query, connection))
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
                using (var command = new SQLiteCommand(query, connection))
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
                string query = "SELECT * FROM Courses";
                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            courses.Add(new Course
                            {
                                CourseId = reader.GetInt32(0),
                                CourseName = reader.GetString(1),
                                CourseCode = reader.GetString(2),
                                Credits = reader.GetInt32(3)
                            });
                        }
                    }
                }
            }
            return courses;
        }

        private void LoadStudents()
        {
            students = GetAllStudents();
            // Update your UI here, e.g., bind students to a ListBox or DataGridView
        }

        private void LoadCourses()
        {
            var courses = GetAllCourses();
            // Update your UI here, e.g., bind courses to a ListBox or DataGridView
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

        private void buttonDisplayAllStudents_Click(object sender, EventArgs e)
        {
            DisplayStudentsForm displayStudentsForm = new DisplayStudentsForm();
            displayStudentsForm.ShowDialog(this); // Open the new form
        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            AddCourseForm addCourseForm = new AddCourseForm();
            addCourseForm.ShowDialog(this);
        }

        private void buttonEditCourse_Click(object sender, EventArgs e)
        {
            string selectedCourseId = GetSelectedCourseId();
            if (!string.IsNullOrEmpty(selectedCourseId))
            {
                EditCourseForm editCourseForm = new EditCourseForm(selectedCourseId);
                editCourseForm.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Please select a course to edit.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DisplayCoursesForm displayCoursesForm = new DisplayCoursesForm();
            displayCoursesForm.ShowDialog(this);
        }


        private string GetSelectedCourseId()
        {
            // Placeholder method to get the selected course ID
            // This should be replaced with actual logic to get the selected course ID
            return "course-id-placeholder";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonDisplayAllStudents_Click(sender, e); // Open DisplayStudentsForm when button2 is clicked
        }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double GPA { get; set; }

        public Student() { }

        public Student(int studentId, string firstName, string lastName, double gpa)
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
            GPA = gpa;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} (ID: {StudentId}) - GPA: {GPA}";
        }
    }

    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public int Credits { get; set; }

        public Course() { }

        public Course(int courseId, string courseName, string courseCode, int credits)
        {
            CourseId = courseId;
            CourseName = courseName;
            CourseCode = courseCode;
            Credits = credits;
        }

        public override string ToString()
        {
            return $"{CourseName} ({CourseCode}) - {Credits} Credits";
        }
    }
}
