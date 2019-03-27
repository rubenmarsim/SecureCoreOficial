using MantenimientosXWings.Tablas;
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
    public partial class frmMantenimientoXWings : Form
    {
        #region Variables Globales
        ReferenceTypes _ReferenceTypes;
        References _References;

        #endregion

        #region Constructores
        public frmMantenimientoXWings()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void frmMantenimientoXWings_Load(object sender, EventArgs e)
        {
            Instancias();
        }

        private void btnReferenceTypes_Click(object sender, EventArgs e)
        {
            Instancias();
            _ReferenceTypes.Show();
        }
        private void btnReferences_Click(object sender, EventArgs e)
        {
            Instancias();
            _References.Show();
        }
        #endregion

        #region Methods
        private void Instancias()
        {
            _ReferenceTypes = new ReferenceTypes();
            _References = new References();
        }
        #endregion
    }
}
