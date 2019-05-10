namespace FTP
{
    partial class frmFTP
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
            this.gBoxPush = new System.Windows.Forms.GroupBox();
            this.btnPush = new System.Windows.Forms.Button();
            this.btnBrowsePush = new System.Windows.Forms.Button();
            this.txtBoxDescPush = new System.Windows.Forms.TextBox();
            this.lblDescPush = new System.Windows.Forms.Label();
            this.gBoxPush.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxPush
            // 
            this.gBoxPush.Controls.Add(this.btnPush);
            this.gBoxPush.Controls.Add(this.btnBrowsePush);
            this.gBoxPush.Controls.Add(this.txtBoxDescPush);
            this.gBoxPush.Controls.Add(this.lblDescPush);
            this.gBoxPush.Location = new System.Drawing.Point(12, 12);
            this.gBoxPush.Name = "gBoxPush";
            this.gBoxPush.Size = new System.Drawing.Size(776, 96);
            this.gBoxPush.TabIndex = 0;
            this.gBoxPush.TabStop = false;
            this.gBoxPush.Text = "Subir Archivo";
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(695, 57);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(75, 23);
            this.btnPush.TabIndex = 3;
            this.btnPush.Text = "PUSH";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // btnBrowsePush
            // 
            this.btnBrowsePush.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowsePush.Location = new System.Drawing.Point(738, 28);
            this.btnBrowsePush.Name = "btnBrowsePush";
            this.btnBrowsePush.Size = new System.Drawing.Size(32, 23);
            this.btnBrowsePush.TabIndex = 2;
            this.btnBrowsePush.Text = "...";
            this.btnBrowsePush.UseVisualStyleBackColor = true;
            this.btnBrowsePush.Click += new System.EventHandler(this.btnBrowsePush_Click);
            // 
            // txtBoxDescPush
            // 
            this.txtBoxDescPush.Location = new System.Drawing.Point(62, 28);
            this.txtBoxDescPush.Name = "txtBoxDescPush";
            this.txtBoxDescPush.ReadOnly = true;
            this.txtBoxDescPush.Size = new System.Drawing.Size(669, 20);
            this.txtBoxDescPush.TabIndex = 1;
            // 
            // lblDescPush
            // 
            this.lblDescPush.AutoSize = true;
            this.lblDescPush.Location = new System.Drawing.Point(6, 28);
            this.lblDescPush.Name = "lblDescPush";
            this.lblDescPush.Size = new System.Drawing.Size(49, 13);
            this.lblDescPush.TabIndex = 0;
            this.lblDescPush.Text = "Archivo: ";
            // 
            // frmFTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gBoxPush);
            this.Name = "frmFTP";
            this.Text = "GestionFTP";
            this.Load += new System.EventHandler(this.frmFTP_Load);
            this.gBoxPush.ResumeLayout(false);
            this.gBoxPush.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxPush;
        private System.Windows.Forms.Button btnBrowsePush;
        private System.Windows.Forms.TextBox txtBoxDescPush;
        private System.Windows.Forms.Label lblDescPush;
        private System.Windows.Forms.Button btnPush;
    }
}