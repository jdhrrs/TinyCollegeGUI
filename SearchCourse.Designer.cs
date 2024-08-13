namespace TinyCollegeGUI
{
    partial class SearchCourse
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCourseID;
        private System.Windows.Forms.Label labelCourseName;
        private System.Windows.Forms.Label labelInstructorName;
        private System.Windows.Forms.TextBox textBoxCourseID;
        private System.Windows.Forms.Label labelCourseNameValue;
        private System.Windows.Forms.Label labelInstructorNameValue;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonClose;

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            labelCourseID = new Label();
            labelCourseName = new Label();
            labelInstructorName = new Label();
            textBoxCourseID = new TextBox();
            labelCourseNameValue = new Label();
            labelInstructorNameValue = new Label();
            buttonFind = new Button();
            buttonClose = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(labelCourseID);
            groupBox1.Controls.Add(labelCourseName);
            groupBox1.Controls.Add(labelInstructorName);
            groupBox1.Controls.Add(textBoxCourseID);
            groupBox1.Controls.Add(labelCourseNameValue);
            groupBox1.Controls.Add(labelInstructorNameValue);
            groupBox1.Controls.Add(buttonFind);
            groupBox1.Controls.Add(buttonClose);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search for a course";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // labelCourseID
            // 
            labelCourseID.AutoSize = true;
            labelCourseID.Location = new Point(6, 22);
            labelCourseID.Name = "labelCourseID";
            labelCourseID.Size = new Size(81, 21);
            labelCourseID.TabIndex = 0;
            labelCourseID.Text = "Course ID:";
            // 
            // labelCourseName
            // 
            labelCourseName.AutoSize = true;
            labelCourseName.Location = new Point(6, 48);
            labelCourseName.Name = "labelCourseName";
            labelCourseName.Size = new Size(108, 21);
            labelCourseName.TabIndex = 1;
            labelCourseName.Text = "Course Name:";
            // 
            // labelInstructorName
            // 
            labelInstructorName.AutoSize = true;
            labelInstructorName.Location = new Point(6, 74);
            labelInstructorName.Name = "labelInstructorName";
            labelInstructorName.Size = new Size(126, 21);
            labelInstructorName.TabIndex = 2;
            labelInstructorName.Text = "Instructor Name:";
            // 
            // textBoxCourseID
            // 
            textBoxCourseID.Location = new Point(96, 19);
            textBoxCourseID.Name = "textBoxCourseID";
            textBoxCourseID.Size = new Size(100, 29);
            textBoxCourseID.TabIndex = 3;
            // 
            // labelCourseNameValue
            // 
            labelCourseNameValue.AutoSize = true;
            labelCourseNameValue.Location = new Point(96, 48);
            labelCourseNameValue.Name = "labelCourseNameValue";
            labelCourseNameValue.Size = new Size(0, 21);
            labelCourseNameValue.TabIndex = 4;
            // 
            // labelInstructorNameValue
            // 
            labelInstructorNameValue.AutoSize = true;
            labelInstructorNameValue.Location = new Point(96, 74);
            labelInstructorNameValue.Name = "labelInstructorNameValue";
            labelInstructorNameValue.Size = new Size(0, 21);
            labelInstructorNameValue.TabIndex = 5;
            // 
            // buttonFind
            // 
            buttonFind.Location = new Point(279, 14);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(75, 29);
            buttonFind.TabIndex = 6;
            buttonFind.Text = "Find";
            buttonFind.UseVisualStyleBackColor = true;
            buttonFind.Click += buttonFind_Click;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(279, 46);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 31);
            buttonClose.TabIndex = 7;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // SearchCourse
            // 
            ClientSize = new Size(384, 221);
            Controls.Add(groupBox1);
            Name = "SearchCourse";
            Text = "SearchCourse";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
