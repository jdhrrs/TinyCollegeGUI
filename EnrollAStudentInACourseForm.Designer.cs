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
            label2 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            enrollButton = new Button();
            closeButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(166, 91);
            label1.Name = "label1";
            label1.Size = new Size(159, 28);
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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 350);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enrollment Data";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(166, 173);
            label2.Name = "label2";
            label2.Size = new Size(148, 28);
            label2.TabIndex = 1;
            label2.Text = "Select a Course:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(439, 95);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(210, 28);
            comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(439, 177);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(210, 28);
            comboBox2.TabIndex = 3;
            // 
            // enrollButton
            // 
            enrollButton.Location = new Point(231, 271);
            enrollButton.Name = "enrollButton";
            enrollButton.Size = new Size(94, 29);
            enrollButton.TabIndex = 4;
            enrollButton.Text = "&Enroll";
            enrollButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(439, 271);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(94, 29);
            closeButton.TabIndex = 5;
            closeButton.Text = "Cl&ose";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // EnrollAStudentInACourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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