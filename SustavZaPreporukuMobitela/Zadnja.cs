using SustavZaPreporukuMobitelaML.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SustavZaPreporukuMobitelaML;
using System.Diagnostics;

namespace SustavZaPreporukuMobitela
{
    public partial class Zadnja : UserControl
    {
        Mobitel mob1 = null;
        Mobitel mob2 = null;
        Mobitel mob3 = null;

        public Zadnja()
        {
            InitializeComponent();
        }
        private String posloziArgumente()
        {
            return BazaOdgovora.cetriG + " " + BazaOdgovora.zaobljeniEkran + " " + BazaOdgovora.godina + " " + BazaOdgovora.tezina + " " +
                BazaOdgovora.sim + " " + BazaOdgovora.display + " " + BazaOdgovora.operacijskiSistem + " " + BazaOdgovora.cpu + " " +
                BazaOdgovora.memorijskaKartica + " " + BazaOdgovora.unutarnjaMemorija + " " + BazaOdgovora.ram + " " + BazaOdgovora.kamera + " " +
                BazaOdgovora.poboljsaniZvucnik + " " + BazaOdgovora.audioPrikljucak + " " + BazaOdgovora.bluetooth + " " + BazaOdgovora.gps + " " +
                BazaOdgovora.nfc+" "+BazaOdgovora.radio+" " +BazaOdgovora.baterija+" "+BazaOdgovora.budzet;
        }

        private void predikcija()
        {
            List<String> brendovi = BazaOdgovora.brand;
            var processes = new List<Process>();
            ProcessStartInfo startInfo = new ProcessStartInfo(
                @"..\..\..\SustavZaPreporukuMobitelaML.ConsoleApp\bin\Debug\netcoreapp3.1\SustavZaPreporukuMobitelaML.ConsoleApp.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments="pid1 "+brendovi.ElementAt(0)+" "+posloziArgumente();
            processes.Add(Process.Start(startInfo));
            if (brendovi.Count > 1)
            {
                startInfo.Arguments = "pid2 " + brendovi.ElementAt(1) + " " + posloziArgumente();
                processes.Add(Process.Start(startInfo));
            }
            if (brendovi.Count > 2)
            {
                startInfo.Arguments = "pid3 " + brendovi.ElementAt(2) + " " + posloziArgumente();
                processes.Add(Process.Start(startInfo));
            }
            foreach (var process in processes)
            {
                process.WaitForExit();
                process.Close();
            }
        }
        private void prikaziData()
        {
            predikcija();
            List<String> brendovi = BazaOdgovora.brand;
            string imeMob1 = System.IO.File.ReadAllText(@"../../../predikcija1.txt");
            mob1 = BazaOdgovora.dajMobitel(imeMob1);
            if (brendovi.Count > 1)
            {
                string imeMob2 = System.IO.File.ReadAllText(@"../../../predikcija2.txt");
                mob2 = BazaOdgovora.dajMobitel(imeMob2);
            }
            if (brendovi.Count > 2)
            {
                string imeMob3 = System.IO.File.ReadAllText(@"../../../predikcija3.txt");
                mob3 = BazaOdgovora.dajMobitel(imeMob3);
            }

        }
        private void btn_preporuci_Click(object sender, EventArgs e)
        {
            this.btn_preporuci.Hide();
            using (ZadLoadingForm zlf = new ZadLoadingForm(prikaziData))
                zlf.ShowDialog();
            if (mob1 != null)
            {
                lblNazivMobitela1.Show();
                lblNazivMobitela1.Text = mob1.model;
                try
                {
                    pictureBox_mob1.Load(mob1.img_url);
                }
                catch (Exception ex) {
                    try
                    {
                        String url = mob1.img_url.Replace("cdn2", "fdn2");
                        pictureBox_mob1.Load(url);
                    }
                    catch (Exception exc)
                    {
                        pictureBox_mob1.Image = Image.FromFile(@"../../../mob.jpg");
                    }
                }
            btn_spec1.Show();
            }
            if (mob2 != null && mob2!=mob1)
            {
                lblNazivMobitela2.Show();
                lblNazivMobitela2.Text = mob2.model;
                try {
                    pictureBox_mob2.Load(mob2.img_url);
                }
                catch (Exception ex)
                {
                    try
                    {
                        String url = mob2.img_url.Replace("cdn2", "fdn2");
                        pictureBox_mob2.Load(url);
                    }
                    catch (Exception ecx)
                    {
                        pictureBox_mob2.Image = Image.FromFile(@"../../../mob.jpg");
                    }
                }
                btn_spec2.Show();
            }
            if (mob3 != null && mob3!=mob2 && mob3!=mob1)
            {
                lblNazivMobitela3.Show();
                lblNazivMobitela3.Text = mob3.model;
                try {
                    pictureBox_mob3.Load(mob3.img_url);
                }
                catch (Exception ex)
                {
                    try
                    {
                        String url = mob3.img_url.Replace("cdn2", "fdn2");
                        pictureBox_mob3.Load(url);
                    }
                    catch (Exception exc)
                    {
                        pictureBox_mob3.Image = Image.FromFile(@"../../../mob.jpg");
                    }
                }
                btn_spec3.Show();
            }
        }

        private void btn_spec1_Click(object sender, EventArgs e)
        {
            if (mob1 != null)
            {
                Specifikacije frmSpec = new Specifikacije(mob1);
                frmSpec.Show();
            }
        }

        private void btn_spec2_Click(object sender, EventArgs e)
        {
            if (mob2 != null)
            {
                Specifikacije frmSpec = new Specifikacije(mob2);
                frmSpec.Show();
            }
        }

        private void btn_spec3_Click(object sender, EventArgs e)
        {
            if (mob3 != null)
            {
                Specifikacije frmSpec = new Specifikacije(mob3);
                frmSpec.Show();
            }
        }

        private void Zadnja_Load(object sender, EventArgs e)
        {
            this.lblNazivMobitela1.Hide();
            this.lblNazivMobitela2.Hide();
            this.lblNazivMobitela3.Hide();
            this.btn_spec1.Hide();
            this.btn_spec2.Hide();
            this.btn_spec3.Hide();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
