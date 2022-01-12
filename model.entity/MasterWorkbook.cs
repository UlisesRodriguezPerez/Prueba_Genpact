using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace model.entity
{
    public class MasterWorkbook
    {
        private String path = SingletonInitialSetup.getInstance.PathFolderMasterWorkbook + @"\" + SingletonInitialSetup.getInstance.NameMasterWorkbook;
        private static MasterWorkbook instance = null; // singleton
        public ExcelFile masterWorkbook;

        public MasterWorkbook() {

            path = @"C:\Users\ulirp\Desktop\PruebaMonitor\Master Workbook\Master Workbook.xlsx";
            
            try
            {
                masterWorkbook = new ExcelFile(path);
                masterWorkbook.readWorkbook();
                masterWorkbook.setSheets();
            }
            catch (Exception)
            {
                masterWorkbook.closeFile();
                throw;
            }
        }

        public static MasterWorkbook getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MasterWorkbook();
                }
                return instance;
            }
        }

        public string Path { get => path; set => path = value; }
    }
}
