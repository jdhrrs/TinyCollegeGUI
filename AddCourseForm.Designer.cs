namespace TinyCollegeGUI
{
    partial class AddCourseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnClose;

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
            lblCourseID = new Label();
            lblCourseName = new Label();
            lblCredits = new Label();
            txtCourseID = new TextBox();
            txtCourseName = new TextBox();
            txtCredits = new TextBox();
            btnAddCourse = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblCourseID
            // 
            lblCourseID.AutoSize = true;
            lblCourseID.Location = new Point(18, 15);
            lblCourseID.Margin = new Padding(4, 0, 4, 0);
            lblCourseID.Name = "lblCourseID";
            lblCourseID.Size = new Size(81, 21);
            lblCourseID.TabIndex = 0;
            lblCourseID.Text = "Course ID:";
            // 
            // lblCourseName
            // 
            lblCourseName.AutoSize = true;
            lblCourseName.Location = new Point(18, 57);
            lblCourseName.Margin = new Padding(4, 0, 4, 0);
            lblCourseName.Name = "lblCourseName";
            lblCourseName.Size = new Size(108, 21);
            lblCourseName.TabIndex = 1;
            lblCourseName.Text = "Course Name:";
            // 
            // lblCredits
            // 
            lblCredits.AutoSize = true;
            lblCredits.Location = new Point(18, 99);
            lblCredits.Margin = new Padding(4, 0, 4, 0);
            lblCredits.Name = "lblCredits";
            lblCredits.Size = new Size(62, 21);
            lblCredits.TabIndex = 2;
            lblCredits.Text = "Credits:";
            // 
            // txtCourseID
            // 
            txtCourseID.Location = new Point(138, 10);
            txtCourseID.Margin = new Padding(4, 5, 4, 5);
            txtCourseID.Name = "txtCourseID";
            txtCourseID.Size = new Size(268, 29);
            txtCourseID.TabIndex = 3;
            // 
            // txtCourseName
            // 
            txtCourseName.Location = new Point(138, 52);
            txtCourseName.Margin = new Padding(4, 5, 4, 5);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(268, 29);
            txtCourseName.TabIndex = 4;
            // 
            // txtCredits
            // 
            txtCredits.Location = new Point(138, 94);
            txtCredits.Margin = new Padding(4, 5, 4, 5);
            txtCredits.Name = "txtCredits";
            txtCredits.Size = new Size(268, 29);
            txtCredits.TabIndex = 5;
            // 
            // btnAddCourse
            // 
            btnAddCourse.Location = new Point(138, 136);
            btnAddCourse.Margin = new Padding(4, 5, 4, 5);
            btnAddCourse.Name = "btnAddCourse";
            btnAddCourse.Size = new Size(112, 37);
            btnAddCourse.TabIndex = 6;
            btnAddCourse.Text = "Add Course";
            btnAddCourse.UseVisualStyleBackColor = true;
            btnAddCourse.Click += btnAddCourse_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(296, 136);
            btnClose.Margin = new Padding(4, 5, 4, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 37);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // AddCourseForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(426, 192);
            Controls.Add(btnClose);
            Controls.Add(btnAddCourse);
            Controls.Add(txtCredits);
            Controls.Add(txtCourseName);
            Controls.Add(txtCourseID);
            Controls.Add(lblCredits);
            Controls.Add(lblCourseName);
            Controls.Add(lblCourseID);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AddCourseForm";
            Text = "Add Course";
            Load += AddCourseForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
