﻿using GestionDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
            _oFD = new OpenFileDialog();
            _oFD.Filter = "PDFs (*.pdf)|*.pdf|Todos los archivos (*.*)|*.*";
            _oFD.FilterIndex = 1;
            _oFD.RestoreDirectory = true;

            if (_oFD.ShowDialog() == DialogResult.OK)
            {
                txtBoxArchivo.Text = _oFD.FileName;
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
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DecryptPDF();
            ShowPDF();

            #region OLD
            //try
            //{
            //    var SelectedIdReferenceValue = short.Parse(dgv_PDFtoDB.SelectedCells[1].Value.ToString());
            //    var PDFbytes = db.AssemblyInstructions.Where(x => x.idreference == SelectedIdReferenceValue).Select(x => x.Instructions).First();

            //    //var ArchivoPDF = System.Text.Encoding.UTF8.GetString(PDFbytes);
            //    //var a = Convert.ToBase64String(PDFbytes);
            //    //System.
            //    //var aa = PDFbytes.ConvertByteToString();
            //    //var a = Encoding.UTF8.GetString(PDFbytes, 0, PDFbytes.Length);
            //    var a = Encoding.ASCII.GetString(PDFbytes);
            //    var b = Encoding.UTF8.GetString(PDFbytes);
            //    var c = Encoding.Unicode.GetString(PDFbytes);

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            //if (dgv_PDFtoDB.Rows.Count > 0)
            //{
            //    int id = int.Parse(dgv_PDFtoDB.Rows[dgv_PDFtoDB.CurrentRow.Index].Cells[0].Value.ToString());

            //    var oDocument = db.AssemblyInstructions.Find(id);

            //    string path = AppDomain.CurrentDomain.BaseDirectory;

            //    string folder = path + "temp\\";

            //    //string fullFilePath = folder + oDocument.realName;

            //    if (!Directory.Exists(folder))
            //        Directory.CreateDirectory(folder);

            //    //if (File.Exists(fullFilePath))
            //    //    File.Delete(fullFilePath);

            //    //File.WriteAllBytes(fullFilePath, oDocument.Instructions);
            //    //Process.Start(fullFilePath);

            //}
            #endregion OLD
        }
        #endregion Events

        #region Methods
        /// <summary>
        /// Carga el comboBox (Idreference --> comboPart) con las partes
        /// </summary>
        private void CargarListaNombre()
        {
            var dt = db.References.Where(x => x.idReferenceType == 2).Select(x => x).ToList();

            cmbBoxIdReference.DataSource = dt;
            cmbBoxIdReference.ValueMember = "idReference";
            cmbBoxIdReference.DisplayMember = "descReference";

        }
        /// <summary>
        /// Vuelve a cargar los datos en el grid
        /// </summary>
        private void RefreshGrid()
        {
            try
            {
                var tAssemblyInstruct = db.AssemblyInstructions.ToList();
                dgvPDF.DataSource = tAssemblyInstruct;
                dgvPDF.Columns[0].Visible = false;

                dgvPDF.Columns[2].Visible = false;

                for (int i = 3; i <= 4; i++) dgvPDF.Columns[i].Visible = false;
            }
            catch (Exception)
            {

            }

        }

        private void DecryptPDF()
        {

        }

        private void ShowPDF()
        {
            string filepath = string.Empty;
            var AppPath = AppDomain.CurrentDomain.BaseDirectory;
            var TempFolder = AppPath + "temp\\";
            //pdfacroviewer pdfacroviewer = new pdfacroviewer();
            //AxAcroPDFLib.AxAcroPDF pdf = new AxAcroPDFLib.AxAcroPDF();

            var oFD = new OpenFileDialog();
            oFD.Filter = "PDFs (*.pdf)|*.pdf|Todos los archivos (*.*)|*.*";
            oFD.FilterIndex = 1;
            oFD.RestoreDirectory = true;

            if (oFD.ShowDialog() == DialogResult.OK)
            {
                filepath = oFD.FileName;
            }

            webBrowserPDF.Navigate(filepath);
        }
        #endregion Methods
    }
}
