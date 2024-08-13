namespace TinyCollegeGUI
{
    partial class EditStudentForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblGPA;
        private System.Windows.Forms.TextBox txtGPA;
        private System.Windows.Forms.Button btnSave;

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
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblGPA = new Label();
            txtGPA = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(20, 50);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(89, 21);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(110, 50);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(200, 29);
            txtFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(20, 100);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(87, 21);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(110, 100);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 29);
            txtLastName.TabIndex = 3;
            // 
            // lblGPA
            // 
            lblGPA.AutoSize = true;
            lblGPA.Location = new Point(20, 150);
            lblGPA.Name = "lblGPA";
            lblGPA.Size = new Size(42, 21);
            lblGPA.TabIndex = 4;
            lblGPA.Text = "GPA:";
            // 
            // txtGPA
            // 
            txtGPA.Location = new Point(110, 150);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(200, 29);
            txtGPA.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(110, 200);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 30);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // EditStudentForm
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(350, 250);
            Controls.Add(lblFirstName);
            Controls.Add(txtFirstName);
            Controls.Add(lblLastName);
            Controls.Add(txtLastName);
            Controls.Add(lblGPA);
            Controls.Add(txtGPA);
            Controls.Add(btnSave);
            Name = "EditStudentForm";
            Text = "Edit Student Information";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

