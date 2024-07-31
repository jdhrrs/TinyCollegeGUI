﻿namespace TinyCollegeGUI
{
    partial class DisplayAllCoursesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewCourses;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credits;

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
            dataGridViewCourses = new DataGridView();
            CourseId = new DataGridViewTextBoxColumn();
            CourseName = new DataGridViewTextBoxColumn();
            CourseCode = new DataGridViewTextBoxColumn();
            Credits = new DataGridViewTextBoxColumn();
            btnClose = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCourses
            // 
            dataGridViewCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCourses.Columns.AddRange(new DataGridViewColumn[] { CourseId, CourseName, CourseCode, Credits });
            dataGridViewCourses.Location = new Point(12, 50);
            dataGridViewCourses.Name = "dataGridViewCourses";
            dataGridViewCourses.RowHeadersWidth = 51;
            dataGridViewCourses.RowTemplate.Height = 24;
            dataGridViewCourses.Size = new Size(600, 276);
            dataGridViewCourses.TabIndex = 0;
            dataGridViewCourses.CellContentClick += dataGridViewCourses_CellContentClick;
            // 
            // CourseId
            // 
            CourseId.HeaderText = "Course ID";
            CourseId.MinimumWidth = 6;
            CourseId.Name = "CourseId";
            CourseId.Width = 125;
            // 
            // CourseName
            // 
            CourseName.HeaderText = "Course Name";
            CourseName.MinimumWidth = 6;
            CourseName.Name = "CourseName";
            CourseName.Width = 150;
            // 
            // CourseCode
            // 
            CourseCode.HeaderText = "Course Code";
            CourseCode.MinimumWidth = 6;
            CourseCode.Name = "CourseCode";
            CourseCode.Width = 150;
            // 
            // Credits
            // 
            Credits.HeaderText = "Credits";
            Credits.MinimumWidth = 6;
            Credits.Name = "Credits";
            Credits.Width = 125;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(537, 332);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 29);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(218, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // DisplayAllCoursesForm
            // 
            ClientSize = new Size(624, 367);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnClose);
            Controls.Add(dataGridViewCourses);
            Name = "DisplayAllCoursesForm";
            Text = "Display All Courses";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
