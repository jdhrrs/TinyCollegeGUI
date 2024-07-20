using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TinyCollegeGUI
{
    public partial class MainForm : Form
    {
        private List<Student> students;

        public MainForm()
        {
            InitializeComponent();
            students = new List<Student>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.StudentAdded += AddStudentForm_StudentAdded;
            addStudentForm.ShowDialog();
        }

        private void AddStudentForm_StudentAdded(Student newStudent)
        {
            students.Add(newStudent);
            toolStripStatusLabel.Text = $"Student {newStudent.FirstName} {newStudent.LastName} added successfully!";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double GPA { get; set; }

        public Student(int studentId, string firstName, string lastName, double gpa)
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
            GPA = gpa;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} (ID: {StudentId}) - GPA: {GPA}";
        }
    }
}
