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
        private void buttonFind_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TinyCollegeDB"].ConnectionString);
            using SqlDataAdapter adapter = new SqlDataAdapter(
            // JOIN command used to combine information from two or more tables in a database - in this case, it it joining the Courses and Instructors tables
                "SELECT * FROM Courses JOIN Instructors ON Courses.InstructorId = Instructors.InstructorId WHERE CourseID = @courseId", conn);
            adapter.SelectCommand.Parameters.AddWithValue("@courseId", textBoxCourseID.Text);
            DataTable courseTable = new DataTable();
            adapter.Fill(courseTable);
            if (courseTable.Rows.Count < 1)
            // Tells system to display a message letting the user know if the course info they entered is not found in the database
            {
                labelCourseNameValue.Text = "No course found";
                labelInstructorNameValue.Text = string.Empty;
                buttonDelete.Enabled = false;
            }
            else
            {
                buttonDelete.Enabled = true;
                DataRow dr = courseTable.Rows[0];
                labelCourseNameValue.Text = dr["CourseName"].ToString();
                labelInstructorNameValue.Text = dr["InstructorName"].ToString();
            }
        }

        // Event handler for Delete button
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TinyCollegeDB"].ConnectionString);
            // Deletes course from database when the delete button is clicked by user; DELETE FROM method tells the system where to delete the corresponding info from from the database, in this case, it is deleting from the Courses table
            using SqlCommand comd = new SqlCommand("DELETE FROM Courses WHERE CourseID = @courseId", conn);
            conn.Open();
            comd.Parameters.AddWithValue("@courseId", textBoxCourseID.Text);
            comd.ExecuteNonQuery();
            // System creates a message box telling the user when the course is successfully deleted from the database
            MessageBox.Show("Course deleted.");
        }

        // Event handler for Close button
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
