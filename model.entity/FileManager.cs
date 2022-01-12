using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model.entity
{
    public class FileManager
    {
        Hashtable verifiedFiles = new Hashtable();


        public void checkFiles()
        {
            FileFactoryProcessing fileFactory = new FileFactoryProcessing();
            Folder folder = new Folder();
            Hashtable hashtableTemp = new Hashtable();

            string pathFolderWatcher = SingletonInitialSetup.getInstance.PathFolderListening;
            string[] filesInFolderWatcher = folder.getFiles(pathFolderWatcher);

            foreach (var file in filesInFolderWatcher)
            {
                string fileName = Path.GetFileName(file);

                if (verifiedFiles.ContainsKey(fileName))
                {
                    hashtableTemp.Add(fileName, verifiedFiles[fileName]);
                }
                else
                {
                    // Process
                    fileFactory.processFile(file);
                }
            }
            verifiedFiles = hashtableTemp;
        }

        public void loadHashVerifiedFiles()
        {
            Folder folder = new Folder();

            string pathFolderProcessedFiles = SingletonInitialSetup.getInstance.PathFolderProcessedFiles;
            string pathFolderNotApplicableFiles = SingletonInitialSetup.getInstance.PathFolderNotApplicableFiles;

            string[] existingProcessedFiles = folder.getFiles(pathFolderProcessedFiles);
            string[] existingNotApplicableFiles = folder.getFiles(pathFolderNotApplicableFiles);


            // simplify in a function
            foreach (var file in existingProcessedFiles)
            {
                string fileName = Path.GetFileName(file);
                verifiedFiles.Add(fileName, file);
            }

            foreach (var file in existingNotApplicableFiles)
            {
                string fileName = Path.GetFileName(file);
                verifiedFiles.Add(fileName, file);
            }

        }
    }
}
