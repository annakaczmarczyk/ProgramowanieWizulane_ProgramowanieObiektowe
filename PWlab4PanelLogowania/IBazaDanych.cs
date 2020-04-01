namespace PanelLogowania
{
    interface IBazaDanych
    {
        void DodajUzytkownika(Uzytkownik uzytkownik);

        Uzytkownik AutoryzujUzytkownika(string login, string haslo);
    }
}
