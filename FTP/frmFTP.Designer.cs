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
            this.btnBrowsePush = new System.Windows.Forms.Button();
            this.txtBoxDescPush = new System.Windows.Forms.TextBox();
            this.lblDescPush = new System.Windows.Forms.Label();
            this.btnPush = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gBoxPush.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxPush
            // 
            this.gBoxPush.Controls.Add(this.btnBrowsePush);
            this.gBoxPush.Controls.Add(this.txtBoxDescPush);
            this.gBoxPush.Controls.Add(this.lblDescPush);
            this.gBoxPush.Location = new System.Drawing.Point(12, 109);
            this.gBoxPush.Name = "gBoxPush";
            this.gBoxPush.Size = new System.Drawing.Size(776, 96);
            this.gBoxPush.TabIndex = 0;
            this.gBoxPush.TabStop = false;
            this.gBoxPush.Text = "URL para subir el archivo";
            // 
            // btnBrowsePush
            // 
            this.btnBrowsePush.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowsePush.Location = new System.Drawing.Point(695, 26);
            this.btnBrowsePush.Name = "btnBrowsePush";
            this.btnBrowsePush.Size = new System.Drawing.Size(75, 23);
            this.btnBrowsePush.TabIndex = 2;
            this.btnBrowsePush.Text = "Examinar";
            this.btnBrowsePush.UseVisualStyleBackColor = true;
            this.btnBrowsePush.Click += new System.EventHandler(this.btnBrowsePush_Click);
            // 
            // txtBoxDescPush
            // 
            this.txtBoxDescPush.Location = new System.Drawing.Point(62, 28);
            this.txtBoxDescPush.Name = "txtBoxDescPush";
            this.txtBoxDescPush.ReadOnly = true;
            this.txtBoxDescPush.Size = new System.Drawing.Size(627, 20);
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
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(637, 13);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(75, 23);
            this.btnPush.TabIndex = 3;
            this.btnPush.Text = "PUSH";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Especifique la ubicación de su archivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(464, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Escriba la dirección donde se encuentra su archivo o examine el equipo en busca d" +
    "e su carpeta.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(718, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox1.Controls.Add(this.btnPush);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(-1, 409);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 42);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // frmFTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gBoxPush);
            this.Name = "frmFTP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subir archivo FTP";
            this.Load += new System.EventHandler(this.frmFTP_Load);
            this.gBoxPush.ResumeLayout(false);
            this.gBoxPush.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxPush;
        private System.Windows.Forms.Button btnBrowsePush;
        private System.Windows.Forms.TextBox txtBoxDescPush;
        private System.Windows.Forms.Label lblDescPush;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}