using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace TinyCollegeGUI
{
    public partial class DisplayAllCoursesForm : Form
    {
        private string connectionString;

        public DisplayAllCoursesForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["TinyCollegeDB"].ConnectionString;
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
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Tells system to SELECT course info FROM courses table in database
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

        // Display the list of courses in the DataGridView
        private void DisplayCourses(List<Course> courses)
        {
            // Clear existing columns
            dataGridViewCourses.Columns.Clear();

            // Set AutoGenerateColumns to false
            dataGridViewCourses.AutoGenerateColumns = false;

            // Define columns manually
            dataGridViewCourses.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CourseID",
                HeaderText = "Course ID",
                Name = "CourseID" // Ensure the Name property matches the column name used in the code
            });
            dataGridViewCourses.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CourseName",
                HeaderText = "Course Name",
                Name = "CourseName" // Ensure the Name property matches the column name used in the code
            });
            dataGridViewCourses.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Credits",
                HeaderText = "Credits",
                Name = "Credits" // Ensure the Name property matches the column name used in the code
            });

            // Bind the list of courses to the DataGridView
            dataGridViewCourses.DataSource = courses;
        }

        // Get a connection to the database
        private SqlConnection GetConnection()
        {
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

        private void dataGridViewCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewCourses_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DisplayAllCoursesForm_Load(object sender, EventArgs e)
        {

        }

        // Delete a course and related enrollments
        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            if (dataGridViewCourses.SelectedRows.Count > 0)
            {
                var selectedCourseID = dataGridViewCourses.SelectedRows[0].Cells["CourseID"].Value.ToString();
                DeleteCourse(selectedCourseID);
            }
            else
            {
            // Tells system to display a message prompting user to select the course they would like to delete from the system
                MessageBox.Show("Please select a course to delete.");
            }
        }

        private void DeleteCourse(string courseID)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Delete related enrollments
                        var deleteEnrollmentsQuery = "DELETE FROM Enrollments WHERE CourseID = @CourseID";
                        using (var command = new SqlCommand(deleteEnrollmentsQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@CourseID", courseID);
                            command.ExecuteNonQuery();
                        }

                        // Delete the course
                        var deleteCourseQuery = "DELETE FROM Courses WHERE CourseID = @CourseID";
                        using (var command = new SqlCommand(deleteCourseQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@CourseID", courseID);
                            command.ExecuteNonQuery();
                        }
                        
                        transaction.Commit();
                        // Displays message to user to let them know when the selected course has been successfully deleted from the database
                        MessageBox.Show("Course deleted successfully.");
                        LoadCourses(); // Refresh the course list
                    }
                    // catch statement allows you to define a block of code to be executed, if an error occurs 
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        // Displays message to user to let them know there was an error when attempting to delete the selected course from the database
                        MessageBox.Show($"Error deleting course: {ex.Message}");
                    }
                }
            }
        }
    }
}
