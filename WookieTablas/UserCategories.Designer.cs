namespace WookieTablas
{
    partial class UserCategories
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
            this.sdsTexBox1 = new SdsTexBox.SdsTexBox();
            this.sdsTexBox2 = new SdsTexBox.SdsTexBox();
            this.sdsTexBox3 = new SdsTexBox.SdsTexBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(144, 433);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(51, 433);
            // 
            // LabelCodeForanea
            // 
            this.LabelCodeForanea.Size = new System.Drawing.Size(0, 13);
            this.LabelCodeForanea.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "AccessLevel";
            // 
            // sdsTexBox1
            // 
            this.sdsTexBox1.BackColor = System.Drawing.SystemColors.Window;
            this.sdsTexBox1.CodeSector = null;
            this.sdsTexBox1.ColumnName = "AccessLevel";
            this.sdsTexBox1.DescCodi = null;
            this.sdsTexBox1.Location = new System.Drawing.Point(144, 232);
            this.sdsTexBox1.Name = "sdsTexBox1";
            this.sdsTexBox1.Nom = null;
            this.sdsTexBox1.NomBBDD = "SecureCore";
            this.sdsTexBox1.NomCamp = null;
            this.sdsTexBox1.NomControl = null;
            this.sdsTexBox1.NomTaula = "UserCategories";
            this.sdsTexBox1.Requerit = false;
            this.sdsTexBox1.SiEsForana = false;
            this.sdsTexBox1.Size = new System.Drawing.Size(100, 20);
            this.sdsTexBox1.TabIndex = 41;
            // 
            // sdsTexBox2
            // 
            this.sdsTexBox2.BackColor = System.Drawing.SystemColors.Window;
            this.sdsTexBox2.CodeSector = null;
            this.sdsTexBox2.ColumnName = "DescCategory";
            this.sdsTexBox2.DescCodi = null;
            this.sdsTexBox2.Location = new System.Drawing.Point(144, 190);
            this.sdsTexBox2.MaxLength = 50;
            this.sdsTexBox2.Name = "sdsTexBox2";
            this.sdsTexBox2.Nom = null;
            this.sdsTexBox2.NomBBDD = "SecureCore";
            this.sdsTexBox2.NomCamp = null;
            this.sdsTexBox2.NomControl = null;
            this.sdsTexBox2.NomTaula = "UserCategories";
            this.sdsTexBox2.Requerit = false;
            this.sdsTexBox2.SiEsForana = false;
            this.sdsTexBox2.Size = new System.Drawing.Size(100, 20);
            this.sdsTexBox2.TabIndex = 37;
            // 
            // sdsTexBox3
            // 
            this.sdsTexBox3.BackColor = System.Drawing.SystemColors.Window;
            this.sdsTexBox3.CodeSector = null;
            this.sdsTexBox3.ColumnName = "CodeCategory";
            this.sdsTexBox3.DescCodi = null;
            this.sdsTexBox3.Location = new System.Drawing.Point(144, 138);
            this.sdsTexBox3.MaxLength = 4;
            this.sdsTexBox3.Name = "sdsTexBox3";
            this.sdsTexBox3.Nom = null;
            this.sdsTexBox3.NomBBDD = "SecureCore";
            this.sdsTexBox3.NomCamp = null;
            this.sdsTexBox3.NomControl = null;
            this.sdsTexBox3.NomTaula = "UserCategories";
            this.sdsTexBox3.Requerit = false;
            this.sdsTexBox3.SiEsForana = false;
            this.sdsTexBox3.Size = new System.Drawing.Size(100, 20);
            this.sdsTexBox3.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "DescCategory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "CodeCategory";
            // 
            // UserCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sdsTexBox1);
            this.Controls.Add(this.sdsTexBox2);
            this.Controls.Add(this.sdsTexBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "UserCategories";
            this.Text = "UserCategories";
            this.Load += new System.EventHandler(this.UserCategories_Load);
            this.Controls.SetChildIndex(this.LabelCodeForanea, 0);
            this.Controls.SetChildIndex(this.btnInsert, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.sdsTexBox3, 0);
            this.Controls.SetChildIndex(this.sdsTexBox2, 0);
            this.Controls.SetChildIndex(this.sdsTexBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private SdsTexBox.SdsTexBox sdsTexBox1;
        private SdsTexBox.SdsTexBox sdsTexBox2;
        private SdsTexBox.SdsTexBox sdsTexBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}