using GemBox.Spreadsheet;
using System;
using System.Data;
using System.Windows.Forms;

namespace FPMG
{
    class ExcelUtility
    {
        public void WriteDataTableToExcel(System.Data.DataTable dataTable, string worksheetName, string saveAsLocation)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            var workbook = new ExcelFile();
            var worksheet = workbook.Worksheets.Add(worksheetName);
            try
            {
                worksheet.InsertDataTable(dataTable,
                    new InsertDataTableOptions()
                    {
                        ColumnHeaders = true,
                        StartRow = 0
                    });
                workbook.Save(saveAsLocation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CreateNewSSTOExcel(System.Data.DataTable dataTable, string worksheetName, string path)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            var workbook = ExcelFile.Load(path);
            var worksheet = workbook.Worksheets.Add(worksheetName);
            try
            {
                worksheet.InsertDataTable(dataTable,
                    new InsertDataTableOptions()
                    {
                        ColumnHeaders = true,
                        StartRow = 0
                    });
                workbook.Save(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
