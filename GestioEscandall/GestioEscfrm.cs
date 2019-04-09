using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionDB;

namespace GestioEscandall
{
    public partial class GestioEscfrm : Form
    {
        #region Variables Globales
        bool primerCop = true;
        private string _Conec;

        XWingsFactoryEntities db;
        #endregion Variables Globales

        #region Constructores
        /// <summary>
        /// Constructor por defecto de la clase
        /// </summary>
        public GestioEscfrm()
        {
            InitializeComponent();
        }
        #endregion Constructores

        #region Events
        
        #region Form load        
        private void GestioEscfrm_Load(object sender, EventArgs e)
        {
            db = new XWingsFactoryEntities();
            cargarComboPart();
        }
        #endregion Form load

        #region DRAG & DROP
        //////////////////// DRAG & DROP //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void listUsats_MouseDown(object sender, MouseEventArgs e)
        {
            if (listUsats.Items.Count == 0)
                return;

            int index = listUsats.IndexFromPoint(e.X, e.Y);
            if (index >= 0)
            {
                string s = listUsats.Items[index].ToString();
                DragDropEffects dde1 = DoDragDrop(s,
                    DragDropEffects.All);

                if (dde1 == DragDropEffects.All)
                {
                    listUsats.Items.RemoveAt(listUsats.IndexFromPoint(e.X, e.Y));
                }
            }
        }

        private void listNoUsat_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void listNoUsat_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                string str = (string)e.Data.GetData(
                    DataFormats.StringFormat);

                listNoUsat.Items.Add(str);
            }
        }

        private void listNoUsat_MouseDown(object sender, MouseEventArgs e)
        {
            if (listNoUsat.Items.Count == 0)
                return;

            int index = listNoUsat.IndexFromPoint(e.X, e.Y);
            if (index >= 0)
            {
                string s = listNoUsat.Items[index].ToString();
                DragDropEffects dde1 = DoDragDrop(s,
                    DragDropEffects.All);

                if (dde1 == DragDropEffects.All)
                {
                    listNoUsat.Items.RemoveAt(listUsats.IndexFromPoint(e.X, e.Y));
                }
            }
        }

        private void listUsats_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void listUsats_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                string str = (string)e.Data.GetData(
                    DataFormats.StringFormat);

                listUsats.Items.Add(str);
            }
        }
        #endregion DRAG & DROP

        private void derecha_Click(object sender, EventArgs e)
        {

            if (listUsats.SelectedIndex != -1)
            {
                listNoUsat.Items.Add(listUsats.SelectedItem);
                listUsats.Items.Remove(listUsats.SelectedItem);
            }
        }
        private void izquierda_Click(object sender, EventArgs e)
        {
            if (listNoUsat.SelectedIndex != -1)
            {
                listUsats.Items.Add(listNoUsat.SelectedItem);
                listNoUsat.Items.Remove(listNoUsat.SelectedItem);
            }
        }
        private void comboPart_SelectedValueChanged(object sender, EventArgs e)
        {
            if (primerCop == false)
            {
                string valor = this.comboPart.GetItemText(this.comboPart.SelectedValue);

                cargarComboObject(valor);
            }
        }

        private void comboPart_Click(object sender, EventArgs e)
        {
            primerCop = false;
        }

        private void comboPart_SelectionChangeCommitted(object sender, EventArgs e)
        {
            listUsats.Items.Clear();
            listNoUsat.Items.Clear();
        }

        private void comboObject_SelectedValueChanged(object sender, EventArgs e)
        {
            if (primerCop == false)
            {
                string valor = this.comboObject.GetItemText(this.comboObject.SelectedValue);

                if (valor != null)
                {
                    //cargarListUsats(valor);
                    cargarListNoUsat(valor);
                }
            }
        }
        private void comboObject_Click(object sender, EventArgs e)
        {
            primerCop = false;
        }

        private void comboObject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            listUsats.Items.Clear();
            listNoUsat.Items.Clear();
        }
        #endregion Events

        #region Funcions
        /// <summary>
        /// Carga el comboBox de las partes principales e intermedias
        /// </summary>
        public void cargarComboPart()
        {            
            var FilteredtReferenceTypes = from r in db.ReferenceTypes
                     where r.idReferenceType == 1 || r.idReferenceType == 2
                     select r;

            comboPart.DataSource = FilteredtReferenceTypes.ToList();
            comboPart.ValueMember = "idReferenceType";
            comboPart.DisplayMember = "descReferenceType";
        }

        public void cargarComboObject(string valor)
        {
            int num = Convert.ToInt32(valor);
            //string selectQuery = "SELECT * FROM [REFERENCES] r, [ReferenceTypes] rt where rt.idReferenceType = r.idReferenceType and  r.idReferenceType = " + num;
            //DataTable dt = PortaTaula(selectQuery);
            var dt = from r in db.References// outer sequence
                     join rt in db.ReferenceTypes //inner sequence 
                     on r.idReferenceType equals rt.idReferenceType // key selector 
                     where r.idReferenceType == num
                     select r;

            comboObject.DataSource = dt.ToList();
            comboObject.ValueMember = "idReference";
            comboObject.DisplayMember = "descReference";
        }

        public void cargarListUsats(string valor)
        {
            int num = Convert.ToInt32(valor);
            //string selectQuery = "select descReference from [References] r, [Structure] s where idReferenceType = " + num + "and s.idReferenceFinal = r.idReference";
            //DataTable dt = PortaTaula(selectQuery);

            List<References> query = (from r in db.References// outer sequence
                                      join s in db.Structure //inner sequence 
                                      on r.idReference equals s.idReferenceFinal // key selector 
                                      where r.idReferenceType == num
                                      select r).ToList();

            DataTable dt = new DataTable();
            foreach (var item in query.ToList())
            {
                dt.Rows.Add(item.ToString());
            }

            //listNoUsat.DataSource = dt.ToList();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listUsats.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        public void cargarListNoUsat(string valor)
        {
            var num = short.Parse(valor);
            //string selectQuery = "select r.descReference from [References] r, [Structure] s where r.idReference = s.idReferencePart and s.idReferenceFinal = " + num;
            //DataTable dt = PortaTaula(selectQuery);

            var query = (from r in db.References// outer sequence
                                      join s in db.Structure //inner sequence 
                                      on r.idReference equals s.idReferencePart // key selector 
                                      where s.idReferenceFinal == num
                                      select r).ToList();


            var JoinRefStruct = db.References.Join(db.Structure, refe => refe.idReference, strct => strct.idReferencePart, (refe, strct) => new { Referencia = refe, Structura = strct });

            var lSubElementos = (JoinRefStruct.Where(x => x.Structura.idReferenceFinal == num).Select(x=>x.Referencia.descReference)).ToList();

            //DataTable dt = new DataTable();

            //foreach (var item in query)
            //{
            //    dt.Rows.Add(item.ToString());
            //}
            ////listUsats.DataSource = dt.ToList();

            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    listNoUsat.Items.Add(dt.Rows[i][0].ToString());
            //}
        }
        #endregion Funcions
    }
}
