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
            System.Console.WriteLine("1");
            InitializeComponent();
            SingletonInitialSetup initialSetup = new SingletonInitialSetup();
            Folder folder = new Folder();

            System.Console.WriteLine("2");

            string nameFolderProcessedFiles = "Processed Files";
            string nameFolderNotApplicableFiles = "Not Applicable Files";

            folder.createFolder(initialSetup.PathFolderProcessingAndNotApplicableFiles, nameFolderProcessedFiles);
            folder.createFolder(initialSetup.PathFolderProcessingAndNotApplicableFiles, nameFolderNotApplicableFiles);

            initialSetup.PathFolderProcessedFiles = initialSetup.PathFolderProcessingAndNotApplicableFiles + nameFolderProcessedFiles;
            initialSetup.PathFolderNotApplicableFiles = initialSetup.PathFolderProcessingAndNotApplicableFiles + nameFolderNotApplicableFiles;

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
