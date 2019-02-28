namespace WookieCodeControls
{
    partial class MainMenu
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.lblControl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // picMenu
            // 
            this.picMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picMenu.BackColor = System.Drawing.Color.IndianRed;
            this.picMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picMenu.Location = new System.Drawing.Point(0, 0);
            this.picMenu.Margin = new System.Windows.Forms.Padding(10, 100, 10, 100);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(180, 173);
            this.picMenu.TabIndex = 0;
            this.picMenu.TabStop = false;
            this.picMenu.Click += new System.EventHandler(this.ObreForm);
            // 
            // lblControl
            // 
            this.lblControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblControl.BackColor = System.Drawing.Color.Maroon;
            this.lblControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblControl.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControl.ForeColor = System.Drawing.Color.White;
            this.lblControl.Location = new System.Drawing.Point(0, 147);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(180, 26);
            this.lblControl.TabIndex = 1;
            this.lblControl.Text = "FLOTA ESPACIAL";
            this.lblControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblControl.Click += new System.EventHandler(this.ObreForm);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lblControl);
            this.Controls.Add(this.picMenu);
            this.Margin = new System.Windows.Forms.Padding(10, 30, 10, 10);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(180, 173);
            this.Click += new System.EventHandler(this.ObreForm);
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMenu;
        private System.Windows.Forms.Label lblControl;
    }
}
