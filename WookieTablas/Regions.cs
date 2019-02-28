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
    public partial class Regions : MantenimientoBase.MantenimentBase
    {
        public Regions()
        {
            InitializeComponent();
            query = "Select * from Regions";
            id = "idRegion";
        }

        private void Regions_Load(object sender, EventArgs e)
        {
            this.Username = ConfigurationManager.AppSettings["UserName"].ToString();
            this.IconUser = ConfigurationManager.AppSettings["Icon"].ToString();
            ButtonAtras.Visible = true;
            TittleScreen.Text = "Regions";
        }
    }
}
