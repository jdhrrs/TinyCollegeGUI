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
        private void buttonFind_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TinyCollegeDB"].ConnectionString);
            using SqlDataAdapter adapter = new SqlDataAdapter(
            // Tells system to SELECT info FROM the joined (or combined) Students and Instructors tables
                "SELECT Students.FirstName, Students.LastName, Instructors.InstructorName FROM Students JOIN Instructors ON Students.InstructorId = Instructors.InstructorId WHERE StudentID = @studentId", conn);
            adapter.SelectCommand.Parameters.AddWithValue("@studentId", textBoxStudentID.Text);
            DataTable studentTable = new DataTable();
            adapter.Fill(studentTable);
            if (studentTable.Rows.Count < 1)
            {
                textBoxStudentName.Text = "No student found";
                labelInstructorNameValue.Text = string.Empty;
            }
            else
            {
                DataRow dr = studentTable.Rows[0];
                textBoxStudentName.Text = dr["FirstName"].ToString() + " " + dr["LastName"].ToString();
                labelInstructorNameValue.Text = dr["InstructorName"].ToString();
            }
        }

        // Event handler for Close button
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
