using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace TinyCollegeGUI
{
    public partial class DisplayAllCoursesForm : Form
    {
        public DisplayAllCoursesForm()
        {
            InitializeComponent();
            LoadCourses();
        }

        private void LoadCourses()
        {
            List<Course> courses = GetAllCourses();
            DisplayCourses(courses);
        }

        private List<Course> GetAllCourses()
        {
            var courses = new List<Course>();
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT CourseID, CourseName, Credits FROM Courses"; // Explicitly select columns
                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                var course = new Course
                                {
                                    CourseID = reader.GetString(0),  // CourseID should be at index 0
                                    CourseName = reader.GetString(1), // CourseName should be at index 1
                                    Credits = reader.GetInt32(2)      // Credits should be at index 2
                                };
                                courses.Add(course);
                            }
                            catch (InvalidCastException e)
                            {
                                // Log the error and the state of the reader
                                MessageBox.Show($"Error reading course data: {e.Message}\nCourseID Value: {reader.GetValue(0)}\nCourseName Value: {reader.GetValue(1)}\nCredits Value: {reader.GetValue(2)}");
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

        private void DisplayCourses(List<Course> courses)
        {
            dataGridViewCourses.DataSource = null;
            dataGridViewCourses.DataSource = courses;
        }

        private SQLiteConnection GetConnection()
        {
            string connectionString = "Data Source=TinyCollege.db;Version=3;";
            return new SQLiteConnection(connectionString);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();
            List<Course> filteredCourses = GetAllCourses().Where(c =>
                c.CourseID.ToLower().Contains(searchText) ||
                c.CourseName.ToLower().Contains(searchText) ||
                c.Credits.ToString().Contains(searchText)).ToList();
            DisplayCourses(filteredCourses);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
