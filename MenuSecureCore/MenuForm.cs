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

namespace MenuSecureCore
{
    public partial class MenuForm : PlantillaPrincipalStarWars.PlantillaForm
    {
        string acclevel;
        public MenuForm()
        {
            this.TittleScreen.Text = "Menu Principal";
            InitializeComponent();    
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

            var db = new ConnectionClass.ClassBDD();
            DataSet dts;
            Actualizar();
            dts = db.PortaPerConsulta(" Select * from MenuSecureCore Where nivell<="+ int.Parse(acclevel));

            int cont = 0;

            foreach (DataRow dr in dts.Tables[0].Rows)
            {

                var MenuItem = new WookieCodeControls.MainMenu
                {
                    LblText = dr["title"].ToString(),
                    Image = dr["icon"].ToString(),
                    NameClass = dr["dllName"].ToString(),
                    NameForm = dr["formName"].ToString(),
                    Location = new Point(10 + (cont * 100), 30)
                };

                PanelButtonsMain.Controls.Add(MenuItem);
                cont++;
            }
        }
        private void Actualizar() {
            acclevel = ConfigurationManager.AppSettings["AccesLevel"].ToString();
            this.Username = ConfigurationManager.AppSettings["UserName"].ToString();
            this.IconUser = ConfigurationManager.AppSettings["Icon"].ToString();
        }

        

      
    }
}
