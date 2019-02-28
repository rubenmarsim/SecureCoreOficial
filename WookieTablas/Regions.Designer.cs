namespace WookieTablas
{
    partial class Regions
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
            this.sdsTexBox2 = new SdsTexBox.SdsTexBox();
            this.sdsTexBox3 = new SdsTexBox.SdsTexBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(149, 430);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(62, 429);
            // 
            // LabelCodeForanea
            // 
            this.LabelCodeForanea.Location = new System.Drawing.Point(45, 321);
            this.LabelCodeForanea.Size = new System.Drawing.Size(0, 13);
            this.LabelCodeForanea.Text = "";
            // 
            // sdsTexBox2
            // 
            this.sdsTexBox2.BackColor = System.Drawing.SystemColors.Window;
            this.sdsTexBox2.CodeSector = null;
            this.sdsTexBox2.ColumnName = "DescRegion";
            this.sdsTexBox2.DescCodi = null;
            this.sdsTexBox2.Location = new System.Drawing.Point(124, 266);
            this.sdsTexBox2.MaxLength = 50;
            this.sdsTexBox2.Name = "sdsTexBox2";
            this.sdsTexBox2.Nom = null;
            this.sdsTexBox2.NomBBDD = "SecureCore";
            this.sdsTexBox2.NomCamp = null;
            this.sdsTexBox2.NomControl = null;
            this.sdsTexBox2.NomTaula = "Regions";
            this.sdsTexBox2.Requerit = false;
            this.sdsTexBox2.SiEsForana = false;
            this.sdsTexBox2.Size = new System.Drawing.Size(100, 20);
            this.sdsTexBox2.TabIndex = 31;
            // 
            // sdsTexBox3
            // 
            this.sdsTexBox3.BackColor = System.Drawing.SystemColors.Window;
            this.sdsTexBox3.CodeSector = null;
            this.sdsTexBox3.ColumnName = "CodeRegion";
            this.sdsTexBox3.DescCodi = null;
            this.sdsTexBox3.Location = new System.Drawing.Point(124, 214);
            this.sdsTexBox3.MaxLength = 4;
            this.sdsTexBox3.Name = "sdsTexBox3";
            this.sdsTexBox3.Nom = null;
            this.sdsTexBox3.NomBBDD = "SecureCore";
            this.sdsTexBox3.NomCamp = null;
            this.sdsTexBox3.NomControl = null;
            this.sdsTexBox3.NomTaula = "Regions";
            this.sdsTexBox3.Requerit = false;
            this.sdsTexBox3.SiEsForana = false;
            this.sdsTexBox3.Size = new System.Drawing.Size(100, 20);
            this.sdsTexBox3.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "DescRegion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "CodeRegion";
            // 
            // Regions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 553);
            this.Controls.Add(this.sdsTexBox2);
            this.Controls.Add(this.sdsTexBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "Regions";
            this.Text = "Regions";
            this.Load += new System.EventHandler(this.Regions_Load);
            this.Controls.SetChildIndex(this.LabelCodeForanea, 0);
            this.Controls.SetChildIndex(this.btnInsert, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.sdsTexBox3, 0);
            this.Controls.SetChildIndex(this.sdsTexBox2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private SdsTexBox.SdsTexBox sdsTexBox2;
        private SdsTexBox.SdsTexBox sdsTexBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}