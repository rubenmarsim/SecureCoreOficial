using MantenimientoBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PantallaCerca
{
    public partial class Cerca : Form
    {
        private string _TableName;

        public string TableName
        {
            get { return _TableName; }
            set { _TableName = value; }
        }

        private string _ControlName;

        public string ControlName
        {
            get { return _ControlName; }
            set { _ControlName = value; }
        }
        private string _NomFomr;

        public string NomFomr
        {
            get { return _NomFomr; }
            set { _NomFomr = value; }
        }

        public Cerca()
        {
            InitializeComponent();
        }

        public Cerca(string TableName, string ControlName, string NomFomr)
        {
            InitializeComponent();

            this.TableName = TableName;
            this.ControlName = ControlName;
            this.NomFomr = NomFomr;
        }
        #region Variables
        //Creamos el dataset
        DataSet dts;
        //Instanciamos la ConnectionClass
        ConnectionClass.ClassBDD BDD = new ConnectionClass.ClassBDD();
        //Hacemos la consulta
        public string query;

        #endregion

        #region Metodos
        public void Inicializar()
        {
            query = "select * from " + TableName;
            dts = BDD.PortaPerConsulta(query);
        }
        public void RellenarGrid(DataSet dts)
        {
            dGVCerca.DataSource = dts.Tables[0];
            dGVCerca.Columns[0].Visible = false;
        }
        public void Bindings()
        {

        }
        #endregion

        #region Eventos
        private void Cerca_Load(object sender, EventArgs e)
        {
            //al cargar utilice el metodo RellenarGrid
            Inicializar();
            RellenarGrid(dts);
            dGVCerca.AllowUserToAddRows = false;
        }

        #endregion

        private void dGVCerca_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name==NomFomr)
                    {
                        foreach (Control frmControl in frm.Controls)
                        {
                            if (frmControl.Name == ControlName)
                            {
                                try
                                {
                                    ((WookieCodeControls.sdsForanea)frmControl).Text = dGVCerca.SelectedCells[0].Value.ToString();
                                    
                                }
                                catch
                                {
                                    MessageBox.Show("ERROR DE DADES");
                                }

                            }
                        }
                    }
                    
                }


                //MessageBox.Show(dGVCerca.SelectedCells[0].Value.ToString());

                    //Assembly ensamblat = Assembly.LoadFrom("SdsTexBox.dll");
                    //Type tipus = ensamblat.GetType("SdsTexBox.SdsTexBox");
                    //Object[] args = { this.dGVCerca.SelectedCells[0].Value.ToString()};
                    //Object dllBD = Activator.CreateInstance(tipus, args);
            }
            catch
            {
                MessageBox.Show("Selecciona toda la linea.");
            }
            this.Close();
        }
    }
}
