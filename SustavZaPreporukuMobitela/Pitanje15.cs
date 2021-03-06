﻿using System;
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
    public partial class Pitanje15 : UserControl
    {
        public Pitanje15()
        {
            InitializeComponent();
            btnNext.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pitanje14 p = new Pitanje14();
            this.Parent.Controls.Add(p);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            Zadnja z = new Zadnja();
            this.Parent.Controls.Add(z);

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

        private void radioModelNovi_CheckedChanged(object sender, EventArgs e)
        {
            BazaOdgovora.godina = 100;
            btnNext.Enabled = true;
        }

        private void radioModelStari_CheckedChanged(object sender, EventArgs e)
        {
            BazaOdgovora.godina = 0;
            btnNext.Enabled = true;
        }

        private void radioModelSvejedno_CheckedChanged(object sender, EventArgs e)
        {
            BazaOdgovora.godina = 50;
            btnNext.Enabled = true;
        }
    }
}
