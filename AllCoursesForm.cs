using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TinyCollegeGUI
{
    public partial class DisplayCoursesForm : Form
    {
        private string connectionString = "Data Source=TinyCollege.db;Version=3;";

        public DisplayCoursesForm()
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
                                CourseId = reader.GetInt32(0),
                                CourseName = reader.GetString(1),
                                CourseCode = reader.GetString(2),
                                Credits = reader.GetInt32(3)
                            });
                        }
                    }
                }
            }
            return courses;
        }

        private void LoadCourses()
        {
            var courses = GetAllCourses();
            foreach (var course in courses)
            {
                listBoxCourses.Items.Add(course.ToString());
            }
        }

        private void listBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
