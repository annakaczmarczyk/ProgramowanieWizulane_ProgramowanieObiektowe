using System;
using System.Drawing;
using System.Windows.Forms;

namespace KostkaDoGry
{
    public partial class Form1 : Form
    {
        private Random _rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'r')
            {
                label1.Text = RzucKostka().ToString();
                label1.ForeColor = Color.FromArgb(WylosujBajt(), WylosujBajt(), WylosujBajt());
            }
        }

        private int RzucKostka()
        {
            return _rnd.Next(1, 7);
        }

        private int WylosujBajt()
        {
            return _rnd.Next(0, 256);
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(label1.Text);

            MessageBox.Show(this, "Skopiowano " + label1.Text + "!");
        }
    }
}
