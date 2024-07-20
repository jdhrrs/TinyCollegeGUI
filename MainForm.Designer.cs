using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TinyCollegeGUI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel;

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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaption;
            textBox1.Font = new Font("Monotype Corsiva", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(93, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(662, 47);
            textBox1.TabIndex = 0;
            textBox1.Text = "Tiny College Course Tracking System";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(121, 97);
            button1.Name = "button1";
            button1.Size = new Size(239, 77);
            button1.TabIndex = 1;
            button1.Text = "Add a Student";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(121, 180);
            button2.Name = "button2";
            button2.Size = new Size(239, 70);
            button2.TabIndex = 2;
            button2.Text = "Display All Students";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(121, 256);
            button3.Name = "button3";
            button3.Size = new Size(239, 76);
            button3.TabIndex = 3;
            button3.Text = "Enroll a Student in a Course";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(121, 338);
            button4.Name = "button4";
            button4.Size = new Size(239, 78);
            button4.TabIndex = 4;
            button4.Text = "What Courses a Student Enrolled In";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(508, 97);
            button5.Name = "button5";
            button5.Size = new Size(211, 77);
            button5.TabIndex = 5;
            button5.Text = "Add a Course";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ActiveCaption;
            button6.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(508, 180);
            button6.Name = "button6";
            button6.Size = new Size(211, 71);
            button6.TabIndex = 6;
            button6.Text = "Display All Courses";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ActiveCaption;
            button7.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(508, 257);
            button7.Name = "button7";
            button7.Size = new Size(211, 75);
            button7.TabIndex = 7;
            button7.Text = "Who is in a Course";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ActiveCaption;
            button8.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(508, 338);
            button8.Name = "button8";
            button8.Size = new Size(211, 78);
            button8.TabIndex = 8;
            button8.Text = "Exit";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 477);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(884, 22);
            statusStrip.TabIndex = 9;
            statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(0, 17);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(884, 499);
            Controls.Add(statusStrip);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Cursor = Cursors.AppStarting;
            Name = "MainForm";
            Text = "Welcome";
            Load += MainForm_Load;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}


