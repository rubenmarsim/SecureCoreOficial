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
        /// <summary>
        /// Determina si es la primera vez que pulsamos en el combobox
        /// (Se usa para los 2 combos)
        /// </summary>
        bool _IsFirstTime = true;
        /// <summary>
        /// Conexion al Entity Framework
        /// </summary>
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
        /// <summary>
        /// Cuando carga el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GestioEscfrm_Load(object sender, EventArgs e)
        {
            db = new XWingsFactoryEntities();
            CargarComboPart();
        }

        /// <summary>
        /// Cuando pulsamos en el comboBox de las partes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboPart_Click(object sender, EventArgs e)
        {
            _IsFirstTime = false;
        }

        /// <summary>
        /// Cuando pulsamos en el comboBox de los elementos/objetos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboObject_Click(object sender, EventArgs e)
        {
            _IsFirstTime = false;
        }

        /// <summary>
        /// Cuando seleccionamos otro campo en el comboBox de las partes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboPart_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!_IsFirstTime)
            {
                string valComboPart = this.comboPart.GetItemText(this.comboPart.SelectedValue);

                CargarComboObject(valComboPart);
            }
        }

        /// <summary>
        /// Cuando seleccionamos otro campo en el combo de los elementos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboObject_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!_IsFirstTime)
            {
                string valComboObject = this.comboObject.GetItemText(this.comboObject.SelectedValue);

                if (!string.IsNullOrEmpty(valComboObject))
                {
                    CargarListViews(valComboObject);
                }
            }
        }

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

        /// <summary>
        /// Cuando pulsamos el boton para pasar un campo de 
        /// izquierda --> derecha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDerecha_Click(object sender, EventArgs e)
        {
            if (listUsats.SelectedIndex != -1)
            {
                listNoUsat.Items.Add(listUsats.SelectedItem);
                listUsats.Items.Remove(listUsats.SelectedItem);
            }
        }

        /// <summary>
        /// Cuando pulsamos el boton para pasar un campo de 
        /// derecha --> izquierda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            if (listNoUsat.SelectedIndex != -1)
            {
                listUsats.Items.Add(listNoUsat.SelectedItem);
                listNoUsat.Items.Remove(listNoUsat.SelectedItem);
            }
        }
        
        #endregion Events

        #region Methods

        #region Miralles
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

        #endregion Miralles

        /// <summary>
        /// Carga el comboBox de las partes principales e intermedias
        /// </summary>
        private void CargarComboPart()
        {            
            var FilteredtReferenceTypes = from r in db.ReferenceTypes
                     where r.idReferenceType == 1 || r.idReferenceType == 2
                     select r;

            comboPart.DataSource = FilteredtReferenceTypes.ToList();
            comboPart.ValueMember = "idReferenceType";
            comboPart.DisplayMember = "descReferenceType";
        }

        /// <summary>
        /// Carga el ComboBox de los Elementos segun la parte
        /// </summary>
        /// <param name="valor"></param>
        private void CargarComboObject(string valor)
        {
            int num = Convert.ToInt32(valor);
            var dt = from r in db.References// outer sequence
                     join rt in db.ReferenceTypes //inner sequence 
                     on r.idReferenceType equals rt.idReferenceType // key selector 
                     where r.idReferenceType == num
                     select r;

            comboObject.DataSource = dt.ToList();
            comboObject.ValueMember = "idReference";
            comboObject.DisplayMember = "descReference";
        }        

        /// <summary>
        /// Carga los elementos usados y no usados en sus respectivos listBox
        /// </summary>
        /// <param name="valor"></param>
        private void CargarListViews(string valor)
        {
            var num = short.Parse(valor);
            
            var JoinRefStruct = db.References.Join(db.Structure, refe => refe.idReference, strct => strct.idReferencePart, (refe, strct) => new { Referencia = refe, Structura = strct });

            //var lSubElementos = (JoinRefStruct.Where(x => x.Structura.idReferenceFinal == num).Select(x=>x.Referencia.descReference)).ToList();

            var lSubElemNoUsados = (JoinRefStruct.Where(x => x.Structura.idReferenceFinal == num && x.Referencia.IsUsed == false).Select(x => x.Referencia.descReference)).ToList();

            var lSubElemUsados = (JoinRefStruct.Where(x => x.Structura.idReferenceFinal == num && x.Referencia.IsUsed == true).Select(x => x.Referencia.descReference)).ToList();

            listNoUsat.DataSource = lSubElemNoUsados;
            listUsats.DataSource = lSubElemUsados;        
        }

        /// <summary>
        /// Limpiamos todso los items de los dos ListBoxs
        /// </summary>
        private void LimpiarListBoxs()
        {
            listUsats.Items.Clear();
            listNoUsat.Items.Clear();
        }

        #endregion Methods

        
    }
}
