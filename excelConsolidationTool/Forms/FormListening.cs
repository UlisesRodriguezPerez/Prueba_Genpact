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
        private FormApplicationStart applicationStart;
        public FormListening(FormApplicationStart applicationStart)
        {
            this.applicationStart = applicationStart;
            InitializeComponent();
            
            Folder folder = new Folder();

            string nameFolderProcessedFiles = "Processed Files";
            string nameFolderNotApplicableFiles = "Not Applicable Files";

            folder.createFolder(SingletonInitialSetup.getInstance.PathFolderProcessingAndNotApplicableFiles, nameFolderProcessedFiles);
            
            folder.createFolder(SingletonInitialSetup.getInstance.PathFolderProcessingAndNotApplicableFiles, nameFolderNotApplicableFiles);

            SingletonInitialSetup.getInstance.PathFolderProcessedFiles = 
                                    SingletonInitialSetup.getInstance.PathFolderProcessingAndNotApplicableFiles + @"\" + nameFolderProcessedFiles;
            SingletonInitialSetup.getInstance.PathFolderNotApplicableFiles = 
                                    SingletonInitialSetup.getInstance.PathFolderProcessingAndNotApplicableFiles + @"\" + nameFolderNotApplicableFiles;

        }

        private void tabAllFiles_Click(object sender, EventArgs e)
        {

        }

        private void tabControlFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshTabPage();
        }

        public void refreshTabPage()
        {
            Folder folder = new Folder();
            string[] listFiles;
            if (tabControlFiles.SelectedTab == tabAllFiles)
            {
                listFiles = folder.getFiles(SingletonInitialSetup.getInstance.PathFolderListening);
                writeFilesInTextBox(listBoxAllFiles, listFiles);
            }
            else if (tabControlFiles.SelectedTab == tabprocessedFiles)
            {
                listFiles = folder.getFiles(SingletonInitialSetup.getInstance.PathFolderProcessedFiles);
                writeFilesInTextBox(listBoxProcessedFiles, listFiles);
            }
            else
            {
                listFiles = folder.getFiles(SingletonInitialSetup.getInstance.PathFolderNotApplicableFiles);
                writeFilesInTextBox(listBoxNotApplicableFiles, listFiles);
            }
        }

        private void FormListening_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(closeForm);
            fileSystemWatcherPrincipalFolder.Path = SingletonInitialSetup.getInstance.PathFolderListening;
        }

        private void closeForm(object sender, EventArgs e)
        {
            this.Hide();
            applicationStart.Show();
        }

        public void writeFilesInTextBox(System.Windows.Forms.ListBox listBox ,string[] listFiles)
        {
            listBox.Items.Clear();
            foreach (var file in listFiles)
            {
                listBoxAllFiles.Items.Add(file);
            }
        }

        private void fileSystemWatcherPrincipalFolder_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            refreshTabPage();
        }

        private void fileSystemWatcherPrincipalFolder_Renamed(object sender, System.IO.RenamedEventArgs e)
        {
            refreshTabPage();
        }
    }
}
