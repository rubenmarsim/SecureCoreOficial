﻿using System;
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
        List<GestionDB.ReferenceTypes> _TableReferencesTypes;
        public bool _bEsNou = false;
        short _IdForania;
        #endregion Variables Globales

        #region Const
        public References()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void References_Load(object sender, EventArgs e)
        {
            Inicializaciones();
            FillGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_bEsNou)
            {
                var inser = new GestionDB.References
                {
                    codeReference = sdstxtcodeReference.Text,
                    descReference = sdstxtdescReference.Text
                };
                db.References.Add(inser);
                db.SaveChanges();
                FillGrid();
                _bEsNou = false;
            }
            else
            {
                db.SaveChanges();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            dGVReferences.AllowUserToAddRows = true;
            _bEsNou = true;

            QuitarBindDades();
            sdstxtcodeReference.Clear();
            sdstxtdescReference.Clear();
            _bEsNou = true;
        }
        private void cmbBoxIdReferenceType_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cmbBoxIdReferenceType.SelectedValue != null)
            {
                Forania();
            }
        }
        private void dGVReferences_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (sdstxBoxIdReferenceType.Text.Equals("1"))
            {
                cmbBoxIdReferenceType.SelectedIndex = 0;
            }else if (sdstxBoxIdReferenceType.Text.Equals("2"))
            {
                cmbBoxIdReferenceType.SelectedIndex = 1;
            }
            else if (sdstxBoxIdReferenceType.Text.Equals("3"))
            {
                cmbBoxIdReferenceType.SelectedIndex = 2;
            }
        }
        #endregion Events

        #region Methods
        private void Inicializaciones()
        {
            db = new GestionDB.XWingsFactoryEntities();
            dGVReferences.AllowUserToAddRows = false;
        }
        private void FillGrid()
        {
            _TableReferences = db.References.Select(x => x).ToList();
            _TableReferencesTypes = db.ReferenceTypes.Select(x => x).ToList();
            var a = _TableReferencesTypes.Select(x => x.codeReferenceType);
            cmbBoxIdReferenceType.DataSource = _TableReferencesTypes.Select(x => x.codeReferenceType).ToList();
            dGVReferences.DataSource = _TableReferences; 
            var iTotalColumns = dGVReferences.Columns.Count;
            dGVReferences.Columns[0].Visible = false;

            for (int i = 5; i < iTotalColumns; i++)
            {
                dGVReferences.Columns[i].Visible = false;
            }
            BindDades();
        }
        private void Forania()
        {
            sdstxBoxIdReferenceType.Text = _TableReferencesTypes.Where(x=>x.codeReferenceType.Equals(cmbBoxIdReferenceType.SelectedValue.ToString())).Select(x => x.idReferenceType).First().ToString();
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

        #endregion Methods

        
    }
}
