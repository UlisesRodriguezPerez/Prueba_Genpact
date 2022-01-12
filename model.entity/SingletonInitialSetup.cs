using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model.entity
{
    public class SingletonInitialSetup
    {
        private static SingletonInitialSetup instance = null; // singleton
        private String pathFolderListening;
        private String pathFolderProcessingAndNotApplicableFiles;
        private String pathFolderProcessedFiles;
        private String pathFolderNotApplicableFiles;
        private String pathFolderMasterWorkbook;

        public SingletonInitialSetup() { }

        public static SingletonInitialSetup getInstance
        {
            get
            {
                if(instance == null)
                {
                    instance = new SingletonInitialSetup();
                }
                return instance;
            }
        }

        public string PathFolderListening { get => pathFolderListening; set => pathFolderListening = value; }
        public string PathFolderProcessingAndNotApplicableFiles { get => pathFolderProcessingAndNotApplicableFiles; set => pathFolderProcessingAndNotApplicableFiles = value; }
        public string PathFolderProcessedFiles { get => pathFolderProcessedFiles; set => pathFolderProcessedFiles = value; }
        public string PathFolderNotApplicableFiles { get => pathFolderNotApplicableFiles; set => pathFolderNotApplicableFiles = value; }
        public string PathFolderMasterWorkbook { get => pathFolderMasterWorkbook; set => pathFolderMasterWorkbook = value; }
    }   
}
