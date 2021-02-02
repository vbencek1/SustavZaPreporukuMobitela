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
    public partial class Specifikacije : Form
    {
        Mobitel mobitel;
        public Specifikacije(Mobitel mob)
        {
            InitializeComponent();
            mobitel = mob;
            prikaziSpecifikacije(mobitel);
            btnClose.Hide();
        }

        private void prikaziSpecifikacije(Mobitel mobitel)
        {
            lab_key.Text = mobitel.brand;
            lblModel.Text = mobitel.model;
            lbl4G.Text = mobitel.fourG;
            lblAnnounced.Text = mobitel.announced;
            lblAudioJack.Text = mobitel.audio_jack;
            lblBackCamera.Text = mobitel.primary_camera;
            lblBattery.Text = mobitel.battery;
            lblBluetooth.Text = mobitel.bluetooth;
            lblColor.Text = mobitel.colors;
            lblCPU.Text = mobitel.CPU;
            lblDimensions.Text = mobitel.dimentions;
            lblDisplayResoultion.Text = mobitel.display_size;
            lblDisplaySize.Text = mobitel.display_resolution;
            lblEdge.Text = mobitel.EDGE;
            lblFrontCamera.Text = mobitel.secondary_camera;
            lblGPS.Text = mobitel.GPS;
            lblGPU.Text = mobitel.GPU;
            lblInternalMemory.Text = mobitel.internal_memory;
            lblLoudSpeaker.Text = mobitel.loud_speaker;
            lblMemoryCard.Text = mobitel.memory_card;
            lblNFC.Text = mobitel.NFC;
            lblOS.Text = mobitel.OS;
            lblPrice.Text = mobitel.approx_price_EUR;
            lblRadio.Text = mobitel.radio;
            lblRAM.Text = mobitel.RAM;
            lblSensors.Text = mobitel.sensors;
            lblSIM.Text = mobitel.SIM;
            lblUSB.Text = mobitel.USB;
            lblWeight.Text = mobitel.weight_g;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
