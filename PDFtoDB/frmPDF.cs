using GestionDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFtoDB
{
    /// <summary>
    /// Formulario para guardar y abrir PDFs
    /// </summary>
    public partial class frmPDF : Form
    {
        #region Variables Globales
        XWingsFactoryEntities db;
        OpenFileDialog _oFD;
        WebBrowser _webBrowserPDF;
        List<References> _FilteredStructTable;
        #endregion Variables Globales

        #region Constructores
        public frmPDF()
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
        private void frmPDF_Load(object sender, EventArgs e)
        {
            db = new XWingsFactoryEntities();
            _webBrowserPDF = new WebBrowser();
            CargarListaNombre();
            RefreshGrid();
        }
        /// <summary>
        /// Cuando pulsamos el boton browse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                _oFD = new OpenFileDialog();
                _oFD.Filter = "PDFs (*.pdf)|*.pdf|Todos los archivos (*.*)|*.*";
                _oFD.FilterIndex = 1;
                _oFD.RestoreDirectory = true;

                if (_oFD.ShowDialog() == DialogResult.OK)
                {
                    txtBoxArchivo.Text = _oFD.FileName;
                }
            }
            catch (Exception Ge)
            {
                MessageBox.Show(Ge.Message);
            }            
        }
        /// <summary>
        /// Cuando pulsamos el boton de guardar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] file = null;
                Stream myStream = _oFD.OpenFile();
                using (MemoryStream ms = new MemoryStream())
                {
                    myStream.CopyTo(ms);
                    file = ms.ToArray();
                }

                var ref1 = (short)cmbBoxIdReference.SelectedValue;

                var sReferences = db.References.Where(x => x.idReference.Equals(ref1)).Select(x => x.idReference).First();

                foreach (var tAssemblyIntruct in db.AssemblyInstructions)
                {
                    if (tAssemblyIntruct.idreference == sReferences)
                    {
                        tAssemblyIntruct.Instructions = file;
                    }
                }

                db.SaveChanges();
                MessageBox.Show("Arxiu guardat.");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("El nombre es obligatorio");
            }
            catch (Exception Ge)
            {
                MessageBox.Show(Ge.Message);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DecryptAndShowPDF();            
        }
        #endregion Events

        #region Methods
        /// <summary>
        /// Carga el comboBox (Idreference --> comboPart) con las partes
        /// </summary>
        private void CargarListaNombre()
        {
            try
            {
                var dt = db.References.Where(x => x.idReferenceType == 2).Select(x => x).ToList();

                cmbBoxIdReference.DataSource = dt;
                cmbBoxIdReference.ValueMember = "idReference";
                cmbBoxIdReference.DisplayMember = "descReference";
            }
            catch (Exception Ge)
            {
                MessageBox.Show(Ge.Message);
            }
        }
        /// <summary>
        /// Vuelve a cargar los datos en el grid
        /// </summary>
        private void RefreshGrid()
        {
            try
            {
                var JoinAI_Struct = db.AssemblyInstructions.Join(db.References, AsInstruct => AsInstruct.idreference, strct => strct.idReference, (AsInstruct, strct) => new { AsemblyInstruction = AsInstruct, Structura = strct });
                _FilteredStructTable = JoinAI_Struct.Select(x => x.Structura).ToList();
                dgvPDF.DataSource = _FilteredStructTable;

                for (int i=0; i<=1;i++) dgvPDF.Columns[i].Visible = false;
                for (int i = 3; i <= dgvPDF.Columns.Count; i++) dgvPDF.Columns[i].Visible = false;
            }
            catch (Exception Ge)
            {
                MessageBox.Show(Ge.Message);
            }
        }

        private void DecryptAndShowPDF()
        {
            try
            {
                if (dgvPDF.Rows.Count > 0)
                {
                    var SelectedDesc = dgvPDF.SelectedCells[0].Value.ToString();
                    var SelectedId = _FilteredStructTable.Where(x => x.descReference.Equals(SelectedDesc)).Select(x => x.idReference).First();
                    var PDFbytes = db.AssemblyInstructions.Where(x => x.idreference == SelectedId).Select(x => x.Instructions).First();
                    
                    _webBrowserPDF.Dispose();
                    Thread.Sleep(1000);

                    var TempFolder = AppDomain.CurrentDomain.BaseDirectory + @"temp\";
                    var FullFilePath = TempFolder + "AssemblyPDF.pdf";

                    File.WriteAllBytes(FullFilePath, PDFbytes);

                    _webBrowserPDF = new WebBrowser();
                    _webBrowserPDF.Location = new Point(481, 12);
                    _webBrowserPDF.Margin = new Padding(3);
                    _webBrowserPDF.Size = new Size(656, 705);
                    this.Controls.Add(_webBrowserPDF);
                    _webBrowserPDF.Show();

                    _webBrowserPDF.Navigate(FullFilePath);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Selecciona un campo del Grid!");
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (InvalidOperationException IOe)
            {
                MessageBox.Show(IOe.Message);
            }
            catch (Exception Ge)
            {
                MessageBox.Show(Ge.Message);
            }
        }

        #endregion Methods
    }
}
