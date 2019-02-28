namespace PlantillaPrincipalStarWars
{
    partial class PlantillaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlantillaForm));
            this.PanelTableTitle = new System.Windows.Forms.TableLayoutPanel();
            this.TittleScreen = new System.Windows.Forms.Label();
            this.UsernameTitle = new System.Windows.Forms.Label();
            this.ButtonAtras = new System.Windows.Forms.PictureBox();
            this.ExitButtonTitle = new System.Windows.Forms.PictureBox();
            this.UserIconTitle = new System.Windows.Forms.PictureBox();
            this.SeparadorPanel = new System.Windows.Forms.Panel();
            this.PanelTableTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButtonTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIconTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTableTitle
            // 
            this.PanelTableTitle.AutoSize = true;
            this.PanelTableTitle.BackColor = System.Drawing.Color.OrangeRed;
            this.PanelTableTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelTableTitle.ColumnCount = 5;
            this.PanelTableTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.PanelTableTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelTableTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.PanelTableTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.PanelTableTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.PanelTableTitle.Controls.Add(this.TittleScreen, 1, 0);
            this.PanelTableTitle.Controls.Add(this.UsernameTitle, 2, 0);
            this.PanelTableTitle.Controls.Add(this.ButtonAtras, 0, 0);
            this.PanelTableTitle.Controls.Add(this.ExitButtonTitle, 4, 0);
            this.PanelTableTitle.Controls.Add(this.UserIconTitle, 3, 0);
            this.PanelTableTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTableTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTableTitle.Margin = new System.Windows.Forms.Padding(10);
            this.PanelTableTitle.Name = "PanelTableTitle";
            this.PanelTableTitle.Padding = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.PanelTableTitle.RowCount = 1;
            this.PanelTableTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelTableTitle.Size = new System.Drawing.Size(950, 95);
            this.PanelTableTitle.TabIndex = 0;
            // 
            // TittleScreen
            // 
            this.TittleScreen.AutoSize = true;
            this.TittleScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TittleScreen.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TittleScreen.ForeColor = System.Drawing.Color.White;
            this.TittleScreen.Location = new System.Drawing.Point(183, 15);
            this.TittleScreen.Name = "TittleScreen";
            this.TittleScreen.Size = new System.Drawing.Size(392, 70);
            this.TittleScreen.TabIndex = 0;
            this.TittleScreen.Text = "Nombre de la pantalla";
            this.TittleScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UsernameTitle
            // 
            this.UsernameTitle.AutoSize = true;
            this.UsernameTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsernameTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTitle.ForeColor = System.Drawing.Color.White;
            this.UsernameTitle.Location = new System.Drawing.Point(581, 15);
            this.UsernameTitle.Name = "UsernameTitle";
            this.UsernameTitle.Size = new System.Drawing.Size(149, 70);
            this.UsernameTitle.TabIndex = 2;
            this.UsernameTitle.Text = "UserName";
            this.UsernameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ButtonAtras
            // 
            this.ButtonAtras.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAtras.Image")));
            this.ButtonAtras.Location = new System.Drawing.Point(13, 18);
            this.ButtonAtras.Name = "ButtonAtras";
            this.ButtonAtras.Size = new System.Drawing.Size(82, 64);
            this.ButtonAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonAtras.TabIndex = 4;
            this.ButtonAtras.TabStop = false;
            this.ButtonAtras.Visible = false;
            this.ButtonAtras.Click += new System.EventHandler(this.BotonAtras_Click);
            // 
            // ExitButtonTitle
            // 
            this.ExitButtonTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ExitButtonTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButtonTitle.BackgroundImage")));
            this.ExitButtonTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitButtonTitle.Location = new System.Drawing.Point(906, 34);
            this.ExitButtonTitle.Name = "ExitButtonTitle";
            this.ExitButtonTitle.Size = new System.Drawing.Size(31, 32);
            this.ExitButtonTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitButtonTitle.TabIndex = 3;
            this.ExitButtonTitle.TabStop = false;
            this.ExitButtonTitle.Click += new System.EventHandler(this.ExitButtonTitle_Click);
            // 
            // UserIconTitle
            // 
            this.UserIconTitle.Location = new System.Drawing.Point(736, 18);
            this.UserIconTitle.Name = "UserIconTitle";
            this.UserIconTitle.Size = new System.Drawing.Size(138, 64);
            this.UserIconTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserIconTitle.TabIndex = 1;
            this.UserIconTitle.TabStop = false;
            // 
            // SeparadorPanel
            // 
            this.SeparadorPanel.BackColor = System.Drawing.Color.Black;
            this.SeparadorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SeparadorPanel.Location = new System.Drawing.Point(0, 95);
            this.SeparadorPanel.Name = "SeparadorPanel";
            this.SeparadorPanel.Size = new System.Drawing.Size(950, 4);
            this.SeparadorPanel.TabIndex = 23;
            // 
            // PlantillaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(950, 561);
            this.Controls.Add(this.SeparadorPanel);
            this.Controls.Add(this.PanelTableTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlantillaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = ".";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PanelTableTitle.ResumeLayout(false);
            this.PanelTableTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButtonTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIconTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PanelTableTitle;
        private System.Windows.Forms.PictureBox ExitButtonTitle;
        public System.Windows.Forms.PictureBox UserIconTitle;
        public System.Windows.Forms.Label UsernameTitle;
        public System.Windows.Forms.Label TittleScreen;
        public System.Windows.Forms.PictureBox ButtonAtras;
        private System.Windows.Forms.Panel SeparadorPanel;
    }
}

