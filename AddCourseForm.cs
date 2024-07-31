using System;
using System.Windows.Forms;

namespace TinyCollegeGUI
{
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            // Logic to add a new course
            string courseID = txtCourseID.Text;
            string courseName = txtCourseName.Text;
            int credits = int.Parse(txtCredits.Text);

            // Add the course to your data source (e.g., a list, database)
            // Example: courses.Add(new Course { CourseID = courseID, CourseName = courseName, Credits = credits });

            // Clear the input fields
            txtCourseID.Clear();
            txtCourseName.Clear();
            txtCredits.Clear();
        }

        private void btnManageCourses_Click(object sender, EventArgs e)
        {
            ManageCoursesForm manageCoursesForm = new ManageCoursesForm();
            manageCoursesForm.Show();
        }
    }
}


