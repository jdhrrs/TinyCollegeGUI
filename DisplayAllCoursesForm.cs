using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace TinyCollegeGUI
{
    public partial class DisplayAllCoursesForm : Form
    {
        private string connectionString = "Data Source=TinyCollege.db;Version=3;";

        public DisplayAllCoursesForm()
        {
            InitializeComponent();
            LoadCourses();
        }

        private SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }

        private List<Course> GetAllCourses()
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
                                CourseID = reader.GetString(0),
                                CourseName = reader.GetString(1),
                                Credits = reader.GetInt32(3)
                            });
                        }
                    }
                }
            }
            return courses;
        }

        private void LoadCourses(List<Course> courses = null)
        {
            if (courses == null)
            {
                courses = GetAllCourses();
            }

            dataGridViewCourses.Rows.Clear();
            foreach (var course in courses)
            {
                dataGridViewCourses.Rows.Add(course.CourseID, course.CourseName, course.Credits);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim().ToLower();
            var allCourses = GetAllCourses();
            var filteredCourses = allCourses.Where(c => c.CourseName.ToLower().Contains(searchTerm)).ToList();
            LoadCourses(filteredCourses);
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
