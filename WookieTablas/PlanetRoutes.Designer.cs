namespace WookieTablas
{
    partial class PlanetRoutes
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
            this.idRoutes = new SdsTexBox.SdsTexBox();
            this.IdPlanet = new SdsTexBox.SdsTexBox();
            this.ForaneaIdPlanet = new WookieCodeControls.sdsForanea();
            this.ForaneaRoutes = new WookieCodeControls.sdsForanea();
            this.Planet = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(148, 453);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(70, 453);
            // 
            // LabelCodeForanea
            // 
            this.LabelCodeForanea.Size = new System.Drawing.Size(0, 13);
            this.LabelCodeForanea.Text = "";
            // 
            // idRoutes
            // 
            this.idRoutes.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.idRoutes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idRoutes.CodeSector = null;
            this.idRoutes.ColumnName = "idRoute";
            this.idRoutes.DescCodi = null;
            this.idRoutes.Enabled = false;
            this.idRoutes.Location = new System.Drawing.Point(423, 234);
            this.idRoutes.Name = "idRoutes";
            this.idRoutes.Nom = null;
            this.idRoutes.NomBBDD = "SecureCore";
            this.idRoutes.NomCamp = "";
            this.idRoutes.NomControl = "ForaneaRoutes";
            this.idRoutes.NomTaula = "Routes";
            this.idRoutes.Requerit = false;
            this.idRoutes.SiEsForana = true;
            this.idRoutes.Size = new System.Drawing.Size(40, 13);
            this.idRoutes.TabIndex = 56;
            // 
            // IdPlanet
            // 
            this.IdPlanet.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.IdPlanet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IdPlanet.CodeSector = null;
            this.IdPlanet.ColumnName = "idPlanet";
            this.IdPlanet.DescCodi = null;
            this.IdPlanet.Enabled = false;
            this.IdPlanet.Location = new System.Drawing.Point(423, 184);
            this.IdPlanet.Name = "IdPlanet";
            this.IdPlanet.Nom = null;
            this.IdPlanet.NomBBDD = "SecureCore";
            this.IdPlanet.NomCamp = null;
            this.IdPlanet.NomControl = "ForaneaIdPlanet";
            this.IdPlanet.NomTaula = "Planets";
            this.IdPlanet.Requerit = false;
            this.IdPlanet.SiEsForana = true;
            this.IdPlanet.Size = new System.Drawing.Size(40, 13);
            this.IdPlanet.TabIndex = 54;
            // 
            // ForaneaIdPlanet
            // 
            this.ForaneaIdPlanet.Control_Id = "IdPlanet";
            this.ForaneaIdPlanet.DescCodi = "DescPlanet";
            this.ForaneaIdPlanet.ErrorText = null;
            this.ForaneaIdPlanet.Location = new System.Drawing.Point(85, 181);
            this.ForaneaIdPlanet.Margin = new System.Windows.Forms.Padding(2);
            this.ForaneaIdPlanet.Name = "ForaneaIdPlanet";
            this.ForaneaIdPlanet.NomCamp = "CodePlanet";
            this.ForaneaIdPlanet.NomControl = "IdPlanet";
            this.ForaneaIdPlanet.NomID = "idPlanet";
            this.ForaneaIdPlanet.NomTaula = "Planet";
            this.ForaneaIdPlanet.Requerit = false;
            this.ForaneaIdPlanet.Size = new System.Drawing.Size(340, 34);
            this.ForaneaIdPlanet.TabIndex = 58;
            this.ForaneaIdPlanet.TextLabel = null;
            // 
            // ForaneaRoutes
            // 
            this.ForaneaRoutes.Control_Id = "idRoutes";
            this.ForaneaRoutes.DescCodi = "DescRoute";
            this.ForaneaRoutes.ErrorText = null;
            this.ForaneaRoutes.Location = new System.Drawing.Point(85, 219);
            this.ForaneaRoutes.Margin = new System.Windows.Forms.Padding(2);
            this.ForaneaRoutes.Name = "ForaneaRoutes";
            this.ForaneaRoutes.NomCamp = "CodeRoute";
            this.ForaneaRoutes.NomControl = "idRoutes";
            this.ForaneaRoutes.NomID = "idRoute";
            this.ForaneaRoutes.NomTaula = "Routes";
            this.ForaneaRoutes.Requerit = false;
            this.ForaneaRoutes.Size = new System.Drawing.Size(340, 32);
            this.ForaneaRoutes.TabIndex = 59;
            this.ForaneaRoutes.TextLabel = null;
            // 
            // Planet
            // 
            this.Planet.AutoSize = true;
            this.Planet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Planet.Location = new System.Drawing.Point(35, 188);
            this.Planet.Name = "Planet";
            this.Planet.Size = new System.Drawing.Size(37, 13);
            this.Planet.TabIndex = 60;
            this.Planet.Text = "Planet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(32, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Routes";
            // 
            // PlanetRoutes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Planet);
            this.Controls.Add(this.ForaneaRoutes);
            this.Controls.Add(this.ForaneaIdPlanet);
            this.Controls.Add(this.idRoutes);
            this.Controls.Add(this.IdPlanet);
            this.Name = "PlanetRoutes";
            this.Text = "PlanetRoutes";
            this.Load += new System.EventHandler(this.PlanetRoutes_Load);
            this.Controls.SetChildIndex(this.LabelCodeForanea, 0);
            this.Controls.SetChildIndex(this.IdPlanet, 0);
            this.Controls.SetChildIndex(this.idRoutes, 0);
            this.Controls.SetChildIndex(this.btnInsert, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.ForaneaIdPlanet, 0);
            this.Controls.SetChildIndex(this.ForaneaRoutes, 0);
            this.Controls.SetChildIndex(this.Planet, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SdsTexBox.SdsTexBox idRoutes;
        private SdsTexBox.SdsTexBox IdPlanet;
        private WookieCodeControls.sdsForanea ForaneaIdPlanet;
        private WookieCodeControls.sdsForanea ForaneaRoutes;
        private System.Windows.Forms.Label Planet;
        private System.Windows.Forms.Label label2;
    }
}