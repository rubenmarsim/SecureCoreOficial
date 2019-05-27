namespace FTP
{
    partial class frmBajarFTP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBajarFTP));
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnNoDescarregar = new System.Windows.Forms.Button();
            this.labelDownload = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(12, 124);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(108, 22);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Descargar";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnNoDescarregar
            // 
            this.btnNoDescarregar.Location = new System.Drawing.Point(126, 123);
            this.btnNoDescarregar.Name = "btnNoDescarregar";
            this.btnNoDescarregar.Size = new System.Drawing.Size(108, 23);
            this.btnNoDescarregar.TabIndex = 1;
            this.btnNoDescarregar.Text = "Cancelar";
            this.btnNoDescarregar.UseVisualStyleBackColor = true;
            this.btnNoDescarregar.Click += new System.EventHandler(this.btnNoDescarregar_Click);
            // 
            // labelDownload
            // 
            this.labelDownload.AutoSize = true;
            this.labelDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDownload.Location = new System.Drawing.Point(6, 78);
            this.labelDownload.Name = "labelDownload";
            this.labelDownload.Size = new System.Drawing.Size(238, 32);
            this.labelDownload.TabIndex = 2;
            this.labelDownload.Text = "Descargar las nuevas comandas para\r\nintroducirlas a la Base de Datos?";
            this.labelDownload.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(82, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmBajarFTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 158);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelDownload);
            this.Controls.Add(this.btnNoDescarregar);
            this.Controls.Add(this.btnDownload);
            this.Name = "frmBajarFTP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Descargar archivos";
            this.Load += new System.EventHandler(this.frmBajarFTP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnNoDescarregar;
        private System.Windows.Forms.Label labelDownload;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}