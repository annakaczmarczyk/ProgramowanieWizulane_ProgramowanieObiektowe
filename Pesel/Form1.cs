using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pesel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Czy Pesel jest prawidlowy?";
        }

        private void sprawdz_Click(object sender, EventArgs e)
        {
            int[] value = {1,3,7,9,1,3,7,9,1,3};
            int wynik = 0;
            int i = 0;
            string wynikPrawieKoncowy;
            int wynikKoncowy = 10;

            if(pesel.Text == "")
            {
                peselWynik.Text = "Brak danych";
                return;
            }

            for(int j=0;j<10;j++)
            {
                wynik += int.Parse(pesel.Text[j].ToString()) * value[i];
                i++;
            }

            wynikPrawieKoncowy = wynik.ToString();

            wynikPrawieKoncowy = wynikPrawieKoncowy[wynikPrawieKoncowy.Length - 1].ToString();

            wynikKoncowy -= int.Parse(wynikPrawieKoncowy);

            if(wynikKoncowy.ToString() == pesel.Text[pesel.Text.Length-1].ToString())
            {
                peselWynik.Text = "Pesel prawidlowy";
            }
            else
            {
                peselWynik.Text = "Pesel nie prawidlowy";
            }
        }
    }
}
