
namespace excelConsolidationTool
{
    partial class FormApplicationStart
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.btnContinue = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFolderForProcessedFiles = new System.Windows.Forms.Button();
            this.txtFolderForProcessedAndNotApplicableFiles = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlSelectFolderMonitor = new System.Windows.Forms.Panel();
            this.btnSelectFolderMonitor = new System.Windows.Forms.Button();
            this.txtFolderMonitor = new System.Windows.Forms.TextBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPrincipal.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlSelectFolderMonitor.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.btnContinue);
            this.pnlPrincipal.Controls.Add(this.panel5);
            this.pnlPrincipal.Controls.Add(this.panel2);
            this.pnlPrincipal.Controls.Add(this.panel1);
            this.pnlPrincipal.Controls.Add(this.pnlSelectFolderMonitor);
            this.pnlPrincipal.Controls.Add(this.pnlTitle);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(567, 253);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // btnContinue
            // 
            this.btnContinue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnContinue.Location = new System.Drawing.Point(0, 219);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(567, 34);
            this.btnContinue.TabIndex = 8;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 185);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(567, 34);
            this.panel5.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFolderForProcessedFiles);
            this.panel2.Controls.Add(this.txtFolderForProcessedAndNotApplicableFiles);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(567, 48);
            this.panel2.TabIndex = 4;
            // 
            // btnFolderForProcessedFiles
            // 
            this.btnFolderForProcessedFiles.Location = new System.Drawing.Point(450, 8);
            this.btnFolderForProcessedFiles.Name = "btnFolderForProcessedFiles";
            this.btnFolderForProcessedFiles.Size = new System.Drawing.Size(97, 32);
            this.btnFolderForProcessedFiles.TabIndex = 1;
            this.btnFolderForProcessedFiles.Text = "Select";
            this.btnFolderForProcessedFiles.UseVisualStyleBackColor = true;
            this.btnFolderForProcessedFiles.Click += new System.EventHandler(this.btnFolderForProcessedFiles_Click);
            // 
            // txtFolderForProcessedAndNotApplicableFiles
            // 
            this.txtFolderForProcessedAndNotApplicableFiles.Enabled = false;
            this.txtFolderForProcessedAndNotApplicableFiles.Location = new System.Drawing.Point(32, 15);
            this.txtFolderForProcessedAndNotApplicableFiles.Name = "txtFolderForProcessedAndNotApplicableFiles";
            this.txtFolderForProcessedAndNotApplicableFiles.Size = new System.Drawing.Size(412, 20);
            this.txtFolderForProcessedAndNotApplicableFiles.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 46);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(567, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select folder for processed and not applicable files";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSelectFolderMonitor
            // 
            this.pnlSelectFolderMonitor.Controls.Add(this.btnSelectFolderMonitor);
            this.pnlSelectFolderMonitor.Controls.Add(this.txtFolderMonitor);
            this.pnlSelectFolderMonitor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSelectFolderMonitor.Location = new System.Drawing.Point(0, 43);
            this.pnlSelectFolderMonitor.Name = "pnlSelectFolderMonitor";
            this.pnlSelectFolderMonitor.Size = new System.Drawing.Size(567, 48);
            this.pnlSelectFolderMonitor.TabIndex = 2;
            // 
            // btnSelectFolderMonitor
            // 
            this.btnSelectFolderMonitor.Location = new System.Drawing.Point(450, 8);
            this.btnSelectFolderMonitor.Name = "btnSelectFolderMonitor";
            this.btnSelectFolderMonitor.Size = new System.Drawing.Size(97, 32);
            this.btnSelectFolderMonitor.TabIndex = 1;
            this.btnSelectFolderMonitor.Text = "Select";
            this.btnSelectFolderMonitor.UseVisualStyleBackColor = true;
            this.btnSelectFolderMonitor.Click += new System.EventHandler(this.btnSelectFolderMonitor_Click);
            // 
            // txtFolderMonitor
            // 
            this.txtFolderMonitor.Enabled = false;
            this.txtFolderMonitor.Location = new System.Drawing.Point(32, 15);
            this.txtFolderMonitor.Name = "txtFolderMonitor";
            this.txtFolderMonitor.Size = new System.Drawing.Size(412, 20);
            this.txtFolderMonitor.TabIndex = 0;
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(567, 43);
            this.pnlTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the folder to monitor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormApplicationStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 253);
            this.Controls.Add(this.pnlPrincipal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormApplicationStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.pnlPrincipal.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlSelectFolderMonitor.ResumeLayout(false);
            this.pnlSelectFolderMonitor.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSelectFolderMonitor;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFolderForProcessedFiles;
        private System.Windows.Forms.TextBox txtFolderForProcessedAndNotApplicableFiles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectFolderMonitor;
        private System.Windows.Forms.TextBox txtFolderMonitor;
    }
}

