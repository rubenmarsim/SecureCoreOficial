using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace GestionXML
{
    /// <summary>
    /// Formulario que crea el archivo XML a partir de la base de datos
    /// </summary>
    public partial class frmXML : Form
    {
        #region Variables Globales        
        ConnectionClass.ClassBDD db;
        DataSet dts;
        string _sResourcesPath;
        enum eTablas
        {
            Routes,
            DefinedRoutes,
            Filiations,
            Regions,
            Planets
        }
        #region Constantes        
        const string _cHyperSpaceData = "hyperSpacedata";
        const string _cHyperSpaceRoutes = "hyperspaceRoutes";
        #region Singulares
        const string _cTableNameRoute = "Route";
        const string _cTableNameDefinedRoute = "DefinedRoute";
        const string _cTableNameFiliation = "Filiation";
        const string _cTableNameRegion = "Region";
        const string _cTableNamePlanet = "Planet";
        #endregion Singulares
        #region Plurales
        const string _cTableNameRoutes = "Routes";
        const string _cTableNameDefinedRoutes = "DefinedRoutes";
        const string _cTableNameFiliations = "Filiations";
        const string _cTableNameRegions = "Regions";
        const string _cTableNamePlanets = "Planets";
        #endregion Plurales
        #endregion Constantes
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
        /// <summary>
        /// Se ejecuta cuando carga el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmXML_Load(object sender, EventArgs e)
        {
            db = new ConnectionClass.ClassBDD();
            _sResourcesPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).Replace("\\", "/") + "/Resources/";
        }
        /// <summary>
        /// Se ejecuta cuando pulsamos el boton de crear el XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateXML_Click(object sender, EventArgs e)
        {
            try
            {
                GetTablas();
                GetInfo();
                WriteXML();

                MessageBox.Show("XML generat correctament.");
            }
            catch (Exception Ge)
            {
                MessageBox.Show(Ge.Message);
            }            
        }
        #endregion Events

        #region Methods
        /// <summary>
        /// Cogemos todas las tablas necesarias de la DB
        /// </summary>
        private void GetTablas()
        {
            SqlConnection con = new SqlConnection("Data Source=wookie-code.database.windows.net;Initial Catalog=SecureCore;User ID=Wookie;Password=123456789aA");
            dts = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter("select * from "+_cTableNameRoutes+ "; select * from " + _cTableNameDefinedRoutes + "; select * from " + _cTableNameFiliations + "; select * from " + _cTableNameRegions + "; select * from " + _cTableNamePlanets, con);
            adapter.TableMappings.Add(_cTableNameRoutes, _cTableNameRoute);
            adapter.TableMappings.Add(_cTableNameDefinedRoutes, _cTableNameDefinedRoute);
            adapter.TableMappings.Add(_cTableNameFiliations, _cTableNameFiliation);
            adapter.TableMappings.Add(_cTableNameRegions, _cTableNameRegion);
            adapter.TableMappings.Add(_cTableNamePlanets, _cTableNamePlanet);
            adapter.Fill(dts);

            dts.DataSetName = _cHyperSpaceData;
            for(int i = 0; i < dts.Tables.Count; i++)
                dts.Tables[i].TableName = adapter.TableMappings[i].DataSetTable;
        }
        /// <summary>
        /// Metodo antiguo usado para escribir el dataset a pelo en el XML
        /// </summary>
        private void WriteXML_OLD()
        {
            try
            {
                dts.WriteXml(_sResourcesPath + "DBTables.xml");
            }
            catch (Exception Ge)
            {
                MessageBox.Show(Ge.Message);
            }            
        }
        /// <summary>
        /// Hace los joins y demas para recoger toda la info como queremos
        /// </summary>
        private void GetInfo()
        {

        }
        /// <summary>
        /// Escribe el XML estructurado y formateado
        /// </summary>
        private void WriteXML()
        {
            XElement xmlTree = new XElement(dts.DataSetName, 
                                    new XElement(_cHyperSpaceRoutes, dts.Tables[0].AsEnumerable().Select(t=>
                                        new XElement(_cTableNameRoute,
                                            new XElement(dts.Tables[(int)eTablas.Routes].Columns[1].ColumnName, t[dts.Tables[(int)eTablas.Routes].Columns[1].ColumnName]),
                                            new XElement(dts.Tables[(int)eTablas.Routes].Columns[2].ColumnName, t[dts.Tables[(int)eTablas.Routes].Columns[2].ColumnName])                        
                                        )
                                    ))
                                );

            xmlTree.Save(_sResourcesPath + "Test.xml");
        }
        #endregion Methods
    }
}
