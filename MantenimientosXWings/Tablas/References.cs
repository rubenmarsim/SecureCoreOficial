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
        SdsTexBox.SdsTexBox _CSDStxtBox;
        List<GestionDB.ReferenceTypes> _TableReferenceTypes;
        #endregion Variables Globales

        public References()
        {
            InitializeComponent();
        }
    }
}
