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
    public partial class UserCategories : MantenimientoBase.MantenimentBase
    {
        public UserCategories()
        {
            InitializeComponent();
            query = "Select * from UserCategories";
            id = "idUserCategory";
        }

        private void UserCategories_Load(object sender, EventArgs e)
        {
            this.Username = ConfigurationManager.AppSettings["UserName"].ToString();
            this.IconUser = ConfigurationManager.AppSettings["Icon"].ToString();
            ButtonAtras.Visible = true;
            TittleScreen.Text = "UserCategories";
        }
    }
}
