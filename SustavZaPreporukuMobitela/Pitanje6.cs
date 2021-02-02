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
    public partial class Pitanje6 : UserControl
    {
        public Pitanje6()
        {
            InitializeComponent();
            btnNext.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pitanje5 p = new Pitanje5();
            this.Parent.Controls.Add(p);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pitanje7 p = new Pitanje7();
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

        private void radioFoto1_CheckedChanged(object sender, EventArgs e)
        {
            BazaOdgovora.memorijskaKartica = 0;
            BazaOdgovora.kamera = 0;
            btnNext.Enabled = true;
        }

        private void radioFoto2_CheckedChanged(object sender, EventArgs e)
        {
            BazaOdgovora.memorijskaKartica = 0;
            BazaOdgovora.kamera = 25;
            btnNext.Enabled = true;
        }

        private void radioFoto3_CheckedChanged(object sender, EventArgs e)
        {
            BazaOdgovora.memorijskaKartica = 100;
            BazaOdgovora.kamera = 50;
            btnNext.Enabled = true;
        }

        private void radioFoto4_CheckedChanged(object sender, EventArgs e)
        {
            BazaOdgovora.memorijskaKartica = 100;
            BazaOdgovora.kamera = 75;
            btnNext.Enabled = true;
        }

        private void radioFoto5_CheckedChanged(object sender, EventArgs e)
        {
            BazaOdgovora.memorijskaKartica = 100;
            BazaOdgovora.kamera = 100;
            btnNext.Enabled = true;
        }
    }
}
