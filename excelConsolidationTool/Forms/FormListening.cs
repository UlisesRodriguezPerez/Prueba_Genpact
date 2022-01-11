using model.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace excelConsolidationTool.Forms
{
    public partial class FormListening : Form
    {
        public FormListening()
        {
            InitializeComponent();
            
            Folder folder = new Folder();

            string nameFolderProcessedFiles = "Processed Files";
            string nameFolderNotApplicableFiles = "Not Applicable Files";

            folder.createFolder(SingletonInitialSetup.getInstance.PathFolderProcessingAndNotApplicableFiles, nameFolderProcessedFiles);
            
            folder.createFolder(SingletonInitialSetup.getInstance.PathFolderProcessingAndNotApplicableFiles, nameFolderNotApplicableFiles);

            SingletonInitialSetup.getInstance.PathFolderProcessedFiles = 
                                    SingletonInitialSetup.getInstance.PathFolderProcessingAndNotApplicableFiles + nameFolderProcessedFiles;
            SingletonInitialSetup.getInstance.PathFolderNotApplicableFiles = 
                                    SingletonInitialSetup.getInstance.PathFolderProcessingAndNotApplicableFiles + nameFolderNotApplicableFiles;

        }

        private void tabAllFiles_Click(object sender, EventArgs e)
        {

        }

        private void tabControlFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControlFiles.SelectedTab == tabAllFiles)
            {
                // Llamar archivos de la carpeta principal
            }
            else if (tabControlFiles.SelectedTab == tabprocessedFiles)
            {
                // Llamar archivos procesados
            }
            else
            {
                // Llamar no procesados
            }
        }
    }
}
