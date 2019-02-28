using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Configuration;
using System.Drawing.Text;
using System.Data.SqlClient;

namespace LogonScreen
{
    /// <summary>
    /// s
    /// </summary>
    public partial class LogonMainScreen : Form
    {
        private int _countDown = 0;
        bool musicOn = false;
        SoundPlayer player = new SoundPlayer
        {
            SoundLocation = Application.StartupPath + @"\\CANTINA.wav"
        };
        public LogonMainScreen()
        {
            InitializeComponent();
         
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            ButtonEntrar.Enabled = false;
           try
            {
            ConnectionClass.ClassBDD connect = new ConnectionClass.ClassBDD();
            DataSet dts;
            dts = connect.ComprobarUser(UserBox.Text, PassBox.Text);
            if (dts.Tables[0].Rows.Count == 1)
            {
                ErrorLabel.Visible = true;
                Timer.Start();
                ErrorLabel.Text = "Bienvenido " + dts.Tables[0].Rows[0]["DescCategory"].ToString() + " " + dts.Tables[0].Rows[0]["UserName"].ToString();



                ConfigurationManager.AppSettings.Set("UserName", dts.Tables[0].Rows[0]["UserName"].ToString());
                ConfigurationManager.AppSettings.Set("AccesLevel", dts.Tables[0].Rows[0]["AccessLevel"].ToString());
                ConfigurationManager.AppSettings.Set("Icon", dts.Tables[0].Rows[0]["Photo"].ToString());

                #region Token
                string idUser = dts.Tables[0].Rows[0]["idUser"].ToString();
                var LoginTicks = DateTime.Now.Ticks;
                string queryToken = "insert into LogUsers (idUser, Token) values (" + idUser + ",'" + LoginTicks + "');";
                connect.Executa(queryToken);
                #endregion
            }
            else
            {
                if (UserBox.Text.ToUpper().Equals("DEATHSTART"))
                {
                    System.Diagnostics.Process.Start("EstrelladelaMuerte.vbs");
                    MessageBox.Show("Felicidades Ganaste un Porta Vasos!", "SEGUNDO EASTER EGG");
                }
                else
                {
                    ErrorLabel.Text = "Error Usuario/Password! ";
                    ErrorLabel.Visible = true;
                    UserBox.Clear();
                    PassBox.Clear();
                    UserBox.Focus();

                }
                    ButtonEntrar.Enabled = true;
                }
        }
            catch (SqlException )
            {
                ButtonEntrar.Enabled = true;
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "¡No sea podido saltar al hyperspace!";

           }

        }
        void Timer_Tick(object sender, EventArgs e)
        {
            _countDown--;
            if (_countDown < 1)
            {
                _countDown = 10;
            }
        }
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LogonMainScreen_Load(object sender, EventArgs e)
        {
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            _countDown = _countDown + 1;
            if (_countDown==2)
            {
                this.Hide();
                ErrorLabel.Visible = false;
               player.Stop();
                Form frm = new MenuSecureCore.MenuForm();
                frm.Show();
            }
        }
        private void IconStarWars_Click(object sender, EventArgs e)
        {
            if (!musicOn)
            {
                player.Play();
                musicOn = true;
                EasterEgg1.Visible = true;
                EasterEgg2.Visible = true;
                EasterEgg3.Visible = true;
                EasterEgg4.Visible = true;
                EasterEgg5.Visible = true;
                EasterEgg6.Visible = true;
                EasterEgg7.Visible = true;
                EasterEgg8.Visible = true;
            }
        }
        private void GifEasterEgg_Click(object sender, EventArgs e)
        {
            desactviarMusic();
        }
        public void desactviarMusic() {
            if (musicOn)
            {
                player.Stop();
                musicOn = false;
                EasterEgg1.Visible = false;
                EasterEgg2.Visible = false;
                EasterEgg3.Visible = false;
                EasterEgg4.Visible = false;
                EasterEgg5.Visible = false;
                EasterEgg6.Visible = false;
                EasterEgg7.Visible = false;
                EasterEgg8.Visible = false;

            }
        }

     
    }
}
