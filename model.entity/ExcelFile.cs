using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using Spiree =  Spire.Xls;


namespace model.entity
{
    public class ExcelFile
    {
        private String pathFile;
        private Excel.Application excelFile = new Excel.Application();
        private Excel.Workbook workbook;
        
        private List<Worksheet> sheets = new List<Worksheet>();


        public ExcelFile(string path)
        {
            try
            {
                this.pathFile = path;
                readWorkbook();
                setSheets();
            }
            catch (Exception)
            {
                closeFile();
                throw;
            }
            
        }

        public void setSheets()
        {
            foreach (Worksheet sheet in workbook.Worksheets)
            {
                addNewSheetToWorkbook(sheet);
            }
        }

        public Excel.Workbook getWorkbook()
        {
            return workbook;
        }

        public void addNewSheetToWorkbook(Worksheet sheet)
        {
            sheets.Add(sheet);
        }

        public void readWorkbook()
        {
            try
            {
                workbook = excelFile.Workbooks.Open(pathFile);
            }
            catch
            {
                // pending to do
                throw;
            }
        }


        // search a better way to do it
        public void closeFile()
        {
            try
            {
                workbook.Close();
                excelFile.Workbooks.Close();
            }
            catch (IOException e)
            {
                System.Console.WriteLine("File is closed");
                throw;
            }
        }


        public void consolidateFile()
        {
            /*Workbook masterWorkbook = MasterWorkbook.getInstance.masterWorkbook.workbook;
            Excel.Worksheet worksheetCopy;
            Excel.Worksheet worksheetOrigin;
            MasterWorkbook.getInstance.masterWorkbook.closeFile();*/

            // Solution: https://www.nuget.org/packages/FreeSpire.XLS/
            int sheetNumber = 0;
            string fileName;
            string pathFileMasterWorkbook = @"C:\Users\ulirp\Desktop\PruebaMonitor\Master Workbook\Master Workbook.xlsx";
            
            foreach (Worksheet sheet in sheets)
            {
                System.Console.WriteLine(sheet.Name);
                fileName = Path.GetFileNameWithoutExtension(pathFile);
                Spiree.Workbook workbook_copy = new Spiree.Workbook();
                workbook_copy.LoadFromFile(pathFile);

                //Get the specific worksheet
                Spiree.Worksheet sheet1 = workbook_copy.Worksheets[sheetNumber];

                //Load target Excel file
                Spiree.Workbook workbook_master = new Spiree.Workbook();

                
                workbook_master.LoadFromFile(pathFileMasterWorkbook);

                //Coyp worhsheet from worbook 1 to workbook 2
                Spiree.Worksheet sheet2 = workbook_master.Worksheets.AddCopy(sheet1);
                sheet2.Name = "Copy_" + fileName + "_" + sheetNumber;

                //Save workbook 2
                workbook_master.Save(); // SaveToFile("Report.xlsx");

                sheetNumber++;
                
            }
        }

        public string PathFile { get => pathFile; set => pathFile = value; }


    }
}
