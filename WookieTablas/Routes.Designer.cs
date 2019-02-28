namespace WookieTablas
{
    partial class Routes
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
            this.sdsTextBoxCodeRoute = new SdsTexBox.SdsTexBox();
            this.sdsTextBoxDescRoute = new SdsTexBox.SdsTexBox();
            this.sdsTextBoxRouteTypes = new SdsTexBox.SdsTexBox();
            this.sdsForaneaRouteTypes = new WookieCodeControls.sdsForanea();
            this.lblCodeRoute = new System.Windows.Forms.Label();
            this.lblDescRoute = new System.Windows.Forms.Label();
            this.sdsForaneaDefinedRoutes = new WookieCodeControls.sdsForanea();
            this.sdsTextBoxDefinedRoute = new SdsTexBox.SdsTexBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(160, 464);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(70, 464);
            // 
            // LabelCodeForanea
            // 
            this.LabelCodeForanea.Location = new System.Drawing.Point(54, 281);
            this.LabelCodeForanea.Size = new System.Drawing.Size(72, 13);
            this.LabelCodeForanea.Text = "IdRouteType:";
            // 
            // sdsTextBoxCodeRoute
            // 
            this.sdsTextBoxCodeRoute.CodeSector = null;
            this.sdsTextBoxCodeRoute.ColumnName = "CodeRoute";
            this.sdsTextBoxCodeRoute.DescCodi = null;
            this.sdsTextBoxCodeRoute.Location = new System.Drawing.Point(141, 179);
            this.sdsTextBoxCodeRoute.MaxLength = 8;
            this.sdsTextBoxCodeRoute.Name = "sdsTextBoxCodeRoute";
            this.sdsTextBoxCodeRoute.Nom = null;
            this.sdsTextBoxCodeRoute.NomBBDD = "SecureCore";
            this.sdsTextBoxCodeRoute.NomCamp = null;
            this.sdsTextBoxCodeRoute.NomControl = null;
            this.sdsTextBoxCodeRoute.NomTaula = "Routes";
            this.sdsTextBoxCodeRoute.Requerit = false;
            this.sdsTextBoxCodeRoute.SiEsForana = false;
            this.sdsTextBoxCodeRoute.Size = new System.Drawing.Size(100, 20);
            this.sdsTextBoxCodeRoute.TabIndex = 0;
            // 
            // sdsTextBoxDescRoute
            // 
            this.sdsTextBoxDescRoute.CodeSector = null;
            this.sdsTextBoxDescRoute.ColumnName = "DescRoute";
            this.sdsTextBoxDescRoute.DescCodi = null;
            this.sdsTextBoxDescRoute.Location = new System.Drawing.Point(141, 226);
            this.sdsTextBoxDescRoute.MaxLength = 50;
            this.sdsTextBoxDescRoute.Name = "sdsTextBoxDescRoute";
            this.sdsTextBoxDescRoute.Nom = null;
            this.sdsTextBoxDescRoute.NomBBDD = "SecureCore";
            this.sdsTextBoxDescRoute.NomCamp = null;
            this.sdsTextBoxDescRoute.NomControl = null;
            this.sdsTextBoxDescRoute.NomTaula = "Routes";
            this.sdsTextBoxDescRoute.Requerit = false;
            this.sdsTextBoxDescRoute.SiEsForana = false;
            this.sdsTextBoxDescRoute.Size = new System.Drawing.Size(100, 20);
            this.sdsTextBoxDescRoute.TabIndex = 0;
            // 
            // sdsTextBoxRouteTypes
            // 
            this.sdsTextBoxRouteTypes.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.sdsTextBoxRouteTypes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sdsTextBoxRouteTypes.CodeSector = null;
            this.sdsTextBoxRouteTypes.ColumnName = "idRouteType";
            this.sdsTextBoxRouteTypes.DescCodi = null;
            this.sdsTextBoxRouteTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdsTextBoxRouteTypes.ForeColor = System.Drawing.Color.Transparent;
            this.sdsTextBoxRouteTypes.Location = new System.Drawing.Point(595, 226);
            this.sdsTextBoxRouteTypes.Name = "sdsTextBoxRouteTypes";
            this.sdsTextBoxRouteTypes.Nom = null;
            this.sdsTextBoxRouteTypes.NomBBDD = "SecureCore";
            this.sdsTextBoxRouteTypes.NomCamp = "idRouteType";
            this.sdsTextBoxRouteTypes.NomControl = "sdsForaneaRouteTypes";
            this.sdsTextBoxRouteTypes.NomTaula = "Routes";
            this.sdsTextBoxRouteTypes.ReadOnly = true;
            this.sdsTextBoxRouteTypes.Requerit = false;
            this.sdsTextBoxRouteTypes.SiEsForana = true;
            this.sdsTextBoxRouteTypes.Size = new System.Drawing.Size(20, 2);
            this.sdsTextBoxRouteTypes.TabIndex = 0;
            this.sdsTextBoxRouteTypes.TabStop = false;
            // 
            // sdsForaneaRouteTypes
            // 
            this.sdsForaneaRouteTypes.Control_Id = "sdsTextBoxRouteTypes";
            this.sdsForaneaRouteTypes.DescCodi = "DescRouteType";
            this.sdsForaneaRouteTypes.ErrorText = null;
            this.sdsForaneaRouteTypes.Location = new System.Drawing.Point(141, 272);
            this.sdsForaneaRouteTypes.Margin = new System.Windows.Forms.Padding(2);
            this.sdsForaneaRouteTypes.Name = "sdsForaneaRouteTypes";
            this.sdsForaneaRouteTypes.NomCamp = "CodeRouteType";
            this.sdsForaneaRouteTypes.NomControl = "txtIDRoute";
            this.sdsForaneaRouteTypes.NomID = "idRouteType";
            this.sdsForaneaRouteTypes.NomTaula = "RouteTypes";
            this.sdsForaneaRouteTypes.Requerit = false;
            this.sdsForaneaRouteTypes.Size = new System.Drawing.Size(340, 29);
            this.sdsForaneaRouteTypes.TabIndex = 24;
            this.sdsForaneaRouteTypes.TextLabel = "RouteType";
            // 
            // lblCodeRoute
            // 
            this.lblCodeRoute.AutoSize = true;
            this.lblCodeRoute.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCodeRoute.Location = new System.Drawing.Point(54, 186);
            this.lblCodeRoute.Name = "lblCodeRoute";
            this.lblCodeRoute.Size = new System.Drawing.Size(67, 13);
            this.lblCodeRoute.TabIndex = 25;
            this.lblCodeRoute.Text = "Code Route:";
            // 
            // lblDescRoute
            // 
            this.lblDescRoute.AutoSize = true;
            this.lblDescRoute.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDescRoute.Location = new System.Drawing.Point(54, 226);
            this.lblDescRoute.Name = "lblDescRoute";
            this.lblDescRoute.Size = new System.Drawing.Size(67, 13);
            this.lblDescRoute.TabIndex = 26;
            this.lblDescRoute.Text = "Desc Route:";
            // 
            // sdsForaneaDefinedRoutes
            // 
            this.sdsForaneaDefinedRoutes.Control_Id = "sdsTextBoxDefinedRoute";
            this.sdsForaneaDefinedRoutes.DescCodi = "RouteMap";
            this.sdsForaneaDefinedRoutes.ErrorText = null;
            this.sdsForaneaDefinedRoutes.Location = new System.Drawing.Point(141, 305);
            this.sdsForaneaDefinedRoutes.Margin = new System.Windows.Forms.Padding(2);
            this.sdsForaneaDefinedRoutes.Name = "sdsForaneaDefinedRoutes";
            this.sdsForaneaDefinedRoutes.NomCamp = "RouteMap";
            this.sdsForaneaDefinedRoutes.NomControl = "txtIDRoute";
            this.sdsForaneaDefinedRoutes.NomID = "idPlanetDest";
            this.sdsForaneaDefinedRoutes.NomTaula = "DefinedRoutes";
            this.sdsForaneaDefinedRoutes.Requerit = false;
            this.sdsForaneaDefinedRoutes.Size = new System.Drawing.Size(340, 30);
            this.sdsForaneaDefinedRoutes.TabIndex = 27;
            this.sdsForaneaDefinedRoutes.TextLabel = "DefRoute";
            // 
            // sdsTextBoxDefinedRoute
            // 
            this.sdsTextBoxDefinedRoute.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.sdsTextBoxDefinedRoute.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sdsTextBoxDefinedRoute.CodeSector = null;
            this.sdsTextBoxDefinedRoute.ColumnName = "idPlanetDest";
            this.sdsTextBoxDefinedRoute.DescCodi = null;
            this.sdsTextBoxDefinedRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdsTextBoxDefinedRoute.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.sdsTextBoxDefinedRoute.Location = new System.Drawing.Point(782, 129);
            this.sdsTextBoxDefinedRoute.Name = "sdsTextBoxDefinedRoute";
            this.sdsTextBoxDefinedRoute.Nom = null;
            this.sdsTextBoxDefinedRoute.NomBBDD = "SecureCore";
            this.sdsTextBoxDefinedRoute.NomCamp = "idPlanetDest";
            this.sdsTextBoxDefinedRoute.NomControl = "sdsForaneaDefinedRoutes";
            this.sdsTextBoxDefinedRoute.NomTaula = "Routes";
            this.sdsTextBoxDefinedRoute.ReadOnly = true;
            this.sdsTextBoxDefinedRoute.Requerit = false;
            this.sdsTextBoxDefinedRoute.SiEsForana = true;
            this.sdsTextBoxDefinedRoute.Size = new System.Drawing.Size(1, 2);
            this.sdsTextBoxDefinedRoute.TabIndex = 29;
            this.sdsTextBoxDefinedRoute.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(58, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "idPlanetDest:";
            // 
            // Routes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 530);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sdsForaneaDefinedRoutes);
            this.Controls.Add(this.lblDescRoute);
            this.Controls.Add(this.lblCodeRoute);
            this.Controls.Add(this.sdsForaneaRouteTypes);
            this.Controls.Add(this.sdsTextBoxDescRoute);
            this.Controls.Add(this.sdsTextBoxCodeRoute);
            this.Controls.Add(this.sdsTextBoxRouteTypes);
            this.Controls.Add(this.sdsTextBoxDefinedRoute);
            this.Name = "Routes";
            this.Text = "Routes";
            this.Load += new System.EventHandler(this.Routes_Load);
            this.Controls.SetChildIndex(this.LabelCodeForanea, 0);
            this.Controls.SetChildIndex(this.sdsTextBoxDefinedRoute, 0);
            this.Controls.SetChildIndex(this.sdsTextBoxRouteTypes, 0);
            this.Controls.SetChildIndex(this.sdsTextBoxCodeRoute, 0);
            this.Controls.SetChildIndex(this.sdsTextBoxDescRoute, 0);
            this.Controls.SetChildIndex(this.sdsForaneaRouteTypes, 0);
            this.Controls.SetChildIndex(this.lblCodeRoute, 0);
            this.Controls.SetChildIndex(this.lblDescRoute, 0);
            this.Controls.SetChildIndex(this.sdsForaneaDefinedRoutes, 0);
            this.Controls.SetChildIndex(this.btnInsert, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SdsTexBox.SdsTexBox sdsTextBoxCodeRoute;
        private SdsTexBox.SdsTexBox sdsTextBoxDescRoute;
        private WookieCodeControls.sdsForanea sdsForaneaRouteTypes;
        private SdsTexBox.SdsTexBox sdsTextBoxRouteTypes;
        private System.Windows.Forms.Label lblCodeRoute;
        private System.Windows.Forms.Label lblDescRoute;
        private WookieCodeControls.sdsForanea sdsForaneaDefinedRoutes;
        private SdsTexBox.SdsTexBox sdsTextBoxDefinedRoute;
        private System.Windows.Forms.Label label1;
    }
}