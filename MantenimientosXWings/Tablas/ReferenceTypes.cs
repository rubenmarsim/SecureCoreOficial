﻿using System;
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
        List<GestionDB.ReferenceTypes> _TableReferenceTypes;
        /// <summary>
        /// Boolean que nos indica si estamos haciendo un insert o no
        /// </summary>
        public bool _bEsNou = false;
        #endregion Variables Globales

        #region Constructores
        public ReferenceTypes()
        {
            InitializeComponent();
        }
        #endregion Constructores

        #region Events
        private void ReferenceTypes_Load(object sender, EventArgs e)
        {
            try
            {
                Inicializaciones();
                FillGrid();
            }
            catch (Exception Ge)
            {
                MessageBox.Show(Ge.Message);
            }
            
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_bEsNou)
                {
                    var inser = new GestionDB.ReferenceTypes
                    {
                        codeReferenceType = sdsTexBoxcodeReference.Text,
                        descReferenceType = sdsTexBoxdescReference.Text
                    };
                    db.ReferenceTypes.Add(inser);
                    db.SaveChanges();
                    FillGrid();
                    _bEsNou = false;
                }
                else
                {
                    db.SaveChanges();
                }
            }
            catch (Exception Ge)
            {
                MessageBox.Show(Ge.Message);
            }
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                QuitarBindDades();
                sdsTexBoxcodeReference.Clear();
                sdsTexBoxdescReference.Clear();
                _bEsNou = true;
            }
            catch (Exception Ge)
            {
                MessageBox.Show(Ge.Message);
            }
            
        }
        #endregion Events

        #region Methods
        private void Inicializaciones()
        {
            db = new GestionDB.XWingsFactoryEntities();
            _CSDStxtBox = new SdsTexBox.SdsTexBox();
            dGVReferenceTypes.AllowUserToAddRows = false;
        }
        private void FillGrid()
        {
            _TableReferenceTypes = db.ReferenceTypes.Select(x => x).ToList();
            dGVReferenceTypes.DataSource = _TableReferenceTypes;
            dGVReferenceTypes.Columns[0].Visible = false;
            dGVReferenceTypes.Columns[3].Visible = false;
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
                    ((SdsTexBox.SdsTexBox)sdsControl).DataBindings.Add("Text", _TableReferenceTypes, ((SdsTexBox.SdsTexBox)sdsControl).ColumnName.ToString());
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
        #endregion Methods
    }
}
