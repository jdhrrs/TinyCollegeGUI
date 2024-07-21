namespace TinyCollegeGUI
{
    partial class AddCourseForm
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
            closeButton = new Button();
            addcourseButton = new Button();
            semesterofferedTextBox = new TextBox();
            coursetitleTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(closeButton);
            groupBox1.Controls.Add(addcourseButton);
            groupBox1.Controls.Add(semesterofferedTextBox);
            groupBox1.Controls.Add(coursetitleTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 341);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add a Course";
            // 
            // closeButton
            // 
            closeButton.Location = new Point(433, 274);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(94, 29);
            closeButton.TabIndex = 5;
            closeButton.Text = "Cl&ose";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // addcourseButton
            // 
            addcourseButton.Location = new Point(182, 274);
            addcourseButton.Name = "addcourseButton";
            addcourseButton.Size = new Size(94, 29);
            addcourseButton.TabIndex = 4;
            addcourseButton.Text = "&Add Course";
            addcourseButton.UseVisualStyleBackColor = true;
            // 
            // semesterofferedTextBox
            // 
            semesterofferedTextBox.Location = new Point(389, 170);
            semesterofferedTextBox.Name = "semesterofferedTextBox";
            semesterofferedTextBox.Size = new Size(227, 27);
            semesterofferedTextBox.TabIndex = 3;
            // 
            // coursetitleTextBox
            // 
            coursetitleTextBox.Location = new Point(389, 89);
            coursetitleTextBox.Name = "coursetitleTextBox";
            coursetitleTextBox.Size = new Size(227, 27);
            coursetitleTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(133, 166);
            label2.Name = "label2";
            label2.Size = new Size(167, 28);
            label2.TabIndex = 1;
            label2.Text = "Semester Offered:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(182, 85);
            label1.Name = "label1";
            label1.Size = new Size(118, 28);
            label1.TabIndex = 0;
            label1.Text = "Course Title:";
            // 
            // AddCourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "AddCourseForm";
            Text = "AddCourseForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Button addcourseButton;
        private TextBox semesterofferedTextBox;
        private TextBox coursetitleTextBox;
        private Button closeButton;
    }
}