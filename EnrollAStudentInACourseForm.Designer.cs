namespace TinyCollegeGUI
{
    partial class EnrollAStudentInACourseForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            CoursecomboBox = new ComboBox();
            label2 = new Label();
            StudentcomboBox = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 41);
            label1.Name = "label1";
            label1.Size = new Size(118, 21);
            label1.TabIndex = 0;
            label1.Text = "Select A Course";
            // 
            // CoursecomboBox
            // 
            CoursecomboBox.FormattingEnabled = true;
            CoursecomboBox.Location = new Point(42, 86);
            CoursecomboBox.Name = "CoursecomboBox";
            CoursecomboBox.Size = new Size(169, 29);
            CoursecomboBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 41);
            label2.Name = "label2";
            label2.Size = new Size(122, 21);
            label2.TabIndex = 2;
            label2.Text = "Select A Student";
            // 
            // StudentcomboBox
            // 
            StudentcomboBox.FormattingEnabled = true;
            StudentcomboBox.Location = new Point(288, 86);
            StudentcomboBox.Name = "StudentcomboBox";
            StudentcomboBox.Size = new Size(169, 29);
            StudentcomboBox.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(191, 173);
            button1.Name = "button1";
            button1.Size = new Size(106, 30);
            button1.TabIndex = 4;
            button1.Text = "A&dd";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(191, 274);
            button2.Name = "button2";
            button2.Size = new Size(106, 30);
            button2.TabIndex = 5;
            button2.Text = "C&lose";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // EnrollAStudentInACourseForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(542, 370);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(StudentcomboBox);
            Controls.Add(label2);
            Controls.Add(CoursecomboBox);
            Controls.Add(label1);
            Name = "EnrollAStudentInACourseForm";
            Text = "EnrollAStudentInACourseForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CoursecomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox StudentcomboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
