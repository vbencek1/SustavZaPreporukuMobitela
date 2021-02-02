using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SustavZaPreporukuMobitela
{
    public partial class Pitanje8 : UserControl
    {
        public Pitanje8()
        {
            InitializeComponent();
            btnNext.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pitanje7 p = new Pitanje7();
            this.Parent.Controls.Add(p);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pitanje9 p = new Pitanje9();
            this.Parent.Controls.Add(p);
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
        }

        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(5, 171, 166);
            btnBack.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnNext_MouseEnter(object sender, EventArgs e)
        {
            btnNext.FlatAppearance.BorderColor = Color.FromArgb(5, 171, 166);
            btnNext.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            btnNext.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
        }

        private void radioFilm1_CheckedChanged(object sender, EventArgs e)
        {
            BazaOdgovora.poboljsaniZvucnik = 0;
            BazaOdgovora.audioPrikljucak = 0;
            btnNext.Enabled = true;
        }

        private void radioFilm2_CheckedChanged(object sender, EventArgs e)
        {
            BazaOdgovora.poboljsaniZvucnik = 50;
            BazaOdgovora.audioPrikljucak = 50;
            btnNext.Enabled = true;
        }

        private void radioFilm3_CheckedChanged(object sender, EventArgs e)
        {
            BazaOdgovora.poboljsaniZvucnik = 50;
            BazaOdgovora.audioPrikljucak = 100;
            btnNext.Enabled = true;
        }

        private void radioFilm4_CheckedChanged(object sender, EventArgs e)
        {
            BazaOdgovora.poboljsaniZvucnik = 100;
            BazaOdgovora.audioPrikljucak = 100;
            BazaOdgovora.display = (BazaOdgovora.display + 75) / 2;
            btnNext.Enabled = true;
        }

        private void radioFilm5_CheckedChanged(object sender, EventArgs e)
        {
            BazaOdgovora.poboljsaniZvucnik = 100;
            BazaOdgovora.audioPrikljucak = 100;
            BazaOdgovora.display = (BazaOdgovora.display + 100) / 2;
            btnNext.Enabled = true;
        }
        private void Pitanje8_Load(object sender, EventArgs e)
        {

        }
    }
}
