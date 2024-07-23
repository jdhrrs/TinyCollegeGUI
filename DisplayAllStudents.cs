using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

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

        // Method to remove a student by StudentId
        private void RemoveStudent(int studentId)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Students WHERE StudentId = @id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", studentId);
                    command.ExecuteNonQuery();
                }
            }
            LoadStudents(); // Refresh the list after removal
            MessageBox.Show("Student removed successfully.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                int studentId = (int)dataGridViewStudents.SelectedRows[0].Cells["StudentId"].Value;
                RemoveStudent(studentId);
            }
            else
            {
                MessageBox.Show("Please select a student to remove.");
            }
        }
    }
}
