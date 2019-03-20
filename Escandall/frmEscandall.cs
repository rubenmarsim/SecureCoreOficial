using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escandall
{
    public partial class frmEscandall : Form
    {
        #region Variables Globales
        GestionDB.XWingsFactoryEntities db;
        List<string> _lstFinalProducts;
        List<string> _lstMiddleProducts;
        List<GestionDB.References> _lstRawMaterials;
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
            CanExecute();
        }

        private void btnPadre_Click(object sender, EventArgs e)
        {
                treeViewEscandall.Nodes.Add(txtBoxAddCampo.Text);
                txtBoxAddCampo.Clear();            
        }

        private void btnHijo_Click(object sender, EventArgs e)
        {
            try
            {
                treeViewEscandall.SelectedNode.Nodes.Add(txtBoxAddCampo.Text);
                txtBoxAddCampo.Clear();
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Selecciona un padre para poder crear el hijo anidado a este.");
            }
        }

        private void btnBorrarCampo_Click(object sender, EventArgs e)
        {
            try
            {
                treeViewEscandall.Nodes.Remove(treeViewEscandall.SelectedNode);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Selecciona el campo que quieres borrar");
            }
            
        }

        private void btnBorrarArbol_Click(object sender, EventArgs e)
        {
            treeViewEscandall.Nodes.Clear();
        }
        private void txtBoxAddCampo_TextChanged(object sender, EventArgs e)
        {
            CanExecute();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Comprueba si el textbox esta vacio o no y activa los 
        /// botones de crear en funcion de eso
        /// </summary>
        private void CanExecute()
        {
            if (string.IsNullOrEmpty(txtBoxAddCampo.Text))
            {
                btnPadre.Enabled = false;
                btnHijo.Enabled = false;
            }
            else
            {
                btnPadre.Enabled = true;
                btnHijo.Enabled = true;
            }
        }

        private void GetData()
        {
            _lstFinalProducts = db.References.Where(x => x.idReferenceType == (short)eReferenceTypes.FinalProducts).Select(x => x.descReference).ToList();
            _lstMiddleProducts = db.References.Where(x => x.idReferenceType == (short)eReferenceTypes.MiddleProducts).Select(x => x.descReference).ToList();
            _lstRawMaterials = db.References.Where(x => x.idReferenceType == (short)eReferenceTypes.RawMaterials).Select(x => x).ToList();
        }
        private void LoadData()
        {
            //--- Productos Principales ---------------------------------------------
            treeViewEscandall.Nodes.Add(_lstFinalProducts[0]);
            //--- Productos intermedios y materia prima -----------------------------
            foreach(var middleProd in _lstMiddleProducts)
            {
                treeViewEscandall.Nodes[0].Nodes.Add(middleProd);

                foreach(var RawProd in _lstRawMaterials)
                {
                    if(RawProd.idReference == (short)eIdReference.Ala)
                        treeViewEscandall.Nodes[0].Nodes[0].Nodes.Add(RawProd.descReference);
                    else if(RawProd.idReference == (short)eIdReference.Motor)
                        treeViewEscandall.Nodes[0].Nodes[1].Nodes.Add(RawProd.descReference);
                    else if (RawProd.idReference == (short)eIdReference.Cabina)
                        treeViewEscandall.Nodes[0].Nodes[2].Nodes.Add(RawProd.descReference);
                    else if (RawProd.idReference == (short)eIdReference.Morro)
                        treeViewEscandall.Nodes[0].Nodes[3].Nodes.Add(RawProd.descReference);
                }                
            }
        }
        #endregion


    }
}
