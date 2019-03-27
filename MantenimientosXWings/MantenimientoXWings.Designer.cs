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
            this.btnReferenceTypes = new System.Windows.Forms.Button();
            this.btnReferences = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReferenceTypes
            // 
            this.btnReferenceTypes.Location = new System.Drawing.Point(317, 54);
            this.btnReferenceTypes.Name = "btnReferenceTypes";
            this.btnReferenceTypes.Size = new System.Drawing.Size(166, 23);
            this.btnReferenceTypes.TabIndex = 0;
            this.btnReferenceTypes.Text = "ReferenceTypes";
            this.btnReferenceTypes.UseVisualStyleBackColor = true;
            this.btnReferenceTypes.Click += new System.EventHandler(this.btnReferenceTypes_Click);
            // 
            // btnReferences
            // 
            this.btnReferences.Location = new System.Drawing.Point(317, 109);
            this.btnReferences.Name = "btnReferences";
            this.btnReferences.Size = new System.Drawing.Size(166, 23);
            this.btnReferences.TabIndex = 1;
            this.btnReferences.Text = "References";
            this.btnReferences.UseVisualStyleBackColor = true;
            this.btnReferences.Click += new System.EventHandler(this.btnReferences_Click);
            // 
            // frmMantenimientoXWings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReferences);
            this.Controls.Add(this.btnReferenceTypes);
            this.Name = "frmMantenimientoXWings";
            this.Text = "MantenimientoXWings";
            this.Load += new System.EventHandler(this.frmMantenimientoXWings_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReferenceTypes;
        private System.Windows.Forms.Button btnReferences;
    }
}

