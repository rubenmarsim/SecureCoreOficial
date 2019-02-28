namespace PantallaCerca
{
    partial class Cerca
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
            this.dGVCerca = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCerca)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVCerca
            // 
            this.dGVCerca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCerca.Location = new System.Drawing.Point(1, 0);
            this.dGVCerca.Name = "dGVCerca";
            this.dGVCerca.Size = new System.Drawing.Size(464, 453);
            this.dGVCerca.TabIndex = 0;
            this.dGVCerca.DoubleClick += new System.EventHandler(this.dGVCerca_DoubleClick);
            // 
            // Cerca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 451);
            this.Controls.Add(this.dGVCerca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Cerca";
            this.Text = "Cerca";
            this.Load += new System.EventHandler(this.Cerca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVCerca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVCerca;
    }
}