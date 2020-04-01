using System.Collections.Generic;

namespace PanelLogowania
{
    class BazaDanychWariantProsty : IBazaDanych
    {
        private Dictionary<string, Uzytkownik> _uzytkownicy = new Dictionary<string, Uzytkownik>();

        public BazaDanychWariantProsty()
        {
            Uzytkownik uzytkownik1 = new Uzytkownik("AKaczmarczyk", "tajneHaslo", "Ania", "Kaczmarczyk");
            Uzytkownik uzytkownik2 = new Uzytkownik("MZmuda", "lab4", "Marcin", "Żmuda");
            Uzytkownik uzytkownik3 = new Uzytkownik("a", "a", "Super", "Admin");

            DodajUzytkownika(uzytkownik1);
            DodajUzytkownika(uzytkownik2);
            DodajUzytkownika(uzytkownik3);
        }

        public void DodajUzytkownika(Uzytkownik uzytkownik)
        {
            if (string.IsNullOrWhiteSpace(uzytkownik.login) || string.IsNullOrWhiteSpace(uzytkownik.haslo))
                return;

            if (!_uzytkownicy.ContainsKey(uzytkownik.login))
                _uzytkownicy[uzytkownik.login] = uzytkownik;
        }

        public Uzytkownik AutoryzujUzytkownika(string login, string haslo)
        {
            //sprawdź, czy użytkownik istnieje
            if (!_uzytkownicy.ContainsKey(login))
                return null; //użytkownik nie istnieje, więc zwróć niezainicjowany obiekt

            //pobierz użytkownika
            Uzytkownik uzytkownik = _uzytkownicy[login];

            //jeżeli hasła się nie pokrywają, zwróć pusty obiekt
            if (!_uzytkownicy[login].haslo.Equals(haslo))
                return null;
            
            return uzytkownik;
        }
    }
}
