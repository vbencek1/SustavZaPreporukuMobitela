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
    public partial class Pitanje4 : UserControl
    {
        public Pitanje4()
        {
            InitializeComponent();
            btnNext.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pitanje3 p = new Pitanje3();
            this.Parent.Controls.Add(p);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            this.Hide();
            Pitanje5 p = new Pitanje5();
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

        private void radioOSiOS_CheckedChanged(object sender, EventArgs e)
        {

            BazaOdgovora.operacijskiSistem = "ios";
            btnNext.Enabled = true;
        }

        private void radioOSAndroid_CheckedChanged(object sender, EventArgs e)
        {
            BazaOdgovora.operacijskiSistem = "android";
            btnNext.Enabled = true;
        }

        private void radioOSWindows_CheckedChanged(object sender, EventArgs e)
        {
            BazaOdgovora.operacijskiSistem = "windows";
            btnNext.Enabled = true;
        }
    }
}
