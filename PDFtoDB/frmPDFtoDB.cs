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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboPart.Text.Trim()) || string.IsNullOrEmpty(textBox_Archivo.Text.Trim()))
            {
                MessageBox.Show("El nombre es obligatorio");
            }
            else
            {
                byte[] file = null;
                Stream myStream = openFileDialog1.OpenFile();
                using (MemoryStream ms = new MemoryStream())
                {
                    myStream.CopyTo(ms);
                    file = ms.ToArray();
                }
                //using (XWingsFactoryEntities db = new XWingsFactoryEntities())
                //{
                    var ref1 = (short)comboPart.SelectedValue;
                    //string ref1 = "Ala";
                    //AssemblyInstructions instructions;
                    //IQueryable<AssemblyInstructions> lst = from b in db.AssemblyInstructions
                    //          join d in db.References
                    //          on b.idreference equals d.idReference
                    //          where d.descReference == ref1
                    //          select b;
                    //var JoinAsemblyRefe = db.AssemblyInstructions.Join(db.References, asm=>asm.idreference, refe=>refe.idReference,(asm, refe)=>new { Assembly = asm, Referenc = refe });
                    //var lst = JoinAsemblyRefe.Where(x => x.Referenc.descReference.Equals(ref1)).Select(x=>x.Assembly.idreference).ToList();

                    var sReferences = db.References.Where(x => x.idReference.Equals(ref1)).Select(x => x.idReference).First();

                    //AssemblyInstructions instructions = new AssemblyInstructions();

                    //instructions.idreference = sReferences;
                    //instructions.Instructions = file;

                    foreach(var tAssemblyIntruct in db.AssemblyInstructions)
                    {
                        if (tAssemblyIntruct.idreference == sReferences)
                        {
                            tAssemblyIntruct.Instructions = file;
                        }
                    }

                    //db.AssemblyInstructions.Select(x => x.idreference) = sReferences;
                    //db.AssemblyInstructions.Select(x => x.Instructions) = file;

                    db.SaveChanges();
                    MessageBox.Show("arxiu guardat");
                //}
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

        #endregion Methods
        
    }
}
