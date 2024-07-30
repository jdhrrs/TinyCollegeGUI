namespace TinyCollegeGUI
{
    partial class AddCourseForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtCourseName;
        private TextBox txtCourseCode;
        private TextBox txtCredits;
        private Button btnSaveCourse;
        private Label lblCourseName;
        private Label lblCourseCode;
        private Label lblCredits;

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
            this.txtCourseName = new TextBox();
            this.txtCourseCode = new TextBox();
            this.txtCredits = new TextBox();
            this.btnSaveCourse = new Button();
            this.lblCourseName = new Label();
            this.lblCourseCode = new Label();
            this.lblCredits = new Label();
            this.SuspendLayout();
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(150, 30);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(200, 22);
            this.txtCourseName.TabIndex = 0;
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.Location = new System.Drawing.Point(150, 70);
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(200, 22);
            this.txtCourseCode.TabIndex = 1;
            // 
            // txtCredits
            // 
            this.txtCredits.Location = new System.Drawing.Point(150, 110);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(200, 22);
            this.txtCredits.TabIndex = 2;
            // 
            // btnSaveCourse
            // 
            this.btnSaveCourse.Location = new System.Drawing.Point(150, 150);
            this.btnSaveCourse.Name = "btnSaveCourse";
            this.btnSaveCourse.Size = new System.Drawing.Size(100, 30);
            this.btnSaveCourse.TabIndex = 3;
            this.btnSaveCourse.Text = "Save Course";
            this.btnSaveCourse.UseVisualStyleBackColor = true;
            this.btnSaveCourse.Click += new System.EventHandler(this.btnSaveCourse_Click);
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(30, 30);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(90, 17);
            this.lblCourseName.TabIndex = 4;
            this.lblCourseName.Text = "Course Name:";
            // 
            // lblCourseCode
            // 
            this.lblCourseCode.AutoSize = true;
            this.lblCourseCode.Location = new System.Drawing.Point(30, 70);
            this.lblCourseCode.Name = "lblCourseCode";
            this.lblCourseCode.Size = new System.Drawing.Size(88, 17);
            this.lblCourseCode.TabIndex = 5;
            this.lblCourseCode.Text = "Course Code:";
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Location = new System.Drawing.Point(30, 110);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(52, 17);
            this.lblCredits.TabIndex = 6;
            this.lblCredits.Text = "Credits:";
            // 
            // AddCourseForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.lblCourseCode);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.btnSaveCourse);
            this.Controls.Add(this.txtCredits);
            this.Controls.Add(this.txtCourseCode);
            this.Controls.Add(this.txtCourseName);
            this.Name = "AddCourseForm";
            this.Text = "Add New Course";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
