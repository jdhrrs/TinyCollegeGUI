using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TinyCollegeGUI
{
    public partial class AddStudentForm : Form
    {
        public event Action<Student> StudentAdded;

        public AddStudentForm()
        {
            InitializeComponent();
        }

        // Handle the Add button click
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Generate a new student ID by calling GetNextStudentId from the main form
            MainForm mainForm = (MainForm)this.Owner;
            int newStudentId = mainForm.GetNextStudentId();
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            double gpa = 0.0; // Default GPA

            Student newStudent = new Student(newStudentId, firstName, lastName, gpa);

            // Raise the event to notify the main form
            StudentAdded?.Invoke(newStudent);

            // Close the form
            this.Close();
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            // Initialization code if needed
        }
    }
}
