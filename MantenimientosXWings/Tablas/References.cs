using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MantenimientosXWings.Tablas
{
    public partial class References : Form
    {
        #region Variables Globales
        GestionDB.XWingsFactoryEntities db;      
        List<GestionDB.References> _TableReferences;
        public bool _bEsNou = false;
        #endregion Variables Globales

        public References()
        {
            InitializeComponent();
        }
        private void Inicializaciones()
        {
            db = new GestionDB.XWingsFactoryEntities();            
            dGVReferences.AllowUserToAddRows = false;
        }
        private void References_Load(object sender, EventArgs e)
        {
            Inicializaciones();
            FillGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            dGVReferences.AllowUserToAddRows = true;
            _bEsNou = true;
        }
        private void FillGrid()
        {
            _TableReferences = db.References.Select(x => x).ToList();
            dGVReferences.DataSource = _TableReferences;
           
            var iTotalColumns = dGVReferences.Columns.Count;
            dGVReferences.Columns[0].Visible = false;

            for (int i = 5; i < iTotalColumns; i++)
            {
                dGVReferences.Columns[i].Visible = false;
            }
            BindDades();
        }
        private void BindDades()
        {
            foreach (Control sdsControl in this.Controls)
            {
                if (sdsControl is SdsTexBox.SdsTexBox)
                {
                    ((SdsTexBox.SdsTexBox)sdsControl).DataBindings.Clear();
                    ((SdsTexBox.SdsTexBox)sdsControl).DataBindings.Add("Text", _TableReferences, ((SdsTexBox.SdsTexBox)sdsControl).ColumnName.ToString());
                    ((SdsTexBox.SdsTexBox)sdsControl).Validated += new EventHandler(Validar);
                }
            }
        }       
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
    }
}
