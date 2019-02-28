namespace WindowsFormsApp2
{
    partial class SplashScreenForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreenForm));
            this.BarraRigth = new System.Windows.Forms.Panel();
            this.BarraBottom = new System.Windows.Forms.Panel();
            this.BarraLeft = new System.Windows.Forms.Panel();
            this.BarraTop = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.ComentProgess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BarraRigth
            // 
            this.BarraRigth.BackColor = System.Drawing.Color.OrangeRed;
            this.BarraRigth.Dock = System.Windows.Forms.DockStyle.Right;
            this.BarraRigth.Location = new System.Drawing.Point(611, 0);
            this.BarraRigth.Name = "BarraRigth";
            this.BarraRigth.Size = new System.Drawing.Size(3, 371);
            this.BarraRigth.TabIndex = 0;
            // 
            // BarraBottom
            // 
            this.BarraBottom.BackColor = System.Drawing.Color.OrangeRed;
            this.BarraBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarraBottom.Location = new System.Drawing.Point(0, 368);
            this.BarraBottom.Name = "BarraBottom";
            this.BarraBottom.Size = new System.Drawing.Size(611, 3);
            this.BarraBottom.TabIndex = 1;
            // 
            // BarraLeft
            // 
            this.BarraLeft.BackColor = System.Drawing.Color.OrangeRed;
            this.BarraLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarraLeft.Location = new System.Drawing.Point(0, 0);
            this.BarraLeft.Name = "BarraLeft";
            this.BarraLeft.Size = new System.Drawing.Size(3, 368);
            this.BarraLeft.TabIndex = 1;
            // 
            // BarraTop
            // 
            this.BarraTop.BackColor = System.Drawing.Color.OrangeRed;
            this.BarraTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTop.Location = new System.Drawing.Point(3, 0);
            this.BarraTop.Name = "BarraTop";
            this.BarraTop.Size = new System.Drawing.Size(608, 3);
            this.BarraTop.TabIndex = 1;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer1_Tick_1);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Enabled = false;
            this.progressBar.Location = new System.Drawing.Point(122, 298);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(360, 4);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 3;
            this.progressBar.Click += new System.EventHandler(this.ProgressBar1_Click);
            // 
            // ComentProgess
            // 
            this.ComentProgess.AutoSize = true;
            this.ComentProgess.BackColor = System.Drawing.Color.Transparent;
            this.ComentProgess.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ComentProgess.Location = new System.Drawing.Point(204, 312);
            this.ComentProgess.Name = "ComentProgess";
            this.ComentProgess.Size = new System.Drawing.Size(35, 13);
            this.ComentProgess.TabIndex = 4;
            this.ComentProgess.Text = "label1";
            this.ComentProgess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ComentProgess.Click += new System.EventHandler(this.Label1_Click);
            // 
            // SplashScreenForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(614, 371);
            this.ControlBox = false;
            this.Controls.Add(this.ComentProgess);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.BarraTop);
            this.Controls.Add(this.BarraLeft);
            this.Controls.Add(this.BarraBottom);
            this.Controls.Add(this.BarraRigth);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "SplashScreenForm";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraRigth;
        private System.Windows.Forms.Panel BarraBottom;
        private System.Windows.Forms.Panel BarraLeft;
        private System.Windows.Forms.Panel BarraTop;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label ComentProgess;
    }
}

