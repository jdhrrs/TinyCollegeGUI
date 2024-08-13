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

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.labelInstructorName = new System.Windows.Forms.Label();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.labelInstructorNameValue = new System.Windows.Forms.Label();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelStudentID);
            this.groupBox1.Controls.Add(this.labelStudentName);
            this.groupBox1.Controls.Add(this.labelInstructorName);
            this.groupBox1.Controls.Add(this.textBoxStudentID);
            this.groupBox1.Controls.Add(this.textBoxStudentName);
            this.groupBox1.Controls.Add(this.labelInstructorNameValue);
            this.groupBox1.Controls.Add(this.buttonFind);
            this.groupBox1.Controls.Add(this.buttonClose);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search for a student";
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Location = new System.Drawing.Point(6, 22);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(61, 13);
            this.labelStudentID.TabIndex = 0;
            this.labelStudentID.Text = "Student ID:";
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Location = new System.Drawing.Point(6, 48);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(78, 13);
            this.labelStudentName.TabIndex = 1;
            this.labelStudentName.Text = "Student Name:";
            // 
            // labelInstructorName
            // 
            this.labelInstructorName.AutoSize = true;
            this.labelInstructorName.Location = new System.Drawing.Point(6, 74);
            this.labelInstructorName.Name = "labelInstructorName";
            this.labelInstructorName.Size = new System.Drawing.Size(84, 13);
            this.labelInstructorName.TabIndex = 2;
            this.labelInstructorName.Text = "Instructor Name:";
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Location = new System.Drawing.Point(96, 19);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(100, 20);
            this.textBoxStudentID.TabIndex = 3;
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.Location = new System.Drawing.Point(96, 45);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(100, 20);
            this.textBoxStudentName.TabIndex = 4;
            // 
            // labelInstructorNameValue
            // 
            this.labelInstructorNameValue.AutoSize = true;
            this.labelInstructorNameValue.Location = new System.Drawing.Point(96, 74);
            this.labelInstructorNameValue.Name = "labelInstructorNameValue";
            this.labelInstructorNameValue.Size = new System.Drawing.Size(0, 13);
            this.labelInstructorNameValue.TabIndex = 5;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(202, 17);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 6;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(202, 43);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // SearchStudent
            // 
            this.ClientSize = new System.Drawing.Size(384, 221);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchStudent";
            this.Text = "SearchStudent";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
