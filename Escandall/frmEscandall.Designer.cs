namespace Escandall
{
    partial class frmEscandall
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
            this.treeViewEscandall = new System.Windows.Forms.TreeView();
            this.btnPadre = new System.Windows.Forms.Button();
            this.btnHijo = new System.Windows.Forms.Button();
            this.btnBorrarCampo = new System.Windows.Forms.Button();
            this.btnBorrarArbol = new System.Windows.Forms.Button();
            this.txtBoxAddCampo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // treeViewEscandall
            // 
            this.treeViewEscandall.Location = new System.Drawing.Point(12, 12);
            this.treeViewEscandall.Name = "treeViewEscandall";
            this.treeViewEscandall.Size = new System.Drawing.Size(375, 426);
            this.treeViewEscandall.TabIndex = 0;
            // 
            // btnPadre
            // 
            this.btnPadre.Location = new System.Drawing.Point(591, 246);
            this.btnPadre.Name = "btnPadre";
            this.btnPadre.Size = new System.Drawing.Size(197, 23);
            this.btnPadre.TabIndex = 1;
            this.btnPadre.Text = "Crear como padre";
            this.btnPadre.UseVisualStyleBackColor = true;
            this.btnPadre.Click += new System.EventHandler(this.btnPadre_Click);
            // 
            // btnHijo
            // 
            this.btnHijo.Location = new System.Drawing.Point(591, 297);
            this.btnHijo.Name = "btnHijo";
            this.btnHijo.Size = new System.Drawing.Size(197, 23);
            this.btnHijo.TabIndex = 2;
            this.btnHijo.Text = "Crear como hijo";
            this.btnHijo.UseVisualStyleBackColor = true;
            this.btnHijo.Click += new System.EventHandler(this.btnHijo_Click);
            // 
            // btnBorrarCampo
            // 
            this.btnBorrarCampo.Location = new System.Drawing.Point(591, 356);
            this.btnBorrarCampo.Name = "btnBorrarCampo";
            this.btnBorrarCampo.Size = new System.Drawing.Size(197, 23);
            this.btnBorrarCampo.TabIndex = 3;
            this.btnBorrarCampo.Text = "Borrar campo seleccionado";
            this.btnBorrarCampo.UseVisualStyleBackColor = true;
            this.btnBorrarCampo.Click += new System.EventHandler(this.btnBorrarCampo_Click);
            // 
            // btnBorrarArbol
            // 
            this.btnBorrarArbol.Location = new System.Drawing.Point(591, 412);
            this.btnBorrarArbol.Name = "btnBorrarArbol";
            this.btnBorrarArbol.Size = new System.Drawing.Size(197, 23);
            this.btnBorrarArbol.TabIndex = 4;
            this.btnBorrarArbol.Text = "Borrar todo el arbol";
            this.btnBorrarArbol.UseVisualStyleBackColor = true;
            this.btnBorrarArbol.Click += new System.EventHandler(this.btnBorrarArbol_Click);
            // 
            // txtBoxAddCampo
            // 
            this.txtBoxAddCampo.Location = new System.Drawing.Point(393, 189);
            this.txtBoxAddCampo.Name = "txtBoxAddCampo";
            this.txtBoxAddCampo.Size = new System.Drawing.Size(395, 20);
            this.txtBoxAddCampo.TabIndex = 5;
            this.txtBoxAddCampo.TextChanged += new System.EventHandler(this.txtBoxAddCampo_TextChanged);
            // 
            // frmEscandall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxAddCampo);
            this.Controls.Add(this.btnBorrarArbol);
            this.Controls.Add(this.btnBorrarCampo);
            this.Controls.Add(this.btnHijo);
            this.Controls.Add(this.btnPadre);
            this.Controls.Add(this.treeViewEscandall);
            this.Name = "frmEscandall";
            this.Text = "Escandall";
            this.Load += new System.EventHandler(this.frmEscandall_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewEscandall;
        private System.Windows.Forms.Button btnPadre;
        private System.Windows.Forms.Button btnHijo;
        private System.Windows.Forms.Button btnBorrarCampo;
        private System.Windows.Forms.Button btnBorrarArbol;
        private System.Windows.Forms.TextBox txtBoxAddCampo;
    }
}

