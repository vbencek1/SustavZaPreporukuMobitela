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
    public partial class Pitanje5 : UserControl
    {
        public Pitanje5()
        {
            InitializeComponent();
            btnNext.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pitanje4 p = new Pitanje4();
            this.Parent.Controls.Add(p);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pitanje6 p = new Pitanje6();
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

        private void radioPutovanje1_CheckedChanged(object sender, EventArgs e)
        {
            BazaOdgovora.tezina = 50;
            BazaOdgovora.gps = 50;
            BazaOdgovora.display = 100;
            btnNext.Enabled = true;
        }

        private void radioPutovanje2_CheckedChanged(object sender, EventArgs e)
        {
            BazaOdgovora.tezina = 50;
            BazaOdgovora.gps = 50;
            BazaOdgovora.display = 75;
            btnNext.Enabled = true;
        }

        private void radioPutovanje3_CheckedChanged(object sender, EventArgs e)
        {
            BazaOdgovora.tezina = 50;
            BazaOdgovora.gps = 100;
            BazaOdgovora.display = 50;
            btnNext.Enabled = true;
        }

        private void radioPutovanje4_CheckedChanged(object sender, EventArgs e)
        {
            BazaOdgovora.tezina = 0;
            BazaOdgovora.gps = 100;
            BazaOdgovora.display = 25;
            btnNext.Enabled = true;
        }

        private void radioPutovanje5_CheckedChanged(object sender, EventArgs e)
        {
            BazaOdgovora.tezina = 0;
            BazaOdgovora.gps = 100;
            BazaOdgovora.display = 0;
            btnNext.Enabled = true;
        }
    }
}
