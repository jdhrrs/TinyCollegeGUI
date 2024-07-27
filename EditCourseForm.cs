using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TinyCollegeGUI
{
    public partial class EditCourseForm : Form
    {
        private Course _course;
        private string _connectionString;

        public EditCourseForm(Course course, string connectionString)
        {
            InitializeComponent();
            _course = course;
            _connectionString = connectionString;
            LoadCourseDetails(); // Load course details into the form fields
        }

        private void LoadCourseDetails()
        {
            // Assuming textBoxCourseName and textBoxCourseDescription are textboxes in the form
            textBoxCourseName.Text = _course.Name;
            textBoxCourseDescription.Text = _course.Description;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Update course details with values from textboxes
            _course.Name = textBoxCourseName.Text;
            _course.Description = textBoxCourseDescription.Text;

            if (UpdateCourse(_course))
            {
                MessageBox.Show("Course information updated successfully.");
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Failed to update course information.");
            }
        }
           // SQLite Update usi9ng DB 
      private bool UpdateCourse(Course course)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = "UPDATE Courses SET Name = @Name, Description = @Description WHERE CourseID = @CourseID";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", course.Name);
                    command.Parameters.AddWithValue("@Description", course.Description);
                    command.Parameters.AddWithValue("@CourseID", course.CourseId);
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // Close the form without saving changes
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
