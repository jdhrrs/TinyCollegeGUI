# TinyCollegeGUI
# Tiny College Student and Course Management System

## Overview
This project is a part of the Advanced Agile Software Development course (CISS 311) at Columbia College of Missouri. The objective is to develop a GUI application in C# for Tiny College that manages student and course information. The application includes functionalities for adding and displaying students and courses, enrolling students in courses, and managing student GPA.

## Features
- **Add New Students:** Add new student information to the system.
- **Display All Students:** View a list of all students in the system.
- **Add New Courses:** Add new courses to the system.
- **Display All Courses:** View a list of all courses offered by the college.
- **Enroll Student in Course:** Enroll a student in a specific course.
- **Display Students in Course:** View a list of all students enrolled in a specific course.
- **Display Courses Taken by Student:** View a list of all courses a student is enrolled in.
- **Manage GPA:** Update and manage students' GPA based on course credit hours and letter grades.

## Getting Started
### Prerequisites
- Visual Studio or any C# compatible IDE
- .NET Framework

### Installation
1. Clone the repository:
    ```bash
    git clone https://github.com/your-username/tiny-college-GUI.git
    ```
2. Open the solution file (`TinyCollege.sln`) in Visual Studio or your preferred IDE.

### Running the Application
1. Build the solution to restore any dependencies and compile the code.
2. Run the application. The main GUI will launch, providing access to the various features.

## Usage
### Main Menu
- **Add New Student:** Input student details (name, ID, etc.) and save.
- **Display All Students:** View and search the list of students.
- **Add New Course:** Input course details (course name, code, etc.) and save.
- **Display All Courses:** View and search the list of courses.
- **Enroll Student:** Select a student and enroll them in a chosen course.
- **Display Students in Course:** Select a course to view enrolled students.
- **Display Courses for Student:** Select a student to view their enrolled courses.
- **Update GPA:** Select a student and input course details to update GPA.

### GPA Management
- A form will prompt for course credit hours and letter grades, which are then used to calculate and update the student's GPA.

## Project Structure
- **CISS311_Dropbox7:** Namespace for the project.
- **Forms:** Contains all the forms used in the application.
- **Models:** Contains data models for students and courses.
- **Services:** Contains business logic and services for handling student and course operations.
- **Utilities:** Helper classes and utilities for the application.

## User Stories
1. As an administrator, I want to add new student records so that I can keep track of student information.
2. As an administrator, I want to view all student records so that I can manage student data.
3. As an administrator, I want to add new courses so that I can offer them to students.
4. As an administrator, I want to view all courses so that I can manage course offerings.
5. As an administrator, I want to enroll students in courses so that they can attend classes.
6. As an administrator, I want to view all students in a specific course so that I can manage enrollments.
7. As an administrator, I want to view all courses a student is enrolled in so that I can manage their academic progress.
8. As an administrator, I want to update a student's GPA so that their academic performance is accurately reflected.


## Authors
- Justin Harris   -  Student Developer
- Luis Aragon     -  Student Developer
- Phil Richey     -  Student Developer
- Madison Mato    -  Student Developer

## License
This project is licensed under the MIT License - see the `LICENSE.md` file for details.

## Acknowledgments
- Professor Miracle for guidance and support throughout the project.
- Columbia College of Missouri for providing the resources and platform for this project.

