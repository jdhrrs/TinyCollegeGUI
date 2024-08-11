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
        private void buttonFind_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TinyCollegeDB"].ConnectionString);
            using SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Course JOIN Instructor ON Course.InstructorId = Instructor.InstructorId WHERE courseId = @courseId", conn);
            adapter.SelectCommand.Parameters.AddWithValue("courseId", textBoxCourseID.Text);
            DataTable courseTable = new DataTable();
            adapter.Fill(courseTable);
            if (courseTable.Rows.Count < 1)
            {
                labelCourseNameValue.Text = "No course found";
                labelInstructorNameValue.Text = string.Empty;
            }
            else
            {
                DataRow dr = courseTable.Rows[0];
                labelCourseNameValue.Text = dr["courseName"].ToString();
                labelInstructorNameValue.Text = dr["instructorName"].ToString();
            }
        }

        // Event handler for Close button
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
