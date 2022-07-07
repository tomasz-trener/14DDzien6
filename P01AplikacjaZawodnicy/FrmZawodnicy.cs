using P01AplikacjaZawodnicy.Domain;
using P01AplikacjaZawodnicy.Repositories;
using P01AplikacjaZawodnicy.ViewModels;
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
    public partial class FrmZawodnicy : Form
    {
        public FrmZawodnicy()
        {
            InitializeComponent();
        }

        public void Odswiez()
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();
            ZawodnicyResultVM resultVM = zr.PobierzZawodnikow(Convert.ToInt32(txtStrona.Text));
            ZbindujDaneZawodnikow(resultVM.Zawodnicy);
            lblLiczbaStron.Text = Convert.ToString(resultVM.LiczbaStron);
        }

        private void ZbindujDaneZawodnikow(Zawodnik[] zawodnicy)
        {
            lbDane.DataSource = zawodnicy;
            lbDane.DisplayMember = "ImieNazwiskoKraj";
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            Odswiez();
        }

        private void btnSzczegoly_Click(object sender, EventArgs e)
        {
            Zawodnik zaznaczony = (Zawodnik)lbDane.SelectedItem;


            FrmSzczegoly fs = new FrmSzczegoly(zaznaczony, this);
            fs.Show();


        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmSzczegoly fs = new FrmSzczegoly(this);
            fs.Show();
        }


        private void Szukaj()
        {
            if (txtSzukaj.Text.Length > 2)
            { 
                ZawodnicyRepository zr = new ZawodnicyRepository();
                ZawodnicyResultVM resultVM = zr.Szukaj(txtSzukaj.Text, Convert.ToInt32(txtStrona.Text));
                ZbindujDaneZawodnikow(resultVM.Zawodnicy);
                lblLiczbaStron.Text = Convert.ToString(resultVM.LiczbaStron);
            }
            else
                Odswiez();
        }

        private void txtSzukaj_TextChanged(object sender, EventArgs e)
        {
            Szukaj();
        }

        private void pbStronaLewo_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtStrona.Text)>1)
            {
                txtStrona.Text = Convert.ToString(Convert.ToInt32(txtStrona.Text) - 1);
                Szukaj();
            }
            
        }

        private void pbStronaPrawo_Click(object sender, EventArgs e)
        {
            txtStrona.Text = Convert.ToString(Convert.ToInt32(txtStrona.Text) + 1);
            Szukaj();
        }
    }
}
