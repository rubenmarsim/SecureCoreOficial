namespace WookieTablas
{
    partial class RouteTypes
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
            this.sdsTexBoxCodeRouteType = new SdsTexBox.SdsTexBox();
            this.sdsTexBoxDescRouteType = new SdsTexBox.SdsTexBox();
            this.lblCodeRouteType = new System.Windows.Forms.Label();
            this.lblDescRouteType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelCodeForanea
            // 
            this.LabelCodeForanea.Size = new System.Drawing.Size(0, 13);
            this.LabelCodeForanea.Text = "";
            // 
            // sdsTexBoxCodeRouteType
            // 
            this.sdsTexBoxCodeRouteType.CodeSector = null;
            this.sdsTexBoxCodeRouteType.ColumnName = "CodeRouteType";
            this.sdsTexBoxCodeRouteType.DescCodi = null;
            this.sdsTexBoxCodeRouteType.Location = new System.Drawing.Point(131, 201);
            this.sdsTexBoxCodeRouteType.MaxLength = 5;
            this.sdsTexBoxCodeRouteType.Name = "sdsTexBoxCodeRouteType";
            this.sdsTexBoxCodeRouteType.Nom = null;
            this.sdsTexBoxCodeRouteType.NomBBDD = "SecureCore";
            this.sdsTexBoxCodeRouteType.NomCamp = null;
            this.sdsTexBoxCodeRouteType.NomControl = null;
            this.sdsTexBoxCodeRouteType.NomTaula = null;
            this.sdsTexBoxCodeRouteType.Requerit = false;
            this.sdsTexBoxCodeRouteType.SiEsForana = false;
            this.sdsTexBoxCodeRouteType.Size = new System.Drawing.Size(100, 20);
            this.sdsTexBoxCodeRouteType.TabIndex = 24;
            // 
            // sdsTexBoxDescRouteType
            // 
            this.sdsTexBoxDescRouteType.CodeSector = null;
            this.sdsTexBoxDescRouteType.ColumnName = "DescRouteType";
            this.sdsTexBoxDescRouteType.DescCodi = null;
            this.sdsTexBoxDescRouteType.Location = new System.Drawing.Point(131, 258);
            this.sdsTexBoxDescRouteType.MaxLength = 50;
            this.sdsTexBoxDescRouteType.Name = "sdsTexBoxDescRouteType";
            this.sdsTexBoxDescRouteType.Nom = null;
            this.sdsTexBoxDescRouteType.NomBBDD = "SecureCore";
            this.sdsTexBoxDescRouteType.NomCamp = null;
            this.sdsTexBoxDescRouteType.NomControl = null;
            this.sdsTexBoxDescRouteType.NomTaula = null;
            this.sdsTexBoxDescRouteType.Requerit = false;
            this.sdsTexBoxDescRouteType.SiEsForana = false;
            this.sdsTexBoxDescRouteType.Size = new System.Drawing.Size(100, 20);
            this.sdsTexBoxDescRouteType.TabIndex = 25;
            // 
            // lblCodeRouteType
            // 
            this.lblCodeRouteType.AutoSize = true;
            this.lblCodeRouteType.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCodeRouteType.Location = new System.Drawing.Point(12, 201);
            this.lblCodeRouteType.Name = "lblCodeRouteType";
            this.lblCodeRouteType.Size = new System.Drawing.Size(94, 13);
            this.lblCodeRouteType.TabIndex = 26;
            this.lblCodeRouteType.Text = "Code Route Type:";
            // 
            // lblDescRouteType
            // 
            this.lblDescRouteType.AutoSize = true;
            this.lblDescRouteType.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDescRouteType.Location = new System.Drawing.Point(12, 258);
            this.lblDescRouteType.Name = "lblDescRouteType";
            this.lblDescRouteType.Size = new System.Drawing.Size(94, 13);
            this.lblDescRouteType.TabIndex = 27;
            this.lblDescRouteType.Text = "Desc Route Type:";
            // 
            // RouteTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 595);
            this.Controls.Add(this.lblDescRouteType);
            this.Controls.Add(this.lblCodeRouteType);
            this.Controls.Add(this.sdsTexBoxDescRouteType);
            this.Controls.Add(this.sdsTexBoxCodeRouteType);
            this.Name = "RouteTypes";
            this.Text = "RouteTypes";
            this.Load += new System.EventHandler(this.RouteTypes_Load);
            this.Controls.SetChildIndex(this.LabelCodeForanea, 0);
            this.Controls.SetChildIndex(this.btnInsert, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.sdsTexBoxCodeRouteType, 0);
            this.Controls.SetChildIndex(this.sdsTexBoxDescRouteType, 0);
            this.Controls.SetChildIndex(this.lblCodeRouteType, 0);
            this.Controls.SetChildIndex(this.lblDescRouteType, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SdsTexBox.SdsTexBox sdsTexBoxCodeRouteType;
        private SdsTexBox.SdsTexBox sdsTexBoxDescRouteType;
        private System.Windows.Forms.Label lblCodeRouteType;
        private System.Windows.Forms.Label lblDescRouteType;
    }
}