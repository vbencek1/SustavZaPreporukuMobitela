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
    public partial class FormPocetna : Form
    {

        public FormPocetna()
        {
            InitializeComponent();
            pitanje11.Hide();
            pitanje21.Hide();
            pitanje31.Hide();
            pitanje41.Hide();
            pitanje51.Hide();
            pitanje61.Hide();
            pitanje71.Hide();
            pitanje81.Hide();
            pitanje91.Hide();
            pitanje101.Hide();
            pitanje111.Hide();
            pitanje121.Hide();
            pitanje131.Hide();
            pitanje141.Hide();
            pitanje151.Hide();
            zadnja1.Hide();
            BazaOdgovora.ucitajMobitele();

        }

        private void BtnPocetak_Click(object sender, EventArgs e)
        {
            panelPocetna.Hide();
            pitanje11.Show();
            pitanje11.BringToFront();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
