namespace WookieTablas
{
    partial class DefinedRoutes
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
            this.label7 = new System.Windows.Forms.Label();
            this.sdsTexBox7 = new SdsTexBox.SdsTexBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sdsTexBox9 = new SdsTexBox.SdsTexBox();
            this.sdsTexBox8 = new SdsTexBox.SdsTexBox();
            this.sdsForanea1 = new WookieCodeControls.sdsForanea();
            this.sdsTxtidRoute = new SdsTexBox.SdsTexBox();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(244, 388);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(166, 389);
            // 
            // LabelCodeForanea
            // 
            this.LabelCodeForanea.Location = new System.Drawing.Point(69, 236);
            this.LabelCodeForanea.Size = new System.Drawing.Size(44, 13);
            this.LabelCodeForanea.Text = "idRoute";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(57, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "RouteMap";
            // 
            // sdsTexBox7
            // 
            this.sdsTexBox7.CodeSector = null;
            this.sdsTexBox7.ColumnName = "RouteMap";
            this.sdsTexBox7.DescCodi = null;
            this.sdsTexBox7.Location = new System.Drawing.Point(119, 204);
            this.sdsTexBox7.MaxLength = 200;
            this.sdsTexBox7.Name = "sdsTexBox7";
            this.sdsTexBox7.Nom = null;
            this.sdsTexBox7.NomBBDD = "SecureCore";
            this.sdsTexBox7.NomCamp = null;
            this.sdsTexBox7.NomControl = null;
            this.sdsTexBox7.NomTaula = "DefinedRoutes";
            this.sdsTexBox7.Requerit = false;
            this.sdsTexBox7.SiEsForana = false;
            this.sdsTexBox7.Size = new System.Drawing.Size(200, 20);
            this.sdsTexBox7.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(15, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "idPlanetDestination";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(29, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "idPlanetOrigin";
            // 
            // sdsTexBox9
            // 
            this.sdsTexBox9.CodeSector = null;
            this.sdsTexBox9.ColumnName = "idPlanetOri";
            this.sdsTexBox9.DescCodi = null;
            this.sdsTexBox9.Location = new System.Drawing.Point(119, 152);
            this.sdsTexBox9.Name = "sdsTexBox9";
            this.sdsTexBox9.Nom = null;
            this.sdsTexBox9.NomBBDD = "SecureCore";
            this.sdsTexBox9.NomCamp = null;
            this.sdsTexBox9.NomControl = null;
            this.sdsTexBox9.NomTaula = "DefinedRoutes";
            this.sdsTexBox9.Requerit = false;
            this.sdsTexBox9.SiEsForana = false;
            this.sdsTexBox9.Size = new System.Drawing.Size(260, 20);
            this.sdsTexBox9.TabIndex = 35;
            // 
            // sdsTexBox8
            // 
            this.sdsTexBox8.CodeSector = null;
            this.sdsTexBox8.ColumnName = "idPlanetDest";
            this.sdsTexBox8.DescCodi = null;
            this.sdsTexBox8.Location = new System.Drawing.Point(119, 178);
            this.sdsTexBox8.Name = "sdsTexBox8";
            this.sdsTexBox8.Nom = null;
            this.sdsTexBox8.NomBBDD = "SecureCore";
            this.sdsTexBox8.NomCamp = null;
            this.sdsTexBox8.NomControl = null;
            this.sdsTexBox8.NomTaula = "DefinedRoutes";
            this.sdsTexBox8.Requerit = false;
            this.sdsTexBox8.SiEsForana = false;
            this.sdsTexBox8.Size = new System.Drawing.Size(100, 20);
            this.sdsTexBox8.TabIndex = 37;
            // 
            // sdsForanea1
            // 
            this.sdsForanea1.Control_Id = "sdsTxtidRoute";
            this.sdsForanea1.DescCodi = "DescRoute";
            this.sdsForanea1.ErrorText = null;
            this.sdsForanea1.Location = new System.Drawing.Point(119, 226);
            this.sdsForanea1.Margin = new System.Windows.Forms.Padding(2);
            this.sdsForanea1.Name = "sdsForanea1";
            this.sdsForanea1.NomCamp = "CodeRoute";
            this.sdsForanea1.NomControl = "sdsTxtidRoute";
            this.sdsForanea1.NomID = "idRoute";
            this.sdsForanea1.NomTaula = "Routes";
            this.sdsForanea1.Requerit = false;
            this.sdsForanea1.Size = new System.Drawing.Size(391, 46);
            this.sdsForanea1.TabIndex = 41;
            this.sdsForanea1.TextLabel = "idRoute";
            // 
            // sdsTxtidRoute
            // 
            this.sdsTxtidRoute.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.sdsTxtidRoute.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sdsTxtidRoute.CodeSector = null;
            this.sdsTxtidRoute.ColumnName = "idRoute";
            this.sdsTxtidRoute.DescCodi = null;
            this.sdsTxtidRoute.Enabled = false;
            this.sdsTxtidRoute.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.sdsTxtidRoute.Location = new System.Drawing.Point(119, 277);
            this.sdsTxtidRoute.Name = "sdsTxtidRoute";
            this.sdsTxtidRoute.Nom = null;
            this.sdsTxtidRoute.NomBBDD = "SecureCore";
            this.sdsTxtidRoute.NomCamp = "";
            this.sdsTxtidRoute.NomControl = "sdsForanea1";
            this.sdsTxtidRoute.NomTaula = "Routes";
            this.sdsTxtidRoute.ReadOnly = true;
            this.sdsTxtidRoute.Requerit = false;
            this.sdsTxtidRoute.SiEsForana = true;
            this.sdsTxtidRoute.Size = new System.Drawing.Size(30, 13);
            this.sdsTxtidRoute.TabIndex = 0;
            this.sdsTxtidRoute.TabStop = false;
            // 
            // DefinedRoutes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 564);
            this.Controls.Add(this.sdsForanea1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sdsTexBox7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sdsTexBox8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sdsTexBox9);
            this.Controls.Add(this.sdsTxtidRoute);
            this.Name = "DefinedRoutes";
            this.Text = "DefinedRoutes";
            this.Load += new System.EventHandler(this.DefinedRoutes_Load);
            this.Controls.SetChildIndex(this.LabelCodeForanea, 0);
            this.Controls.SetChildIndex(this.sdsTxtidRoute, 0);
            this.Controls.SetChildIndex(this.sdsTexBox9, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.sdsTexBox8, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.sdsTexBox7, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.btnInsert, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.sdsForanea1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private SdsTexBox.SdsTexBox sdsTexBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private SdsTexBox.SdsTexBox sdsTexBox9;
        private SdsTexBox.SdsTexBox sdsTexBox8;
        private WookieCodeControls.sdsForanea sdsForanea1;
        private SdsTexBox.SdsTexBox sdsTxtidRoute;
    }
}