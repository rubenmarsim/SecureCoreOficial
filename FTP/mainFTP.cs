using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTP
{
    public partial class mainFTP : Form
    {
        public mainFTP()
        {
            InitializeComponent();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            frmFTP frm = new frmFTP();
            frm.Show();
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            frmBajarFTP frm = new frmBajarFTP();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
