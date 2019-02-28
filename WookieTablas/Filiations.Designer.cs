namespace WookieTablas
{
    partial class Filiations
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
            this.sdsTexBox3 = new SdsTexBox.SdsTexBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sdsTexBox4 = new SdsTexBox.SdsTexBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(150, 401);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(57, 400);
            // 
            // LabelCodeForanea
            // 
            this.LabelCodeForanea.Size = new System.Drawing.Size(0, 13);
            this.LabelCodeForanea.Text = "";
            // 
            // sdsTexBox3
            // 
            this.sdsTexBox3.BackColor = System.Drawing.SystemColors.Window;
            this.sdsTexBox3.CodeSector = null;
            this.sdsTexBox3.ColumnName = "DescFiliations";
            this.sdsTexBox3.DescCodi = null;
            this.sdsTexBox3.Location = new System.Drawing.Point(150, 275);
            this.sdsTexBox3.MaxLength = 25;
            this.sdsTexBox3.Name = "sdsTexBox3";
            this.sdsTexBox3.Nom = null;
            this.sdsTexBox3.NomBBDD = "SecureCore";
            this.sdsTexBox3.NomCamp = null;
            this.sdsTexBox3.NomControl = null;
            this.sdsTexBox3.NomTaula = "Filiations";
            this.sdsTexBox3.Requerit = false;
            this.sdsTexBox3.SiEsForana = false;
            this.sdsTexBox3.Size = new System.Drawing.Size(100, 20);
            this.sdsTexBox3.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "DescFiliations";
            // 
            // sdsTexBox4
            // 
            this.sdsTexBox4.BackColor = System.Drawing.SystemColors.Window;
            this.sdsTexBox4.CodeSector = null;
            this.sdsTexBox4.ColumnName = "CodeFiliation";
            this.sdsTexBox4.DescCodi = null;
            this.sdsTexBox4.Location = new System.Drawing.Point(150, 236);
            this.sdsTexBox4.MaxLength = 4;
            this.sdsTexBox4.Name = "sdsTexBox4";
            this.sdsTexBox4.Nom = null;
            this.sdsTexBox4.NomBBDD = "SecureCore";
            this.sdsTexBox4.NomCamp = null;
            this.sdsTexBox4.NomControl = null;
            this.sdsTexBox4.NomTaula = "Filiations";
            this.sdsTexBox4.Requerit = false;
            this.sdsTexBox4.SiEsForana = false;
            this.sdsTexBox4.Size = new System.Drawing.Size(100, 20);
            this.sdsTexBox4.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "CodeFiliation";
            // 
            // Filiations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 520);
            this.Controls.Add(this.sdsTexBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sdsTexBox3);
            this.Controls.Add(this.label3);
            this.Name = "Filiations";
            this.Text = "Filiations";
            this.Load += new System.EventHandler(this.Filiations_Load);
            this.Controls.SetChildIndex(this.LabelCodeForanea, 0);
            this.Controls.SetChildIndex(this.btnInsert, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.sdsTexBox3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.sdsTexBox4, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SdsTexBox.SdsTexBox sdsTexBox3;
        private System.Windows.Forms.Label label3;
        private SdsTexBox.SdsTexBox sdsTexBox4;
        private System.Windows.Forms.Label label4;
    }
}