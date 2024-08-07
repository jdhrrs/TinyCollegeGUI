using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TinyCollegeGUI
{
    public partial class ManageCoursesForm : Form
    {
        private List<Course> courses = new List<Course>();

        public ManageCoursesForm()
        {
            InitializeComponent();
            LoadCourses();
        }

        private void LoadCourses()
        {
            // Load courses from the data source (e.g., file or database)
            courses = GetCourses();
            DisplayCourses();
        }

        private void DisplayCourses()
        {
            listBoxCourses.Items.Clear();
            foreach (var course in courses)
            {
                listBoxCourses.Items.Add(course.ToString());
            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            var course = new Course
            {
                CourseID = txtCourseID.Text,
                CourseName = txtCourseName.Text,
                Credits = int.Parse(txtCredits.Text)
            };
            courses.Add(course);
            SaveCourses(); // Save to data source
            DisplayCourses();
            ClearForm();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (listBoxCourses.SelectedItem != null)
            {
                var selectedCourse = courses[listBoxCourses.SelectedIndex];
                selectedCourse.CourseID = txtCourseID.Text;
                selectedCourse.CourseName = txtCourseName.Text;
                selectedCourse.Credits = int.Parse(txtCredits.Text); // Correctly parse string to int
                SaveCourses(); // Save to data source
                DisplayCourses();
                ClearForm();
            }
        }

        private void btnRemoveCourse_Click(object sender, EventArgs e)
        {
            if (listBoxCourses.SelectedItem != null)
            {
                courses.RemoveAt(listBoxCourses.SelectedIndex);
                SaveCourses(); // Save to data source
                DisplayCourses();
                ClearForm();
            }
        }

        private void listBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCourses.SelectedItem != null)
            {
                var selectedCourse = courses[listBoxCourses.SelectedIndex];
                txtCourseID.Text = selectedCourse.CourseID;
                txtCourseName.Text = selectedCourse.CourseName;
                txtCredits.Text = selectedCourse.Credits.ToString(); // Correctly convert int to string
            }
        }

        private void ClearForm()
        {
            txtCourseID.Clear();
            txtCourseName.Clear();
            txtCredits.Clear();
        }

        private void SaveCourses()
        {
            // Save courses to the data source 
        }

        private List<Course> GetCourses()
        {
            // Retrieve courses from the data source 
            return new List<Course>();
        }

        private void ManageCoursesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
