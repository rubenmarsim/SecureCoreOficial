namespace MantenimientosXWings
{
    partial class frmMantenimientoXWings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoXWings));
            this.btnReferenceTypes = new System.Windows.Forms.Button();
            this.btnReferences = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReferenceTypes
            // 
            this.btnReferenceTypes.Location = new System.Drawing.Point(240, 78);
            this.btnReferenceTypes.Name = "btnReferenceTypes";
            this.btnReferenceTypes.Size = new System.Drawing.Size(116, 23);
            this.btnReferenceTypes.TabIndex = 0;
            this.btnReferenceTypes.Text = "ReferenceTypes";
            this.btnReferenceTypes.UseVisualStyleBackColor = true;
            this.btnReferenceTypes.Click += new System.EventHandler(this.btnReferenceTypes_Click);
            // 
            // btnReferences
            // 
            this.btnReferences.Location = new System.Drawing.Point(118, 78);
            this.btnReferences.Name = "btnReferences";
            this.btnReferences.Size = new System.Drawing.Size(116, 23);
            this.btnReferences.TabIndex = 1;
            this.btnReferences.Text = "References";
            this.btnReferences.UseVisualStyleBackColor = true;
            this.btnReferences.Click += new System.EventHandler(this.btnReferences_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elija como gestionar el mantenimiento de los X-Wings:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMantenimientoXWings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 150);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReferences);
            this.Controls.Add(this.btnReferenceTypes);
            this.Name = "frmMantenimientoXWings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de los X-Wings";
            this.Load += new System.EventHandler(this.frmMantenimientoXWings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReferenceTypes;
        private System.Windows.Forms.Button btnReferences;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

