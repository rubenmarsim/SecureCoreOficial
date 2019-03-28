namespace Escandall
{
    partial class frmEscandall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEscandall));
            this.treeViewEscandall = new System.Windows.Forms.TreeView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.picBoxEscandall = new System.Windows.Forms.PictureBox();
            this.WMPEscandall = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEscandall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMPEscandall)).BeginInit();
            this.SuspendLayout();
            // 
            // treeViewEscandall
            // 
            this.treeViewEscandall.Location = new System.Drawing.Point(12, 12);
            this.treeViewEscandall.Name = "treeViewEscandall";
            this.treeViewEscandall.Size = new System.Drawing.Size(351, 426);
            this.treeViewEscandall.TabIndex = 0;
            this.treeViewEscandall.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewEscandall_AfterSelect);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 444);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(351, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // picBoxEscandall
            // 
            this.picBoxEscandall.Location = new System.Drawing.Point(369, 12);
            this.picBoxEscandall.Name = "picBoxEscandall";
            this.picBoxEscandall.Size = new System.Drawing.Size(449, 205);
            this.picBoxEscandall.TabIndex = 7;
            this.picBoxEscandall.TabStop = false;
            // 
            // WMPEscandall
            // 
            this.WMPEscandall.Enabled = true;
            this.WMPEscandall.Location = new System.Drawing.Point(369, 223);
            this.WMPEscandall.Name = "WMPEscandall";
            this.WMPEscandall.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMPEscandall.OcxState")));
            this.WMPEscandall.Size = new System.Drawing.Size(449, 244);
            this.WMPEscandall.TabIndex = 8;
            // 
            // frmEscandall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 475);
            this.Controls.Add(this.WMPEscandall);
            this.Controls.Add(this.picBoxEscandall);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.treeViewEscandall);
            this.Name = "frmEscandall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escandall";
            this.Load += new System.EventHandler(this.frmEscandall_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEscandall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMPEscandall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewEscandall;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.PictureBox picBoxEscandall;
        private AxWMPLib.AxWindowsMediaPlayer WMPEscandall;
    }
}

