using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Data.SQLite;
namespace TinyCollegeGUI
{
    public partial class DisplayStudentsForm : Form
    {
        private string connectionString = "Data Source=TinyCollege.db;Version=3;";

        public DisplayStudentsForm()
        {
            InitializeComponent();
            LoadStudents(); // Load students when the form loads
        }

        // Establish a connection to the SQLite database
        private SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
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

        // Load students into the DataGridView
        private void LoadStudents()
        {
            var students = GetAllStudents();
            dataGridViewStudents.DataSource = students;
        }
    }
}

