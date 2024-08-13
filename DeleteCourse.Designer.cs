namespace TinyCollegeGUI
{
    partial class DeleteCourse
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
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonClose;

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCourseID = new System.Windows.Forms.Label();
            this.labelCourseName = new System.Windows.Forms.Label();
            this.labelInstructorName = new System.Windows.Forms.Label();
            this.textBoxCourseID = new System.Windows.Forms.TextBox();
            this.labelCourseNameValue = new System.Windows.Forms.Label();
            this.labelInstructorNameValue = new System.Windows.Forms.Label();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCourseID);
            this.groupBox1.Controls.Add(this.labelCourseName);
            this.groupBox1.Controls.Add(this.labelInstructorName);
            this.groupBox1.Controls.Add(this.textBoxCourseID);
            this.groupBox1.Controls.Add(this.labelCourseNameValue);
            this.groupBox1.Controls.Add(this.labelInstructorNameValue);
            this.groupBox1.Controls.Add(this.buttonFind);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.buttonClose);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete a course";
            // 
            // labelCourseID
            // 
            this.labelCourseID.AutoSize = true;
            this.labelCourseID.Location = new System.Drawing.Point(6, 22);
            this.labelCourseID.Name = "labelCourseID";
            this.labelCourseID.Size = new System.Drawing.Size(59, 13);
            this.labelCourseID.TabIndex = 0;
            this.labelCourseID.Text = "Course ID:";
            // 
            // labelCourseName
            // 
            this.labelCourseName.AutoSize = true;
            this.labelCourseName.Location = new System.Drawing.Point(6, 48);
            this.labelCourseName.Name = "labelCourseName";
            this.labelCourseName.Size = new System.Drawing.Size(74, 13);
            this.labelCourseName.TabIndex = 1;
            this.labelCourseName.Text = "Course Name:";
            // 
            // labelInstructorName
            // 
            this.labelInstructorName.AutoSize = true;
            this.labelInstructorName.Location = new System.Drawing.Point(6, 74);
            this.labelInstructorName.Name = "labelInstructorName";
            this.labelInstructorName.Size = new System.Drawing.Size(84, 13);
            this.labelInstructorName.TabIndex = 2;
            this.labelInstructorName.Text = "Instructor Name:";
            // 
            // textBoxCourseID
            // 
            this.textBoxCourseID.Location = new System.Drawing.Point(96, 19);
            this.textBoxCourseID.Name = "textBoxCourseID";
            this.textBoxCourseID.Size = new System.Drawing.Size(100, 20);
            this.textBoxCourseID.TabIndex = 3;
            // 
            // labelCourseNameValue
            // 
            this.labelCourseNameValue.AutoSize = true;
            this.labelCourseNameValue.Location = new System.Drawing.Point(96, 48);
            this.labelCourseNameValue.Name = "labelCourseNameValue";
            this.labelCourseNameValue.Size = new System.Drawing.Size(0, 13);
            this.labelCourseNameValue.TabIndex = 4;
            // 
            // labelInstructorNameValue
            // 
            this.labelInstructorNameValue.AutoSize = true;
            this.labelInstructorNameValue.Location = new System.Drawing.Point(96, 74);
            this.labelInstructorNameValue.Name = "labelInstructorNameValue";
            this.labelInstructorNameValue.Size = new System.Drawing.Size(0, 13);
            this.labelInstructorNameValue.TabIndex = 5;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(202, 17);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 6;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(202, 43);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(202, 72);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // DeleteCourse
            // 
            this.ClientSize = new System.Drawing.Size(384, 221);
            this.Controls.Add(this.groupBox1);
            this.Name = "DeleteCourse";
            this.Text = "DeleteCourse";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
