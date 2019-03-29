using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFtoDB
{
    public partial class frm_PDFtoDB : Form
    {
        GestionDB.XWingsFactoryEntities db;
        public frm_PDFtoDB()
        {
            InitializeComponent();
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Todos los archivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_Archivo.Text = openFileDialog1.FileName;
            }
            var a = db.AssemblyInstructions;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (textBox_Nombre.Text.Trim().Equals("") || textBox_Archivo.Text.Trim().Equals(""))
            {
                MessageBox.Show("El nombre es obligatorio");
                return;
            }

            byte[] file = null;
            Stream myStream = openFileDialog1.OpenFile();
            using (MemoryStream ms = new MemoryStream())
            {
                myStream.CopyTo(ms);
                file = ms.ToArray();
            }

            GestionDB.AssemblyInstructions oDocument = new GestionDB.AssemblyInstructions
            {
                idreference = textBox_Nombre.Text.Trim(),
                Instructions = file,
                id = openFileDialog1.SafeFileName,
            };

            db.AssemblyInstructions.Add(oDocument);
            db.SaveChanges();
            

            Refresh();
        }
        private void Refresh()
        {

            using (GestionDB.XWingsFactoryEntities db = new GestionDB.XWingsFactoryEntities())
            {
                var lst = db.AssemblyInstructions.Select(x => x).ToList();
                dgv_PDFtoDB.DataSource = lst;
            }
        }

        private void frm_PDFtoDB_Load(object sender, EventArgs e)
        {
            db = new GestionDB.XWingsFactoryEntities();
            Refresh();
            dgv_PDFtoDB.Columns[3].Visible = false;
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            if (dgv_PDFtoDB.Rows.Count > 0)
            {
                int id = int.Parse(dgv_PDFtoDB.Rows[dgv_PDFtoDB.CurrentRow.Index].Cells[0].Value.ToString());

                using (GestionDB.XWingsFactoryEntities db = new GestionDB.XWingsFactoryEntities())
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
    }
}
