using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace model.entity
{
    public class Folder
    {
        public void createFolder(String path, String name)
        {
            string newFolderPathname = path + @"\" + name;

            try
            {
                if (!Directory.Exists(newFolderPathname))
                {
                    Directory.CreateDirectory(newFolderPathname);
                    
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string[] getFiles(string pathFolder)
        {
            string[] listFiles = Directory.GetFiles(pathFolder);
            return listFiles;
        }

        public void moveFile(string file, string newLocationFile)
        {
            string fileName = Path.GetFileName(file);
            File.Move(file, newLocationFile + @"\" + fileName);
        }
    }
}
