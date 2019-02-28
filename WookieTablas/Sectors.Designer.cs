namespace WookieTablas
{
    partial class Sectors
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
            this.DesSector = new System.Windows.Forms.Label();
            this.labCodSector = new System.Windows.Forms.Label();
            this.sdstxtRegion = new SdsTexBox.SdsTexBox();
            this.sdsForaneaRegion = new WookieCodeControls.sdsForanea();
            this.sdsTexBox2 = new SdsTexBox.SdsTexBox();
            this.sdsTexBox3 = new SdsTexBox.SdsTexBox();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(156, 357);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(70, 357);
            // 
            // LabelCodeForanea
            // 
            this.LabelCodeForanea.Location = new System.Drawing.Point(79, 257);
            this.LabelCodeForanea.Size = new System.Drawing.Size(50, 13);
            this.LabelCodeForanea.Text = "IdRegion";
            // 
            // DesSector
            // 
            this.DesSector.AutoSize = true;
            this.DesSector.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DesSector.Location = new System.Drawing.Point(58, 205);
            this.DesSector.Name = "DesSector";
            this.DesSector.Size = new System.Drawing.Size(57, 13);
            this.DesSector.TabIndex = 36;
            this.DesSector.Text = "DesSector";
            // 
            // labCodSector
            // 
            this.labCodSector.AutoSize = true;
            this.labCodSector.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labCodSector.Location = new System.Drawing.Point(58, 161);
            this.labCodSector.Name = "labCodSector";
            this.labCodSector.Size = new System.Drawing.Size(63, 13);
            this.labCodSector.TabIndex = 35;
            this.labCodSector.Text = "CodeSector";
            // 
            // sdstxtRegion
            // 
            this.sdstxtRegion.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.sdstxtRegion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sdstxtRegion.CodeSector = null;
            this.sdstxtRegion.ColumnName = "idRegion";
            this.sdstxtRegion.DescCodi = null;
            this.sdstxtRegion.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.sdstxtRegion.Location = new System.Drawing.Point(728, 158);
            this.sdstxtRegion.Name = "sdstxtRegion";
            this.sdstxtRegion.Nom = null;
            this.sdstxtRegion.NomBBDD = "SecureCore";
            this.sdstxtRegion.NomCamp = "idRegion";
            this.sdstxtRegion.NomControl = "sdsForaneaRegion";
            this.sdstxtRegion.NomTaula = "Sectors";
            this.sdstxtRegion.ReadOnly = true;
            this.sdstxtRegion.Requerit = false;
            this.sdstxtRegion.SiEsForana = true;
            this.sdstxtRegion.Size = new System.Drawing.Size(20, 13);
            this.sdstxtRegion.TabIndex = 31;
            this.sdstxtRegion.TabStop = false;
            // 
            // sdsForaneaRegion
            // 
            this.sdsForaneaRegion.Control_Id = "sdstxtRegion";
            this.sdsForaneaRegion.DescCodi = "DescRegion";
            this.sdsForaneaRegion.ErrorText = null;
            this.sdsForaneaRegion.Location = new System.Drawing.Point(141, 248);
            this.sdsForaneaRegion.Margin = new System.Windows.Forms.Padding(2);
            this.sdsForaneaRegion.Name = "sdsForaneaRegion";
            this.sdsForaneaRegion.NomCamp = "CodeRegion";
            this.sdsForaneaRegion.NomControl = "txtIDRegion";
            this.sdsForaneaRegion.NomID = "idRegion";
            this.sdsForaneaRegion.NomTaula = "Regions";
            this.sdsForaneaRegion.Requerit = false;
            this.sdsForaneaRegion.Size = new System.Drawing.Size(345, 37);
            this.sdsForaneaRegion.TabIndex = 34;
            this.sdsForaneaRegion.TextLabel = "Region";
            // 
            // sdsTexBox2
            // 
            this.sdsTexBox2.CodeSector = null;
            this.sdsTexBox2.ColumnName = "DescSector";
            this.sdsTexBox2.DescCodi = null;
            this.sdsTexBox2.Location = new System.Drawing.Point(141, 205);
            this.sdsTexBox2.MaxLength = 50;
            this.sdsTexBox2.Name = "sdsTexBox2";
            this.sdsTexBox2.Nom = null;
            this.sdsTexBox2.NomBBDD = "SecureCore";
            this.sdsTexBox2.NomCamp = null;
            this.sdsTexBox2.NomControl = null;
            this.sdsTexBox2.NomTaula = "Sectors";
            this.sdsTexBox2.Requerit = false;
            this.sdsTexBox2.SiEsForana = false;
            this.sdsTexBox2.Size = new System.Drawing.Size(100, 20);
            this.sdsTexBox2.TabIndex = 32;
            // 
            // sdsTexBox3
            // 
            this.sdsTexBox3.CodeSector = null;
            this.sdsTexBox3.ColumnName = "CodeSector";
            this.sdsTexBox3.DescCodi = null;
            this.sdsTexBox3.Location = new System.Drawing.Point(141, 158);
            this.sdsTexBox3.MaxLength = 4;
            this.sdsTexBox3.Name = "sdsTexBox3";
            this.sdsTexBox3.Nom = null;
            this.sdsTexBox3.NomBBDD = "SecureCore";
            this.sdsTexBox3.NomCamp = null;
            this.sdsTexBox3.NomControl = null;
            this.sdsTexBox3.NomTaula = "Sectors";
            this.sdsTexBox3.Requerit = false;
            this.sdsTexBox3.SiEsForana = false;
            this.sdsTexBox3.Size = new System.Drawing.Size(100, 20);
            this.sdsTexBox3.TabIndex = 33;
            // 
            // Sectors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.DesSector);
            this.Controls.Add(this.labCodSector);
            this.Controls.Add(this.sdsForaneaRegion);
            this.Controls.Add(this.sdsTexBox2);
            this.Controls.Add(this.sdsTexBox3);
            this.Controls.Add(this.sdstxtRegion);
            this.Name = "Sectors";
            this.Text = "Sectors";
            this.Load += new System.EventHandler(this.Sectors_Load);
            this.Controls.SetChildIndex(this.LabelCodeForanea, 0);
            this.Controls.SetChildIndex(this.sdstxtRegion, 0);
            this.Controls.SetChildIndex(this.btnInsert, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.sdsTexBox3, 0);
            this.Controls.SetChildIndex(this.sdsTexBox2, 0);
            this.Controls.SetChildIndex(this.sdsForaneaRegion, 0);
            this.Controls.SetChildIndex(this.labCodSector, 0);
            this.Controls.SetChildIndex(this.DesSector, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DesSector;
        private System.Windows.Forms.Label labCodSector;
        private SdsTexBox.SdsTexBox sdstxtRegion;
        private WookieCodeControls.sdsForanea sdsForaneaRegion;
        private SdsTexBox.SdsTexBox sdsTexBox2;
        private SdsTexBox.SdsTexBox sdsTexBox3;
    }
}