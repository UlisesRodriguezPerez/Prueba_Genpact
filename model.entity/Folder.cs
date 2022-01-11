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
        public Boolean createFolder(String path, String name)
        {
            string newFolderPathname = path + @"\" + name;

            try
            {
                if (Directory.Exists(newFolderPathname))
                {
                    return false;
                }
                else
                {
                    Directory.CreateDirectory(newFolderPathname);
                    return true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
