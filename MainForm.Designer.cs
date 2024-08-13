namespace TinyCollegeGUI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.Button btnGenerateStudentReport;
        private System.Windows.Forms.Button btnGenerateCourseReport;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Label label1;

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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            btnEditStudent = new Button();
            btnGenerateStudentReport = new Button();
            btnGenerateCourseReport = new Button();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            label1 = new Label();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(50, 97);
            button1.Name = "button1";
            button1.Size = new Size(239, 77);
            button1.TabIndex = 1;
            button1.Text = "Add a Student";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(50, 180);
            button2.Name = "button2";
            button2.Size = new Size(239, 70);
            button2.TabIndex = 2;
            button2.Text = "Display All Students";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(50, 256);
            button3.Name = "button3";
            button3.Size = new Size(239, 76);
            button3.TabIndex = 3;
            button3.Text = "Enroll a Student in a Course";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(0, 0);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 0;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonFace;
            button5.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(450, 97);
            button5.Name = "button5";
            button5.Size = new Size(211, 77);
            button5.TabIndex = 5;
            button5.Text = "Add a Course";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonFace;
            button6.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(450, 180);
            button6.Name = "button6";
            button6.Size = new Size(211, 71);
            button6.TabIndex = 6;
            button6.Text = "Display All Courses";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ButtonFace;
            button7.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(450, 257);
            button7.Name = "button7";
            button7.Size = new Size(211, 75);
            button7.TabIndex = 7;
            button7.Text = "Who is in a Course";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ButtonFace;
            button8.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(50, 416);
            button8.Name = "button8";
            button8.Size = new Size(239, 72);
            button8.TabIndex = 8;
            button8.Text = "Exit";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // btnEditStudent
            // 
            btnEditStudent.BackColor = SystemColors.ButtonFace;
            btnEditStudent.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditStudent.Location = new Point(450, 338);
            btnEditStudent.Name = "btnEditStudent";
            btnEditStudent.Size = new Size(211, 72);
            btnEditStudent.TabIndex = 9;
            btnEditStudent.Text = "Edit Student";
            btnEditStudent.UseVisualStyleBackColor = false;
            btnEditStudent.Click += btnEditStudent_Click;
            // 
            // btnGenerateStudentReport
            // 
            btnGenerateStudentReport.BackColor = SystemColors.ButtonFace;
            btnGenerateStudentReport.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateStudentReport.Location = new Point(50, 338);
            btnGenerateStudentReport.Name = "btnGenerateStudentReport";
            btnGenerateStudentReport.Size = new Size(239, 72);
            btnGenerateStudentReport.TabIndex = 10;
            btnGenerateStudentReport.Text = "Generate Student Report";
            btnGenerateStudentReport.UseVisualStyleBackColor = false;
            btnGenerateStudentReport.Click += btnGenerateStudentReport_Click;
            // 
            // btnGenerateCourseReport
            // 
            btnGenerateCourseReport.BackColor = SystemColors.ButtonFace;
            btnGenerateCourseReport.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateCourseReport.Location = new Point(450, 416);
            btnGenerateCourseReport.Name = "btnGenerateCourseReport";
            btnGenerateCourseReport.Size = new Size(211, 72);
            btnGenerateCourseReport.TabIndex = 11;
            btnGenerateCourseReport.Text = "Generate Course Report";
            btnGenerateCourseReport.UseVisualStyleBackColor = false;
            btnGenerateCourseReport.Click += btnGenerateCourseReport_Click;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 598);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(738, 22);
            statusStrip.TabIndex = 12;
            statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(0, 17);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Ivory;
            label1.Location = new Point(167, 31);
            label1.Name = "label1";
            label1.Size = new Size(533, 34);
            label1.TabIndex = 13;
            label1.Text = "Tiny College Course Tracking System";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(738, 620);
            Controls.Add(label1);
            Controls.Add(statusStrip);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button8);
            Controls.Add(btnEditStudent);
            Controls.Add(btnGenerateStudentReport);
            Controls.Add(btnGenerateCourseReport);
            Cursor = Cursors.AppStarting;
            Name = "MainForm";
            Text = "Welcome";
            Load += MainForm_Load;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
