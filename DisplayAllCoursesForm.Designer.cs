namespace TinyCollegeGUI
{
    partial class DisplayAllCoursesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewCourses;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDeleteCourse; // Declare the delete button
        private System.Windows.Forms.TextBox txtSearch;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewCourses = new DataGridView();
            CourseIDColumn = new DataGridViewTextBoxColumn();
            CourseNameColumn = new DataGridViewTextBoxColumn();
            CreditsColumn = new DataGridViewTextBoxColumn();
            btnClose = new Button();
            btnSearch = new Button();
            btnDeleteCourse = new Button(); // Initialize the delete button
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCourses
            // 
            dataGridViewCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCourses.Columns.AddRange(new DataGridViewColumn[] { CourseIDColumn, CourseNameColumn, CreditsColumn });
            dataGridViewCourses.Location = new Point(18, 66);
            dataGridViewCourses.Margin = new Padding(4, 5, 4, 5);
            dataGridViewCourses.Name = "dataGridViewCourses";
            dataGridViewCourses.Size = new Size(1164, 607);
            dataGridViewCourses.TabIndex = 0;
            dataGridViewCourses.CellContentClick += dataGridViewCourses_CellContentClick_1;
            // 
            // CourseIDColumn
            // 
            CourseIDColumn.HeaderText = "Course ID";
            CourseIDColumn.Name = "CourseIDColumn";
            // 
            // CourseNameColumn
            // 
            CourseNameColumn.HeaderText = "Course Name";
            CourseNameColumn.Name = "CourseNameColumn";
            // 
            // CreditsColumn
            // 
            CreditsColumn.HeaderText = "Credits";
            CreditsColumn.Name = "CreditsColumn";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1070, 683);
            btnClose.Margin = new Padding(4, 5, 4, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 37);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1070, 19);
            btnSearch.Margin = new Padding(4, 5, 4, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 37);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDeleteCourse
            // 
            btnDeleteCourse.Location = new Point(930, 683); // Set position and size
            btnDeleteCourse.Margin = new Padding(4, 5, 4, 5);
            btnDeleteCourse.Name = "btnDeleteCourse";
            btnDeleteCourse.Size = new Size(112, 37);
            btnDeleteCourse.TabIndex = 4;
            btnDeleteCourse.Text = "Delete Course";
            btnDeleteCourse.UseVisualStyleBackColor = true;
            btnDeleteCourse.Click += btnDeleteCourse_Click; // Set event handler
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(18, 19);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(1040, 29);
            txtSearch.TabIndex = 3;
            // 
            // DisplayAllCoursesForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1200, 727);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnDeleteCourse); // Add delete button to the form
            Controls.Add(btnClose);
            Controls.Add(dataGridViewCourses);
            Margin = new Padding(4, 5, 4, 5);
            Name = "DisplayAllCoursesForm";
            Text = "Display All Courses";
            Load += DisplayAllCoursesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn CourseIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditsColumn;
    }
}
