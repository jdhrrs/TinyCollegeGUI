namespace TinyCollegeGUI
{
    partial class EnrollAStudentInACourseForm
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            closeButton = new Button();
            enrollButton = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(187, 96);
            label1.Name = "label1";
            label1.Size = new Size(125, 21);
            label1.TabIndex = 0;
            label1.Text = "Select A Student:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(closeButton);
            groupBox1.Controls.Add(enrollButton);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(873, 367);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enrollment Data";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(494, 285);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(106, 30);
            closeButton.TabIndex = 5;
            closeButton.Text = "Cl&ose";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // enrollButton
            // 
            enrollButton.Location = new Point(260, 285);
            enrollButton.Name = "enrollButton";
            enrollButton.Size = new Size(106, 30);
            enrollButton.TabIndex = 4;
            enrollButton.Text = "&Enroll";
            enrollButton.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(494, 186);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(236, 29);
            comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(494, 100);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(236, 29);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(187, 182);
            label2.Name = "label2";
            label2.Size = new Size(119, 21);
            label2.TabIndex = 1;
            label2.Text = "Select a Course:";
            // 
            // EnrollAStudentInACourseForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 472);
            Controls.Add(groupBox1);
            Name = "EnrollAStudentInACourseForm";
            Text = "Enroll A Student In A Course";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Button closeButton;
        private Button enrollButton;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
    }
}