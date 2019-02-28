using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectionClass;
using System.Configuration;
using System.Reflection;

namespace WookieCodeControls
{
    public partial class sdsForanea : UserControl
    {
        public sdsForanea()
        {
            InitializeComponent();
        }
        private Boolean _Requerit;
        public Boolean Requerit
        {
            get { return _Requerit; }
            set
            {
                _Requerit = value;
            }
        }
        private String _lblCodi;
        public String TextLabel
        {
            get { return _lblCodi; }
            set
            {
                //lblCodi.Text = value;
                _lblCodi = value;
            }

        }

        private String _ControlId;
        public String Control_Id
        {
            get { return _ControlId; }
            set
            {
                _ControlId = value;
            }
        }

        private String _ErrorText;

        public String ErrorText
        {
            get { return _ErrorText; }
            set
            {
                _ErrorText = value;
            }
        }

        private String _Text;

        public override String Text
        {
            get { return _Text; }
            set
            {
                _Text = value;
                InsertaID(value);
            }
        }
        private String _NomTaula;

        public String NomTaula
        {
            get { return _NomTaula; }
            set
            {
                _NomTaula = value;
            }
        }

        private String _NomCamp;
        public String NomCamp
        {
            get { return _NomCamp; }
            set
            {
                _NomCamp = value;
            }
        }

        private String _DescCodi;

        public String DescCodi
        {
            get { return _DescCodi; }
            set
            {
                _DescCodi = value;
            }
        }

        private String _NomID;
        public String NomID
        {
            get { return _NomID; }
            set
            {
                _NomID = value;
            }
        }
        public string _NomControl;
        public string NomControl
        {
            get { return _NomControl; }
            set { _NomControl = value; }
        }
        ////////////////////////////METODES//////////////////////////////////////
        DataSet dts;
        ClassBDD CDB;
        private bool bEsNou = false;
        private void Inicializaciones()
        {
        
        }

        private void InsertaID(string id)
        {
            txtCode.Clear();
            txtShow.Clear();
       
            string query = "select * from " + _NomTaula + " where " + NomID + " = " + id;
            CDB = new ClassBDD();
            dts = CDB.PortaPerConsulta(query);
            if (dts.Tables[0].Rows.Count == 1)
            {
                txtShow.Text = dts.Tables[0].Rows[0][DescCodi].ToString();
                txtCode.Text = dts.Tables[0].Rows[0][NomCamp].ToString();
                string ID = dts.Tables[0].Rows[0][NomID].ToString();
                PossarId(ID);
            }
        }

        private void PossarId(string ID)
        {
            Form frm = this.FindForm();

            foreach (Control c in frm.Controls)
            {
                if (c.Name == Control_Id)
                {
                    c.Text = ID;
                }
            }
        }
        private void txtCode_Validating(object sender, CancelEventArgs e)
        {
            string query = "select * from " + _NomTaula + " where " + _NomCamp + " = " + "'" + txtCode.Text + "'";
            CDB = new ClassBDD();
            dts = CDB.PortaPerConsulta(query);
            if (dts.Tables[0].Rows.Count == 1)
            {
                txtShow.Text = dts.Tables[0].Rows[0][DescCodi].ToString();
                string ID = dts.Tables[0].Rows[0][NomID].ToString();

                PossarId(ID);
                //Form frm = this.FindForm();

                //foreach (Control c in frm.Controls)
                //{
                //    if (c.Name == NomControl)
                //    {
                //        c.Text = ID;
                //    }
                //}
            }
        }

        private void txtCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {                
                Assembly ensamblat = Assembly.LoadFrom("PantallaCerca.dll");                
                Type tipus = ensamblat.GetType("PantallaCerca.Cerca");
                string NomForm = this.FindForm().Name;
                Object[] args = { this.NomTaula, this.Name, NomForm };
                Object dllBD = Activator.CreateInstance(tipus, args);

                ((Form)dllBD).Show();
            }
        }

        
    }
}
