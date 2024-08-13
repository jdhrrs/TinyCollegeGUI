namespace TinyCollegeGUI
{
    partial class GenerateStudentReportForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCriteria;
        private System.Windows.Forms.TextBox txtCriteria;
        private System.Windows.Forms.Button btnGenerateReport;

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
            lblCriteria = new Label();
            txtCriteria = new TextBox();
            btnGenerateReport = new Button();
            SuspendLayout();
            // 
            // lblCriteria
            // 
            lblCriteria.AutoSize = true;
            lblCriteria.Location = new Point(12, 30);
            lblCriteria.Name = "lblCriteria";
            lblCriteria.Size = new Size(115, 21);
            lblCriteria.TabIndex = 0;
            lblCriteria.Text = "Search Criteria:";
            // 
            // txtCriteria
            // 
            txtCriteria.Location = new Point(130, 30);
            txtCriteria.Name = "txtCriteria";
            txtCriteria.Size = new Size(200, 29);
            txtCriteria.TabIndex = 1;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(130, 70);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(150, 30);
            btnGenerateReport.TabIndex = 2;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // GenerateStudentReportForm
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(400, 150);
            Controls.Add(lblCriteria);
            Controls.Add(txtCriteria);
            Controls.Add(btnGenerateReport);
            Name = "GenerateStudentReportForm";
            Text = "Generate Student Report";
            Load += GenerateStudentReportForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
