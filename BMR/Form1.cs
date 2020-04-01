using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMR
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            this.Text = "BMR";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BMI_Click(object sender, EventArgs e)
        {
            double wynikKod = 0;
            if (MezczyznaWartosc.Checked == true)
            {
                wynikKod = 9.99 * double.Parse(WartoscMasy.Text) + 6.25 * double.Parse(WartoscWzrostu.Text) - 4.92 * double.Parse(WartoscWieku.Text) + 5;
            }
            else
            {
                wynikKod = 9.99 * double.Parse(WartoscMasy.Text) + 6.25 * double.Parse(WartoscWzrostu.Text) - 4.92 * double.Parse(WartoscWieku.Text) - 161;
            }
            wynik.Text = wynikKod.ToString();
        }

        private void wynik_TextChanged(object sender, EventArgs e)
        {
}

        private void wynikBMI_Click(object sender, EventArgs e)
        {

        }
    }
}

/*
 Mężczyźni: [9,99 x masa ciała (kg)] + [6,25 x wzrost (cm)] - [4,92 x wiek (lata)] + 5

Kobiety: [9,99 x masa ciała (kg)] + [6,25 x wzrost (cm)] - [4,92 x wiek(lata)] – 161
     */
