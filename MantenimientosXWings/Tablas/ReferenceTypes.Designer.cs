namespace MantenimientosXWings
{
    partial class ReferenceTypes
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
            this.sdsTexBoxcodeReference = new SdsTexBox.SdsTexBox();
            this.sdsTexBoxdescReference = new SdsTexBox.SdsTexBox();
            this.lblcodeReference = new System.Windows.Forms.Label();
            this.lbldescReference = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVReferenceTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVReferenceTypes
            // 
            this.dGVReferenceTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVReferenceTypes.Location = new System.Drawing.Point(12, 12);
            this.dGVReferenceTypes.Name = "dGVReferenceTypes";
            this.dGVReferenceTypes.Size = new System.Drawing.Size(464, 352);
            this.dGVReferenceTypes.TabIndex = 0;
            // 
            // sdsTexBoxcodeReference
            // 
            this.sdsTexBoxcodeReference.CodeSector = null;
            this.sdsTexBoxcodeReference.ColumnName = "codeReferenceType";
            this.sdsTexBoxcodeReference.DescCodi = null;
            this.sdsTexBoxcodeReference.Location = new System.Drawing.Point(629, 160);
            this.sdsTexBoxcodeReference.Name = "sdsTexBoxcodeReference";
            this.sdsTexBoxcodeReference.Nom = null;
            this.sdsTexBoxcodeReference.NomBBDD = "XWingsFactory";
            this.sdsTexBoxcodeReference.NomCamp = "codeReferenceType";
            this.sdsTexBoxcodeReference.NomControl = null;
            this.sdsTexBoxcodeReference.NomTaula = "ReferenceTypes";
            this.sdsTexBoxcodeReference.Requerit = false;
            this.sdsTexBoxcodeReference.SiEsForana = false;
            this.sdsTexBoxcodeReference.Size = new System.Drawing.Size(142, 20);
            this.sdsTexBoxcodeReference.TabIndex = 1;
            // 
            // sdsTexBoxdescReference
            // 
            this.sdsTexBoxdescReference.CodeSector = null;
            this.sdsTexBoxdescReference.ColumnName = "descReferenceType";
            this.sdsTexBoxdescReference.DescCodi = null;
            this.sdsTexBoxdescReference.Location = new System.Drawing.Point(629, 204);
            this.sdsTexBoxdescReference.Name = "sdsTexBoxdescReference";
            this.sdsTexBoxdescReference.Nom = null;
            this.sdsTexBoxdescReference.NomBBDD = "XWingsFactory";
            this.sdsTexBoxdescReference.NomCamp = "descReferenceType";
            this.sdsTexBoxdescReference.NomControl = null;
            this.sdsTexBoxdescReference.NomTaula = "ReferenceTypes";
            this.sdsTexBoxdescReference.Requerit = false;
            this.sdsTexBoxdescReference.SiEsForana = false;
            this.sdsTexBoxdescReference.Size = new System.Drawing.Size(142, 20);
            this.sdsTexBoxdescReference.TabIndex = 2;
            // 
            // lblcodeReference
            // 
            this.lblcodeReference.AutoSize = true;
            this.lblcodeReference.Location = new System.Drawing.Point(511, 160);
            this.lblcodeReference.Name = "lblcodeReference";
            this.lblcodeReference.Size = new System.Drawing.Size(81, 13);
            this.lblcodeReference.TabIndex = 3;
            this.lblcodeReference.Text = "codeReference";
            // 
            // lbldescReference
            // 
            this.lbldescReference.AutoSize = true;
            this.lbldescReference.Location = new System.Drawing.Point(511, 204);
            this.lbldescReference.Name = "lbldescReference";
            this.lbldescReference.Size = new System.Drawing.Size(80, 13);
            this.lbldescReference.TabIndex = 4;
            this.lbldescReference.Text = "descReference";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(538, 299);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(648, 299);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // ReferenceTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lbldescReference);
            this.Controls.Add(this.lblcodeReference);
            this.Controls.Add(this.sdsTexBoxdescReference);
            this.Controls.Add(this.sdsTexBoxcodeReference);
            this.Controls.Add(this.dGVReferenceTypes);
            this.Name = "ReferenceTypes";
            this.Text = "ReferenceTypes";
            this.Load += new System.EventHandler(this.ReferenceTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVReferenceTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVReferenceTypes;
        private SdsTexBox.SdsTexBox sdsTexBoxcodeReference;
        private SdsTexBox.SdsTexBox sdsTexBoxdescReference;
        private System.Windows.Forms.Label lblcodeReference;
        private System.Windows.Forms.Label lbldescReference;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
    }
}