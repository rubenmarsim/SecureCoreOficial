#region Usings
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
#endregion Usings

namespace FTP
{
    /// <summary>
    /// Formulario para bajar archivos del ftp
    /// </summary>
    public partial class frmBajarFTP : Form
    {
        #region Variables Globales

        FtpWebRequest _Request;
        FtpWebResponse _Response;
        Stream _ResponseStream;
        StreamReader _Reader;
        const string _cstrDomain = "ftp://172.17.6.0";
        const string _cstrUserName = "wookiecode";
        const string _cstrPassword = "12345aA";
        string _FileName = string.Empty;
        GestionDB.XWingsFactoryEntities db;

        #endregion Variables Globales

        #region Constructors
        public frmBajarFTP()
        {
            InitializeComponent();
        }
        #endregion Constructors

        #region Events

        /// <summary>
        /// Cuando carga el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBajarFTP_Load(object sender, EventArgs e)
        {
            db = new GestionDB.XWingsFactoryEntities();
        }

        /// <summary>
        /// Cuando pulsamos el boton de descargar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDownload_Click(object sender, EventArgs e)
        {
            DownloadDoc();

            var oDoc = _Reader.ReadToEnd();

            CloseConnections();

            GestionarArchivo(oDoc);
        }

        #endregion Events

        #region Methods

        /// <summary>
        /// Descargamos el documento .edi con el que vamos a operar
        /// </summary>
        private void DownloadDoc()
        {
            _Request = (FtpWebRequest)WebRequest.Create(_cstrDomain + "/comandes.edi");
            _Request.Credentials = new NetworkCredential(_cstrUserName, _cstrPassword);
            _Request.Method = WebRequestMethods.Ftp.DownloadFile;

            _Response = (FtpWebResponse)_Request.GetResponse();

            _ResponseStream = _Response.GetResponseStream();
            _Reader = new StreamReader(_ResponseStream);
        }

        /// <summary>
        /// Close all connects
        /// </summary>
        private void CloseConnections() { _Reader.Close(); _Response.Close(); }

        private void GestionarArchivo(string oDoc)
        {
            var a = oDoc.ToArray();

            System.DateTime sisTimeOrder = new DateTime();
            string strCodeOrder = string.Empty;
            short? sIdPlanet = 0;
            short? sIdReference = 0;



            var inserOrders = new GestionDB.Orders
            {
                codeOrder = strCodeOrder,
                dateOrder = sisTimeOrder,                
            };

            var inserOrdersDetail = new GestionDB.OrdersDetail
            {
                idPlanet = sIdPlanet,
                idReference = sIdReference,
            };

            db.Orders.Add(inserOrders);
            //db.OrdersDetail.Add(inserOrdersDetail);
            db.SaveChanges();
        }

        #endregion Methods
    }
}
