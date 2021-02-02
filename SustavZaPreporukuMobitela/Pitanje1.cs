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
    public partial class Pitanje1 : UserControl
    {
        public Pitanje1()
        {
            InitializeComponent();
            btnNext.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPocetna fp = new FormPocetna();
            fp.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pitanje2 p = new Pitanje2();
            this.Parent.Controls.Add(p);
        }

        private void Pitanje1_Load(object sender, EventArgs e)
        {

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

        private void listaBrendova_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<String> odgBrand = new List<string>();
            foreach (String brend in listaBrendova.SelectedItems)
            {
                odgBrand.Add(brend);
            }

            if (listaBrendova.SelectedItems.Count > 0 && listaBrendova.SelectedItems.Count <= 3)
            {
                BazaOdgovora.brand = odgBrand;
                btnNext.Enabled = true;
            }
            else
            {
                btnNext.Enabled = false;
            }
        }
    }
    
}
