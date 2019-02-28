using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApp2
{
    public partial class SplashScreenForm : Form
    {

        public SplashScreenForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
        private void Timer1_Tick_1(object sender, EventArgs e)
        {

            ModifyProgressBarColor.SetState(progressBar, 1);
            progressBar.Increment(1);

            if(progressBar.Value == 1)
            {
                ComentProgess.Text = "INICIALIZANDO CARACTERISTICAS....";
            }

            if (progressBar.Value == 20)
            {
                ComentProgess.Text = "        DESCARGANDO PAQUETES...";
            }
            else
            {
                if (progressBar.Value == 47)
                {
                    ComentProgess.Text = "           CARGANDO GRAFICOS...";
                }
                else if(progressBar.Value == 78)
                {
                    ComentProgess.Text = "PROBANDO CONEXIONES DE RED...";
                }
            }

            if (progressBar.Value == 25)
            {
                timer.Stop();
                this.Hide();
                Form frm = new LogonScreen.LogonMainScreen();
                frm.Show();

            }

        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}
