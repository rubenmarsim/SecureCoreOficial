using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionXML
{
    /// <summary>
    /// Formulario que crea el archivo XML a partir de la base de datos
    /// </summary>
    public partial class frmXML : Form
    {
        #region Variables Globales        
        GestionDB.SecureCoreDataSet db;
        List<object> lTables;
        #endregion Variables Globales

        #region Constructores
        /// <summary>
        /// Constructor predeterminado
        /// </summary>
        public frmXML()
        {
            InitializeComponent();
        }
        #endregion Constructores

        #region Events
        private void frmXML_Load(object sender, EventArgs e)
        {            
            db = new GestionDB.SecureCoreDataSet();
        }
        private void btnCreateXML_Click(object sender, EventArgs e)
        {
            GetTablas();
        }
        #endregion Events

        #region Methods
        private void GetTablas()
        {
            var a = db;
            lTables = new List<object>();
            lTables.Add(db.Routes.ToList());
            lTables.Add(db.DefinedRoutes.ToList());
            lTables.Add(db.Filiations.ToList());
            lTables.Add(db.Regions.ToList());
            lTables.Add(db.Planets.ToList());
        }
        #endregion Methods
    }
}
