namespace TinyCollegeGUI
{
    partial class DisplayCoursesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxCourses;
        private System.Windows.Forms.Button btnClose;

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
            listBoxCourses = new ListBox();
            btnClose = new Button();
            SuspendLayout();
            // 
            // listBoxCourses
            // 
            listBoxCourses.FormattingEnabled = true;
            listBoxCourses.ItemHeight = 21;
            listBoxCourses.Location = new Point(12, 12);
            listBoxCourses.Name = "listBoxCourses";
            listBoxCourses.Size = new Size(360, 256);
            listBoxCourses.TabIndex = 0;
            listBoxCourses.SelectedIndexChanged += listBoxCourses_SelectedIndexChanged;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(297, 294);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // DisplayCoursesForm
            // 
            ClientSize = new Size(384, 329);
            Controls.Add(btnClose);
            Controls.Add(listBoxCourses);
            Name = "DisplayCoursesForm";
            Text = "Display All Courses";
            ResumeLayout(false);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
