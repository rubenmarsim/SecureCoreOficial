namespace ConsejoJedai
{
    partial class ConsejoForm
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
            this.PanelButtonsMain = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // PanelButtonsMain
            // 
            this.PanelButtonsMain.AutoSize = true;
            this.PanelButtonsMain.BackColor = System.Drawing.Color.Transparent;
            this.PanelButtonsMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelButtonsMain.Location = new System.Drawing.Point(0, 95);
            this.PanelButtonsMain.Margin = new System.Windows.Forms.Padding(10);
            this.PanelButtonsMain.Name = "PanelButtonsMain";
            this.PanelButtonsMain.Size = new System.Drawing.Size(800, 355);
            this.PanelButtonsMain.TabIndex = 1;
            // 
            // ConsejoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelButtonsMain);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "ConsejoForm";
            this.Text = "ConsejoForm";
            this.Load += new System.EventHandler(this.ConsejoForm_Load);
            this.Controls.SetChildIndex(this.PanelButtonsMain, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanelButtonsMain;
    }
}