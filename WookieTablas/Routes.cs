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
    public partial class Routes : MantenimientoBase.MantenimentBase
    {
        public Routes()
        {
            InitializeComponent();
            query = "Select * from Routes";
            id = "idRoute";
        }
        public Routes(string idcerca) {
            sdsTextBoxRouteTypes.Text = idcerca;
        }

        private void Routes_Load(object sender, EventArgs e)
        {         
            this.Username = ConfigurationManager.AppSettings["UserName"].ToString();
            this.IconUser = ConfigurationManager.AppSettings["Icon"].ToString();
            ButtonAtras.Visible = true;
            TittleScreen.Text = "Routes";
        }
    }
}
