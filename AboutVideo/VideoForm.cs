using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AboutVideo
{
    public partial class VideoForm : PlantillaPrincipalStarWars.PlantillaForm
    {

        public VideoForm()
        {
           

            InitializeComponent();
            
        }

        public void actualizar() {
            this.Username = ConfigurationManager.AppSettings["UserName"].ToString();
            this.IconUser = ConfigurationManager.AppSettings["Icon"].ToString();
            ButtonAtras.Visible = true;
            TittleScreen.Text = "Creditos";
        }
        private void VideoForm_Load(object sender, EventArgs e)
        {
            actualizar();
        }
    }
}
