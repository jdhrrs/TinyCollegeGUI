using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;

namespace TinyCollegeGUI
{
    public partial class GenerateCourseReportForm : Form
    {
        private string connectionString;

        public GenerateCourseReportForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["TinyCollegeDB"].ConnectionString;
        }

        private void GenerateCourseReportForm_Load(object sender, EventArgs e)
        {
            // Any initialization tasks can be performed here.
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            var criteria = txtCriteria.Text;
            var dataTable = GetCourseReportData(criteria);

            if (dataTable.Rows.Count > 0)
            {
                SaveReport(dataTable);
            }
            else
            {
                MessageBox.Show("No data found for the given criteria.");
            }
        }

        private DataTable GetCourseReportData(string criteria)
        {
            var dataTable = new DataTable();
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Courses WHERE CourseName LIKE @Criteria";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Criteria", $"%{criteria}%");
                    using (var adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        private void SaveReport(DataTable dataTable)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx|PDF Files|*.pdf",
                Title = "Save Report"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = saveFileDialog.FileName;
                var fileExtension = Path.GetExtension(filePath);

                switch (fileExtension)
                {
                    case ".xlsx":
                        ExportToExcel(dataTable, filePath);
                        break;
                   
                    default:
                        MessageBox.Show("Unsupported file format.");
                        break;
                }
            }
        }

        private void ExportToExcel(DataTable dataTable, string filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Course Report");
                worksheet.Cells["A1"].LoadFromDataTable(dataTable, true);
                package.SaveAs(new FileInfo(filePath));
            }
            MessageBox.Show("Report exported to Excel successfully.");
        }

        // Couldnt get PDF to work :(
        // private void ExportToPdf(DataTable dataTable, string filePath)
       //  {
      //      MessageBox.Show("PDF export functionality to be implemented.");
        }
    }
