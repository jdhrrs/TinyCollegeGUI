namespace TinyCollegeGUI
{
    public class Course
    {
        public string CourseID { get; set; }
        public string CourseName { get; set; }
        public int Credits { get; set; }

        public Course() { }
        // gives values to the info that corresponds to the courses in the database, like the course ID, the name of the course, and how many credits the course is worth
        public Course(string courseId, string courseName, int credits)
        {
            CourseID = courseId;
            CourseName = courseName;
            Credits = credits;
        }
        // override the ToString method in order to provide information about the type to client code
        public override string ToString()
        {
            return $"{CourseName} ({CourseID}) - {Credits} Credits";
        }
    }
}
