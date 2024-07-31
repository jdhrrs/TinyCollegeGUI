namespace TinyCollegeGUI
{
    partial class AddCourseForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnManageCourses;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblCredits;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnAddCourse = new Button();
            btnManageCourses = new Button();
            txtCourseID = new TextBox();
            txtCourseName = new TextBox();
            txtCredits = new TextBox();
            lblCourseID = new Label();
            lblCourseName = new Label();
            lblCredits = new Label();
            SuspendLayout();
            // 
            // btnAddCourse
            // 
            btnAddCourse.Location = new Point(38, 110);
            btnAddCourse.Name = "btnAddCourse";
            btnAddCourse.Size = new Size(100, 37);
            btnAddCourse.TabIndex = 0;
            btnAddCourse.Text = "Add Course";
            btnAddCourse.UseVisualStyleBackColor = true;
            btnAddCourse.Click += btnAddCourse_Click;
            // 
            // btnManageCourses
            // 
            btnManageCourses.Location = new Point(200, 110);
            btnManageCourses.Name = "btnManageCourses";
            btnManageCourses.Size = new Size(100, 37);
            btnManageCourses.TabIndex = 1;
            btnManageCourses.Text = "Manage Courses";
            btnManageCourses.UseVisualStyleBackColor = true;
            btnManageCourses.Click += btnManageCourses_Click;
            // 
            // txtCourseID
            // 
            txtCourseID.Location = new Point(100, 20);
            txtCourseID.Name = "txtCourseID";
            txtCourseID.Size = new Size(200, 29);
            txtCourseID.TabIndex = 2;
            // 
            // txtCourseName
            // 
            txtCourseName.Location = new Point(100, 50);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(200, 29);
            txtCourseName.TabIndex = 3;
            // 
            // txtCredits
            // 
            txtCredits.Location = new Point(100, 80);
            txtCredits.Name = "txtCredits";
            txtCredits.Size = new Size(200, 29);
            txtCredits.TabIndex = 4;
            // 
            // lblCourseID
            // 
            lblCourseID.AutoSize = true;
            lblCourseID.Location = new Point(10, 20);
            lblCourseID.Name = "lblCourseID";
            lblCourseID.Size = new Size(78, 21);
            lblCourseID.TabIndex = 5;
            lblCourseID.Text = "Course ID";
            // 
            // lblCourseName
            // 
            lblCourseName.AutoSize = true;
            lblCourseName.Location = new Point(-2, 50);
            lblCourseName.Name = "lblCourseName";
            lblCourseName.Size = new Size(105, 21);
            lblCourseName.TabIndex = 6;
            lblCourseName.Text = "Course Name";
            // 
            // lblCredits
            // 
            lblCredits.AutoSize = true;
            lblCredits.Location = new Point(10, 80);
            lblCredits.Name = "lblCredits";
            lblCredits.Size = new Size(59, 21);
            lblCredits.TabIndex = 7;
            lblCredits.Text = "Credits";
            // 
            // AddCourseForm
            // 
            ClientSize = new Size(320, 150);
            Controls.Add(lblCredits);
            Controls.Add(lblCourseName);
            Controls.Add(lblCourseID);
            Controls.Add(txtCredits);
            Controls.Add(txtCourseName);
            Controls.Add(txtCourseID);
            Controls.Add(btnManageCourses);
            Controls.Add(btnAddCourse);
            Name = "AddCourseForm";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
