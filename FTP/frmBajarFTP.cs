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
        #endregion Variables Globales

        #region Constructors
        public frmBajarFTP()
        {
            InitializeComponent();
        }
        #endregion Constructors

        #region Events

        private void frmBajarFTP_Load(object sender, EventArgs e)
        {

        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            DownloadDoc();

            var oDoc = _Reader.ReadToEnd();

            CloseConnections();
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
        #endregion Methods
    }
}
