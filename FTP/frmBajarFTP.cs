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
using System.Data.Entity.Infrastructure;
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
            try
            {
                _Request = (FtpWebRequest)WebRequest.Create(_cstrDomain + "/comandes.edi");
                _Request.Credentials = new NetworkCredential(_cstrUserName, _cstrPassword);
                _Request.Method = WebRequestMethods.Ftp.DownloadFile;

                _Response = (FtpWebResponse)_Request.GetResponse();

                _ResponseStream = _Response.GetResponseStream();
                _Reader = new StreamReader(_ResponseStream);
            }
            catch(WebException e)
            {
                MessageBox.Show(e.Message);
            }
            
        }

        /// <summary>
        /// Close all connects
        /// </summary>
        private void CloseConnections() { _Reader.Close(); _Response.Close(); }

        private void GestionarArchivo(string oDoc)
        {
            try
            {
                #region Variables
                var DocSplit = oDoc.Split();
                System.DateTime sisTimeOrder;
                string strCodeOrder = string.Empty;
                string strYYMMDD = string.Empty;
                string strAA = string.Empty;
                string strB = string.Empty;
                string strCCC = string.Empty;
                string strDia = string.Empty;
                string strMes = string.Empty;
                string strAño = string.Empty;
                List<string> lCant = new List<string>();
                List<System.DateTime> lsisTimeDeliveryDate = new List<DateTime>();
                List<string> lPlanets = new List<string>();
                List<string> lReferences = new List<string>();
                string strDiaDD = string.Empty;
                string strMesDD = string.Empty;
                string strAñoDD = string.Empty;
                #endregion Variables

                #region Get Info
                foreach (var Line in DocSplit)
                {
                    if (Line.Contains("DTM|"))
                    {
                        strYYMMDD = Line.Substring(6, 6);
                        strDia = Line.Substring(10,2);
                        strMes = Line.Substring(8, 2);
                        strAño = Line.Substring(4, 4);
                    }
                    if (Line.Contains("ORD|")) strAA = Line.Substring(18, 2);
                    if (Line.Contains("NADMS|"))
                    {
                        strB = Line.Substring(6, 1);
                        strCCC = Line.Substring(12, 3);
                    }
                    if (Line.Length>3 && Line.Substring(0,3).Equals("LIN"))
                    {
                        lPlanets.Add(Line.Substring(11,4));
                        lReferences.Add(Line.Substring(16, 13));
                    }
                    if (Line.Contains("QTYLIN|")&&Line.Substring(7,2).Equals("21"))
                        lCant.Add(Line.Substring(10, 2));
                    if (Line.Contains("DTMLIN|"))
                    {
                        strDiaDD = Line.Substring(13, 2);
                        strMesDD = Line.Substring(11, 2);
                        strAñoDD = Line.Substring(7, 4);
                        lsisTimeDeliveryDate.Add(new DateTime(int.Parse(strAñoDD), int.Parse(strMesDD), int.Parse(strDiaDD)));
                    }
                }
                strCodeOrder = strYYMMDD + strAA + strB + strCCC;
                sisTimeOrder = new DateTime(int.Parse(strAño), int.Parse(strMes), int.Parse(strDia));
                #endregion Get Info

                var inserOrders = new GestionDB.Orders
                {
                    codeOrder = strCodeOrder,
                    dateOrder = sisTimeOrder,
                };

                db.Orders.Add(inserOrders);

                for (int i = 0; i < lCant.Count; i++)
                {
                    var lTablePlanets = db.Planets.ToList();
                    var iIdPlanet = lTablePlanets.Where(x => x.CodePlanet.Equals(lPlanets[i])).Select(x => x.idPlanet).First();
                    var sIdPlanet = (short)iIdPlanet;
                    var lTableReferences = db.References.ToList();
                    var sIdReference = lTableReferences.Where(x => x.codeReference.Equals(lReferences[i])).Select(x => x.idReference).First();
                    var inserOrdersDetail = new GestionDB.OrdersDetail
                    {
                        idOrder = db.Orders.Where(x => x.codeOrder.Equals(strCodeOrder)).Select(x => x.idOrder).First(),
                        idPlanet = sIdPlanet,
                        idReference = sIdReference,
                        Quantity = short.Parse(lCant[i]),
                        DeliveryDate = lsisTimeDeliveryDate[i],
                    };

                    db.OrdersDetail.Add(inserOrdersDetail);
                }

                db.SaveChanges();
                MessageBox.Show("Datos actualizados en la DB.");
            }
            catch (DbUpdateException DBUe)
            {
                MessageBox.Show(DBUe.Message);
            }
            catch (ArgumentOutOfRangeException AOoRe)
            {
                MessageBox.Show(AOoRe.Message);
            }
            catch(FormatException Fe)
            {
                MessageBox.Show(Fe.Message);
            }
            catch (NotSupportedException NSe)
            {
                MessageBox.Show(NSe.Message);
            }
            catch (InvalidOperationException IOe)
            {
                MessageBox.Show(IOe.Message);
            }
        }

        #endregion Methods

        private void btnNoDescarregar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
