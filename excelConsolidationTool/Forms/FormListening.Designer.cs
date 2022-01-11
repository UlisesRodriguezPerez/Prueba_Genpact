
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.tabControlFiles = new System.Windows.Forms.TabControl();
            this.tabAllFiles = new System.Windows.Forms.TabPage();
            this.tabprocessedFiles = new System.Windows.Forms.TabPage();
            this.tabNotapplicable = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            this.tabControlFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
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
            this.tabNotapplicable.Location = new System.Drawing.Point(4, 22);
            this.tabNotapplicable.Name = "tabNotapplicable";
            this.tabNotapplicable.Size = new System.Drawing.Size(792, 329);
            this.tabNotapplicable.TabIndex = 2;
            this.tabNotapplicable.Text = "Not Applicable";
            this.tabNotapplicable.UseVisualStyleBackColor = true;
            // 
            // FormListening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlPrincipal);
            this.Name = "FormListening";
            this.Text = "FormListening";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            this.tabControlFiles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.TabControl tabControlFiles;
        private System.Windows.Forms.TabPage tabAllFiles;
        private System.Windows.Forms.TabPage tabprocessedFiles;
        private System.Windows.Forms.TabPage tabNotapplicable;
        private System.Windows.Forms.Panel pnlTop;
    }
}