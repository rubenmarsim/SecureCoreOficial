namespace PDFtoDB
{
    partial class frmPDF
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
            this.lblIdReference = new System.Windows.Forms.Label();
            this.lblArchivo = new System.Windows.Forms.Label();
            this.grpBoxPDF = new System.Windows.Forms.GroupBox();
            this.txtBoxArchivo = new System.Windows.Forms.TextBox();
            this.cmbBoxIdReference = new System.Windows.Forms.ComboBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.dgvPDF = new System.Windows.Forms.DataGridView();
            this.webBrowserPDF = new System.Windows.Forms.WebBrowser();
            this.grpBoxPDF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdReference
            // 
            this.lblIdReference.AutoSize = true;
            this.lblIdReference.Location = new System.Drawing.Point(6, 27);
            this.lblIdReference.Name = "lblIdReference";
            this.lblIdReference.Size = new System.Drawing.Size(69, 13);
            this.lblIdReference.TabIndex = 0;
            this.lblIdReference.Text = "IdReference:";
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Location = new System.Drawing.Point(6, 51);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(46, 13);
            this.lblArchivo.TabIndex = 1;
            this.lblArchivo.Text = "Archivo:";
            // 
            // grpBoxPDF
            // 
            this.grpBoxPDF.Controls.Add(this.dgvPDF);
            this.grpBoxPDF.Controls.Add(this.btnOpen);
            this.grpBoxPDF.Controls.Add(this.btnSave);
            this.grpBoxPDF.Controls.Add(this.btnBrowse);
            this.grpBoxPDF.Controls.Add(this.txtBoxArchivo);
            this.grpBoxPDF.Controls.Add(this.cmbBoxIdReference);
            this.grpBoxPDF.Controls.Add(this.lblIdReference);
            this.grpBoxPDF.Controls.Add(this.lblArchivo);
            this.grpBoxPDF.Location = new System.Drawing.Point(12, 12);
            this.grpBoxPDF.Name = "grpBoxPDF";
            this.grpBoxPDF.Size = new System.Drawing.Size(463, 266);
            this.grpBoxPDF.TabIndex = 2;
            this.grpBoxPDF.TabStop = false;
            this.grpBoxPDF.Text = "Gestion PDF";
            // 
            // txtBoxArchivo
            // 
            this.txtBoxArchivo.Location = new System.Drawing.Point(82, 51);
            this.txtBoxArchivo.Name = "txtBoxArchivo";
            this.txtBoxArchivo.ReadOnly = true;
            this.txtBoxArchivo.Size = new System.Drawing.Size(333, 20);
            this.txtBoxArchivo.TabIndex = 3;
            // 
            // cmbBoxIdReference
            // 
            this.cmbBoxIdReference.FormattingEnabled = true;
            this.cmbBoxIdReference.Location = new System.Drawing.Point(82, 27);
            this.cmbBoxIdReference.Name = "cmbBoxIdReference";
            this.cmbBoxIdReference.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxIdReference.TabIndex = 2;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(421, 51);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(29, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(375, 96);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(294, 96);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "Abrir";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // dgvPDF
            // 
            this.dgvPDF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPDF.Location = new System.Drawing.Point(9, 96);
            this.dgvPDF.Name = "dgvPDF";
            this.dgvPDF.Size = new System.Drawing.Size(279, 155);
            this.dgvPDF.TabIndex = 3;
            // 
            // webBrowserPDF
            // 
            this.webBrowserPDF.Location = new System.Drawing.Point(481, 12);
            this.webBrowserPDF.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserPDF.Name = "webBrowserPDF";
            this.webBrowserPDF.Size = new System.Drawing.Size(307, 426);
            this.webBrowserPDF.TabIndex = 3;
            // 
            // frmPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowserPDF);
            this.Controls.Add(this.grpBoxPDF);
            this.Name = "frmPDF";
            this.Text = "frmPDF";
            this.Load += new System.EventHandler(this.frmPDF_Load);
            this.grpBoxPDF.ResumeLayout(false);
            this.grpBoxPDF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPDF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIdReference;
        private System.Windows.Forms.Label lblArchivo;
        private System.Windows.Forms.GroupBox grpBoxPDF;
        private System.Windows.Forms.ComboBox cmbBoxIdReference;
        private System.Windows.Forms.TextBox txtBoxArchivo;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.DataGridView dgvPDF;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.WebBrowser webBrowserPDF;
    }
}