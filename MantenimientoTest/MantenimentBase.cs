using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectionClass;
using SdsTexBox;

namespace MantenimientoBase
{
    /// <summary>
    /// Clase base de la cual hereden todas la clases que necesitan hacer un 
    /// mantenimiento de una tabla de la base de datos
    /// </summary>
    public partial class MantenimentBase : PlantillaPrincipalStarWars.PlantillaForm
    {
        #region Variables Globales
        /// <summary>
        /// Definimos un dataset
        /// </summary>
        DataSet dts;
        /// <summary>
        /// Definimos la ConectionClass
        /// </summary>
        ClassBDD CDB;
        /// <summary>
        /// Boolean que nos indica si estamos haciendo un insert o no
        /// </summary>
        public bool bEsNou = false;
        /// <summary>
        /// Consulta que se va a hacer a la DB
        /// </summary>
        public string query ="Select * from Planets";
        /// <summary>
        /// ID
        /// </summary>
        public string id="idPlanet";
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto de la clase MantenimentBase
        /// </summary>
        public MantenimentBase()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Aqui hacemos todas las instancias que necesitamos, llenamos el DataGridView, y definimos los parametros necesarios
        /// </summary>
        private void Inicializaciones()
        {
            
            CDB = new ClassBDD();
            SdsTexBox.SdsTexBox CSDStxtBox = new SdsTexBox.SdsTexBox();
            dts = CDB.PortaPerConsulta(query);
            RellenarDataGrid(dts);
            dgvMant_table.AllowUserToAddRows = false;
        }
        /// <summary>
        /// Metodo que sirve para rellenar el DataGridView
        /// </summary>
        /// <param name="dataset">Dataset que contiene los datos de la consulta que hemos hecho a la Db</param>
        private void RellenarDataGrid(DataSet dataset)
        {
            dgvMant_table.DataSource = dts.Tables[0];
            this.dgvMant_table.Columns[id].Visible = false;
            BindDades();
        }
        /// <summary>
        /// Con este metodo hacemos que cuando pulsamos un campo del datagrid,
        /// se muestren los datos en los SDSTextBox
        /// </summary>
        private void BindDades()
        {
            foreach (Control sdsControl in this.Controls)
            {
                if (sdsControl is SdsTexBox.SdsTexBox)
                {
                    ((SdsTexBox.SdsTexBox)sdsControl).DataBindings.Clear();
                    ((SdsTexBox.SdsTexBox)sdsControl).DataBindings.Add("Text", dts.Tables[0], ((SdsTexBox.SdsTexBox)sdsControl).ColumnName.ToString());
                    ((SdsTexBox.SdsTexBox)sdsControl).Validated += new EventHandler(Validar);
                }
            }
        }
        /// <summary>
        /// Con este metodo deshacemos que cuando pulsemos un campo en el datagrid 
        /// se muestren los datos en el SDSTextBox
        /// </summary>
        private void QuitarBindDades()
        {
            foreach (Control sdsControl in this.Controls)
            {
                if (sdsControl is SdsTexBox.SdsTexBox)
                {
                    ((SdsTexBox.SdsTexBox)sdsControl).DataBindings.Clear();
                    sdsControl.Text = "";             
                }
            }
        }
        /// <summary>
        /// Añade una fila vacia al DataGridView, para posteriormente poder hacer
        /// el insert
        /// </summary>
        private void AñadirFila()
        {
            string nomCamp = ""; 
            DataRow dr = dts.Tables[0].NewRow();
            foreach (Control sdsControl in this.Controls)
            {
                if (sdsControl is SdsTexBox.SdsTexBox)
                {
                    nomCamp = ((SdsTexBox.SdsTexBox)sdsControl).ColumnName;
                    dr[nomCamp] = sdsControl.Text;
                }
            }
            dts.Tables[0].Rows.Add(dr);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Validar(object sender, EventArgs e)
        {
            if (!bEsNou)
            {
                ((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
            }        
        }
        /// <summary>
        /// Este evento primero comprueba si es un insert y si es este caso insert una 
        /// fila y luego compara la informacion que le pasamos en el dataset con la info 
        /// de la DB y cambia en la DB lo que encuentra diferente en el dataset, y luego
        /// activa los bindings otra vez, y sino hace la comparacion directamente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!bEsNou)
                {
                    CDB.Actualitzar(dts, query);
                }
                else
                {
                    AñadirFila();
                    CDB.Actualitzar(dts, query);
                    BindDades();
                }
                bEsNou = false;
            }
            catch (DBConcurrencyException)
            {
                bEsNou = false;
                BindDades();
            }
        }
        /// <summary>
        /// Este evento quita los bindings y pone el bool EsNou a true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            bEsNou = true;
            QuitarBindDades();
        }
        /// <summary>
        /// Este evento carga las instancias y las partes graficas ejecutando para ello
        /// los metodos Inicializaciones y Actualizar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMant_Table_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            
            Inicializaciones();
            Actualizar();
        }
        /// <summary>
        /// Este metodo se encarga de actualizar algunas partes visuales y algunas partes
        /// del configurationManager
        /// </summary>
        public void Actualizar() {
            ButtonAtras.Visible = true;
            TittleScreen.Text = " Mantenimiento de UserRanks";
            this.Username = ConfigurationManager.AppSettings["UserName"].ToString();
            this.IconUser = ConfigurationManager.AppSettings["Icon"].ToString();
        }

        #endregion
    }
}
