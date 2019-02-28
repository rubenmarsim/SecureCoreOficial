using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SdsTexBox
{
    public class SdsTexBox : TextBox
        {
        public SdsTexBox()
        {
            InitializeComponent();
        }

        //public SdsTexBox(string id)
        //{
        //    InitializeComponent();
        //    this.id = id;
        //}
        string _Nom;
        public string Nom
        {
            get { return _Nom; }
            set { _Nom = value; }
        }

        private string _ColumnName;
        public string ColumnName
        {
            get { return _ColumnName; }
            set { _ColumnName = value; }
        }

        public string _NomControl;
        public string NomControl
        {
            get { return _NomControl; }
            set { _NomControl = value; }
        }
        //////////PROPIETATS///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private Boolean _Requerit;
        public Boolean Requerit
        {
            get { return _Requerit; }
            set
            {
                _Requerit = value;
            }

        }
        private String _NomBBDD;
        private TextBox TextBox1;
        public String NomBBDD
        {
            get { return _NomBBDD; }
            set
            {
                _NomBBDD = value;
            }
        }
        private Boolean _SiEsForana;
        public Boolean SiEsForana
        {
            get { return _SiEsForana; }
            set
            {
                _SiEsForana = value;
            }
        }
        private String _NomTaula;

        public String NomTaula
        {
            get { return _NomTaula; }
            set
            {
                _NomTaula = value;
            }
        }
        private String _NomCamp;

        public String NomCamp
        {
            get { return _NomCamp; }
            set
            {
                _NomCamp = value;
            }
        }
        private String _DescCodi;

        public String DescCodi
        {
            get { return _DescCodi; }
            set
            {
                _DescCodi = value;
            }
        }
        private String _CodeSector;
        public String CodeSector
        {
            get { return _CodeSector; }
            set
            {
                _CodeSector = value;
            }
        }
        /////////////////////////METODES///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        private void TxtCode_Validated(object sender, EventArgs e)
        {
            //ValidaDades();
        }
        private void TxtCode_Leave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }
        private void InitializeComponent()
        {
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(0, 0);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(100, 20);
            this.TextBox1.TabIndex = 0;
            // 
            // SdsTexBox
            // 
            this.Name = "TextBox1";
            this.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.Leave += new System.EventHandler(this.TxtCode_Leave);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCode_Validating);
            this.Validated += new System.EventHandler(this.TxtCode_Validated);
            this.ResumeLayout(false);

        }
        private void TxtCode_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Requerit)
            {
                if (Text.Length == 0) e.Cancel = true;
            }
            EsForanea();
        }
        private void EsForanea()
        {
            string nomFormulari = FindForm().Name;

            if (SiEsForana)
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == nomFormulari)
                    {
                        foreach (Control frmControl in frm.Controls)
                        {
                            if (frmControl is WookieCodeControls.sdsForanea)
                            {
                                try
                                {
                                    if (frmControl.Name == this.NomControl)
                                    {
                                        frmControl.Text = this.Text;
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("ERROR DE DADES");
                                }

                            }
                        }
                    }
                }
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
           EsForanea();
        }
    }
}
