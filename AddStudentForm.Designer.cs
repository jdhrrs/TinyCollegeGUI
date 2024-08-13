namespace TinyCollegeGUI
{
    partial class AddStudentForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxGPA;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelGPA;
        private System.Windows.Forms.Button buttonAddStudent;

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
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxGPA = new TextBox();
            labelFirstName = new Label();
            labelLastName = new Label();
            labelGPA = new Label();
            buttonAddStudent = new Button();
            SuspendLayout();
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(130, 20);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(200, 29);
            textBoxFirstName.TabIndex = 0;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(130, 60);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(200, 29);
            textBoxLastName.TabIndex = 1;
            // 
            // textBoxGPA
            // 
            textBoxGPA.Location = new Point(130, 100);
            textBoxGPA.Name = "textBoxGPA";
            textBoxGPA.Size = new Size(200, 29);
            textBoxGPA.TabIndex = 2;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(20, 20);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(89, 21);
            labelFirstName.TabIndex = 3;
            labelFirstName.Text = "First Name:";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(20, 60);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(87, 21);
            labelLastName.TabIndex = 4;
            labelLastName.Text = "Last Name:";
            // 
            // labelGPA
            // 
            labelGPA.AutoSize = true;
            labelGPA.Location = new Point(20, 100);
            labelGPA.Name = "labelGPA";
            labelGPA.Size = new Size(42, 21);
            labelGPA.TabIndex = 5;
            labelGPA.Text = "GPA:";
            // 
            // buttonAddStudent
            // 
            buttonAddStudent.Location = new Point(130, 140);
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.Size = new Size(200, 33);
            buttonAddStudent.TabIndex = 6;
            buttonAddStudent.Text = "Add Student";
            buttonAddStudent.UseVisualStyleBackColor = true;
            buttonAddStudent.Click += buttonAddStudent_Click;
            // 
            // AddStudentForm
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(400, 200);
            Controls.Add(buttonAddStudent);
            Controls.Add(labelGPA);
            Controls.Add(labelLastName);
            Controls.Add(labelFirstName);
            Controls.Add(textBoxGPA);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Name = "AddStudentForm";
            Load += AddStudentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
