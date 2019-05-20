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

namespace GestionXML
{
    /// <summary>
    /// Formulario que crea el archivo XML a partir de la base de datos
    /// </summary>
    public partial class frmXML : Form
    {
        #region Variables Globales        
        GestionDB.SecureCoreDataSet db;
        ConnectionClass.ClassBDD BDD;
        DataSet dts;
        string _sResourcesPath;
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
            BDD = new ConnectionClass.ClassBDD();
            db = new GestionDB.SecureCoreDataSet();
            _sResourcesPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).Replace("\\", "/") + "/Resources/";
        }
        private void btnCreateXML_Click(object sender, EventArgs e)
        {
            GetTablas();
            WriteXML();

            MessageBox.Show("XML generat correctament.");
        }
        #endregion Events

        #region Methods
        private void GetTablas()
        {
            SqlConnection con = new SqlConnection("Data Source=wookie-code.database.windows.net;Initial Catalog=SecureCore;User ID=Wookie;Password=123456789aA"); //"GestionDB.Properties.Settings.SecureCoreConnectionString"
            dts = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter("select * from Routes; select * from DefinedRoutes; select * from Filiations; select * from Regions; select * from Planets", con);
            adapter.TableMappings.Add("Routes", "Route");
            adapter.TableMappings.Add("DefinedRoutes", "DefinedRoute");
            adapter.TableMappings.Add("Filiations", "Filiation");
            adapter.TableMappings.Add("Regions", "Region");
            adapter.TableMappings.Add("Planets", "Planet");
            adapter.Fill(dts);

            dts.DataSetName = "hyperSpacedata";
            for(int i=0;i<=4;i++)
                dts.Tables[i].TableName = adapter.TableMappings[i].DataSetTable;
        }

        private void WriteXML()
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

        private void FormatXML()
        {
            
        }
        #endregion Methods
    }
}