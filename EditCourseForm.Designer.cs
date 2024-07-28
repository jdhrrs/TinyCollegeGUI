namespace TinyCollegeGUI
{
    partial class EditCourseForm
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
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.textBoxCourseDescription = new System.Windows.Forms.TextBox();
            this.labelCourseName = new System.Windows.Forms.Label();
            this.labelCourseDescription = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Location = new System.Drawing.Point(150, 30);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(200, 20);
            this.textBoxCourseName.TabIndex = 0;
            // 
            // textBoxCourseDescription
            // 
            this.textBoxCourseDescription.Location = new System.Drawing.Point(150, 70);
            this.textBoxCourseDescription.Name = "textBoxCourseDescription";
            this.textBoxCourseDescription.Size = new System.Drawing.Size(200, 20);
            this.textBoxCourseDescription.TabIndex = 1;
            // 
            // labelCourseName
            // 
            this.labelCourseName.AutoSize = true;
            this.labelCourseName.Location = new System.Drawing.Point(30, 30);
            this.labelCourseName.Name = "labelCourseName";
            this.labelCourseName.Size = new System.Drawing.Size(74, 13);
            this.labelCourseName.TabIndex = 2;
            this.labelCourseName.Text = "Course Name:";
            // 
            // labelCourseDescription
            // 
            this.labelCourseDescription.AutoSize = true;
            this.labelCourseDescription.Location = new System.Drawing.Point(30, 70);
            this.labelCourseDescription.Name = "labelCourseDescription";
            this.labelCourseDescription.Size = new System.Drawing.Size(97, 13);
            this.labelCourseDescription.TabIndex = 3;
            this.labelCourseDescription.Text = "Course Description:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(150, 110);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(275, 110);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // EditCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelCourseDescription);
            this.Controls.Add(this.labelCourseName);
            this.Controls.Add(this.textBoxCourseDescription);
            this.Controls.Add(this.textBoxCourseName);
            this.Name = "EditCourseForm";
            this.Text = "Edit Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.TextBox textBoxCourseDescription;
        private System.Windows.Forms.Label labelCourseName;
        private System.Windows.Forms.Label labelCourseDescription;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}
