using GestionDB;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PDFtoDB
{
    public partial class frm_PDFtoDB : Form
    {
        #region Variables globales
        XWingsFactoryEntities db;
        #endregion Variables globales

        #region Constructores

        public frm_PDFtoDB()
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
        private void frm_PDFtoDB_Load(object sender, EventArgs e)
        {
            db = new XWingsFactoryEntities();
            cargarListaNombre();
            RefreshGrid();
        }

        /// <summary>
        /// Cuando pulsamos el boton browse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Browse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDFs (*.pdf)|*.pdf|Todos los archivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_Archivo.Text = openFileDialog1.FileName;
            }
        }

        /// <summary>
        /// Cuando pulsamos el boton de guardar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] file = null;
                Stream myStream = openFileDialog1.OpenFile();
                using (MemoryStream ms = new MemoryStream())
                {
                    myStream.CopyTo(ms);
                    file = ms.ToArray();
                }

                var ref1 = (short)comboPart.SelectedValue;

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

        private void btn_Open_Click(object sender, EventArgs e)
        {
            if (dgv_PDFtoDB.Rows.Count > 0)
            {
                int id = int.Parse(dgv_PDFtoDB.Rows[dgv_PDFtoDB.CurrentRow.Index].Cells[0].Value.ToString());

                using (XWingsFactoryEntities db = new XWingsFactoryEntities())
                {
                    var oDocument = db.AssemblyInstructions.Find(id);

                    string path = AppDomain.CurrentDomain.BaseDirectory;

                    string folder = path + "temp\\";

                    //string fullFilePath = folder + oDocument.realName;

                    if (!Directory.Exists(folder))
                        Directory.CreateDirectory(folder);

                    //if (File.Exists(fullFilePath))
                    //    File.Delete(fullFilePath);

                    //File.WriteAllBytes(fullFilePath, oDocument.Instructions);
                    //Process.Start(fullFilePath);
                }
            }
        }
        #endregion Events

        #region Methods
        /// <summary>
        /// Carga el comboBox (Idreference --> comboPart) con las partes
        /// </summary>
        private void cargarListaNombre()
        {
            var dt = db.References.Where(x => x.idReferenceType == 2).Select(x => x).ToList();
            
            comboPart.DataSource = dt;
            comboPart.ValueMember = "idReference";
            comboPart.DisplayMember = "descReference";

        }

        private void RefreshGrid()
        {
            var tAssemblyInstruct = db.AssemblyInstructions.ToList();
            dgv_PDFtoDB.DataSource = tAssemblyInstruct;
            dgv_PDFtoDB.Columns[0].Visible = false;
            for(int i=3;i<=4;i++) dgv_PDFtoDB.Columns[i].Visible = false;
        }

        #endregion Methods
        
    }
}
