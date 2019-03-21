namespace WookieTablas
{
    partial class frmReferenceTypes
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
            this.dGVReferenceTypes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVReferenceTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVReferenceTypes
            // 
            this.dGVReferenceTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVReferenceTypes.Location = new System.Drawing.Point(12, 12);
            this.dGVReferenceTypes.Name = "dGVReferenceTypes";
            this.dGVReferenceTypes.Size = new System.Drawing.Size(441, 257);
            this.dGVReferenceTypes.TabIndex = 0;
            // 
            // frmReferenceTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dGVReferenceTypes);
            this.Name = "frmReferenceTypes";
            this.Text = "ReferenceTypes";
            this.Load += new System.EventHandler(this.frmReferenceTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVReferenceTypes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVReferenceTypes;
    }
}