namespace TinyCollegeGUI
{
    public class Course
    {
        public string CourseID { get; set; }
        public string CourseName { get; set; }
        public int Credits { get; set; }

        public Course() { }

        public Course(string courseId, string courseName, int credits)
        {
            CourseID = courseId;
            CourseName = courseName;
            Credits = credits;
        }

        public override string ToString()
        {
            return $"{CourseName} ({CourseID}) - {Credits} Credits";
        }
    }
}
