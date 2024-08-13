namespace TinyCollegeGUI
{
    partial class WhoIsInACourseForm
    {
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.Button btnSearchStudents;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.DataGridView dataGridViewCourses;
        private System.Windows.Forms.Button btnClose;

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
            txtCourseID = new TextBox();
            btnSearchStudents = new Button();
            dataGridViewStudents = new DataGridView();
            dataGridViewCourses = new DataGridView();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).BeginInit();
            SuspendLayout();
            // 
            // txtCourseID
            // 
            txtCourseID.Location = new Point(18, 19);
            txtCourseID.Margin = new Padding(4, 5, 4, 5);
            txtCourseID.Name = "txtCourseID";
            txtCourseID.Size = new Size(298, 29);
            txtCourseID.TabIndex = 0;
            // 
            // btnSearchStudents
            // 
            btnSearchStudents.Location = new Point(327, 16);
            btnSearchStudents.Margin = new Padding(4, 5, 4, 5);
            btnSearchStudents.Name = "btnSearchStudents";
            btnSearchStudents.Size = new Size(112, 37);
            btnSearchStudents.TabIndex = 1;
            btnSearchStudents.Text = "Find";
            btnSearchStudents.UseVisualStyleBackColor = true;
            btnSearchStudents.Click += btnSearchStudents_Click;
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Location = new Point(18, 81);
            dataGridViewStudents.Margin = new Padding(4, 5, 4, 5);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.Size = new Size(1140, 242);
            dataGridViewStudents.TabIndex = 2;
            // 
            // dataGridViewCourses
            // 
            dataGridViewCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCourses.Location = new Point(18, 355);
            dataGridViewCourses.Margin = new Padding(4, 5, 4, 5);
            dataGridViewCourses.Name = "dataGridViewCourses";
            dataGridViewCourses.Size = new Size(1140, 242);
            dataGridViewCourses.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(525, 614);
            btnClose.Margin = new Padding(4, 5, 4, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 37);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // WhoIsInACourseForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1176, 664);
            Controls.Add(btnClose);
            Controls.Add(dataGridViewCourses);
            Controls.Add(dataGridViewStudents);
            Controls.Add(btnSearchStudents);
            Controls.Add(txtCourseID);
            Margin = new Padding(4, 5, 4, 5);
            Name = "WhoIsInACourseForm";
            Text = "Who Is In A Course";
            Load += WhoIsInACourseForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
