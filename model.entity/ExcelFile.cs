using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model.entity
{
    public class ExcelFile
    {
        private String path;

        public ExcelFile(string path)
        {
            this.path = path;
        }

        public string Path { get => path; set => path = value; }

        public void readFile(String path)
        {
            try
            {

            }
            catch
            {

            }
        }

        public void saveFile(String pathSave)
        {
            try
            {

            }
            catch
            {

            }
        }

        public void consolidateFile()
        {

        }
    }
}
