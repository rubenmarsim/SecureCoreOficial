namespace WookieTablas
{
    partial class MilitaryCamps
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
            this.sdsTexBox1 = new SdsTexBox.SdsTexBox();
            this.sdsTexBox2 = new SdsTexBox.SdsTexBox();
            this.idPlanetas = new SdsTexBox.SdsTexBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ForaneaPlanet = new WookieCodeControls.sdsForanea();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(190, 458);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(95, 461);
            this.btnInsert.Size = new System.Drawing.Size(75, 20);
            // 
            // LabelCodeForanea
            // 
            this.LabelCodeForanea.Size = new System.Drawing.Size(0, 13);
            this.LabelCodeForanea.Text = "";
            // 
            // sdsTexBox1
            // 
            this.sdsTexBox1.CodeSector = null;
            this.sdsTexBox1.ColumnName = "CodeCamp";
            this.sdsTexBox1.DescCodi = null;
            this.sdsTexBox1.Location = new System.Drawing.Point(119, 163);
            this.sdsTexBox1.MaxLength = 12;
            this.sdsTexBox1.Name = "sdsTexBox1";
            this.sdsTexBox1.Nom = null;
            this.sdsTexBox1.NomBBDD = "SecureCore";
            this.sdsTexBox1.NomCamp = "";
            this.sdsTexBox1.NomControl = null;
            this.sdsTexBox1.NomTaula = "MilitaryCamps";
            this.sdsTexBox1.Requerit = false;
            this.sdsTexBox1.SiEsForana = false;
            this.sdsTexBox1.Size = new System.Drawing.Size(100, 20);
            this.sdsTexBox1.TabIndex = 24;
            // 
            // sdsTexBox2
            // 
            this.sdsTexBox2.CodeSector = null;
            this.sdsTexBox2.ColumnName = "DescCamp";
            this.sdsTexBox2.DescCodi = null;
            this.sdsTexBox2.Location = new System.Drawing.Point(119, 214);
            this.sdsTexBox2.MaxLength = 200;
            this.sdsTexBox2.Name = "sdsTexBox2";
            this.sdsTexBox2.Nom = null;
            this.sdsTexBox2.NomBBDD = "SecureCore";
            this.sdsTexBox2.NomCamp = "";
            this.sdsTexBox2.NomControl = null;
            this.sdsTexBox2.NomTaula = "MilitaryCamps";
            this.sdsTexBox2.Requerit = false;
            this.sdsTexBox2.SiEsForana = false;
            this.sdsTexBox2.Size = new System.Drawing.Size(100, 20);
            this.sdsTexBox2.TabIndex = 25;
            // 
            // idPlanetas
            // 
            this.idPlanetas.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.idPlanetas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idPlanetas.CodeSector = null;
            this.idPlanetas.ColumnName = "idPlanet";
            this.idPlanetas.DescCodi = null;
            this.idPlanetas.Enabled = false;
            this.idPlanetas.Location = new System.Drawing.Point(373, 290);
            this.idPlanetas.Name = "idPlanetas";
            this.idPlanetas.Nom = null;
            this.idPlanetas.NomBBDD = "SecureCore";
            this.idPlanetas.NomCamp = "";
            this.idPlanetas.NomControl = "ForaneaPlanet";
            this.idPlanetas.NomTaula = "Planets";
            this.idPlanetas.Requerit = false;
            this.idPlanetas.SiEsForana = true;
            this.idPlanetas.Size = new System.Drawing.Size(40, 13);
            this.idPlanetas.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(45, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "CodeCamp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(45, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "DescCamp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(59, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "idPlanet";
            // 
            // ForaneaPlanet
            // 
            this.ForaneaPlanet.Control_Id = "idPlanetas";
            this.ForaneaPlanet.DescCodi = "DescPlanet";
            this.ForaneaPlanet.ErrorText = null;
            this.ForaneaPlanet.Location = new System.Drawing.Point(119, 256);
            this.ForaneaPlanet.Margin = new System.Windows.Forms.Padding(2);
            this.ForaneaPlanet.Name = "ForaneaPlanet";
            this.ForaneaPlanet.NomCamp = "CodePlanet";
            this.ForaneaPlanet.NomControl = "idPlanetas";
            this.ForaneaPlanet.NomID = "idPlanet";
            this.ForaneaPlanet.NomTaula = "Planets";
            this.ForaneaPlanet.Requerit = false;
            this.ForaneaPlanet.Size = new System.Drawing.Size(339, 38);
            this.ForaneaPlanet.TabIndex = 30;
            this.ForaneaPlanet.TextLabel = null;
            // 
            // MilitaryCamps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 558);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ForaneaPlanet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sdsTexBox2);
            this.Controls.Add(this.sdsTexBox1);
            this.Controls.Add(this.idPlanetas);
            this.Name = "MilitaryCamps";
            this.Text = "MilitaryCamps";
            this.Load += new System.EventHandler(this.MilitaryCamps_Load);
            this.Controls.SetChildIndex(this.LabelCodeForanea, 0);
            this.Controls.SetChildIndex(this.idPlanetas, 0);
            this.Controls.SetChildIndex(this.btnInsert, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.sdsTexBox1, 0);
            this.Controls.SetChildIndex(this.sdsTexBox2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.ForaneaPlanet, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SdsTexBox.SdsTexBox sdsTexBox1;
        private SdsTexBox.SdsTexBox sdsTexBox2;
        private SdsTexBox.SdsTexBox idPlanetas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private WookieCodeControls.sdsForanea ForaneaPlanet;
    }
}