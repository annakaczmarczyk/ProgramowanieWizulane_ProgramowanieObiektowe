using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelLogowania
{
    public partial class Form2 : Form
    {
        public Form1 logowanie;

        public Form2()
        {
            InitializeComponent();
        }

        public void UstawTekst(string info)
        {

        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'q')
            {
                logowanie.Show();
                Close();
            }
        }

        private void Label_MouseHover(object sender, EventArgs e)
        {
            NazwiskoLabel.ForeColor = Color.Blue;
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            NazwiskoLabel.ForeColor = Color.Black;
        }
    }
}
