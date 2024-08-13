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
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.btnEditSelectedStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.Size = new System.Drawing.Size(760, 400);
            this.dataGridViewStudents.TabIndex = 0;
            // 
            // btnEditSelectedStudent
            // 
            this.btnEditSelectedStudent.Location = new System.Drawing.Point(340, 430);
            this.btnEditSelectedStudent.Name = "btnEditSelectedStudent";
            this.btnEditSelectedStudent.Size = new System.Drawing.Size(100, 30);
            this.btnEditSelectedStudent.TabIndex = 1;
            this.btnEditSelectedStudent.Text = "Edit Student";
            this.btnEditSelectedStudent.UseVisualStyleBackColor = true;
            this.btnEditSelectedStudent.Click += new System.EventHandler(this.btnEditSelectedStudent_Click);
            // 
            // SelectStudentForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 481);
            this.Controls.Add(this.btnEditSelectedStudent);
            this.Controls.Add(this.dataGridViewStudents);
            this.Name = "SelectStudentForm";
            this.Text = "Select Student to Edit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
