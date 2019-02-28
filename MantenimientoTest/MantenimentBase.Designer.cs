namespace MantenimientoBase
{
    partial class MantenimentBase
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMant_table = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.LabelCodeForanea = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMant_table)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMant_table
            // 
            this.dgvMant_table.AllowUserToOrderColumns = true;
            this.dgvMant_table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMant_table.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvMant_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMant_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMant_table.Location = new System.Drawing.Point(486, 137);
            this.dgvMant_table.Name = "dgvMant_table";
            this.dgvMant_table.Size = new System.Drawing.Size(457, 385);
            this.dgvMant_table.TabIndex = 0;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(79, 498);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(72, 24);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(157, 498);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // LabelCodeForanea
            // 
            this.LabelCodeForanea.AutoSize = true;
            this.LabelCodeForanea.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelCodeForanea.Location = new System.Drawing.Point(25, 272);
            this.LabelCodeForanea.Name = "LabelCodeForanea";
            this.LabelCodeForanea.Size = new System.Drawing.Size(18, 13);
            this.LabelCodeForanea.TabIndex = 24;
            this.LabelCodeForanea.Text = "txt";
            // 
            // MantenimentBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 564);
            this.Controls.Add(this.LabelCodeForanea);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dgvMant_table);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "MantenimentBase";
            this.Text = "frmMant_Table";
            this.Load += new System.EventHandler(this.FrmMant_Table_Load);
            this.Controls.SetChildIndex(this.dgvMant_table, 0);
            this.Controls.SetChildIndex(this.btnInsert, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.LabelCodeForanea, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMant_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.DataGridView dgvMant_table;
        public System.Windows.Forms.Button btnInsert;
        public System.Windows.Forms.Label LabelCodeForanea;
    }
}

