using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace TinyCollegeGUI
{
    public partial class WhoIsInACourseForm : Form
    {
        private string connectionString;

        // Constructor
        public WhoIsInACourseForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["TinyCollegeDB"].ConnectionString;
        }

        // Method to get SQL connection
        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Event handler for Find button click
        private void findButton_Click(object sender, EventArgs e)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT Students.FirstName, Students.LastName " +
                               "FROM Enrollments " +
                               "JOIN Students ON Enrollments.StudentID = Students.StudentID " +
                               "WHERE Enrollments.CourseID = @CourseID";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CourseID", textBoxCourseID.Text);
                    using (var reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridViewStudents.DataSource = dt;
                    }
                }
            }
        }

        // Event handler for Close button click
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
