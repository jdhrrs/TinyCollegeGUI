using System;
using System.Windows.Forms;

namespace TinyCollegeGUI
{
    public partial class AddStudentForm : Form
    {
        public event EventHandler StudentAdded;
        public Student NewStudent { get; private set; } // Property to hold the new student

        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            if (double.TryParse(textBoxGPA.Text, out double gpa))
            {
                NewStudent = new Student
                {
                    FirstName = firstName,
                    LastName = lastName,
                    GPA = gpa
                };

                StudentAdded?.Invoke(this, EventArgs.Empty); // Raise the event
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid GPA value.");
            }
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            // Event handler code if needed
        }
    }
}

