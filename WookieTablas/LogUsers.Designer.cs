namespace WookieTablas
{
    partial class LogUsers
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
            this.label4 = new System.Windows.Forms.Label();
            this.sdsTexBox4 = new SdsTexBox.SdsTexBox();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(155, 460);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(68, 460);
            // 
            // LabelCodeForanea
            // 
            this.LabelCodeForanea.Size = new System.Drawing.Size(0, 13);
            this.LabelCodeForanea.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(35, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "PortPlanet";
            this.label4.Visible = false;
            // 
            // sdsTexBox4
            // 
            this.sdsTexBox4.CodeSector = null;
            this.sdsTexBox4.ColumnName = null;
            this.sdsTexBox4.DescCodi = null;
            this.sdsTexBox4.Location = new System.Drawing.Point(97, 184);
            this.sdsTexBox4.Name = "sdsTexBox4";
            this.sdsTexBox4.Nom = null;
            this.sdsTexBox4.NomBBDD = null;
            this.sdsTexBox4.NomCamp = null;
            this.sdsTexBox4.NomControl = null;
            this.sdsTexBox4.NomTaula = null;
            this.sdsTexBox4.Requerit = false;
            this.sdsTexBox4.SiEsForana = false;
            this.sdsTexBox4.Size = new System.Drawing.Size(200, 20);
            this.sdsTexBox4.TabIndex = 52;
            this.sdsTexBox4.Visible = false;
            // 
            // LogUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 530);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sdsTexBox4);
            this.Name = "LogUsers";
            this.Text = "LogUsers";
            this.Load += new System.EventHandler(this.LogUsers_Load);
            this.Controls.SetChildIndex(this.LabelCodeForanea, 0);
            this.Controls.SetChildIndex(this.btnInsert, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.sdsTexBox4, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private SdsTexBox.SdsTexBox sdsTexBox4;
    }
}