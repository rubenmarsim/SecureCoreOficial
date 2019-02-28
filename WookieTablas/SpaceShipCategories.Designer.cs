namespace WookieTablas
{
    partial class SpaceShipCategories
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sdsTexBox1 = new SdsTexBox.SdsTexBox();
            this.sdsTexBox2 = new SdsTexBox.SdsTexBox();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(161, 466);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(68, 465);
            // 
            // LabelCodeForanea
            // 
            this.LabelCodeForanea.Size = new System.Drawing.Size(0, 13);
            this.LabelCodeForanea.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(29, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "DescSpaceShipCategory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(29, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "CodeSpaceShipCategory";
            // 
            // sdsTexBox1
            // 
            this.sdsTexBox1.CodeSector = null;
            this.sdsTexBox1.ColumnName = "DescSpaceShipCategory";
            this.sdsTexBox1.DescCodi = null;
            this.sdsTexBox1.Location = new System.Drawing.Point(161, 209);
            this.sdsTexBox1.MaxLength = 50;
            this.sdsTexBox1.Name = "sdsTexBox1";
            this.sdsTexBox1.Nom = null;
            this.sdsTexBox1.NomBBDD = "SecureCore";
            this.sdsTexBox1.NomCamp = null;
            this.sdsTexBox1.NomControl = null;
            this.sdsTexBox1.NomTaula = "SpaceShipCategories";
            this.sdsTexBox1.Requerit = false;
            this.sdsTexBox1.SiEsForana = false;
            this.sdsTexBox1.Size = new System.Drawing.Size(100, 20);
            this.sdsTexBox1.TabIndex = 31;
            // 
            // sdsTexBox2
            // 
            this.sdsTexBox2.CodeSector = null;
            this.sdsTexBox2.ColumnName = "CodeSpaceShipCategory";
            this.sdsTexBox2.DescCodi = null;
            this.sdsTexBox2.Location = new System.Drawing.Point(161, 153);
            this.sdsTexBox2.MaxLength = 4;
            this.sdsTexBox2.Name = "sdsTexBox2";
            this.sdsTexBox2.Nom = null;
            this.sdsTexBox2.NomBBDD = "SecureCore";
            this.sdsTexBox2.NomCamp = null;
            this.sdsTexBox2.NomControl = null;
            this.sdsTexBox2.NomTaula = "SpaceShipCategories";
            this.sdsTexBox2.Requerit = false;
            this.sdsTexBox2.SiEsForana = false;
            this.sdsTexBox2.Size = new System.Drawing.Size(100, 20);
            this.sdsTexBox2.TabIndex = 32;
            // 
            // SpaceShipCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 546);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sdsTexBox1);
            this.Controls.Add(this.sdsTexBox2);
            this.Name = "SpaceShipCategories";
            this.Text = "SpaceShipCategories";
            this.Load += new System.EventHandler(this.SpaceShipCategories_Load);
            this.Controls.SetChildIndex(this.LabelCodeForanea, 0);
            this.Controls.SetChildIndex(this.btnInsert, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.sdsTexBox2, 0);
            this.Controls.SetChildIndex(this.sdsTexBox1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private SdsTexBox.SdsTexBox sdsTexBox1;
        private SdsTexBox.SdsTexBox sdsTexBox2;
    }
}