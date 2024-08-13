using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace TinyCollegeGUI
{
    public partial class DisplayAllStudentsForm : Form
    {
        private string connectionString;

        public DisplayAllStudentsForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["TinyCollegeDB"].ConnectionString;
            LoadStudents(); // Load students when the form loads
        }

        // Establish a connection to the SQL Server database
        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Retrieve all students from the Students table
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
                using (var command = new SqlCommand(query, connection))
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

        private void DisplayStudentsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
