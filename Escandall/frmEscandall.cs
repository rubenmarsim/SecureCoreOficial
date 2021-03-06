﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escandall
{
    /// <summary>
    /// Formulario que muestra el escandall mediante un treeview
    /// </summary>
    public partial class frmEscandall : Form
    {
        #region Variables Globales
        GestionDB.XWingsFactoryEntities db;
        List<string> _lstFinalProducts;
        List<GestionDB.References> _lstMiddleProducts;
        List<GestionDB.References> _lstRawMaterials;
        List<string> _lstProductsAla;
        List<string> _lstProductsMotor;
        List<string> _lstProductsCabina;
        List<string> _lstProductsMorro;
        string _NamePhoto;
        string _NameVideo;
        /// <summary>
        /// Definicion de cada id del campo idRederenceType
        /// </summary>
        enum eReferenceTypes
        {
            FinalProducts = 1,
            MiddleProducts = 2,
            RawMaterials = 3,
        }
        enum eIdReference
        {
            Ala = 19,
            Motor = 22,
            Cabina = 23,
            Morro = 24
        }
        enum MiddleProductsInTreeView
        {
            Ala,
            Motor,
            Cabina,
            Morro
        }

        #endregion

        #region Constructores
        public frmEscandall()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void frmEscandall_Load(object sender, EventArgs e)
        {
            db = new GestionDB.XWingsFactoryEntities();
            GetData();
            LoadData();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            treeViewEscandall.Nodes.Clear();
            GetData();
            LoadData();
        }
        private void treeViewEscandall_AfterSelect(object sender, TreeViewEventArgs e)
        {
            GetMediaData();
            FillMedia();
        }
        #endregion Events

        #region Methods
        /// <summary>
        /// Cogemos la info que queremos de la DB y la guardamos en variables
        /// </summary>
        private void GetData()
        {
            try
            {
                _lstFinalProducts = db.References.Where(x => x.idReferenceType == (short)eReferenceTypes.FinalProducts).Select(x => x.descReference).ToList();
                _lstMiddleProducts = db.References.Where(x => x.idReferenceType == (short)eReferenceTypes.MiddleProducts).Select(x => x).ToList();
                _lstRawMaterials = db.References.Where(x => x.idReferenceType == (short)eReferenceTypes.RawMaterials).Select(x => x).ToList();
                var JoinRefStruct = db.References.Join(db.Structure, refe => refe.idReference, strct => strct.idReferencePart, (refe, strct) => new { Referencia = refe, Structura = strct });
                _lstProductsAla = JoinRefStruct.Where(x => x.Structura.idReferenceFinal == (short)eIdReference.Ala).Select(x => x.Referencia.descReference).ToList();
                _lstProductsMotor = JoinRefStruct.Where(x => x.Structura.idReferenceFinal == (short)eIdReference.Motor).Select(x => x.Referencia.descReference).ToList();
                _lstProductsCabina = JoinRefStruct.Where(x => x.Structura.idReferenceFinal == (short)eIdReference.Cabina).Select(x => x.Referencia.descReference).ToList();
                _lstProductsMorro = JoinRefStruct.Where(x => x.Structura.idReferenceFinal == (short)eIdReference.Morro).Select(x => x.Referencia.descReference).ToList();
            }
            catch (Exception Ge)
            {
                MessageBox.Show(Ge.Message);
            }            
        }
        /// <summary>
        /// Filtramos la info y la ponemos en el treeview
        /// </summary>
        private void LoadData()
        {
            try
            {
                //--- Productos Principales ---------------------------------------------
                foreach (var FinalProd in _lstFinalProducts) treeViewEscandall.Nodes.Add(FinalProd);
                //--- Productos intermedios y materia prima -----------------------------
                foreach (var middleProd in _lstMiddleProducts)
                {
                    treeViewEscandall.Nodes[0].Nodes.Add(middleProd.descReference);

                    if (middleProd.idReference == (short)eIdReference.Ala)
                    {
                        foreach (var ProductAla in _lstProductsAla)
                        {
                            treeViewEscandall.Nodes[0].Nodes[(int)MiddleProductsInTreeView.Ala].Nodes.Add(ProductAla);
                        }
                    }
                    else if (middleProd.idReference == (short)eIdReference.Motor)
                    {
                        foreach (var ProductMotor in _lstProductsMotor)
                        {
                            treeViewEscandall.Nodes[0].Nodes[(int)MiddleProductsInTreeView.Motor].Nodes.Add(ProductMotor);
                        }
                    }
                    else if (middleProd.idReference == (short)eIdReference.Cabina)
                    {
                        foreach (var ProductCabina in _lstProductsCabina)
                        {
                            treeViewEscandall.Nodes[0].Nodes[(int)MiddleProductsInTreeView.Cabina].Nodes.Add(ProductCabina);
                        }
                    }
                    else if (middleProd.idReference == (short)eIdReference.Morro)
                    {
                        foreach (var ProductMorro in _lstProductsMorro)
                        {
                            treeViewEscandall.Nodes[0].Nodes[(int)MiddleProductsInTreeView.Morro].Nodes.Add(ProductMorro);
                        }
                    }
                }
            }
            catch (Exception Ge)
            {
                MessageBox.Show(Ge.Message);
            }            
        }
        /// <summary>
        /// Cogemos unicamente los nombres de la photo y del video teniendo en cuenta 
        /// el campo que esta seleccionado en el treeview
        /// </summary>
        private void GetMediaData()
        {
            try
            {
                var slctedNode = treeViewEscandall.SelectedNode.Text;
                _NamePhoto = db.References.Where(x => x.descReference.Equals(slctedNode)).Select(x => x.Photo).ToList().First();
                _NameVideo = db.References.Where(x => x.descReference.Equals(slctedNode)).Select(x => x.VideoExplode).ToList().First();
            }
            catch (Exception Ge)
            {
                MessageBox.Show(Ge.Message);
            }
            
        }
        private void FillMedia()
        {
            try
            {
                var ResourcesPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).Replace("\\", "/") + "/Resources/";
                if (!string.IsNullOrEmpty(_NamePhoto))
                {
                    picBoxEscandall.ImageLocation = ResourcesPath + _NamePhoto;
                    picBoxEscandall.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                if (!string.IsNullOrEmpty(_NameVideo))
                {
                    WMPEscandall.URL = ResourcesPath + _NameVideo;
                }
            }
            catch (Exception Ge)
            {
                MessageBox.Show(Ge.Message);
            }
                       
        }
        #endregion Methods

        
    }
}
