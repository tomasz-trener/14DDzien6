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
    public partial class FrmStartowy : Form
    {
        public FrmSzczegoly FrmSzczegoly;

        public TextBox TxtDane { get { return txtDane; } }
        public FrmStartowy()
        {
            InitializeComponent();
        }

        private void btnWyslij_Click(object sender, EventArgs e)
        {
            FrmSzczegoly.TxtDane.Text = txtDane.Text;
        }

        private void btnPokaz_Click(object sender, EventArgs e)
        {
            if (FrmSzczegoly==null)
            {
                FrmSzczegoly = new FrmSzczegoly(this);
                FrmSzczegoly.Show();
            }
         

           
        }
    }
}
