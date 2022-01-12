using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
// using Spire.Xls;


namespace model.entity
{
    public class ExcelFile
    {
        private String path;
        private Excel.Application excelFile = new Excel.Application();
        private Excel.Workbook workbook;
        //private Excel.Worksheet worksheet_;
        private List<Worksheet> sheets = new List<Worksheet>();


        public ExcelFile(string path)
        {
            try
            {
                this.path = path;
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
                workbook = excelFile.Workbooks.Open(path);
            }
            catch
            {
                // pending to do
                throw;
            }
        }

        public void closeFile()
        {
            workbook.Close();
            excelFile.Workbooks.Close();
        }

        public void consolidateFile()
        {
            Workbook masterWorkbook = MasterWorkbook.getInstance.masterWorkbook.workbook;
            Excel.Worksheet worksheetCopy;
            Excel.Worksheet worksheetOrigin;

            foreach (Worksheet sheet in sheets)
            {
                worksheetOrigin = (workbook.Application.ActiveWorkbook.Sheets[sheet.Index]);

                worksheetCopy = masterWorkbook.Application.Worksheets.Add();

                masterWorkbook.Save();

                //worksheetCopy = MasterWorkbook.getInstance.masterWorkbook.workbook.Worksheets[worksheetCopy.Index];

                //worksheetOrigin.Copy(worksheetCopy);
  
            }
            //closeFile();
        }

        public string Path { get => path; set => path = value; }


    }
}
