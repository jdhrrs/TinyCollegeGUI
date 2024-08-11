using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace TinyCollegeGUI
{
    public partial class DeleteCourse : Form
    {
        public DeleteCourse()
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
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
                DataRow dr = courseTable.Rows[0];
                lblCourseName.Text = dr["CourseName"].ToString();
                lblInstructorName.Text = dr["InstructorName"].ToString();
            }
        }

        // Event handler for Delete button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TinyCollegeDB"].ConnectionString);
            using SqlCommand comd = new SqlCommand("DELETE FROM Courses WHERE CourseID = @courseId", conn);
            conn.Open();
            comd.Parameters.AddWithValue("@courseId", txtCourseID.Text);
            comd.ExecuteNonQuery();
            MessageBox.Show("Course deleted.");
        }

        // Event handler for Close button
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
