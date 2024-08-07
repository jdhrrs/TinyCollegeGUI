namespace TinyCollegeGUI
{
    partial class ManageCoursesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnRemoveCourse;
        private System.Windows.Forms.ListBox listBoxCourses;

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
            txtCourseID = new TextBox();
            txtCourseName = new TextBox();
            txtCredits = new TextBox();
            lblCourseID = new Label();
            lblCourseName = new Label();
            lblCredits = new Label();
            btnAddCourse = new Button();
            btnSaveChanges = new Button();
            btnRemoveCourse = new Button();
            listBoxCourses = new ListBox();
            SuspendLayout();
            // 
            // txtCourseID
            // 
            txtCourseID.Location = new Point(100, 20);
            txtCourseID.Name = "txtCourseID";
            txtCourseID.Size = new Size(200, 29);
            txtCourseID.TabIndex = 0;
            // 
            // txtCourseName
            // 
            txtCourseName.Location = new Point(100, 50);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(200, 29);
            txtCourseName.TabIndex = 1;
            // 
            // txtCredits
            // 
            txtCredits.Location = new Point(100, 80);
            txtCredits.Name = "txtCredits";
            txtCredits.Size = new Size(200, 29);
            txtCredits.TabIndex = 2;
            // 
            // lblCourseID
            // 
            lblCourseID.AutoSize = true;
            lblCourseID.Location = new Point(10, 20);
            lblCourseID.Name = "lblCourseID";
            lblCourseID.Size = new Size(78, 21);
            lblCourseID.TabIndex = 3;
            lblCourseID.Text = "Course ID";
            // 
            // lblCourseName
            // 
            lblCourseName.AutoSize = true;
            lblCourseName.Location = new Point(10, 50);
            lblCourseName.Name = "lblCourseName";
            lblCourseName.Size = new Size(105, 21);
            lblCourseName.TabIndex = 4;
            lblCourseName.Text = "Course Name";
            // 
            // lblCredits
            // 
            lblCredits.AutoSize = true;
            lblCredits.Location = new Point(10, 80);
            lblCredits.Name = "lblCredits";
            lblCredits.Size = new Size(59, 21);
            lblCredits.TabIndex = 5;
            lblCredits.Text = "Credits";
            // 
            // btnAddCourse
            // 
            btnAddCourse.Location = new Point(10, 110);
            btnAddCourse.Name = "btnAddCourse";
            btnAddCourse.Size = new Size(100, 34);
            btnAddCourse.TabIndex = 6;
            btnAddCourse.Text = "Add New Course";
            btnAddCourse.UseVisualStyleBackColor = true;
            btnAddCourse.Click += btnAddCourse_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(130, 110);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(100, 34);
            btnSaveChanges.TabIndex = 7;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // btnRemoveCourse
            // 
            btnRemoveCourse.Location = new Point(250, 110);
            btnRemoveCourse.Name = "btnRemoveCourse";
            btnRemoveCourse.Size = new Size(100, 34);
            btnRemoveCourse.TabIndex = 8;
            btnRemoveCourse.Text = "Remove Course";
            btnRemoveCourse.UseVisualStyleBackColor = true;
            btnRemoveCourse.Click += btnRemoveCourse_Click;
            // 
            // listBoxCourses
            // 
            listBoxCourses.FormattingEnabled = true;
            listBoxCourses.ItemHeight = 21;
            listBoxCourses.Location = new Point(10, 150);
            listBoxCourses.Name = "listBoxCourses";
            listBoxCourses.Size = new Size(340, 193);
            listBoxCourses.TabIndex = 9;
            listBoxCourses.SelectedIndexChanged += listBoxCourses_SelectedIndexChanged;
            // 
            // ManageCoursesForm
            // 
            ClientSize = new Size(360, 370);
            Controls.Add(listBoxCourses);
            Controls.Add(btnRemoveCourse);
            Controls.Add(btnSaveChanges);
            Controls.Add(btnAddCourse);
            Controls.Add(lblCredits);
            Controls.Add(lblCourseName);
            Controls.Add(lblCourseID);
            Controls.Add(txtCredits);
            Controls.Add(txtCourseName);
            Controls.Add(txtCourseID);
            Name = "ManageCoursesForm";
            Load += ManageCoursesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
