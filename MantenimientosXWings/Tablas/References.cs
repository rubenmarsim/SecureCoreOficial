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
            //BindDades();
        }        
    }
}