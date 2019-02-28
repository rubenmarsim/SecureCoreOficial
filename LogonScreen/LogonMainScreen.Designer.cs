namespace LogonScreen
{
    partial class LogonMainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogonMainScreen));
            this.UserTitle = new System.Windows.Forms.Label();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.PasswordTitle = new System.Windows.Forms.Label();
            this.IconStarWars = new System.Windows.Forms.PictureBox();
            this.ButtonEntrar = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.EasterEgg1 = new System.Windows.Forms.PictureBox();
            this.EasterEgg2 = new System.Windows.Forms.PictureBox();
            this.EasterEgg3 = new System.Windows.Forms.PictureBox();
            this.EasterEgg4 = new System.Windows.Forms.PictureBox();
            this.EasterEgg5 = new System.Windows.Forms.PictureBox();
            this.EasterEgg6 = new System.Windows.Forms.PictureBox();
            this.EasterEgg7 = new System.Windows.Forms.PictureBox();
            this.EasterEgg8 = new System.Windows.Forms.PictureBox();
            this.BarraBottom = new System.Windows.Forms.Panel();
            this.BarraRigth = new System.Windows.Forms.Panel();
            this.BarraTop = new System.Windows.Forms.Panel();
            this.BarraLeft = new System.Windows.Forms.Panel();
            this.Marco = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.IconStarWars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EasterEgg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EasterEgg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EasterEgg3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EasterEgg4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EasterEgg5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EasterEgg6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EasterEgg7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EasterEgg8)).BeginInit();
            this.BarraRigth.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserTitle
            // 
            resources.ApplyResources(this.UserTitle, "UserTitle");
            this.UserTitle.BackColor = System.Drawing.Color.Transparent;
            this.UserTitle.ForeColor = System.Drawing.Color.Gold;
            this.UserTitle.Name = "UserTitle";
            // 
            // UserBox
            // 
            resources.ApplyResources(this.UserBox, "UserBox");
            this.UserBox.Name = "UserBox";
            // 
            // PassBox
            // 
            resources.ApplyResources(this.PassBox, "PassBox");
            this.PassBox.Name = "PassBox";
            // 
            // PasswordTitle
            // 
            resources.ApplyResources(this.PasswordTitle, "PasswordTitle");
            this.PasswordTitle.BackColor = System.Drawing.Color.Transparent;
            this.PasswordTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasswordTitle.ForeColor = System.Drawing.Color.Gold;
            this.PasswordTitle.Name = "PasswordTitle";
            // 
            // IconStarWars
            // 
            resources.ApplyResources(this.IconStarWars, "IconStarWars");
            this.IconStarWars.BackColor = System.Drawing.Color.Transparent;
            this.IconStarWars.Name = "IconStarWars";
            this.IconStarWars.TabStop = false;
            this.IconStarWars.Click += new System.EventHandler(this.IconStarWars_Click);
            // 
            // ButtonEntrar
            // 
            this.ButtonEntrar.BackColor = System.Drawing.Color.Transparent;
            this.ButtonEntrar.FlatAppearance.BorderSize = 0;
            this.ButtonEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.ButtonEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.ButtonEntrar, "ButtonEntrar");
            this.ButtonEntrar.ForeColor = System.Drawing.Color.Yellow;
            this.ButtonEntrar.Name = "ButtonEntrar";
            this.ButtonEntrar.UseVisualStyleBackColor = false;
            this.ButtonEntrar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ErrorLabel
            // 
            resources.ApplyResources(this.ErrorLabel, "ErrorLabel");
            this.ErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.ErrorLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Name = "ErrorLabel";
            // 
            // buttonExit
            // 
            resources.ApplyResources(this.buttonExit, "buttonExit");
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.ForeColor = System.Drawing.Color.Red;
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // EasterEgg1
            // 
            resources.ApplyResources(this.EasterEgg1, "EasterEgg1");
            this.EasterEgg1.BackColor = System.Drawing.Color.Transparent;
            this.EasterEgg1.Name = "EasterEgg1";
            this.EasterEgg1.TabStop = false;
            this.EasterEgg1.Click += new System.EventHandler(this.GifEasterEgg_Click);
            // 
            // EasterEgg2
            // 
            resources.ApplyResources(this.EasterEgg2, "EasterEgg2");
            this.EasterEgg2.BackColor = System.Drawing.Color.Transparent;
            this.EasterEgg2.Name = "EasterEgg2";
            this.EasterEgg2.TabStop = false;
            this.EasterEgg2.Click += new System.EventHandler(this.GifEasterEgg_Click);
            // 
            // EasterEgg3
            // 
            resources.ApplyResources(this.EasterEgg3, "EasterEgg3");
            this.EasterEgg3.BackColor = System.Drawing.Color.Transparent;
            this.EasterEgg3.Name = "EasterEgg3";
            this.EasterEgg3.TabStop = false;
            this.EasterEgg3.Click += new System.EventHandler(this.GifEasterEgg_Click);
            // 
            // EasterEgg4
            // 
            resources.ApplyResources(this.EasterEgg4, "EasterEgg4");
            this.EasterEgg4.BackColor = System.Drawing.Color.Transparent;
            this.EasterEgg4.Name = "EasterEgg4";
            this.EasterEgg4.TabStop = false;
            this.EasterEgg4.Click += new System.EventHandler(this.GifEasterEgg_Click);
            // 
            // EasterEgg5
            // 
            resources.ApplyResources(this.EasterEgg5, "EasterEgg5");
            this.EasterEgg5.BackColor = System.Drawing.Color.Transparent;
            this.EasterEgg5.Name = "EasterEgg5";
            this.EasterEgg5.TabStop = false;
            this.EasterEgg5.Click += new System.EventHandler(this.GifEasterEgg_Click);
            // 
            // EasterEgg6
            // 
            resources.ApplyResources(this.EasterEgg6, "EasterEgg6");
            this.EasterEgg6.BackColor = System.Drawing.Color.Transparent;
            this.EasterEgg6.Name = "EasterEgg6";
            this.EasterEgg6.TabStop = false;
            this.EasterEgg6.Click += new System.EventHandler(this.GifEasterEgg_Click);
            // 
            // EasterEgg7
            // 
            resources.ApplyResources(this.EasterEgg7, "EasterEgg7");
            this.EasterEgg7.BackColor = System.Drawing.Color.Transparent;
            this.EasterEgg7.Name = "EasterEgg7";
            this.EasterEgg7.TabStop = false;
            this.EasterEgg7.Click += new System.EventHandler(this.GifEasterEgg_Click);
            // 
            // EasterEgg8
            // 
            resources.ApplyResources(this.EasterEgg8, "EasterEgg8");
            this.EasterEgg8.BackColor = System.Drawing.Color.Transparent;
            this.EasterEgg8.Name = "EasterEgg8";
            this.EasterEgg8.TabStop = false;
            this.EasterEgg8.Click += new System.EventHandler(this.GifEasterEgg_Click);
            // 
            // BarraBottom
            // 
            this.BarraBottom.BackColor = System.Drawing.Color.OrangeRed;
            resources.ApplyResources(this.BarraBottom, "BarraBottom");
            this.BarraBottom.Name = "BarraBottom";
            // 
            // BarraRigth
            // 
            this.BarraRigth.BackColor = System.Drawing.Color.OrangeRed;
            this.BarraRigth.Controls.Add(this.BarraTop);
            resources.ApplyResources(this.BarraRigth, "BarraRigth");
            this.BarraRigth.Name = "BarraRigth";
            // 
            // BarraTop
            // 
            this.BarraTop.BackColor = System.Drawing.Color.OrangeRed;
            resources.ApplyResources(this.BarraTop, "BarraTop");
            this.BarraTop.Name = "BarraTop";
            // 
            // BarraLeft
            // 
            this.BarraLeft.BackColor = System.Drawing.Color.OrangeRed;
            resources.ApplyResources(this.BarraLeft, "BarraLeft");
            this.BarraLeft.Name = "BarraLeft";
            // 
            // Marco
            // 
            this.Marco.BackColor = System.Drawing.Color.OrangeRed;
            resources.ApplyResources(this.Marco, "Marco");
            this.Marco.Name = "Marco";
            // 
            // LogonMainScreen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.EasterEgg4);
            this.Controls.Add(this.Marco);
            this.Controls.Add(this.BarraLeft);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.BarraRigth);
            this.Controls.Add(this.EasterEgg8);
            this.Controls.Add(this.EasterEgg6);
            this.Controls.Add(this.IconStarWars);
            this.Controls.Add(this.BarraBottom);
            this.Controls.Add(this.EasterEgg7);
            this.Controls.Add(this.EasterEgg5);
            this.Controls.Add(this.EasterEgg3);
            this.Controls.Add(this.EasterEgg2);
            this.Controls.Add(this.EasterEgg1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.ButtonEntrar);
            this.Controls.Add(this.PasswordTitle);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.UserTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogonMainScreen";
            this.Load += new System.EventHandler(this.LogonMainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IconStarWars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EasterEgg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EasterEgg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EasterEgg3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EasterEgg4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EasterEgg5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EasterEgg6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EasterEgg7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EasterEgg8)).EndInit();
            this.BarraRigth.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserTitle;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Label PasswordTitle;
        private System.Windows.Forms.PictureBox IconStarWars;
        private System.Windows.Forms.Button ButtonEntrar;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.PictureBox EasterEgg1;
        private System.Windows.Forms.PictureBox EasterEgg2;
        private System.Windows.Forms.PictureBox EasterEgg3;
        private System.Windows.Forms.PictureBox EasterEgg4;
        private System.Windows.Forms.PictureBox EasterEgg5;
        private System.Windows.Forms.PictureBox EasterEgg6;
        private System.Windows.Forms.PictureBox EasterEgg7;
        private System.Windows.Forms.PictureBox EasterEgg8;
        private System.Windows.Forms.Panel BarraBottom;
        private System.Windows.Forms.Panel BarraRigth;
        private System.Windows.Forms.Panel BarraTop;
        private System.Windows.Forms.Panel BarraLeft;
        private System.Windows.Forms.Panel Marco;
    }
}

