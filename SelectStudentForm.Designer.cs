namespace TinyCollegeGUI
{
    partial class SelectStudentForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.Button btnEditSelectedStudent;

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
            dataGridViewStudents = new DataGridView();
            btnEditSelectedStudent = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Location = new Point(12, 12);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.Size = new Size(760, 400);
            dataGridViewStudents.TabIndex = 0;
            dataGridViewStudents.CellContentClick += dataGridViewStudents_CellContentClick;
            // 
            // btnEditSelectedStudent
            // 
            btnEditSelectedStudent.Location = new Point(340, 430);
            btnEditSelectedStudent.Name = "btnEditSelectedStudent";
            btnEditSelectedStudent.Size = new Size(100, 30);
            btnEditSelectedStudent.TabIndex = 1;
            btnEditSelectedStudent.Text = "Edit Student";
            btnEditSelectedStudent.UseVisualStyleBackColor = true;
            btnEditSelectedStudent.Click += btnEditSelectedStudent_Click;
            // 
            // SelectStudentForm
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(784, 481);
            Controls.Add(btnEditSelectedStudent);
            Controls.Add(dataGridViewStudents);
            Name = "SelectStudentForm";
            Text = "Select Student to Edit";
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ResumeLayout(false);
        }
    }
}
