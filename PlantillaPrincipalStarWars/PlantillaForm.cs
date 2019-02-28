using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantillaPrincipalStarWars
{
    public partial class PlantillaForm : Form
    {
        public PlantillaForm()
        {
            InitializeComponent();
        }
        string _nombrePantalla;
        public string NombrePantalla
        {
            get { return _nombrePantalla; }
            set
            {
                _nombrePantalla = value;
                TittleScreen.Text = value;
            }
        }
        string _username;
        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                UsernameTitle.Text = value;
            }
        }
        string _iconUser;
        public string IconUser
        {
            get { return _iconUser; }
            set
            {
                _iconUser = value;
                
                UserIconTitle.ImageLocation = Application.StartupPath+@"\\Imagenes\"+value;

                UserIconTitle.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void ExitButtonTitle_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Hazlo o no lo hagas, pero no lo intentes", "¿Cerrar Sesion?", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                foreach (Form frm in Application.OpenForms)
                {
                    frm.Hide();
                }
                Assembly ensamblat = Assembly.LoadFrom("LogonScreen.dll");
                Object dllBD;
                Type tipus;

                tipus = ensamblat.GetType("LogonScreen.LogonMainScreen");
                dllBD = Activator.CreateInstance(tipus);
                ((Form)dllBD).Show();
            }
        }
        public void CerrarPrograma()
        {
            Application.Exit();
        }
        private void BotonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}