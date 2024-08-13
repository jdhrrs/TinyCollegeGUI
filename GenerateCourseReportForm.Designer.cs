namespace TinyCollegeGUI
{
    partial class GenerateCourseReportForm
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
            lblCriteria.Location = new Point(30, 30);
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
            // GenerateCourseReportForm
            // 
            ClientSize = new Size(400, 150);
            Controls.Add(lblCriteria);
            Controls.Add(txtCriteria);
            Controls.Add(btnGenerateReport);
            Name = "GenerateCourseReportForm";
            Text = "Generate Course Report";
            Load += GenerateCourseReportForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
