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
        // creates the event handler for the "Add Student" button, or in other words, makes the button functional
        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
        // the string.IsNullOrWHiteSpace method will return a boolean value. If the method’s parameter list is null or String.Empty, or only contains white-space characters then return True otherwise return False.
            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text) ||
                string.IsNullOrWhiteSpace(textBoxLastName.Text) ||
                string.IsNullOrWhiteSpace(textBoxGPA.Text) ||
                !double.TryParse(textBoxGPA.Text, out double gpa))
            {
            // system creates a message box that tells the user to enter valid, or correct, student info
                MessageBox.Show("Please enter valid student information.");
                return;
            }
            // gives values to text boxes on this form
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
