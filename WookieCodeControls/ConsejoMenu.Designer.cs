namespace WookieCodeControls
{
    partial class ConsejoMenu
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
            this.ButtonConsejo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonConsejo
            // 
            this.ButtonConsejo.BackColor = System.Drawing.Color.Maroon;
            this.ButtonConsejo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonConsejo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonConsejo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonConsejo.ForeColor = System.Drawing.Color.White;
            this.ButtonConsejo.Location = new System.Drawing.Point(0, 0);
            this.ButtonConsejo.Name = "ButtonConsejo";
            this.ButtonConsejo.Size = new System.Drawing.Size(191, 52);
            this.ButtonConsejo.TabIndex = 0;
            this.ButtonConsejo.Text = "Text";
            this.ButtonConsejo.UseVisualStyleBackColor = false;
            this.ButtonConsejo.Click += new System.EventHandler(this.ObreForm);
            // 
            // ConsejoMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonConsejo);
            this.Name = "ConsejoMenu";
            this.Size = new System.Drawing.Size(191, 52);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonConsejo;
    }
}
