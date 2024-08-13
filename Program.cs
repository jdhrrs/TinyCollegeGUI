/* 
Tiny College Student and Course Management System

This program is designed to manage student and course information for Tiny College.
It provides a graphical user interface (GUI) for performing various operations such as:
- Adding new students
- Displaying all students
- Adding new courses
- Displaying all courses
- Enrolling a student in a course
- Displaying all students in a course
- Displaying all courses taken by a student
- Deleting a course
- Deleting a student

The program connects to a SQL Server database to store and retrieve information.
It uses various forms to provide a user-friendly way to interact with the data.

Key Features:
- DataGridView for displaying data
- TextBox and Button controls for searching and performing actions
- Event handlers for handling user interactions
- Exception handling for database operations

Delete Student Functionality:
The program allows users to delete a student from the database. When a student is deleted,
all related records such as course enrollments are also removed to maintain database integrity.
*/

namespace TinyCollegeGUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}
