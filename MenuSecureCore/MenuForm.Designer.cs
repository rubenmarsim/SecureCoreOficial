namespace MenuSecureCore
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.PanelButtonsMain = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // PanelButtonsMain
            // 
            this.PanelButtonsMain.AutoSize = true;
            this.PanelButtonsMain.BackColor = System.Drawing.Color.Transparent;
            this.PanelButtonsMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelButtonsMain.Location = new System.Drawing.Point(0, 0);
            this.PanelButtonsMain.Margin = new System.Windows.Forms.Padding(10);
            this.PanelButtonsMain.Name = "PanelButtonsMain";
            this.PanelButtonsMain.Size = new System.Drawing.Size(876, 561);
            this.PanelButtonsMain.TabIndex = 0;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(876, 561);
            this.Controls.Add(this.PanelButtonsMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "MenuForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.Controls.SetChildIndex(this.PanelButtonsMain, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanelButtonsMain;
    }
}

