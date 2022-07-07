using P01AplikacjaZawodnicy.Domain;
using P01AplikacjaZawodnicy.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01AplikacjaZawodnicy
{
    public partial class FrmSzczegoly : Form
    {
        enum TrybOkienka
        {
            Dodawanie,
            Edycja
        }


        private Zawodnik zaznaczony;
        private readonly FrmZawodnicy frmZawodnicy;

        private TrybOkienka trybOkienka => zaznaczony == null ? TrybOkienka.Dodawanie : TrybOkienka.Edycja;

        //{
        //    get
        //    {
        //        return zaznaczony == null ? TrybOkienka.Dodawanie : TrybOkienka.Edycja;
        //    }
        //}

        public FrmSzczegoly()
        {
            InitializeComponent();
        }

        public FrmSzczegoly(FrmZawodnicy frmZawodnicy) :this()
        {
            this.frmZawodnicy = frmZawodnicy;
        }

        public FrmSzczegoly(Zawodnik zaznaczony, FrmZawodnicy frmZawodnicy) : this(frmZawodnicy)
        {
            this.zaznaczony = zaznaczony;
            txtImie.Text = zaznaczony.Imie;
            txtNazwisko.Text = zaznaczony.Nazwisko;
            txtKraj.Text = zaznaczony.Kraj;
            dtpDataUr.Value = zaznaczony.DataUrodzenia;
            numWaga.Value = zaznaczony.Waga;
            numWzrost.Value = zaznaczony.Wzrost;
            btnUsun.Visible = true;
        }

      

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();
            if (trybOkienka == TrybOkienka.Dodawanie)
            {
                zaznaczony = new Zawodnik(); // jak jestesmy w trybie dodwania to tworzymy nowego zawodnika
                ZczytajDaneZkontrolek();
                zr.Dodaj(zaznaczony);
            }
            else if (trybOkienka == TrybOkienka.Edycja)
            {
                ZczytajDaneZkontrolek();
                zr.Edytuj(zaznaczony);
            }
            frmZawodnicy.Odswiez();
            this.Close();
        }

        private void ZczytajDaneZkontrolek()
        {
            zaznaczony.Imie = txtImie.Text;
            zaznaczony.Nazwisko = txtNazwisko.Text;
            zaznaczony.Kraj = txtKraj.Text;
            zaznaczony.DataUrodzenia = dtpDataUr.Value;
            zaznaczony.Wzrost = Convert.ToInt32(numWzrost.Value);
            zaznaczony.Waga = Convert.ToInt32(numWaga.Value);
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            DialogResult dr= MessageBox.Show("Czy na pewno chcesz usunac zawodnika?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                ZawodnicyRepository zr = new ZawodnicyRepository();
                zr.Usun(zaznaczony);
                frmZawodnicy.Odswiez();
                this.Close();
            }
           
        }
    }
}
