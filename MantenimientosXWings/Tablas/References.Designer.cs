namespace MantenimientosXWings.Tablas
{
    partial class References
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
            this.dGVReferences = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.labcodeReference = new System.Windows.Forms.Label();
            this.labdescReference = new System.Windows.Forms.Label();
            this.labphoto = new System.Windows.Forms.Label();
            this.labvideo = new System.Windows.Forms.Label();
            this.labidReferenceType = new System.Windows.Forms.Label();
            this.cmbBoxIdReferenceType = new System.Windows.Forms.ComboBox();
            this.sdstxtvideo = new SdsTexBox.SdsTexBox();
            this.sdstxtphoto = new SdsTexBox.SdsTexBox();
            this.sdstxtdescReference = new SdsTexBox.SdsTexBox();
            this.sdstxtcodeReference = new SdsTexBox.SdsTexBox();
            this.sdstxBoxIdReferenceType = new SdsTexBox.SdsTexBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVReferences)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVReferences
            // 
            this.dGVReferences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVReferences.Location = new System.Drawing.Point(12, 12);
            this.dGVReferences.Name = "dGVReferences";
            this.dGVReferences.Size = new System.Drawing.Size(464, 352);
            this.dGVReferences.TabIndex = 0;
            this.dGVReferences.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVReferences_CellClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(530, 265);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(642, 265);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // labcodeReference
            // 
            this.labcodeReference.AutoSize = true;
            this.labcodeReference.Location = new System.Drawing.Point(482, 55);
            this.labcodeReference.Name = "labcodeReference";
            this.labcodeReference.Size = new System.Drawing.Size(82, 13);
            this.labcodeReference.TabIndex = 5;
            this.labcodeReference.Text = "CodeReference";
            // 
            // labdescReference
            // 
            this.labdescReference.AutoSize = true;
            this.labdescReference.Location = new System.Drawing.Point(482, 81);
            this.labdescReference.Name = "labdescReference";
            this.labdescReference.Size = new System.Drawing.Size(82, 13);
            this.labdescReference.TabIndex = 6;
            this.labdescReference.Text = "DescReference";
            // 
            // labphoto
            // 
            this.labphoto.AutoSize = true;
            this.labphoto.Location = new System.Drawing.Point(482, 104);
            this.labphoto.Name = "labphoto";
            this.labphoto.Size = new System.Drawing.Size(35, 13);
            this.labphoto.TabIndex = 10;
            this.labphoto.Text = "Photo";
            // 
            // labvideo
            // 
            this.labvideo.AutoSize = true;
            this.labvideo.Location = new System.Drawing.Point(482, 133);
            this.labvideo.Name = "labvideo";
            this.labvideo.Size = new System.Drawing.Size(34, 13);
            this.labvideo.TabIndex = 11;
            this.labvideo.Text = "Video";
            this.labvideo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labidReferenceType
            // 
            this.labidReferenceType.AutoSize = true;
            this.labidReferenceType.Location = new System.Drawing.Point(478, 164);
            this.labidReferenceType.Name = "labidReferenceType";
            this.labidReferenceType.Size = new System.Drawing.Size(90, 13);
            this.labidReferenceType.TabIndex = 13;
            this.labidReferenceType.Text = "IdReferenceType";
            // 
            // cmbBoxIdReferenceType
            // 
            this.cmbBoxIdReferenceType.FormattingEnabled = true;
            this.cmbBoxIdReferenceType.Location = new System.Drawing.Point(565, 161);
            this.cmbBoxIdReferenceType.Name = "cmbBoxIdReferenceType";
            this.cmbBoxIdReferenceType.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxIdReferenceType.TabIndex = 14;
            this.cmbBoxIdReferenceType.SelectedValueChanged += new System.EventHandler(this.cmbBoxIdReferenceType_SelectedValueChanged);
            // 
            // sdstxtvideo
            // 
            this.sdstxtvideo.CodeSector = null;
            this.sdstxtvideo.ColumnName = "VideoExplode";
            this.sdstxtvideo.DescCodi = null;
            this.sdstxtvideo.Location = new System.Drawing.Point(565, 130);
            this.sdstxtvideo.Name = "sdstxtvideo";
            this.sdstxtvideo.Nom = null;
            this.sdstxtvideo.NomBBDD = "XWingsFactory";
            this.sdstxtvideo.NomCamp = "";
            this.sdstxtvideo.NomControl = null;
            this.sdstxtvideo.NomTaula = "References";
            this.sdstxtvideo.Requerit = false;
            this.sdstxtvideo.SiEsForana = false;
            this.sdstxtvideo.Size = new System.Drawing.Size(100, 20);
            this.sdstxtvideo.TabIndex = 9;
            // 
            // sdstxtphoto
            // 
            this.sdstxtphoto.CodeSector = null;
            this.sdstxtphoto.ColumnName = "Photo";
            this.sdstxtphoto.DescCodi = null;
            this.sdstxtphoto.Location = new System.Drawing.Point(565, 104);
            this.sdstxtphoto.Name = "sdstxtphoto";
            this.sdstxtphoto.Nom = null;
            this.sdstxtphoto.NomBBDD = "XWingsFactory";
            this.sdstxtphoto.NomCamp = "";
            this.sdstxtphoto.NomControl = null;
            this.sdstxtphoto.NomTaula = "References";
            this.sdstxtphoto.Requerit = false;
            this.sdstxtphoto.SiEsForana = false;
            this.sdstxtphoto.Size = new System.Drawing.Size(100, 20);
            this.sdstxtphoto.TabIndex = 8;
            // 
            // sdstxtdescReference
            // 
            this.sdstxtdescReference.CodeSector = null;
            this.sdstxtdescReference.ColumnName = "descReference";
            this.sdstxtdescReference.DescCodi = null;
            this.sdstxtdescReference.Location = new System.Drawing.Point(565, 78);
            this.sdstxtdescReference.Name = "sdstxtdescReference";
            this.sdstxtdescReference.Nom = null;
            this.sdstxtdescReference.NomBBDD = "XWingsFactory";
            this.sdstxtdescReference.NomCamp = "";
            this.sdstxtdescReference.NomControl = null;
            this.sdstxtdescReference.NomTaula = "References";
            this.sdstxtdescReference.Requerit = false;
            this.sdstxtdescReference.SiEsForana = false;
            this.sdstxtdescReference.Size = new System.Drawing.Size(100, 20);
            this.sdstxtdescReference.TabIndex = 4;
            // 
            // sdstxtcodeReference
            // 
            this.sdstxtcodeReference.CodeSector = null;
            this.sdstxtcodeReference.ColumnName = "codeReference";
            this.sdstxtcodeReference.DescCodi = null;
            this.sdstxtcodeReference.Location = new System.Drawing.Point(565, 52);
            this.sdstxtcodeReference.Name = "sdstxtcodeReference";
            this.sdstxtcodeReference.Nom = null;
            this.sdstxtcodeReference.NomBBDD = "XWingsFactory";
            this.sdstxtcodeReference.NomCamp = "";
            this.sdstxtcodeReference.NomControl = "References";
            this.sdstxtcodeReference.NomTaula = null;
            this.sdstxtcodeReference.Requerit = false;
            this.sdstxtcodeReference.SiEsForana = false;
            this.sdstxtcodeReference.Size = new System.Drawing.Size(100, 20);
            this.sdstxtcodeReference.TabIndex = 3;
            // 
            // sdstxBoxIdReferenceType
            // 
            this.sdstxBoxIdReferenceType.CodeSector = null;
            this.sdstxBoxIdReferenceType.ColumnName = "idReferenceType";
            this.sdstxBoxIdReferenceType.DescCodi = null;
            this.sdstxBoxIdReferenceType.Location = new System.Drawing.Point(638, 344);
            this.sdstxBoxIdReferenceType.Name = "sdstxBoxIdReferenceType";
            this.sdstxBoxIdReferenceType.Nom = null;
            this.sdstxBoxIdReferenceType.NomBBDD = "XWingsFactory";
            this.sdstxBoxIdReferenceType.NomCamp = null;
            this.sdstxBoxIdReferenceType.NomControl = null;
            this.sdstxBoxIdReferenceType.NomTaula = "References";
            this.sdstxBoxIdReferenceType.Requerit = false;
            this.sdstxBoxIdReferenceType.SiEsForana = false;
            this.sdstxBoxIdReferenceType.Size = new System.Drawing.Size(38, 20);
            this.sdstxBoxIdReferenceType.TabIndex = 15;
            // 
            // References
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 536);
            this.Controls.Add(this.cmbBoxIdReferenceType);
            this.Controls.Add(this.labidReferenceType);
            this.Controls.Add(this.labvideo);
            this.Controls.Add(this.labphoto);
            this.Controls.Add(this.sdstxtvideo);
            this.Controls.Add(this.sdstxtphoto);
            this.Controls.Add(this.labdescReference);
            this.Controls.Add(this.labcodeReference);
            this.Controls.Add(this.sdstxtdescReference);
            this.Controls.Add(this.sdstxtcodeReference);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dGVReferences);
            this.Controls.Add(this.sdstxBoxIdReferenceType);
            this.Name = "References";
            this.Text = "References";
            this.Load += new System.EventHandler(this.References_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVReferences)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVReferences;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private SdsTexBox.SdsTexBox sdstxtcodeReference;
        private SdsTexBox.SdsTexBox sdstxtdescReference;
        private System.Windows.Forms.Label labcodeReference;
        private System.Windows.Forms.Label labdescReference;
        private SdsTexBox.SdsTexBox sdstxtphoto;
        private SdsTexBox.SdsTexBox sdstxtvideo;
        private System.Windows.Forms.Label labphoto;
        private System.Windows.Forms.Label labvideo;
        private System.Windows.Forms.Label labidReferenceType;
        private System.Windows.Forms.ComboBox cmbBoxIdReferenceType;
        private SdsTexBox.SdsTexBox sdstxBoxIdReferenceType;
    }
}