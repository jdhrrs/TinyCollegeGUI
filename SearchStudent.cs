using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace TinyCollegeGUI
{
    public partial class SearchStudent : Form
    {
        public SearchStudent()
        {
            InitializeComponent();
        }

        // Event handler for Find button
        private void btnFind_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TinyCollegeDB"].ConnectionString);
            using SqlDataAdapter adapter = new SqlDataAdapter(
                "SELECT * FROM Students JOIN Instructors ON Students.InstructorId = Instructors.InstructorId WHERE StudentID = @studentId", conn);
            adapter.SelectCommand.Parameters.AddWithValue("@studentId", txtStudentID.Text);
            DataTable studentTable = new DataTable();
            adapter.Fill(studentTable);
            if (studentTable.Rows.Count < 1)
            {
                lblStudentName.Text = "No student found";
                lblInstructorName.Text = string.Empty;
            }
            else
            {
                DataRow dr = studentTable.Rows[0];
                lblStudentName.Text = dr["StudentName"].ToString();
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
