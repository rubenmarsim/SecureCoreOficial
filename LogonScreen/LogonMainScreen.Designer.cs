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
            this.UserBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.IconStarWars = new System.Windows.Forms.PictureBox();
            this.ButtonEntrar = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.IconStarWars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            this.ButtonEntrar.BackColor = System.Drawing.Color.Black;
            this.ButtonEntrar.FlatAppearance.BorderSize = 0;
            this.ButtonEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.ButtonEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.ButtonEntrar, "ButtonEntrar");
            this.ButtonEntrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonEntrar.Name = "ButtonEntrar";
            this.ButtonEntrar.UseVisualStyleBackColor = false;
            this.ButtonEntrar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ErrorLabel
            // 
            resources.ApplyResources(this.ErrorLabel, "ErrorLabel");
            this.ErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.ErrorLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ErrorLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // LogonMainScreen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.IconStarWars);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.ButtonEntrar);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.UserBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogonMainScreen";
            this.Load += new System.EventHandler(this.LogonMainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IconStarWars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.PictureBox IconStarWars;
        private System.Windows.Forms.Button ButtonEntrar;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

