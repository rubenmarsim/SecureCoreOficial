namespace WookieTablas
{
    partial class Species
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(154, 401);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(65, 401);
            // 
            // LabelCodeForanea
            // 
            this.LabelCodeForanea.Size = new System.Drawing.Size(0, 13);
            this.LabelCodeForanea.Text = "";
            // 
            // sdsTexBox1
            // 
            this.sdsTexBox1.BackColor = System.Drawing.SystemColors.Window;
            this.sdsTexBox1.CodeSector = null;
            this.sdsTexBox1.ColumnName = "DescSpecie";
            this.sdsTexBox1.DescCodi = null;
            this.sdsTexBox1.Location = new System.Drawing.Point(129, 214);
            this.sdsTexBox1.MaxLength = 50;
            this.sdsTexBox1.Name = "sdsTexBox1";
            this.sdsTexBox1.Nom = null;
            this.sdsTexBox1.NomBBDD = "SecureCore";
            this.sdsTexBox1.NomCamp = null;
            this.sdsTexBox1.NomControl = null;
            this.sdsTexBox1.NomTaula = "Species";
            this.sdsTexBox1.Requerit = false;
            this.sdsTexBox1.SiEsForana = false;
            this.sdsTexBox1.Size = new System.Drawing.Size(100, 20);
            this.sdsTexBox1.TabIndex = 45;
            // 
            // sdsTexBox2
            // 
            this.sdsTexBox2.BackColor = System.Drawing.SystemColors.Window;
            this.sdsTexBox2.CodeSector = null;
            this.sdsTexBox2.ColumnName = "CodeSpecie";
            this.sdsTexBox2.DescCodi = null;
            this.sdsTexBox2.Location = new System.Drawing.Point(129, 162);
            this.sdsTexBox2.MaxLength = 4;
            this.sdsTexBox2.Name = "sdsTexBox2";
            this.sdsTexBox2.Nom = null;
            this.sdsTexBox2.NomBBDD = "SecureCore";
            this.sdsTexBox2.NomCamp = null;
            this.sdsTexBox2.NomControl = null;
            this.sdsTexBox2.NomTaula = "Species";
            this.sdsTexBox2.Requerit = false;
            this.sdsTexBox2.SiEsForana = false;
            this.sdsTexBox2.Size = new System.Drawing.Size(100, 20);
            this.sdsTexBox2.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "DescSpecie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "CodeSpecie";
            // 
            // Species
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 532);
            this.Controls.Add(this.sdsTexBox1);
            this.Controls.Add(this.sdsTexBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Species";
            this.Text = "Species";
            this.Load += new System.EventHandler(this.Species_Load);
            this.Controls.SetChildIndex(this.LabelCodeForanea, 0);
            this.Controls.SetChildIndex(this.btnInsert, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.sdsTexBox2, 0);
            this.Controls.SetChildIndex(this.sdsTexBox1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private SdsTexBox.SdsTexBox sdsTexBox1;
        private SdsTexBox.SdsTexBox sdsTexBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}