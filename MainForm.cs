using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TinyCollegeGUI
{
    public partial class MainForm : Form
    {
        // List to hold students
        private List<Student> students;
        // SQLite connection string
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

        // Method to get a SQLite connection
        private SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }

        // Method to create tables if they do not exist
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

        // Method to add a new student to the database
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

        // Method to get all students from the database
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

        // Method to load all students into the ListBox
        private void LoadStudents()
        {
            students = GetAllStudents();

            // Assuming listBoxStudents is a ListBox control on the form
            listBoxStudents.Items.Clear();
            foreach (var student in students)
            {
                listBoxStudents.Items.Add(student.ToString());
            }
        }

        // Event handler for adding a new student
        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.StudentAdded += AddStudentForm_StudentAdded;
            addStudentForm.ShowDialog(this); // Pass the main form as owner
        }

        // Method to handle the addition of a new student
        private void AddStudentForm_StudentAdded(Student newStudent)
        {
            AddStudent(newStudent.FirstName, newStudent.LastName, newStudent.GPA); // Save to database
            students.Add(newStudent); // Add to local list
            toolStripStatusLabel.Text = $"Student {newStudent.FirstName} {newStudent.LastName} added successfully!";
            LoadStudents(); // Refresh UI
        }

        // Event handler for displaying all students
        private void buttonDisplayAllStudents_Click(object sender, EventArgs e)
        {
            DisplayStudentsForm displayStudentsForm = new DisplayStudentsForm();
            displayStudentsForm.ShowDialog(this); // Open the new form
        }

        // Event handler for deleting a student
        private void buttonDeleteStudent_Click(object sender, EventArgs e)
        {
            if (listBoxStudents.SelectedItem != null)
            {
                string selectedStudent = listBoxStudents.SelectedItem.ToString();
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bool isDeleted = DeleteStudent(selectedStudent);
                    if (isDeleted)
                    {
                        LoadStudents();
                        toolStripStatusLabel.Text = "Student record deleted successfully.";
                    }
                    else
                    {
                        toolStripStatusLabel.Text = "Failed to delete student record.";
                    }
                }
            }
            else
            {
                toolStripStatusLabel.Text = "Please select a student to delete.";
            }
        }

        // Method to delete a student from the database
        private bool DeleteStudent(string studentName)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Students WHERE FirstName || ' ' || LastName = @Name";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", studentName);
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        // Event handler for editing a course (assuming listBoxCourses is a ListBox control on the form)
        private void buttonEditCourse_Click(object sender, EventArgs e)
        {
            if (listBoxCourses.SelectedItem != null)
            {
                string selectedCourse = listBoxCourses.SelectedItem.ToString();
                Course course = GetCourseByName(selectedCourse);
                if (course != null)
                {
                    EditCourseForm editCourseForm = new EditCourseForm(course, connectionString);
                    if (editCourseForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadCourses();
                        toolStripStatusLabel.Text = "Course information updated successfully.";
                    }
                }
                else
                {
                    toolStripStatusLabel.Text = "Course not found.";
                }
            }
            else
            {
                toolStripStatusLabel.Text = "Please select a course to edit.";
            }
        }

        // Method to get a course by its name
        private Course GetCourseByName(string courseName)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Courses WHERE Name = @Name";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", courseName);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Course
                            {
                                CourseId = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Description = reader.GetString(2)
                            };
                        }
                    }
                }
            }
            return null;
        }

        // Method to load all courses into the ListBox (assuming listBoxCourses is a ListBox control on the form)
        private void LoadCourses()
        {
            courses = GetAllCourses();
            listBoxCourses.Items.Clear();
            foreach (var course in courses)
            {
                listBoxCourses.Items.Add(course.Name);
            }
        }

        // Method to get all courses from the database
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
                                Name = reader.GetString(1),
                                Description = reader.GetString(2)
                            });
                        }
                    }
                }
            }
            return courses;
        }

        // Event handler for closing the form
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    // Class representing a Student
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double GPA { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} (ID: {StudentId}) - GPA: {GPA}";
        }
    }

    // Class representing a Course
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
