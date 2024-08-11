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
            using SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Student JOIN Instructor ON Student.InstructorId = Instructor.InstructorId WHERE studentId = @studentId", conn);
            adapter.SelectCommand.Parameters.AddWithValue("studentId", textBoxStudentID.Text);
            DataTable studentTable = new DataTable();
            adapter.Fill(studentTable);
            if (studentTable.Rows.Count < 1)
            {
                textBoxStudentName.Text = "No student found";
                labelInstructorNameValue.Text = string.Empty;
                // Disable the delete button if it exists, in this case we don't have one
            }
            else
            {
                // Enable the delete button if it exists, in this case we don't have one
                DataRow dr = studentTable.Rows[0];
                textBoxStudentName.Text = dr["studentName"].ToString();
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
