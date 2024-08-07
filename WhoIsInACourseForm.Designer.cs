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
            findButton = new Button();
            closeButton = new Button();
            studentsListBox = new ListBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
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
            groupBox1.Location = new Point(14, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(873, 365);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Course Data";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // findButton
            // 
            findButton.Location = new Point(515, 47);
            findButton.Name = "findButton";
            findButton.Size = new Size(106, 30);
            findButton.TabIndex = 7;
            findButton.Text = "&Find";
            findButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(361, 319);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(106, 30);
            closeButton.TabIndex = 6;
            closeButton.Text = "Cl&ose";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // studentsListBox
            // 
            studentsListBox.FormattingEnabled = true;
            studentsListBox.ItemHeight = 21;
            studentsListBox.Location = new Point(7, 193);
            studentsListBox.Name = "studentsListBox";
            studentsListBox.Size = new Size(848, 109);
            studentsListBox.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(326, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(140, 29);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(326, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(294, 29);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(7, 161);
            label3.Name = "label3";
            label3.Size = new Size(272, 21);
            label3.TabIndex = 2;
            label3.Text = "All Students Enrolled In This Course:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(107, 102);
            label2.Name = "label2";
            label2.Size = new Size(101, 21);
            label2.TabIndex = 1;
            label2.Text = "Course Title:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(128, 43);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 0;
            label1.Text = "Course ID:";
            // 
            // WhoIsInACourseForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 472);
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