using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinyCollege
{
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
        }

        private void btnSaveCourse_Click(object sender, EventArgs e)
        {
            // Code to save new course to the database
            string courseName = txtCourseName.Text;
            string courseCode = txtCourseCode.Text;
            int credits;
            if (int.TryParse(txtCredits.Text, out credits))
            {
                // Save course to the database
                // Database.SaveCourse(courseName, courseCode, credits);
                MessageBox.Show("Course added successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter valid credits.");
            }
        }
    }
}
