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
    public partial class FrmZawodnicy : Form
    {
        public FrmZawodnicy()
        {
            InitializeComponent();
        }

        public void Odswiez()
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();
            lbDane.DataSource = zr.PobierzZawodnikow();
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
    }
}
