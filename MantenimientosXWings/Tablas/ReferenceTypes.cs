using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MantenimientosXWings
{
    public partial class ReferenceTypes : Form
    {
        #region Variables Globales
        GestionDB.XWingsFactoryEntities db;
        SdsTexBox.SdsTexBox _CSDStxtBox;
        /// <summary>
        /// Boolean que nos indica si estamos haciendo un insert o no
        /// </summary>
        public bool _bEsNou = false;
        #endregion

        #region Constructores
        public ReferenceTypes()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void ReferenceTypes_Load(object sender, EventArgs e)
        {
            Inicializaciones();
            FillGrid();
        }
        #endregion

        #region Methods
        private void Inicializaciones()
        {
            db = new GestionDB.XWingsFactoryEntities();
            _CSDStxtBox = new SdsTexBox.SdsTexBox();
            dGVReferenceTypes.AllowUserToAddRows = false;
        }
        private void FillGrid()
        {
            var TableReferenceTypes = db.ReferenceTypes.Select(x => new { x.codeReferenceType, x.descReferenceType });
            var a = TableReferenceTypes.Select
            dGVReferenceTypes.DataSource = TableReferenceTypes;
            //BindDades();
        }
        /// <summary>
        /// Con este metodo hacemos que cuando pulsamos un campo del datagrid,
        /// se muestren los datos en los SDSTextBox
        /// </summary>
        private void BindDades(string lstRefTypes)
        {
            foreach (Control sdsControl in this.Controls)
            {
                if (sdsControl is SdsTexBox.SdsTexBox)
                {
                    ((SdsTexBox.SdsTexBox)sdsControl).DataBindings.Clear();
                    //((SdsTexBox.SdsTexBox)sdsControl).DataBindings.Add("Text", TableReferenceTypes.Select(x=>x), ((SdsTexBox.SdsTexBox)sdsControl).ColumnName.ToString());
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

        public void Validar(object sender, EventArgs e)
        {
            if (!_bEsNou)
            {
                ((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
            }
        }
        #endregion
    }
}
