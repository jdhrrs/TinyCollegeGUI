namespace TinyCollegeGUI
{
    partial class WhoIsInACourseForm
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
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            studentsListBox = new ListBox();
            closeButton = new Button();
            findButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(findButton);
            groupBox1.Controls.Add(closeButton);
            groupBox1.Controls.Add(studentsListBox);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 348);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Course Data";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(114, 41);
            label1.Name = "label1";
            label1.Size = new Size(106, 28);
            label1.TabIndex = 0;
            label1.Text = "Course ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(95, 97);
            label2.Name = "label2";
            label2.Size = new Size(125, 28);
            label2.TabIndex = 1;
            label2.Text = "Course Title:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 153);
            label3.Name = "label3";
            label3.Size = new Size(342, 28);
            label3.TabIndex = 2;
            label3.Text = "All Students Enrolled In This Course:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(290, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(290, 45);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 4;
            // 
            // studentsListBox
            // 
            studentsListBox.FormattingEnabled = true;
            studentsListBox.Location = new Point(6, 184);
            studentsListBox.Name = "studentsListBox";
            studentsListBox.Size = new Size(754, 104);
            studentsListBox.TabIndex = 5;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(321, 304);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(94, 29);
            closeButton.TabIndex = 6;
            closeButton.Text = "Cl&ose";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // findButton
            // 
            findButton.Location = new Point(458, 45);
            findButton.Name = "findButton";
            findButton.Size = new Size(94, 29);
            findButton.TabIndex = 7;
            findButton.Text = "&Find";
            findButton.UseVisualStyleBackColor = true;
            // 
            // WhoIsInACourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "WhoIsInACourseForm";
            Text = "Who Is In A Course";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button findButton;
        private Button closeButton;
        private ListBox studentsListBox;
    }
}