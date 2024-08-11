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
        private System.Windows.Forms.Button buttonDeleteCourse;
        private System.Windows.Forms.Button buttonFindStudent;
        private System.Windows.Forms.Button buttonFindCourse;
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.buttonDeleteCourse = new System.Windows.Forms.Button();
            this.buttonFindStudent = new System.Windows.Forms.Button();
            this.buttonFindCourse = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(121, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 77);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add a Student";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(121, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 70);
            this.button2.TabIndex = 2;
            this.button2.Text = "Display All Students";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(121, 256);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(239, 76);
            this.button3.TabIndex = 3;
            this.button3.Text = "Enroll a Student in a Course";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(121, 338);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(239, 78);
            this.button4.TabIndex = 4;
            this.button4.Text = "What Courses a Student Enrolled In";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(508, 97);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(211, 77);
            this.button5.TabIndex = 5;
            this.button5.Text = "Add a Course";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.buttonAddCourse_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(508, 180);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(211, 71);
            this.button6.TabIndex = 6;
            this.button6.Text = "Display All Courses";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(508, 257);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(211, 75);
            this.button7.TabIndex = 7;
            this.button7.Text = "Who is in a Course";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button8.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(508, 338);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(211, 78);
            this.button8.TabIndex = 8;
            this.button8.Text = "Exit";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // buttonDeleteCourse
            // 
            this.buttonDeleteCourse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDeleteCourse.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteCourse.Location = new System.Drawing.Point(750, 97);
            this.buttonDeleteCourse.Name = "buttonDeleteCourse";
            this.buttonDeleteCourse.Size = new System.Drawing.Size(211, 77);
            this.buttonDeleteCourse.TabIndex = 9;
            this.buttonDeleteCourse.Text = "Delete a Course";
            this.buttonDeleteCourse.UseVisualStyleBackColor = false;
            this.buttonDeleteCourse.Click += new System.EventHandler(this.buttonDeleteCourse_Click);
            // 
            // buttonFindStudent
            // 
            this.buttonFindStudent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonFindStudent.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindStudent.Location = new System.Drawing.Point(750, 180);
            this.buttonFindStudent.Name = "buttonFindStudent";
            this.buttonFindStudent.Size = new System.Drawing.Size(211, 71);
            this.buttonFindStudent.TabIndex = 10;
            this.buttonFindStudent.Text = "Find Student";
            this.buttonFindStudent.UseVisualStyleBackColor = false;
            this.buttonFindStudent.Click += new System.EventHandler(this.buttonFindStudent_Click);
            // 
            // buttonFindCourse
            // 
            this.buttonFindCourse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonFindCourse.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindCourse.Location = new System.Drawing.Point(750, 257);
            this.buttonFindCourse.Name = "buttonFindCourse";
            this.buttonFindCourse.Size = new System.Drawing.Size(211, 75);
            this.buttonFindCourse.TabIndex = 11;
            this.buttonFindCourse.Text = "Find Course";
            this.buttonFindCourse.UseVisualStyleBackColor = false;
            this.buttonFindCourse.Click += new System.EventHandler(this.buttonFindCourse_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 477);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip.TabIndex = 12;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 23.9999962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(167, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 34);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tiny College Course Tracking System";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1008, 499);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.buttonFindCourse);
            this.Controls.Add(this.buttonFindStudent);
            this.Controls.Add(this.buttonDeleteCourse);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Name = "MainForm";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
