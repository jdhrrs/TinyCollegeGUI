using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using TinyCollegeGUI;

namespace TinyCollege
{
    public static class DatabaseHelper
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["TinyCollegeDB"].ConnectionString;
        // creates a list so the user can view all courses that are in the database and the courses' corresponding information
        public static List<Course> GetAllCourses()
        {
            List<Course> courses = new List<Course>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SELECT FROM command is used to select specific data from the table (the Course Table) in the database; SELECT tells the system exactly what info to extract and FROM tells the system where to pull that info from 
                string query = "SELECT CourseID, CourseName, Credits FROM Courses";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Course course = new Course
                    {
                        CourseID = reader.GetString(0),  // Assuming CourseID is stored as a string
                        CourseName = reader.GetString(1),
                        Credits = reader.GetInt32(2)
                    };
                    courses.Add(course);
                }
            }

            return courses;
        }
    }
}

