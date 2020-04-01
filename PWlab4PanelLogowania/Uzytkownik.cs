namespace PanelLogowania
{
    class Uzytkownik
    {
        public string login;

        public string haslo;

        public string imie;

        public string nazwisko;

        public Uzytkownik(string login, string haslo, string imie, string nazwisko)
        {
            this.login = login;
            this.haslo = haslo;
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
    }
}
