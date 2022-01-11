using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model.entity
{
    class FileFactoryProcessing
    {
        

        public void saveFile(FileType type, String fileName)
        {
            switch (type)
            {
                case FileType.EXCEL:
                    ExcelFile excelFile = new ExcelFile(fileName);
                    excelFile.processFile(); // retornar el archivo
                    excelFile.saveFile("path de archivos procesados.");
                    break;
                case FileType.OTHERS:

                    break;
            }
        }
    }
}
