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
    public partial class Pitanje7 : UserControl
    {
        public Pitanje7()
        {
            InitializeComponent();
            btnNext.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pitanje6 p = new Pitanje6();
            this.Parent.Controls.Add(p);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pitanje8 p = new Pitanje8();
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

        private void radioGaming1_CheckedChanged(object sender, EventArgs e)
        {
            BazaOdgovora.cpu = 20;
            BazaOdgovora.ram = 0;
            BazaOdgovora.unutarnjaMemorija = 0;
            btnNext.Enabled = true;
        }

        private void radioGaming2_CheckedChanged(object sender, EventArgs e)
        {
            BazaOdgovora.cpu = 40;
            BazaOdgovora.ram = 25;
            BazaOdgovora.unutarnjaMemorija = 25;
            btnNext.Enabled = true;
        }

        private void radioGaming3_CheckedChanged(object sender, EventArgs e)
        {
            BazaOdgovora.cpu = 60;
            BazaOdgovora.ram = 50;
            BazaOdgovora.unutarnjaMemorija = 50;
            btnNext.Enabled = true;
        }

        private void radioGaming4_CheckedChanged(object sender, EventArgs e)
        {
            BazaOdgovora.cpu = 80;
            BazaOdgovora.ram = 75;
            BazaOdgovora.unutarnjaMemorija = 75;
            btnNext.Enabled = true;
        }

        private void radioGaming5_CheckedChanged(object sender, EventArgs e)
        {
            BazaOdgovora.cpu = 100;
            BazaOdgovora.ram = 100;
            BazaOdgovora.unutarnjaMemorija = 100;
            btnNext.Enabled = true;
        }

        
    }
}
