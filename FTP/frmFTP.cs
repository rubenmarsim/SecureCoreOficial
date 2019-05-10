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
    /// Formulario para subir y bajar archivos mediante FTP
    /// </summary>
    public partial class frmFTP : Form
    {
        #region Variables Globales
        OpenFileDialog _oFD;
        FtpWebRequest _Request;
        const string _cstrDomain = "ftp://172.17.6.0";
        const string _cstrUserName = "wookiecode";
        const string _cstrPassword = "12345aA";

        #endregion Variables Globales

        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public frmFTP()
        {
            InitializeComponent();
        }
        #endregion Constructores

        #region Events

        /// <summary>
        /// Cuando carga el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmFTP_Load(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Cuando pulsamos el boton de navegar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowsePush_Click(object sender, EventArgs e)
        {
            GetDocument();
        }
        /// <summary>
        /// Cuando pulsamos el boton de subir archivo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPush_Click(object sender, EventArgs e)
        {
            SubirArchivo();
        }

        #endregion Events

        #region Methods

        /// <summary>
        /// Abre un OpenFileDialog para seleccionar el archivo que queremos subir
        /// </summary>
        private void GetDocument()
        {
            _oFD = new OpenFileDialog();
            _oFD.Filter = "Todos los archivos (*.*)|*.*";
            _oFD.FilterIndex = 1;
            _oFD.RestoreDirectory = true;

            if (_oFD.ShowDialog() == DialogResult.OK)
            {
                txtBoxDescPush.Text = _oFD.FileName;
            }
        }        

        private void SubirArchivo()
        {
            try
            {
                _Request = (FtpWebRequest)WebRequest.Create(_cstrDomain + "/ArchivoSubidoFTP.txt");
                _Request.Credentials = new NetworkCredential(_cstrUserName, _cstrPassword);
                _Request.Method = WebRequestMethods.Ftp.UploadFile;

                StreamReader sourceStream = new StreamReader("Recursos/testfile.txt");
                byte[] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
                sourceStream.Close();
                _Request.ContentLength = fileContents.Length;

                Stream requestStream = _Request.GetRequestStream();
                requestStream.Write(fileContents, 0, fileContents.Length);
                requestStream.Close();

                FtpWebResponse response = (FtpWebResponse)_Request.GetResponse();

                Console.WriteLine("Upload File Complete, status {0}", response.StatusDescription);

                response.Close();

                MessageBox.Show("Archivo subido correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion Methods

        
    }
}
