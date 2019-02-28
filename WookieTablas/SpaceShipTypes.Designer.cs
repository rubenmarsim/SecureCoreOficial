namespace WookieTablas
{
    partial class SpaceShipTypes
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
            this.sdstxtCodeSector = new SdsTexBox.SdsTexBox();
            this.sdstxtDescSpaceShipType = new SdsTexBox.SdsTexBox();
            this.labCodeSpaceShipType = new System.Windows.Forms.Label();
            this.labDescSpaceShipType = new System.Windows.Forms.Label();
            this.sdsForaneaSpaceShipCategory = new WookieCodeControls.sdsForanea();
            this.sdstxtFiliation = new SdsTexBox.SdsTexBox();
            this.sdsForaneaFiliation = new WookieCodeControls.sdsForanea();
            this.sdstxtSpaceShipCategories = new SdsTexBox.SdsTexBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdate.Location = new System.Drawing.Point(139, 417);
            // 
            // btnInsert
            // 
            this.btnInsert.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInsert.Location = new System.Drawing.Point(47, 417);
            // 
            // LabelCodeForanea
            // 
            this.LabelCodeForanea.Location = new System.Drawing.Point(92, 282);
            this.LabelCodeForanea.Size = new System.Drawing.Size(51, 13);
            this.LabelCodeForanea.Text = "IdFiliation";
            // 
            // sdstxtCodeSector
            // 
            this.sdstxtCodeSector.CodeSector = null;
            this.sdstxtCodeSector.ColumnName = "CodeSpaceShipType";
            this.sdstxtCodeSector.DescCodi = null;
            this.sdstxtCodeSector.Location = new System.Drawing.Point(149, 181);
            this.sdstxtCodeSector.MaxLength = 4;
            this.sdstxtCodeSector.Name = "sdstxtCodeSector";
            this.sdstxtCodeSector.Nom = null;
            this.sdstxtCodeSector.NomBBDD = "SecureCore";
            this.sdstxtCodeSector.NomCamp = null;
            this.sdstxtCodeSector.NomControl = null;
            this.sdstxtCodeSector.NomTaula = "SpaceShipTypes";
            this.sdstxtCodeSector.Requerit = false;
            this.sdstxtCodeSector.SiEsForana = false;
            this.sdstxtCodeSector.Size = new System.Drawing.Size(100, 20);
            this.sdstxtCodeSector.TabIndex = 33;
            // 
            // sdstxtDescSpaceShipType
            // 
            this.sdstxtDescSpaceShipType.CodeSector = null;
            this.sdstxtDescSpaceShipType.ColumnName = "DescSpaceShipType";
            this.sdstxtDescSpaceShipType.DescCodi = null;
            this.sdstxtDescSpaceShipType.Location = new System.Drawing.Point(149, 225);
            this.sdstxtDescSpaceShipType.MaxLength = 200;
            this.sdstxtDescSpaceShipType.Name = "sdstxtDescSpaceShipType";
            this.sdstxtDescSpaceShipType.Nom = null;
            this.sdstxtDescSpaceShipType.NomBBDD = "SecureCore";
            this.sdstxtDescSpaceShipType.NomCamp = null;
            this.sdstxtDescSpaceShipType.NomControl = null;
            this.sdstxtDescSpaceShipType.NomTaula = "SpaceShipTypes";
            this.sdstxtDescSpaceShipType.Requerit = false;
            this.sdstxtDescSpaceShipType.SiEsForana = false;
            this.sdstxtDescSpaceShipType.Size = new System.Drawing.Size(100, 20);
            this.sdstxtDescSpaceShipType.TabIndex = 32;
            // 
            // labCodeSpaceShipType
            // 
            this.labCodeSpaceShipType.AutoSize = true;
            this.labCodeSpaceShipType.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labCodeSpaceShipType.Location = new System.Drawing.Point(35, 184);
            this.labCodeSpaceShipType.Name = "labCodeSpaceShipType";
            this.labCodeSpaceShipType.Size = new System.Drawing.Size(108, 13);
            this.labCodeSpaceShipType.TabIndex = 35;
            this.labCodeSpaceShipType.Text = "CodeSpaceShipType";
            // 
            // labDescSpaceShipType
            // 
            this.labDescSpaceShipType.AutoSize = true;
            this.labDescSpaceShipType.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labDescSpaceShipType.Location = new System.Drawing.Point(35, 225);
            this.labDescSpaceShipType.Name = "labDescSpaceShipType";
            this.labDescSpaceShipType.Size = new System.Drawing.Size(108, 13);
            this.labDescSpaceShipType.TabIndex = 36;
            this.labDescSpaceShipType.Text = "DescSpaceShipType";
            // 
            // sdsForaneaSpaceShipCategory
            // 
            this.sdsForaneaSpaceShipCategory.Control_Id = "sdsForaneaSpaceShipCategory";
            this.sdsForaneaSpaceShipCategory.DescCodi = "DescSpaceShipCategory";
            this.sdsForaneaSpaceShipCategory.ErrorText = null;
            this.sdsForaneaSpaceShipCategory.Location = new System.Drawing.Point(149, 314);
            this.sdsForaneaSpaceShipCategory.Margin = new System.Windows.Forms.Padding(2);
            this.sdsForaneaSpaceShipCategory.Name = "sdsForaneaSpaceShipCategory";
            this.sdsForaneaSpaceShipCategory.NomCamp = "CodeSpaceShipCategory";
            this.sdsForaneaSpaceShipCategory.NomControl = "sdsForaneaSpaceShipCategory";
            this.sdsForaneaSpaceShipCategory.NomID = "idSpaceShipCategory";
            this.sdsForaneaSpaceShipCategory.NomTaula = "SpaceShipCategories";
            this.sdsForaneaSpaceShipCategory.Requerit = false;
            this.sdsForaneaSpaceShipCategory.Size = new System.Drawing.Size(339, 34);
            this.sdsForaneaSpaceShipCategory.TabIndex = 44;
            this.sdsForaneaSpaceShipCategory.TextLabel = "SpaceShipCategory";
            // 
            // sdstxtFiliation
            // 
            this.sdstxtFiliation.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.sdstxtFiliation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sdstxtFiliation.CodeSector = null;
            this.sdstxtFiliation.ColumnName = "idFiliation";
            this.sdstxtFiliation.DescCodi = null;
            this.sdstxtFiliation.Location = new System.Drawing.Point(327, 234);
            this.sdstxtFiliation.Name = "sdstxtFiliation";
            this.sdstxtFiliation.Nom = null;
            this.sdstxtFiliation.NomBBDD = "SecureCore";
            this.sdstxtFiliation.NomCamp = "idFiliation";
            this.sdstxtFiliation.NomControl = "sdsForaneaFiliation";
            this.sdstxtFiliation.NomTaula = "SpaceShipType";
            this.sdstxtFiliation.Requerit = false;
            this.sdstxtFiliation.SiEsForana = true;
            this.sdstxtFiliation.Size = new System.Drawing.Size(20, 13);
            this.sdstxtFiliation.TabIndex = 31;
            // 
            // sdsForaneaFiliation
            // 
            this.sdsForaneaFiliation.Control_Id = "sdsForaneaFiliation";
            this.sdsForaneaFiliation.DescCodi = "DescFiliation";
            this.sdsForaneaFiliation.ErrorText = null;
            this.sdsForaneaFiliation.Location = new System.Drawing.Point(149, 272);
            this.sdsForaneaFiliation.Margin = new System.Windows.Forms.Padding(2);
            this.sdsForaneaFiliation.Name = "sdsForaneaFiliation";
            this.sdsForaneaFiliation.NomCamp = "CodeFiliation";
            this.sdsForaneaFiliation.NomControl = "sdsForaneaFiliation";
            this.sdsForaneaFiliation.NomID = "idFiliation";
            this.sdsForaneaFiliation.NomTaula = "Filiations";
            this.sdsForaneaFiliation.Requerit = false;
            this.sdsForaneaFiliation.Size = new System.Drawing.Size(336, 38);
            this.sdsForaneaFiliation.TabIndex = 34;
            this.sdsForaneaFiliation.TextLabel = "Filiations";
            // 
            // sdstxtSpaceShipCategories
            // 
            this.sdstxtSpaceShipCategories.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.sdstxtSpaceShipCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sdstxtSpaceShipCategories.CodeSector = null;
            this.sdstxtSpaceShipCategories.ColumnName = "idSpaceShipCategory";
            this.sdstxtSpaceShipCategories.DescCodi = null;
            this.sdstxtSpaceShipCategories.Location = new System.Drawing.Point(609, 234);
            this.sdstxtSpaceShipCategories.Name = "sdstxtSpaceShipCategories";
            this.sdstxtSpaceShipCategories.Nom = null;
            this.sdstxtSpaceShipCategories.NomBBDD = "SecureCore";
            this.sdstxtSpaceShipCategories.NomCamp = "idSpaceShipCategory";
            this.sdstxtSpaceShipCategories.NomControl = "sdsForaneaSpaceShipCategory";
            this.sdstxtSpaceShipCategories.NomTaula = "SpaceShipCategory";
            this.sdstxtSpaceShipCategories.Requerit = false;
            this.sdstxtSpaceShipCategories.SiEsForana = true;
            this.sdstxtSpaceShipCategories.Size = new System.Drawing.Size(20, 13);
            this.sdstxtSpaceShipCategories.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(35, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "IdSpaceShipCategory";
            // 
            // SpaceShipTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(891, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sdstxtSpaceShipCategories);
            this.Controls.Add(this.sdsForaneaSpaceShipCategory);
            this.Controls.Add(this.labDescSpaceShipType);
            this.Controls.Add(this.labCodeSpaceShipType);
            this.Controls.Add(this.sdstxtFiliation);
            this.Controls.Add(this.sdsForaneaFiliation);
            this.Controls.Add(this.sdstxtDescSpaceShipType);
            this.Controls.Add(this.sdstxtCodeSector);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "SpaceShipTypes";
            this.Text = "SpaceShipTypes";
            this.Load += new System.EventHandler(this.SpaceShipTypes_Load);
            this.Controls.SetChildIndex(this.sdstxtCodeSector, 0);
            this.Controls.SetChildIndex(this.sdstxtDescSpaceShipType, 0);
            this.Controls.SetChildIndex(this.sdsForaneaFiliation, 0);
            this.Controls.SetChildIndex(this.sdstxtFiliation, 0);
            this.Controls.SetChildIndex(this.labCodeSpaceShipType, 0);
            this.Controls.SetChildIndex(this.labDescSpaceShipType, 0);
            this.Controls.SetChildIndex(this.sdsForaneaSpaceShipCategory, 0);
            this.Controls.SetChildIndex(this.sdstxtSpaceShipCategories, 0);
            this.Controls.SetChildIndex(this.LabelCodeForanea, 0);
            this.Controls.SetChildIndex(this.btnInsert, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SdsTexBox.SdsTexBox sdstxtCodeSector;
        private SdsTexBox.SdsTexBox sdstxtDescSpaceShipType;
        private System.Windows.Forms.Label labCodeSpaceShipType;
        private System.Windows.Forms.Label labDescSpaceShipType;
        private WookieCodeControls.sdsForanea sdsForaneaSpaceShipCategory;
        private SdsTexBox.SdsTexBox sdstxtFiliation;
        private WookieCodeControls.sdsForanea sdsForaneaFiliation;
        private SdsTexBox.SdsTexBox sdstxtSpaceShipCategories;
        private System.Windows.Forms.Label label1;
    }
}