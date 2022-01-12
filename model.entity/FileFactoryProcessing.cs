using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace model.entity
{
    class FileFactoryProcessing
    {
        

        public void processFile(string file)
        {
            FileType type = getFileType(file);
            Folder folder = new Folder();

            switch (type)
            {
                case FileType.EXCEL:
                    ExcelFile excelFile = new ExcelFile(file);
                    
                    // Not work
                    excelFile.consolidateFile();


                    excelFile.closeFile();
                    folder.moveFile(file, SingletonInitialSetup.getInstance.PathFolderProcessedFiles);
                    break;
                case FileType.OTHER:
                    folder.moveFile(file, SingletonInitialSetup.getInstance.PathFolderNotApplicableFiles);
                    break;
            }
        }

        public FileType getFileType(string file)
        {
            string extension = Path.GetExtension(file);
            Regex regex = new Regex("\\.xls*");
            if (regex.IsMatch(extension, 0)){
                return FileType.EXCEL;
            }
            else
            {
                return FileType.OTHER;
            }
        }
    }
}
