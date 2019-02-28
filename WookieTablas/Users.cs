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

namespace WookieTablas
{
    public partial class Users : MantenimientoBase.MantenimentBase
    {
        public Users()
        {
            InitializeComponent();
            query = "Select * from Users";
            base.id = "idUser";
        }
        private void Users_Load(object sender, EventArgs e)
        {
            this.Username = ConfigurationManager.AppSettings["UserName"].ToString();
            this.IconUser = ConfigurationManager.AppSettings["Icon"].ToString();
            ButtonAtras.Visible = true;
            TittleScreen.Text = "Users";
        }
        private void sdsTexBox5_TextChanged(object sender, EventArgs e)
        {
            pictureBoxPreview.ImageLocation = Application.StartupPath + @"\\Imagenes\" + sdsTexBox5.Text;
            pictureBoxPreview.SizeMode = PictureBoxSizeMode.StretchImage;
        }

       
    }
}
