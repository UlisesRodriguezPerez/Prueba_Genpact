using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model.entity
{
    public class InitialSetup
    {
        private String pathFolderListening;
        private String pathFolderProcessingAndNotApplicableFiles;

        public InitialSetup(string pathFolderListening, string pathFolderProcessingAndNotApplicableFiles)
        {
            this.pathFolderListening = pathFolderListening;
            this.pathFolderProcessingAndNotApplicableFiles = pathFolderProcessingAndNotApplicableFiles;
        }

        public string PathFolderListening { get => pathFolderListening; set => pathFolderListening = value; }
        public string PathFolderProcessingAndNotApplicableFiles { get => pathFolderProcessingAndNotApplicableFiles; set => pathFolderProcessingAndNotApplicableFiles = value; }
    
        
    }   
}
