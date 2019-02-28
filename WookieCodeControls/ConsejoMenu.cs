using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace WookieCodeControls
{
    public partial class ConsejoMenu : UserControl
    {
        public ConsejoMenu()
        {
            InitializeComponent();
        }

        private string _lblText;
        public string LblText
        {
            get { return _lblText; }
            set
            {
                _lblText = value;
                ButtonConsejo.Text = value;
            }
        }



        private string _NameClass;
        public string NameClass
        {
            get { return _NameClass; }
            set { _NameClass = value; }
        }

        private string _NameForm;
        public string NameForm
        {
            get { return _NameForm; }
            set { _NameForm = value; }
        }

        private void ObreForm(object sender, EventArgs e)
        {
            Assembly ensamblat = Assembly.LoadFrom(NameClass);
            Object dllBD;
            Type tipus;
            tipus = ensamblat.GetType(NameForm);
            dllBD = Activator.CreateInstance(tipus);

            ((Form)dllBD).Show();
            ButtonConsejo.Text = LblText;
        }

    }

}

