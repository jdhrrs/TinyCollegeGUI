namespace TinyCollegeGUI
{
    partial class SearchStudent
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.Label labelInstructorName;
        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.Label labelInstructorNameValue;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonClose;

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
            labelStudentID = new Label();
            labelStudentName = new Label();
            labelInstructorName = new Label();
            textBoxStudentID = new TextBox();
            textBoxStudentName = new TextBox();
            labelInstructorNameValue = new Label();
            buttonFind = new Button();
            buttonClose = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(labelStudentID);
            groupBox1.Controls.Add(labelStudentName);
            groupBox1.Controls.Add(labelInstructorName);
            groupBox1.Controls.Add(textBoxStudentID);
            groupBox1.Controls.Add(textBoxStudentName);
            groupBox1.Controls.Add(labelInstructorNameValue);
            groupBox1.Controls.Add(buttonFind);
            groupBox1.Controls.Add(buttonClose);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search for a student";
            // 
            // labelStudentID
            // 
            labelStudentID.AutoSize = true;
            labelStudentID.Location = new Point(6, 22);
            labelStudentID.Name = "labelStudentID";
            labelStudentID.Size = new Size(85, 21);
            labelStudentID.TabIndex = 0;
            labelStudentID.Text = "Student ID:";
            // 
            // labelStudentName
            // 
            labelStudentName.AutoSize = true;
            labelStudentName.Location = new Point(6, 48);
            labelStudentName.Name = "labelStudentName";
            labelStudentName.Size = new Size(112, 21);
            labelStudentName.TabIndex = 1;
            labelStudentName.Text = "Student Name:";
            // 
            // labelInstructorName
            // 
            labelInstructorName.AutoSize = true;
            labelInstructorName.Location = new Point(6, 74);
            labelInstructorName.Name = "labelInstructorName";
            labelInstructorName.Size = new Size(126, 21);
            labelInstructorName.TabIndex = 2;
            labelInstructorName.Text = "Instructor Name:";
            // 
            // textBoxStudentID
            // 
            textBoxStudentID.Location = new Point(124, 19);
            textBoxStudentID.Name = "textBoxStudentID";
            textBoxStudentID.Size = new Size(149, 29);
            textBoxStudentID.TabIndex = 3;
            // 
            // textBoxStudentName
            // 
            textBoxStudentName.Location = new Point(124, 48);
            textBoxStudentName.Name = "textBoxStudentName";
            textBoxStudentName.Size = new Size(149, 29);
            textBoxStudentName.TabIndex = 4;
            // 
            // labelInstructorNameValue
            // 
            labelInstructorNameValue.AutoSize = true;
            labelInstructorNameValue.Location = new Point(96, 74);
            labelInstructorNameValue.Name = "labelInstructorNameValue";
            labelInstructorNameValue.Size = new Size(0, 21);
            labelInstructorNameValue.TabIndex = 5;
            // 
            // buttonFind
            // 
            buttonFind.Location = new Point(279, 14);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(75, 29);
            buttonFind.TabIndex = 6;
            buttonFind.Text = "Find";
            buttonFind.UseVisualStyleBackColor = true;
            buttonFind.Click += buttonFind_Click;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(279, 44);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 30);
            buttonClose.TabIndex = 7;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // SearchStudent
            // 
            ClientSize = new Size(384, 221);
            Controls.Add(groupBox1);
            Name = "SearchStudent";
            Text = "SearchStudent";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }
    }
}
