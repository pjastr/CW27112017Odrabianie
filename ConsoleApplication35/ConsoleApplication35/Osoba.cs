using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication35
{
    class Osoba
    {
        private int wiek; //deklaracja pola
        public Urodziny ur; //pole referencyjne

        //konstruktor domyślny (uzupełniamy o tworzenie obiektu)
        public Osoba()
        {
            ur = new Urodziny();
        }

        //konstruktor parametryczny
        public Osoba(int wiek, string miejsce)
        {
            this.wiek = wiek;
            ur = new Urodziny();
            ur.UstawMiejsceUr(miejsce);
        }

        public void UstawWiek(int wiek) //metoda na ustawienie wieku
        {
            this.wiek = wiek;
        }

        public int PobierzWiek() //metoda na pobranie wieku
        {
            return wiek;
        }

        public Osoba GlebokaKopia() //implementacja głębokiej kopii
        {
            Osoba tempOsoba = new Osoba();
            tempOsoba.wiek = this.wiek;
            tempOsoba.ur.UstawMiejsceUr(this.ur.PobierzMiejsceUr());
            return tempOsoba;

        }
    }
}
