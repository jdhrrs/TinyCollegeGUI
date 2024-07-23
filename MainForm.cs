using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

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

        // Establish a connection to the SQLite database
        private SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }

        // Create the Students table if it does not exist
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

                using (var command = new SQLiteCommand(createStudentsTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        // Add a new student to the Students table
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

        // Get the next available Student ID from the Students table
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

        // Retrieve all students from the Students table
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

        // Load students from the database and update the UI
        private void LoadStudents()
        {
            students = GetAllStudents();
            // Update your UI here, e.g., bind students to a ListBox or DataGridView
        }

        // Open the AddStudentForm to add a new student
        private void button1_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.StudentAdded += AddStudentForm_StudentAdded;
            addStudentForm.ShowDialog(this); // Pass the main form as owner
        }

        // Handle the event when a new student is added from the AddStudentForm
        private void AddStudentForm_StudentAdded(Student newStudent)
        {
            AddStudent(newStudent.FirstName, newStudent.LastName, newStudent.GPA); // Save to database
            students.Add(newStudent); // Add to local list
            toolStripStatusLabel.Text = $"Student {newStudent.FirstName} {newStudent.LastName} added successfully!";
            LoadStudents(); // Refresh UI
        }

        // Close the application
        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Open the form to add a new course
        private void button5_Click(object sender, EventArgs e)
        {
            // Implement course addition logic here
        }
    }

    // Student class representing the Student entity
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
}
