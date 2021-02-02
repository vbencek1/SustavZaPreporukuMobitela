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
    public partial class Pitanje14 : UserControl
    {
        public Pitanje14()
        {
            InitializeComponent();
            btnNext.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pitanje13 p = new Pitanje13();
            this.Parent.Controls.Add(p);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pitanje15 p = new Pitanje15();
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

        private void radioEdgeDa_CheckedChanged(object sender, EventArgs e)
        {
            BazaOdgovora.zaobljeniEkran = 100;
            btnNext.Enabled = true;
        }

        private void radioEdgeNe_CheckedChanged(object sender, EventArgs e)
        {
            BazaOdgovora.zaobljeniEkran = 0;
            btnNext.Enabled = true;
        }

        private void radioEdgeSvejedno_CheckedChanged(object sender, EventArgs e)
        {
            BazaOdgovora.zaobljeniEkran = 50;
            btnNext.Enabled = true;
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
