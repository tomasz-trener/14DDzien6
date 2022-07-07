using P01AplikacjaZawodnicy.Domain;
using P01AplikacjaZawodnicy.ViewModels;
using P04BibliotekaPolaczenieZBaza;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01AplikacjaZawodnicy.Repositories
{
    //http://github.com/tomasz-trener/14DDzien6
    //przerwa 13:40
    internal class ZawodnicyRepository
    {

        public ZawodnicyResultVM PobierzZawodnikow(int strona)
        {
            return Szukaj("", strona);
            //PolaczenieZBaza pzb = new PolaczenieZBaza();

            //string sql = "SELECT id_zawodnika, id_trenera, imie, nazwisko, kraj, data_ur, wzrost,waga FROM zawodnicy";

            //object[][] wynik = pzb.WykonajPolecenieSQL(sql);

            //return transformujNaZawodnikow(wynik);
        }

        private Zawodnik[] transformujNaZawodnikow(object[][] dane)
        {
            int liczbaWierszy = dane.Length;
            Zawodnik[] zawodnicy = new Zawodnik[liczbaWierszy];
            for (int i = 0; i < liczbaWierszy; i++)
                zawodnicy[i] = new Zawodnik(dane[i]);

            return zawodnicy;
        }

        private SqlParameter[] stworzParametryPodstawowe(Zawodnik zaznaczony)
        {
            SqlParameter[] sqlParameters =
          {
                new SqlParameter()
                {
                    ParameterName="@imie", Value= zaznaczony.Imie, SqlDbType= System.Data.SqlDbType.VarChar
                },
                new SqlParameter()
                {
                    ParameterName="@nazwisko", Value= zaznaczony.Nazwisko, SqlDbType= System.Data.SqlDbType.VarChar
                },
                new SqlParameter()
                {
                    ParameterName="@kraj", Value= zaznaczony.Kraj, SqlDbType= System.Data.SqlDbType.VarChar
                },
                new SqlParameter()
                {
                    ParameterName="@data_ur", Value= zaznaczony.DataUrodzenia, SqlDbType= System.Data.SqlDbType.DateTime
                },
                new SqlParameter()
                {
                    ParameterName="@waga", Value= zaznaczony.Waga, SqlDbType= System.Data.SqlDbType.Int
                },
                new SqlParameter()
                {
                    ParameterName="@wzrost", Value= zaznaczony.Wzrost, SqlDbType= System.Data.SqlDbType.Int
                },
            };
            return sqlParameters;
        }

        internal ZawodnicyResultVM Szukaj(string text, int strona)
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza();
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter()
                {
                    ParameterName = "@dane",
                    Value = text,
                    SqlDbType = System.Data.SqlDbType.VarChar
                },
                 new SqlParameter()
                {
                    ParameterName = "@ile",
                    Value = 3,
                    SqlDbType = System.Data.SqlDbType.Int
                },
                   new SqlParameter()
                {
                    ParameterName = "@strona",
                    Value = strona,
                    SqlDbType = System.Data.SqlDbType.Int
                },
            };

            WynikRozbudowany wynikRozbudowany = pzb.WykonajPolecenieSQLZLiczbaStron("Szukaj",
                sqlParameters,
                System.Data.CommandType.StoredProcedure);

            return new ZawodnicyResultVM()
            {
                Zawodnicy = transformujNaZawodnikow(wynikRozbudowany.Wynik),
                LiczbaStron = wynikRozbudowany.LiczbaStron
            };
        }

        internal void Edytuj(Zawodnik zaznaczony)
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza();

            string sql = @"update zawodnicy set 
                           imie = @imie, 
                           nazwisko = @nazwisko,
                           kraj = @kraj,
                           data_ur = @data_ur,
                           waga = @waga,
                           wzrost = @wzrost
                           where id_zawodnika = @id";
            
            List<SqlParameter> sqlParameters = stworzParametryPodstawowe(zaznaczony).ToList();
            sqlParameters.Add(new SqlParameter()
            {
                ParameterName = "@id",
                Value = zaznaczony.Id_zawodnika,
                SqlDbType = System.Data.SqlDbType.Int
            });

            pzb.WykonajPolecenieSQL(sql, sqlParameters.ToArray());

        }

        internal void Usun(Zawodnik zaznaczony)
        {
            string sql = "delete zawodnicy where id_zawodnika=@id";

            SqlParameter sqlParameter = new SqlParameter()
            {
                ParameterName = "@id",
                Value = zaznaczony.Id_zawodnika,
                SqlDbType = System.Data.SqlDbType.Int
            };
            PolaczenieZBaza pzb = new PolaczenieZBaza();
            pzb.WykonajPolecenieSQL(sql, new SqlParameter[] { sqlParameter });
        }

        internal void Dodaj(Zawodnik zaznaczony)
        {
            string sql = @"insert into zawodnicy 
                        (imie, nazwisko, kraj, data_ur, wzrost,waga)
                        values (@imie,@nazwisko,@kraj,@data_ur,@wzrost,@waga)";

            PolaczenieZBaza pzb = new PolaczenieZBaza();
            SqlParameter[] sqlParameters = stworzParametryPodstawowe(zaznaczony);

            pzb.WykonajPolecenieSQL(sql, sqlParameters);
        }
    }
}
