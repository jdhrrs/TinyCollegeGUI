using System;
using System.Windows.Forms;
using TinyCollege;
using System.Data.SqlClient;

namespace TinyCollegeGUI
{
    public partial class AddStudentForm : Form
    {
        public event EventHandler StudentAdded;
        public Student NewStudent { get; private set; }

        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text) ||
                string.IsNullOrWhiteSpace(textBoxLastName.Text) ||
                string.IsNullOrWhiteSpace(textBoxGPA.Text) ||
                !double.TryParse(textBoxGPA.Text, out double gpa))
            {
                MessageBox.Show("Please enter valid student information.");
                return;
            }

            NewStudent = new Student
            {
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                GPA = gpa
            };

            StudentAdded?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
