namespace TinyCollege
{
    partial class EditCourseForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtCourseName;
        private TextBox txtCourseCode;
        private TextBox txtCredits;
        private Button btnSaveCourse;
        private Label lblCourseName;
        private Label lblCourseCode;
        private Label lblCredits;

        private void InitializeComponent()
        {
            txtCourseName = new TextBox();
            txtCourseCode = new TextBox();
            txtCredits = new TextBox();
            btnSaveCourse = new Button();
            lblCourseName = new Label();
            lblCourseCode = new Label();
            lblCredits = new Label();
            SuspendLayout();
            // 
            // txtCourseName
            // 
            txtCourseName.Location = new Point(150, 30);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(200, 29);
            txtCourseName.TabIndex = 0;
            // 
            // txtCourseCode
            // 
            txtCourseCode.Location = new Point(150, 70);
            txtCourseCode.Name = "txtCourseCode";
            txtCourseCode.Size = new Size(200, 29);
            txtCourseCode.TabIndex = 1;
            // 
            // txtCredits
            // 
            txtCredits.Location = new Point(150, 110);
            txtCredits.Name = "txtCredits";
            txtCredits.Size = new Size(200, 29);
            txtCredits.TabIndex = 2;
            // 
            // btnSaveCourse
            // 
            btnSaveCourse.Location = new Point(150, 150);
            btnSaveCourse.Name = "btnSaveCourse";
            btnSaveCourse.Size = new Size(100, 30);
            btnSaveCourse.TabIndex = 3;
            btnSaveCourse.Text = "Save Course";
            btnSaveCourse.UseVisualStyleBackColor = true;
            btnSaveCourse.Click += btnSaveCourse_Click;
            // 
            // lblCourseName
            // 
            lblCourseName.AutoSize = true;
            lblCourseName.Location = new Point(30, 30);
            lblCourseName.Name = "lblCourseName";
            lblCourseName.Size = new Size(108, 21);
            lblCourseName.TabIndex = 4;
            lblCourseName.Text = "Course Name:";
            // 
            // lblCourseCode
            // 
            lblCourseCode.AutoSize = true;
            lblCourseCode.Location = new Point(30, 70);
            lblCourseCode.Name = "lblCourseCode";
            lblCourseCode.Size = new Size(102, 21);
            lblCourseCode.TabIndex = 5;
            lblCourseCode.Text = "Course Code:";
            // 
            // lblCredits
            // 
            lblCredits.AutoSize = true;
            lblCredits.Location = new Point(30, 110);
            lblCredits.Name = "lblCredits";
            lblCredits.Size = new Size(62, 21);
            lblCredits.TabIndex = 6;
            lblCredits.Text = "Credits:";
            // 
            // EditCourseForm
            // 
            ClientSize = new Size(400, 200);
            Controls.Add(lblCredits);
            Controls.Add(lblCourseCode);
            Controls.Add(lblCourseName);
            Controls.Add(btnSaveCourse);
            Controls.Add(txtCredits);
            Controls.Add(txtCourseCode);
            Controls.Add(txtCourseName);
            Name = "EditCourseForm";
            Text = "Edit Course Information";
            Load += EditCourseForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
