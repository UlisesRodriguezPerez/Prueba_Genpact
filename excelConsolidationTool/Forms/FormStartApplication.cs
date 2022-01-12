using excelConsolidationTool.Forms;
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

namespace excelConsolidationTool
{
    public partial class FormApplicationStart : Form
    {
        public FormApplicationStart()
        {
            InitializeComponent();
        }

        private void btnSelectFolderMonitor_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtFolderMonitor.Text = folderBrowserDialog.SelectedPath;
            }
            else
            {
                txtFolderMonitor.Text = "";
            }
        }

        private void btnFolderForProcessedFiles_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtFolderForProcessedAndNotApplicableFiles.Text = folderBrowserDialog.SelectedPath;
            }
            else
            {
                txtFolderForProcessedAndNotApplicableFiles.Text = "";
            }
        }
        
        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (txtFolderMonitor.Text == "" || txtFolderForProcessedAndNotApplicableFiles.Text == "") {
                MessageBox.Show("Please select the folders");
            }
            else
            { 
                SingletonInitialSetup.getInstance.PathFolderListening = txtFolderMonitor.Text;
                SingletonInitialSetup.getInstance.PathFolderProcessingAndNotApplicableFiles = txtFolderForProcessedAndNotApplicableFiles.Text;
                
                FormListening formListening = new FormListening(this);
                formListening.Show();

                this.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
