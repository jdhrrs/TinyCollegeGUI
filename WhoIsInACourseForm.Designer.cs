namespace TinyCollegeGUI
{
    partial class WhoIsInACourseForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCourseID;
        private System.Windows.Forms.TextBox textBoxCourseID;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.Button closeButton;

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
            groupBox1 = new GroupBox();
            labelCourseID = new Label();
            textBoxCourseID = new TextBox();
            findButton = new Button();
            dataGridViewStudents = new DataGridView();
            closeButton = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelCourseID);
            groupBox1.Controls.Add(textBoxCourseID);
            groupBox1.Controls.Add(findButton);
            groupBox1.Controls.Add(dataGridViewStudents);
            groupBox1.Controls.Add(closeButton);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 348);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Course Data";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // labelCourseID
            // 
            labelCourseID.AutoSize = true;
            labelCourseID.Location = new Point(13, 13);
            labelCourseID.Name = "labelCourseID";
            labelCourseID.Size = new Size(81, 21);
            labelCourseID.TabIndex = 0;
            labelCourseID.Text = "Course ID:";
            // 
            // textBoxCourseID
            // 
            textBoxCourseID.Location = new Point(76, 10);
            textBoxCourseID.Name = "textBoxCourseID";
            textBoxCourseID.Size = new Size(100, 29);
            textBoxCourseID.TabIndex = 1;
            // 
            // findButton
            // 
            findButton.Location = new Point(182, 8);
            findButton.Name = "findButton";
            findButton.Size = new Size(75, 23);
            findButton.TabIndex = 2;
            findButton.Text = "Find";
            findButton.UseVisualStyleBackColor = true;
            findButton.Click += findButton_Click;
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Location = new Point(16, 37);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.Size = new Size(441, 150);
            dataGridViewStudents.TabIndex = 3;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(382, 193);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 4;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // WhoIsInACourseForm
            // 
            ClientSize = new Size(469, 228);
            Controls.Add(groupBox1);
            Name = "WhoIsInACourseForm";
            Text = "Who Is In A Course";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ResumeLayout(false);
        }
    }
}
