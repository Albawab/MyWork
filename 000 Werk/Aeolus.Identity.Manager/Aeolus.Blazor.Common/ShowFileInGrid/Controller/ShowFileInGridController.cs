using HenE.Aeolus.Blazor.Common.ShowFileInGrid.Interfaces;
using HenE.Aeolus.Blazor.Common.ShowFileInGrid.Model;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.IO;

namespace HenE.Aeolus.Blazor.Common.ShowFileInGrid.Controller
{
    public class ShowFileInGridController : IShowFileInGrid
    {

        /// <summary>
        /// Geeft de data van de exel bestand terug.
        /// </summary>
        /// <returns>Een nieuwe list met data van Excel bestand.</returns>
        public List<ExcelCelModel> GetExcelItems(string fileName)
        {
            return new List<ExcelCelModel>()
            {
                new ExcelCelModel() { Name = ReadExcel(fileName) },
            };

        }

        /// <summary>
        /// Leest de data van een Excel bestand.
        /// </summary>
        /// <returns></returns>
        private string ReadExcel(string fileName)
        {
            if (fileName != null && fileName != string.Empty)
            {

            
            string name;
            ExcelEngine excelEngine = new ExcelEngine();

            // Instantiate the Excel application object
            IApplication application = excelEngine.Excel;

            // Set the default application version
            application.DefaultVersion = ExcelVersion.Excel2016;

            // Load the existing Excel workbook into IWorkbook
            FileStream inputStream = new FileStream(fileName, FileMode.Open);
            IWorkbook workbook = application.Workbooks.Open(inputStream);

            // Get the first worksheet in the workbook into IWorksheet
            IWorksheet worksheet = workbook.Worksheets[0];

            name = worksheet.Range["A2"].Value;

            inputStream.Dispose();
            inputStream.Close();

            return name;
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
