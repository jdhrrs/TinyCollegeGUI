using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyCollegeGUI
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double GPA { get; set; }

        public Student() { }

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
