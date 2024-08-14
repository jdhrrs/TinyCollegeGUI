using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace TinyCollegeGUI
{
    public partial class SelectStudentForm : Form
    {
        private List<Student> students;
        private string connectionString;

        public SelectStudentForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["TinyCollegeDB"].ConnectionString;
            LoadStudents();
        }

        private void LoadStudents()
        {
        // Generates list of students in database
            students = new List<Student>();
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Tells system to SELECT info (student name, ID, and GPA) FROM the Students table from the database
                string query = "SELECT StudentID, FirstName, LastName, GPA FROM Students";
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

            dataGridViewStudents.DataSource = students;
        }
        // Event handler for Edit Selected Student button
        private void btnEditSelectedStudent_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                var selectedStudentId = dataGridViewStudents.SelectedRows[0].Cells["StudentId"].Value.ToString();
                EditStudentForm editStudentForm = new EditStudentForm(selectedStudentId);
                editStudentForm.ShowDialog();
                this.Close();
            }
            else
            {
            // Displays message box to user to prompt them to select a student from the database whose information they wish to edit/update in the system
                MessageBox.Show("Please select a student to edit.");
            }
        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
