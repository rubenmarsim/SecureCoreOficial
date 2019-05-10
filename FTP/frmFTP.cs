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

namespace FTP
{
    /// <summary>
    /// Formulario para subir y bajar archivos mediante FTP
    /// </summary>
    public partial class frmFTP : Form
    {
        #region Variables Globales
        OpenFileDialog _oFD;
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
            try
            {
                 
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://172.16.6.0");
                request.Method = WebRequestMethods.Ftp.UploadFile;

                request.Credentials = new  NetworkCredential("wookiecode", "12345aA");

                StreamReader sourceStream = new StreamReader("Recursos/testfile.txt");
                byte[] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
                sourceStream.Close();
                request.ContentLength = fileContents.Length;

                Stream requestStream = request.GetRequestStream();
                requestStream.Write(fileContents, 0, fileContents.Length);
                requestStream.Close();

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                Console.WriteLine("Upload File Complete, status {0}", response.StatusDescription);

                response.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Cuando pulsamos el boton de navegar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowsePush_Click(object sender, EventArgs e)
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
        /// <summary>
        /// Cuando pulsamos el boton de subir archivo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPush_Click(object sender, EventArgs e)
        {

        }

        #endregion Events

        #region Methods

        #endregion Methods

    }
}
