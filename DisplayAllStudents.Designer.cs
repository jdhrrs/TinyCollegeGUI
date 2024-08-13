using System.ComponentModel;
using System.Windows.Forms;

namespace TinyCollegeGUI
{
    partial class DisplayAllStudentsForm
    {
        private DataGridView dataGridViewStudents;
        private Button button1;
        private IContainer components = null; // Added this line to fix the missing components error

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewStudents = new DataGridView();
            button1 = new Button();
            ((ISupportInitialize)dataGridViewStudents).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Location = new Point(12, 12);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.RowHeadersWidth = 51;
            dataGridViewStudents.RowTemplate.Height = 24;
            dataGridViewStudents.Size = new Size(776, 426);
            dataGridViewStudents.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(34, 454);
            button1.Name = "button1";
            button1.Size = new Size(166, 65);
            button1.TabIndex = 1;
            button1.Text = "Remove Selected Student";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(button1_Click);
            // 
            // DisplayAllStudentsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 540);
            Controls.Add(button1);
            Controls.Add(dataGridViewStudents);
            Name = "DisplayAllStudentsForm";
            Text = "Display Students";
            Load += new System.EventHandler(DisplayAllStudentsForm_Load);
            ((ISupportInitialize)dataGridViewStudents).EndInit();
            ResumeLayout(false);
        }
    }
}

