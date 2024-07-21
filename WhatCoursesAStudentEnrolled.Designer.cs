namespace TinyCollegeGUI
{
    partial class WhatCoursesAStudentEnrolled
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            findButton = new Button();
            label3 = new Label();
            courseListBox = new ListBox();
            closeButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(findButton);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 160);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Data";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 52);
            label1.Name = "label1";
            label1.Size = new Size(114, 28);
            label1.TabIndex = 0;
            label1.Text = "Student ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 104);
            label2.Name = "label2";
            label2.Size = new Size(148, 28);
            label2.TabIndex = 1;
            label2.Text = "Student Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(246, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(288, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(246, 56);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(170, 27);
            textBox2.TabIndex = 3;
            // 
            // findButton
            // 
            findButton.Location = new Point(440, 56);
            findButton.Name = "findButton";
            findButton.Size = new Size(94, 29);
            findButton.TabIndex = 4;
            findButton.Text = "&Find";
            findButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 185);
            label3.Name = "label3";
            label3.Size = new Size(266, 28);
            label3.TabIndex = 5;
            label3.Text = "All Courses by This Student:";
            // 
            // courseListBox
            // 
            courseListBox.FormattingEnabled = true;
            courseListBox.Location = new Point(12, 216);
            courseListBox.Name = "courseListBox";
            courseListBox.Size = new Size(776, 104);
            courseListBox.TabIndex = 6;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(334, 337);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(94, 29);
            closeButton.TabIndex = 7;
            closeButton.Text = "Cl&ose";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // WhatCoursesAStudentEnrolled
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(closeButton);
            Controls.Add(courseListBox);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Name = "WhatCoursesAStudentEnrolled";
            Text = "What Courses A Student Enrolled";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button findButton;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private ListBox courseListBox;
        private Button closeButton;
    }
}