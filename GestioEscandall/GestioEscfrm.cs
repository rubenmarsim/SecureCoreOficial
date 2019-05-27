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
    /// <summary>
    /// Clase/Form para la gestion del escandall
    /// </summary>
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
        /// <summary>
        /// Mensaje para cuando hacemos una accion que requiere hacer alguna seleccion previamente
        /// </summary>
        string _SelectionErrorMessage = "Selecciona un elemento!";
        /// <summary>
        /// Id del valor seleccionado en el combo de las partes
        /// </summary>
        string _valComboPart = string.Empty;
        /// <summary>
        /// Id del valor seleccionado en el combo de las partes
        /// </summary>
        string _valComboObject = string.Empty;
        /// <summary>
        /// Lista de todos los subElementos del objeto
        /// </summary>
        IQueryable<References> _lSubElementos;

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
                _valComboPart = this.comboPart.GetItemText(this.comboPart.SelectedValue);

                CargarComboObject(_valComboPart);
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
                _valComboObject = this.comboObject.GetItemText(this.comboObject.SelectedValue);

                if (!string.IsNullOrEmpty(_valComboObject))
                {
                    CargarListBoxs();
                }
            }
        }        

        /// <summary>
        /// Cuando pulsamos el boton para pasar un campo de 
        /// izquierda --> derecha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnUsedToUsed_Click(object sender, EventArgs e)
        {
            try
            {
                listUsats.Items.Add(listNoUsat.SelectedItem);
                listNoUsat.Items.Remove(listNoUsat.SelectedItem);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show(_SelectionErrorMessage);
            }
        }

        /// <summary>
        /// Cuando pulsamos el boton para pasar un campo de 
        /// derecha --> izquierda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUsedToUnUsed_Click(object sender, EventArgs e)
        {
            try
            {
                listNoUsat.Items.Add(listUsats.SelectedItem);
                listUsats.Items.Remove(listUsats.SelectedItem);

            }
            catch (ArgumentNullException)
            {
                MessageBox.Show(_SelectionErrorMessage);
            }            
        }

        #region DRAG & DROP

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
            try
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
            catch(ArgumentOutOfRangeException AOoRE)
            {
                MessageBox.Show(AOoRE.Message);
                CargarListBoxs();
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

        #endregion DRAG & DROP

        /// <summary>
        /// Cuando pulsamos el boton update, este sirve para guardar los elementos del los 
        /// listbox en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SavelstBoxToDB();

            CargarListBoxs();
        }

        #endregion Events

        #region Methods

        /// <summary>
        /// Carga el comboBox de las partes principales e intermedias
        /// </summary>
        private void CargarComboPart()
        {
            try
            {
                var FilteredtReferenceTypes = from r in db.ReferenceTypes
                                              where r.idReferenceType == 1 || r.idReferenceType == 2
                                              select r;

                comboPart.DataSource = FilteredtReferenceTypes.ToList();
                comboPart.ValueMember = "idReferenceType";
                comboPart.DisplayMember = "descReferenceType";
            }
            catch (Exception Ge)
            {
                MessageBox.Show(Ge.Message);
            }            
        }

        /// <summary>
        /// Carga el ComboBox de los Elementos segun la parte
        /// </summary>
        /// <param name="valor"></param>
        private void CargarComboObject(string valor)
        {
            try
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
            catch (Exception Ge)
            {
                MessageBox.Show(Ge.Message);
            }            
        }        

        /// <summary>
        /// Carga los elementos usados y no usados en sus respectivos listBox
        /// </summary>
        /// <param name="valor"></param>
        private void CargarListBoxs()
        {
            try
            {
                LimpiarListBoxs();
                var num = short.Parse(_valComboObject);

                var JoinRefStruct = db.References.Join(db.Structure, refe => refe.idReference, strct => strct.idReferencePart, (refe, strct) => new { Referencia = refe, Structura = strct });

                _lSubElementos = JoinRefStruct.Where(x => x.Structura.idReferenceFinal == num).Select(x => x.Referencia);

                var lSubElemNoUsados = (JoinRefStruct.Where(x => x.Structura.idReferenceFinal == num && x.Referencia.IsUsed == false).Select(x => x.Referencia.descReference)).ToList();
                var lSubElemUsados = (JoinRefStruct.Where(x => x.Structura.idReferenceFinal == num && x.Referencia.IsUsed == true).Select(x => x.Referencia.descReference)).ToList();

                foreach (var subElem in lSubElemNoUsados) listNoUsat.Items.Add(subElem);
                foreach (var subElem in lSubElemUsados) listUsats.Items.Add(subElem);
            }
            catch (Exception Ge)
            {
                MessageBox.Show(Ge.Message);
            }            
        }
        /// <summary>
        /// Comprueba los cambios de los listbox y los sube a la base de datos.
        /// </summary>
        private void SavelstBoxToDB()
        {
            try
            {
                foreach (var SubElem in _lSubElementos)
                {
                    if (listNoUsat.Items.Contains(SubElem.descReference))
                    {
                        SubElem.IsUsed = false;
                    }
                    else if (listUsats.Items.Contains(SubElem.descReference))
                    {
                        SubElem.IsUsed = true;
                    }
                }
                db.SaveChanges();
                CargarListBoxs();
                MessageBox.Show("Update Correcte!");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        /// <summary>
        /// Limpiamos todso los items de los dos ListBoxs
        /// </summary>
        private void LimpiarListBoxs()
        {
            try
            {
                listUsats.Items.Clear();
                listNoUsat.Items.Clear();
            }
            catch (Exception Ge)
            {
                MessageBox.Show(Ge.Message);
            }            
        }

        #endregion Methods        
    }
}
