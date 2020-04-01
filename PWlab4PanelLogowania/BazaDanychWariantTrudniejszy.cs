using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace PanelLogowania
{
    class BazaDanychWariantTrudniejszy : IBazaDanych
    {
        private Dictionary<string, Uzytkownik> _uzytkownicy = new Dictionary<string, Uzytkownik>();

        //obsługa funkcji skrótu MD5.
        //użyty kod pochodzi ze strony https://docs.microsoft.com/pl-pl/dotnet/api/system.security.cryptography.md5
        private MD5 md5Hash = MD5.Create();

        public BazaDanychWariantTrudniejszy()
        {
            Uzytkownik uzytkownik1 = new Uzytkownik("AKaczmarczyk", GetMd5Hash(md5Hash, "tajneHaslo"), "Ania", "Kaczmarczyk");
            Uzytkownik uzytkownik2 = new Uzytkownik("MZmuda", GetMd5Hash(md5Hash, "lab4"), "Marcin", "Żmuda");
            Uzytkownik uzytkownik3 = new Uzytkownik("a", GetMd5Hash(md5Hash, "a"), "Super", "Admin");

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

            //https://docs.microsoft.com/pl-pl/dotnet/api/system.security.cryptography.md5

            //pobierz użytkownika
            Uzytkownik uzytkownik = _uzytkownicy[login];

            var zaszyfrowaneHaslo = _uzytkownicy[login].haslo;

            //jeżeli hasła się nie pokrywają, zwróć pusty obiekt
            if (!VerifyMd5Hash(md5Hash, haslo, zaszyfrowaneHaslo))
                return null;

            return uzytkownik;
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        // Verify a hash against a string.
        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
