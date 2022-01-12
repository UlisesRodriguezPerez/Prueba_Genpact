using model.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace excelConsolidationTool.Forms
{
    public partial class FormListening : Form
    {
        private FormApplicationStart applicationStart;
        private FileManager fileManager = new FileManager();
        public FormListening(FormApplicationStart applicationStart)
        {
            this.applicationStart = applicationStart;
            InitializeComponent();
            initialSetup();
            fileManager.checkFiles();
        }

        public void initialSetup()
        {
            Folder folder = new Folder();

            string nameFolderProcessedFiles = "Processed Files";
            string nameFolderNotApplicableFiles = "Not Applicable Files";
            string masterWorkbook = "Master Workbook";
            string pathFolderProcessingAndNotApplicableFiles = SingletonInitialSetup.getInstance.PathFolderProcessingAndNotApplicableFiles;

            folder.createFolder(pathFolderProcessingAndNotApplicableFiles, nameFolderProcessedFiles);

            folder.createFolder(pathFolderProcessingAndNotApplicableFiles, nameFolderNotApplicableFiles);

            folder.createFolder(pathFolderProcessingAndNotApplicableFiles, masterWorkbook);

            SingletonInitialSetup.getInstance.PathFolderProcessedFiles =
                                    pathFolderProcessingAndNotApplicableFiles + @"\" + nameFolderProcessedFiles;
            SingletonInitialSetup.getInstance.PathFolderNotApplicableFiles =
                                    pathFolderProcessingAndNotApplicableFiles + @"\" + nameFolderNotApplicableFiles;
            SingletonInitialSetup.getInstance.PathFolderMasterWorkbook =
                                    pathFolderProcessingAndNotApplicableFiles + @"\" + masterWorkbook;

            fileManager.loadHashVerifiedFiles();

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
                writeFilesInListBox(listBoxAllFiles, listFiles);
            }
            else if (tabControlFiles.SelectedTab == tabProcessedFiles)
            {
                listFiles = folder.getFiles(SingletonInitialSetup.getInstance.PathFolderProcessedFiles);
                writeFilesInListBox(listBoxProcessedFiles, listFiles);
            }
            else
            {
                listFiles = folder.getFiles(SingletonInitialSetup.getInstance.PathFolderNotApplicableFiles);
                writeFilesInListBox(listBoxNotApplicableFiles, listFiles);
            }
        }

        private void FormListening_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(closeForm);
            fileSystemWatcherPrincipalFolder.Path = SingletonInitialSetup.getInstance.PathFolderListening;
            refreshTabPage();
        }

        private void closeForm(object sender, EventArgs e)
        {
            this.Hide();
            applicationStart.Show();
        }

        public void writeFilesInListBox(System.Windows.Forms.ListBox listBox ,string[] listFiles)
        {
            listBox.Items.Clear();
            foreach (var file in listFiles)
            {
                string fileName = Path.GetFileName(file);
                listBox.Items.Add(fileName);
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

        private void fileSystemWatcherPrincipalFolder_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            refreshTabPage();
        }

        private void fileSystemWatcherPrincipalFolder_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
            refreshTabPage();
        }
    }
}
