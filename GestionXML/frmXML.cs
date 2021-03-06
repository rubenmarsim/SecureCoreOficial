﻿using System;
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
            try
            {
                db = new ConnectionClass.ClassBDD();
                _sResourcesPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).Replace("\\", "/") + "/Resources/";
            }
            catch (Exception Ge)
            {
                MessageBox.Show(Ge.Message);
            }            
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
            try
            {
                SqlConnection con = new SqlConnection("Data Source=wookie-code.database.windows.net;Initial Catalog=SecureCore;User ID=Wookie;Password=123456789aA");
                dts = new DataSet();

                SqlDataAdapter adapter = new SqlDataAdapter("select * from ViewJoinRoutesV2; select * from ViewJoinDefinedRoutesV2; select DescFiliations from Filiations; select DescRegion, Remarks from Regions; select * from ViewJoinPlanetsV2", con);
                adapter.TableMappings.Add(_cTableNameRoutes, _cTableNameRoute);
                adapter.TableMappings.Add(_cTableNameDefinedRoutes, _cTableNameDefinedRoute);
                adapter.TableMappings.Add(_cTableNameFiliations, _cTableNameFiliation);
                adapter.TableMappings.Add(_cTableNameRegions, _cTableNameRegion);
                adapter.TableMappings.Add(_cTableNamePlanets, _cTableNamePlanet);
                adapter.Fill(dts);

                dts.DataSetName = _cHyperSpaceData;
                for (int i = 0; i < dts.Tables.Count; i++)
                    dts.Tables[i].TableName = adapter.TableMappings[i].DataSetTable;
            }
            catch (Exception Ge)
            {
                MessageBox.Show(Ge.Message);
            }            
        }
        /// <summary>
        /// Escribe el XML estructurado y formateado
        /// </summary>
        private void WriteXML()
        {
            try
            {
                XElement xmlTree = new XElement(dts.DataSetName,
                                    new XElement(_cHyperSpaceRoutes, dts.Tables[(int)eTablas.Routes].AsEnumerable().Select(t =>
                                        new XElement(_cTableNameRoute,
                                            new XElement("type", t[dts.Tables[(int)eTablas.Routes].Columns[0].ColumnName]),
                                            new XElement("nameRoute", t[dts.Tables[(int)eTablas.Routes].Columns[1].ColumnName]),
                                            new XElement("start", t[dts.Tables[(int)eTablas.Routes].Columns[2].ColumnName]),
                                            new XElement("end", t[dts.Tables[(int)eTablas.Routes].Columns[3].ColumnName])
                                        )
                                        ),
                                        new XElement(_cTableNameDefinedRoutes, dts.Tables[(int)eTablas.DefinedRoutes].AsEnumerable().Select(t =>
                                            new XElement(_cTableNameDefinedRoute,
                                                    new XElement("OrDes", t[dts.Tables[(int)eTablas.DefinedRoutes].Columns[0].ColumnName]),
                                                    new XElement("selectedRoute", t[dts.Tables[(int)eTablas.DefinedRoutes].Columns[1].ColumnName]),
                                                    new XElement("map", t[dts.Tables[(int)eTablas.DefinedRoutes].Columns[2].ColumnName])
                                            )
                                        ))
                                    ),
                                    new XElement(_cTableNameFiliations, dts.Tables[(int)eTablas.Filiations].AsEnumerable().Select(t =>
                                            new XElement("description", t[dts.Tables[(int)eTablas.Filiations].Columns[0].ColumnName])
                                    )),
                                    new XElement(_cTableNameRegions, dts.Tables[(int)eTablas.Regions].AsEnumerable().Select(t =>
                                            new XElement(_cTableNameRegion,
                                                    new XElement("nameRegion", t[dts.Tables[(int)eTablas.Regions].Columns[0].ColumnName]),
                                                    new XElement("descriptionRegion", t[dts.Tables[(int)eTablas.Regions].Columns[1].ColumnName])
                                            )
                                    )),
                                    new XElement(_cTableNamePlanets, dts.Tables[(int)eTablas.Planets].AsEnumerable().Select(t =>
                                            new XElement(_cTableNamePlanet,
                                                    new XElement("name", t[dts.Tables[(int)eTablas.Planets].Columns[0].ColumnName]),
                                                    new XElement("sector", t[dts.Tables[(int)eTablas.Planets].Columns[1].ColumnName]),
                                                    new XElement("filiation", t[dts.Tables[(int)eTablas.Planets].Columns[2].ColumnName]),
                                                    new XElement("situation",
                                                        new XElement("long", t[dts.Tables[(int)eTablas.Planets].Columns[3].ColumnName]),
                                                        new XElement("lat", t[dts.Tables[(int)eTablas.Planets].Columns[4].ColumnName]),
                                                        new XElement("parsecs", t[dts.Tables[(int)eTablas.Planets].Columns[5].ColumnName])
                                                    ),
                                                    new XElement("hyperspaceRoute",
                                                        new XElement("route", t[dts.Tables[(int)eTablas.Planets].Columns[6].ColumnName])
                                                    ),
                                                    new XElement("natives", t[dts.Tables[(int)eTablas.Planets].Columns[7].ColumnName])
                                            )
                                    ))
                                );

                xmlTree.Save(_sResourcesPath + "HyperSpaceData.xml");
            }
            catch (Exception Ge)
            {
                MessageBox.Show(Ge.Message);
            }            
        }
        #endregion Methods

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
