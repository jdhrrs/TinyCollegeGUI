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
            dataGridViewStudents.Location = new Point(18, 19);
            dataGridViewStudents.Margin = new Padding(4, 5, 4, 5);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.RowHeadersWidth = 51;
            dataGridViewStudents.RowTemplate.Height = 24;
            dataGridViewStudents.Size = new Size(1164, 688);
            dataGridViewStudents.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Location = new Point(51, 733);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(249, 105);
            button1.TabIndex = 1;
            button1.Text = "Delete Selected Student From Database";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DisplayAllStudentsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1200, 872);
            Controls.Add(button1);
            Controls.Add(dataGridViewStudents);
            Margin = new Padding(4, 5, 4, 5);
            Name = "DisplayAllStudentsForm";
            Text = "Display Students";
            Load += DisplayAllStudentsForm_Load;
            ((ISupportInitialize)dataGridViewStudents).EndInit();
            ResumeLayout(false);
        }
    }
}

