using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02KomunikacjaPomiedzyFormularzami
{
    public partial class FrmSzczegoly : Form
    {
        private readonly FrmStartowy frmStartowy;

        // Publiczna Wlasciwosc daje nam dostep do prywatnego pola
        public TextBox TxtDane {  get { return txtDane; } }

        public FrmSzczegoly(FrmStartowy frmStartowy)
        {
            InitializeComponent();
            this.frmStartowy = frmStartowy;
        }

        private void btnWyslij_Click(object sender, EventArgs e)
        {
            frmStartowy.TxtDane.Text = txtDane.Text;
        }

        private void FrmSzczegoly_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmStartowy.FrmSzczegoly = null;
        }
    }
}
