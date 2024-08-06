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
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            this.CourseIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCourses
            // 
            this.dataGridViewCourses.AutoGenerateColumns = false;
            this.dataGridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseIDColumn,
            this.CourseNameColumn,
            this.CreditsColumn});
            this.dataGridViewCourses.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.Size = new System.Drawing.Size(776, 376);
            this.dataGridViewCourses.TabIndex = 0;
            this.dataGridViewCourses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCourses_CellContentClick_1);
            // 
            // CourseIDColumn
            // 
            this.CourseIDColumn.HeaderText = "Course ID";
            this.CourseIDColumn.Name = "CourseIDColumn";
            // 
            // CourseNameColumn
            // 
            this.CourseNameColumn.HeaderText = "Course Name";
            this.CourseNameColumn.Name = "CourseNameColumn";
            // 
            // CreditsColumn
            // 
            this.CreditsColumn.HeaderText = "Credits";
            this.CreditsColumn.Name = "CreditsColumn";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(713, 423);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(713, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(695, 20);
            this.txtSearch.TabIndex = 3;
            // 
            // DisplayAllCoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridViewCourses);
            this.Name = "DisplayAllCoursesForm";
            this.Text = "Display All Courses";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn CourseIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditsColumn;
    }
}

