using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01AplikacjaZawodnicy.Domain
{
    public class Zawodnik
    {
        public int Id_zawodnika;
        public int Id_trenera;
        public string Imie;
        public string Nazwisko { get; set; }
        public string Kraj;
        public DateTime DataUrodzenia;
        public int Wzrost;
        public int Waga;

        public string ImieNazwiskoKraj
        {
            get
            {
                return
                    Imie + " " +
                    Nazwisko + " " +
                    Kraj;
            }
        }

        public string DaneZeWzrostem
        {
            get { return ImieNazwiskoKraj + " " + Wzrost; }
        }
        public Zawodnik()
        {
        }

        public Zawodnik(object[] komorki)
        {
            Id_zawodnika = (int)komorki[0];

            if (komorki[1] != DBNull.Value)
                Id_trenera = (int)komorki[1];

            Imie = (string)komorki[2];
            Nazwisko = (string)komorki[3];
            Kraj = (string)komorki[4];
            DataUrodzenia = (DateTime)komorki[5];
            Wzrost = (int)komorki[6];
            Waga = (int)komorki[7];
        }


    }
}
