using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WookieTablas
{
    public partial class frmReferenceTypes : Form
    {
        #region Variables Globañes
        GestionDB.XWingsFactoryEntities db;
        IQueryable<GestionDB.ReferenceTypes> _TableReferenceTypes;
        #endregion

        #region Constructores
        public frmReferenceTypes()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void frmReferenceTypes_Load(object sender, EventArgs e)
        {
            Instancias();
            GetInfo();
            FillGrid();
        }
        #endregion

        #region Methods
        private void Instancias()
        {
            db = new GestionDB.XWingsFactoryEntities();
        }
        private void GetInfo()
        {
            _TableReferenceTypes = db.ReferenceTypes.Select(x => x);
        }
        private void FillGrid()
        {
            dGVReferenceTypes.DataSource = _TableReferenceTypes;
        }
        #endregion
    }
}
