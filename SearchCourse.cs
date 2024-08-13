using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace TinyCollegeGUI
{
    public partial class SearchCourse : Form
    {
        public SearchCourse()
        {
            InitializeComponent();
        }

        // Event handler for Find button
        private void btnFind_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TinyCollegeDB"].ConnectionString);
            using SqlDataAdapter adapter = new SqlDataAdapter(
                "SELECT * FROM Courses JOIN Instructors ON Courses.InstructorId = Instructors.InstructorId WHERE CourseID = @courseId", conn);
            adapter.SelectCommand.Parameters.AddWithValue("@courseId", txtCourseID.Text);
            DataTable courseTable = new DataTable();
            adapter.Fill(courseTable);
            if (courseTable.Rows.Count < 1)
            {
                lblCourseName.Text = "No course found";
                lblInstructorName.Text = string.Empty;
            }
            else
            {
                DataRow dr = courseTable.Rows[0];
                lblCourseName.Text = dr["CourseName"].ToString();
                lblInstructorName.Text = dr["InstructorName"].ToString();
            }
        }

        // Event handler for Close button
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
