using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SustavZaPreporukuMobitela
{
    public partial class Pitanje3 : UserControl
    {
        public Pitanje3()
        {
            InitializeComponent();
            btnNext.Enabled = false;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pitanje2 p = new Pitanje2();
            this.Parent.Controls.Add(p);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pitanje4 p = new Pitanje4();
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


        private void radioKorist1h_CheckedChanged(object sender, EventArgs e)
        {
            BazaOdgovora.baterija = 0;
            btnNext.Enabled = true;
        }

        private void radioKorist12h_CheckedChanged(object sender, EventArgs e)
        {
            BazaOdgovora.baterija = 25;
            btnNext.Enabled = true;
        }


        private void radioKorist24h_CheckedChanged(object sender, EventArgs e)
        {
            BazaOdgovora.baterija = 50;
            btnNext.Enabled = true;
        }

        private void radioKorist48h_CheckedChanged(object sender, EventArgs e)
        {
            BazaOdgovora.baterija = 75;
            btnNext.Enabled = true;
        }

        private void radioKorist8h_CheckedChanged(object sender, EventArgs e)
        {
            BazaOdgovora.baterija = 100;
            btnNext.Enabled = true;
        }
    }
}
