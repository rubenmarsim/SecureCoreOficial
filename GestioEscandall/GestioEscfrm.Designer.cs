﻿namespace GestioEscandall
{
    partial class GestioEscfrm
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
            this.listNoUsat = new System.Windows.Forms.ListBox();
            this.listUsats = new System.Windows.Forms.ListBox();
            this.btnUsedToUnUsed = new System.Windows.Forms.Button();
            this.btnUnUsedToUsed = new System.Windows.Forms.Button();
            this.comboPart = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.comboObject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listNoUsat
            // 
            this.listNoUsat.AllowDrop = true;
            this.listNoUsat.FormattingEnabled = true;
            this.listNoUsat.Location = new System.Drawing.Point(50, 95);
            this.listNoUsat.Name = "listNoUsat";
            this.listNoUsat.Size = new System.Drawing.Size(232, 251);
            this.listNoUsat.TabIndex = 0;
            this.listNoUsat.DragDrop += new System.Windows.Forms.DragEventHandler(this.listNoUsat_DragDrop);
            this.listNoUsat.DragOver += new System.Windows.Forms.DragEventHandler(this.listNoUsat_DragOver);
            this.listNoUsat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listNoUsat_MouseDown);
            // 
            // listUsats
            // 
            this.listUsats.AllowDrop = true;
            this.listUsats.FormattingEnabled = true;
            this.listUsats.Location = new System.Drawing.Point(369, 95);
            this.listUsats.Name = "listUsats";
            this.listUsats.Size = new System.Drawing.Size(232, 251);
            this.listUsats.TabIndex = 1;
            this.listUsats.DragDrop += new System.Windows.Forms.DragEventHandler(this.listUsats_DragDrop);
            this.listUsats.DragOver += new System.Windows.Forms.DragEventHandler(this.listUsats_DragOver);
            this.listUsats.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listUsats_MouseDown);
            // 
            // btnUsedToUnUsed
            // 
            this.btnUsedToUnUsed.Location = new System.Drawing.Point(288, 221);
            this.btnUsedToUnUsed.Name = "btnUsedToUnUsed";
            this.btnUsedToUnUsed.Size = new System.Drawing.Size(75, 23);
            this.btnUsedToUnUsed.TabIndex = 2;
            this.btnUsedToUnUsed.Text = "< <";
            this.btnUsedToUnUsed.UseVisualStyleBackColor = true;
            this.btnUsedToUnUsed.Click += new System.EventHandler(this.btnUsedToUnUsed_Click);
            // 
            // btnUnUsedToUsed
            // 
            this.btnUnUsedToUsed.Location = new System.Drawing.Point(288, 172);
            this.btnUnUsedToUsed.Name = "btnUnUsedToUsed";
            this.btnUnUsedToUsed.Size = new System.Drawing.Size(75, 23);
            this.btnUnUsedToUsed.TabIndex = 3;
            this.btnUnUsedToUsed.Text = "> >";
            this.btnUnUsedToUsed.UseVisualStyleBackColor = true;
            this.btnUnUsedToUsed.Click += new System.EventHandler(this.btnUnUsedToUsed_Click);
            // 
            // comboPart
            // 
            this.comboPart.DisplayMember = "descReferenceType";
            this.comboPart.FormattingEnabled = true;
            this.comboPart.Location = new System.Drawing.Point(50, 32);
            this.comboPart.Name = "comboPart";
            this.comboPart.Size = new System.Drawing.Size(165, 21);
            this.comboPart.TabIndex = 4;
            this.comboPart.ValueMember = "idReferenceType";
            this.comboPart.SelectedValueChanged += new System.EventHandler(this.comboPart_SelectedValueChanged);
            this.comboPart.Click += new System.EventHandler(this.comboPart_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(445, 369);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // comboObject
            // 
            this.comboObject.DisplayMember = "descReference";
            this.comboObject.FormattingEnabled = true;
            this.comboObject.Location = new System.Drawing.Point(235, 32);
            this.comboObject.Name = "comboObject";
            this.comboObject.Size = new System.Drawing.Size(185, 21);
            this.comboObject.TabIndex = 6;
            this.comboObject.ValueMember = "idReference";
            this.comboObject.SelectedValueChanged += new System.EventHandler(this.comboObject_SelectedValueChanged);
            this.comboObject.Click += new System.EventHandler(this.comboObject_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "No usados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(366, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Usados:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(526, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GestioEscfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 422);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboObject);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.comboPart);
            this.Controls.Add(this.btnUnUsedToUsed);
            this.Controls.Add(this.btnUsedToUnUsed);
            this.Controls.Add(this.listUsats);
            this.Controls.Add(this.listNoUsat);
            this.Name = "GestioEscfrm";
            this.Text = "Gestión Escandall";
            this.Load += new System.EventHandler(this.GestioEscfrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listNoUsat;
        private System.Windows.Forms.ListBox listUsats;
        private System.Windows.Forms.Button btnUsedToUnUsed;
        private System.Windows.Forms.Button btnUnUsedToUsed;
        private System.Windows.Forms.ComboBox comboPart;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox comboObject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

