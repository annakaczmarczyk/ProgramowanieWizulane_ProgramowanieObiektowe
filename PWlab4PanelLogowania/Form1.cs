using System;
using System.Windows.Forms;

namespace PanelLogowania
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton1_Click(object sender, EventArgs e)
        {
            OtworzSystemKomputerowy(new BazaDanychWariantProsty());
        }

        private void loginButton2_Click(object sender, EventArgs e)
        {
            OtworzSystemKomputerowy(new BazaDanychWariantTrudniejszy());
        }

        private void OtworzSystemKomputerowy(IBazaDanych bazaDanych)
        {
            Uzytkownik uzytkownikZautoryzowany = bazaDanych.AutoryzujUzytkownika(uzytkownikTextBox.Text, hasloTextBox.Text);

            if (uzytkownikZautoryzowany != null)
            {
                Form2 okno = new Form2();

                okno.logowanie = this;
                okno.ImieLabel.Text = uzytkownikZautoryzowany.imie;
                okno.NazwiskoLabel.Text = uzytkownikZautoryzowany.nazwisko;

                okno.Show();

                Hide();
            }
            else
            {
                MessageBox.Show(this, "Nieprawidłowy użytkownik lub hasło!", "Błąd autoryzacji",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
