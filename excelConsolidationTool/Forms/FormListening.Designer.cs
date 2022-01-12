
namespace excelConsolidationTool.Forms
{
    partial class FormListening
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileSystemWatcherPrincipalFolder = new System.IO.FileSystemWatcher();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.tabControlFiles = new System.Windows.Forms.TabControl();
            this.tabAllFiles = new System.Windows.Forms.TabPage();
            this.tabprocessedFiles = new System.Windows.Forms.TabPage();
            this.tabNotapplicable = new System.Windows.Forms.TabPage();
            this.listBoxAllFiles = new System.Windows.Forms.ListBox();
            this.listBoxProcessedFiles = new System.Windows.Forms.ListBox();
            this.listBoxNotApplicableFiles = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcherPrincipalFolder)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            this.tabControlFiles.SuspendLayout();
            this.tabAllFiles.SuspendLayout();
            this.tabprocessedFiles.SuspendLayout();
            this.tabNotapplicable.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcherPrincipalFolder
            // 
            this.fileSystemWatcherPrincipalFolder.EnableRaisingEvents = true;
            this.fileSystemWatcherPrincipalFolder.SynchronizingObject = this;
            this.fileSystemWatcherPrincipalFolder.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcherPrincipalFolder_Changed);
            this.fileSystemWatcherPrincipalFolder.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcherPrincipalFolder_Changed);
            this.fileSystemWatcherPrincipalFolder.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcherPrincipalFolder_Changed);
            this.fileSystemWatcherPrincipalFolder.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcherPrincipalFolder_Renamed);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.tabControlFiles);
            this.pnlPrincipal.Controls.Add(this.pnlTop);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(800, 450);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 95);
            this.pnlTop.TabIndex = 0;
            // 
            // tabControlFiles
            // 
            this.tabControlFiles.Controls.Add(this.tabAllFiles);
            this.tabControlFiles.Controls.Add(this.tabprocessedFiles);
            this.tabControlFiles.Controls.Add(this.tabNotapplicable);
            this.tabControlFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlFiles.Location = new System.Drawing.Point(0, 95);
            this.tabControlFiles.Multiline = true;
            this.tabControlFiles.Name = "tabControlFiles";
            this.tabControlFiles.SelectedIndex = 0;
            this.tabControlFiles.Size = new System.Drawing.Size(800, 355);
            this.tabControlFiles.TabIndex = 1;
            this.tabControlFiles.SelectedIndexChanged += new System.EventHandler(this.tabControlFiles_SelectedIndexChanged);
            // 
            // tabAllFiles
            // 
            this.tabAllFiles.Controls.Add(this.listBoxAllFiles);
            this.tabAllFiles.Location = new System.Drawing.Point(4, 22);
            this.tabAllFiles.Name = "tabAllFiles";
            this.tabAllFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabAllFiles.Size = new System.Drawing.Size(792, 329);
            this.tabAllFiles.TabIndex = 0;
            this.tabAllFiles.Text = "All";
            this.tabAllFiles.UseVisualStyleBackColor = true;
            this.tabAllFiles.Click += new System.EventHandler(this.tabAllFiles_Click);
            // 
            // tabprocessedFiles
            // 
            this.tabprocessedFiles.Controls.Add(this.listBoxProcessedFiles);
            this.tabprocessedFiles.Location = new System.Drawing.Point(4, 22);
            this.tabprocessedFiles.Name = "tabprocessedFiles";
            this.tabprocessedFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabprocessedFiles.Size = new System.Drawing.Size(792, 329);
            this.tabprocessedFiles.TabIndex = 1;
            this.tabprocessedFiles.Text = "Processed";
            this.tabprocessedFiles.UseVisualStyleBackColor = true;
            // 
            // tabNotapplicable
            // 
            this.tabNotapplicable.Controls.Add(this.listBoxNotApplicableFiles);
            this.tabNotapplicable.Location = new System.Drawing.Point(4, 22);
            this.tabNotapplicable.Name = "tabNotapplicable";
            this.tabNotapplicable.Size = new System.Drawing.Size(792, 329);
            this.tabNotapplicable.TabIndex = 2;
            this.tabNotapplicable.Text = "Not Applicable";
            this.tabNotapplicable.UseVisualStyleBackColor = true;
            // 
            // listBoxAllFiles
            // 
            this.listBoxAllFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxAllFiles.FormattingEnabled = true;
            this.listBoxAllFiles.Location = new System.Drawing.Point(3, 3);
            this.listBoxAllFiles.Name = "listBoxAllFiles";
            this.listBoxAllFiles.Size = new System.Drawing.Size(786, 323);
            this.listBoxAllFiles.TabIndex = 0;
            // 
            // listBoxProcessedFiles
            // 
            this.listBoxProcessedFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxProcessedFiles.FormattingEnabled = true;
            this.listBoxProcessedFiles.Location = new System.Drawing.Point(3, 3);
            this.listBoxProcessedFiles.Name = "listBoxProcessedFiles";
            this.listBoxProcessedFiles.Size = new System.Drawing.Size(786, 323);
            this.listBoxProcessedFiles.TabIndex = 0;
            // 
            // listBoxNotApplicableFiles
            // 
            this.listBoxNotApplicableFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxNotApplicableFiles.FormattingEnabled = true;
            this.listBoxNotApplicableFiles.Location = new System.Drawing.Point(0, 0);
            this.listBoxNotApplicableFiles.Name = "listBoxNotApplicableFiles";
            this.listBoxNotApplicableFiles.Size = new System.Drawing.Size(792, 329);
            this.listBoxNotApplicableFiles.TabIndex = 0;
            // 
            // FormListening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlPrincipal);
            this.Name = "FormListening";
            this.Text = "FormListening";
            this.Load += new System.EventHandler(this.FormListening_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcherPrincipalFolder)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            this.tabControlFiles.ResumeLayout(false);
            this.tabAllFiles.ResumeLayout(false);
            this.tabprocessedFiles.ResumeLayout(false);
            this.tabNotapplicable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcherPrincipalFolder;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.TabControl tabControlFiles;
        private System.Windows.Forms.TabPage tabAllFiles;
        private System.Windows.Forms.TabPage tabprocessedFiles;
        private System.Windows.Forms.TabPage tabNotapplicable;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.ListBox listBoxAllFiles;
        private System.Windows.Forms.ListBox listBoxProcessedFiles;
        private System.Windows.Forms.ListBox listBoxNotApplicableFiles;
    }
}