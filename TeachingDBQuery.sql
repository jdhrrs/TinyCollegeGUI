-- Create Students table 
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Students]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[Students](
        [StudentID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
        [FirstName] NVARCHAR(50) NOT NULL,
        [LastName] NVARCHAR(50) NOT NULL,
        [GPA] [float] NULL
    );
END;
GO

-- Create Courses table 
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Courses]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[Courses](
        [CourseID] NVARCHAR(50) NOT NULL PRIMARY KEY,
        [CourseName] NVARCHAR(100) NOT NULL,
        [Credits] [int] NOT NULL
    );
END;
GO

-- Create Enrollments table 
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Enrollments]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[Enrollments](
        [EnrollmentID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
        [StudentID] [int] NOT NULL FOREIGN KEY REFERENCES Students(StudentID),
        [CourseID] NVARCHAR(50) NOT NULL FOREIGN KEY REFERENCES Courses(CourseID)
    );
END;
GO
