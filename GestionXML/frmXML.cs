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
            
        }
        object _oRoutes;
        #region Constantes        
        const string _cHyperSpaceData = "hyperSpacedata";
        const string _cHyperSpaceRoutes = "hyperspaceRoutes";
        #region Singulares
        const string _cTableNameRoute = "Route";
        const string _cTableNameDefinedRoute = "DefinedRoute";
        const string _cTableNamePlanetRoutes = "PlanetRoutes";
        const string _cTableNameRouteTypes = "RouteTypes";
        const string _cTableNameFiliation = "Filiation";
        const string _cTableNameRegion = "Region";
        const string _cTableNamePlanet = "Planet";
        #endregion Singulares
        #region Plurales
        const string _cTableNameRoutes = "Routes";
        const string _cTableNameDefinedRoutes = "DefinedRoutes";
        const string _cTableNamePlanetRoute = "PlanetRoute";
        const string _cTableNameRouteType = "RouteType";
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
                //GetInfo();
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

            SqlDataAdapter adapter = new SqlDataAdapter("select * from ViewJoinRoutes", con);
            adapter.TableMappings.Add(_cTableNameRoutes, _cTableNameRoute);
            adapter.Fill(dts);

            dts.DataSetName = _cHyperSpaceData;
            for(int i = 0; i < dts.Tables.Count; i++)
                dts.Tables[i].TableName = adapter.TableMappings[i].DataSetTable;
        }
        /// <summary>
        /// Escribe el XML estructurado y formateado
        /// </summary>
        private void WriteXML()
        {
            XElement xmlTree = new XElement(dts.DataSetName,
                                    new XElement(_cHyperSpaceRoutes, dts.Tables[0].AsEnumerable().Select(t =>
                                        new XElement(_cTableNameRoute,
                                            new XElement("type", t[dts.Tables[(int)eTablas.Routes].Columns[0].ColumnName]),
                                            new XElement("nameRoute", t[dts.Tables[(int)eTablas.Routes].Columns[1].ColumnName]),
                                            new XElement("start", t[dts.Tables[(int)eTablas.Routes].Columns[2].ColumnName])
                                        )
                                    ))
                                );

            xmlTree.Save(_sResourcesPath + "Test.xml");
        }
        #endregion Methods
    }
}
