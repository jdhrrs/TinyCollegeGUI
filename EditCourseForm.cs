using System;
using System.Windows.Forms;

namespace TinyCollege
{
    public partial class EditCourseForm : Form
    {
        private string courseId;

        public EditCourseForm(string courseId)
        {
            InitializeComponent();
            this.courseId = courseId;
            // Load course details into the form
            // var course = Database.GetCourse(courseId);
            // txtCourseName.Text = course.Name;
            // txtCourseCode.Text = course.Code;
            // txtCredits.Text = course.Credits.ToString();
        }

        private void btnSaveCourse_Click(object sender, EventArgs e)
        {
            // Code to update course information in the database
            string courseName = txtCourseName.Text;
            string courseCode = txtCourseCode.Text;
            int credits;
            if (int.TryParse(txtCredits.Text, out credits))
            {
                // Update course in the database
                // Database.UpdateCourse(courseId, courseName, courseCode, credits);
                MessageBox.Show("Course updated successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter valid credits.");
            }
        }
    }
}

