using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;

namespace TinyCollegeGUI
{
    public partial class DisplayAllCoursesForm : Form
    {
        public DisplayAllCoursesForm()
        {
            InitializeComponent();
            LoadCourses();
        }

        // Load courses from the database and display them in the DataGridView
        private void LoadCourses()
        {
            List<Course> courses = GetAllCourses();
            DisplayCourses(courses);
        }

        // Retrieve all courses from the database
        private List<Course> GetAllCourses()
        {
            var courses = new List<Course>();
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT CourseID, CourseName, Credits FROM Courses";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                var course = new Course
                                {
                                    CourseID = reader.GetString(0),
                                    CourseName = reader.GetString(1),
                                    Credits = reader.GetInt32(2)
                                };
                                courses.Add(course);
                            }
                            catch (InvalidCastException e)
                            {
                                MessageBox.Show($"Error reading course data: {e.Message}\nCourseID Value: {reader.GetValue(0)}\nCourseName Value: {reader.GetValue(1)}\nCredits Value: {reader.GetValue(2)}");
                            }
                            catch (Exception e)
                            {
                                MessageBox.Show($"Unexpected error: {e.Message}");
                            }
                        }
                    }
                }
            }
            return courses;
        }

        // Display the list of courses in the DataGridView
        private void DisplayCourses(List<Course> courses)
        {
            dataGridViewCourses.Columns.Clear();
            dataGridViewCourses.AutoGenerateColumns = false;

            dataGridViewCourses.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CourseID",
                HeaderText = "Course ID"
            });
            dataGridViewCourses.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CourseName",
                HeaderText = "Course Name"
            });
            dataGridViewCourses.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Credits",
                HeaderText = "Credits"
            });

            dataGridViewCourses.DataSource = courses;
        }

        // Get a connection to the database
        private SqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["TinyCollegeDB"].ConnectionString;
            return new SqlConnection(connectionString);
        }

        // Search courses based on the text in the search box
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();
            List<Course> filteredCourses = GetAllCourses().Where(c =>
                c.CourseID.ToLower().Contains(searchText) ||
                c.CourseName.ToLower().Contains(searchText) ||
                c.Credits.ToString().Contains(searchText)).ToList();
            DisplayCourses(filteredCourses);
        }

        // Close the form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Delete the selected course
        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            if (dataGridViewCourses.SelectedRows.Count > 0)
            {
                var selectedCourse = dataGridViewCourses.SelectedRows[0].DataBoundItem as Course;
                if (selectedCourse != null)
                {
                    DeleteCourse(selectedCourse.CourseID);
                    LoadCourses(); // Refresh the course list
                }
            }
            else
            {
                MessageBox.Show("Please select a course to delete.");
            }
        }

        // Method to delete a course from the database
        private void DeleteCourse(string courseID)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Courses WHERE CourseID = @CourseID";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CourseID", courseID);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void dataGridViewCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewCourses_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DisplayAllCoursesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
