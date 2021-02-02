using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SustavZaPreporukuMobitela
{
    public class Mobitel
    {
        public String key;
        public String brand;
        public String model;
        public String fourG;
        public String EDGE;
        public String announced;
        public String dimentions;
        public String weight_g;
        public String SIM;
        public String display_resolution;
        public String display_size;
        public String OS;
        public String CPU;
        public String GPU;
        public String memory_card;
        public String internal_memory;
        public String RAM;
        public String primary_camera;
        public String secondary_camera;
        public String loud_speaker;
        public String audio_jack;
        public String bluetooth;
        public String GPS;
        public String NFC;
        public String radio;
        public String USB;
        public String sensors;
        public String battery;
        public String colors;
        public String approx_price_EUR;
        public String img_url;

        public Mobitel(string key, string brand, string model, string fourG, string eDGE, string announced, string dimentions, string weight_g, string sIM, string display_resolution, string display_size, string oS, string cPU, string gPU, string memory_card, string internal_memory, string rAM, string primary_camera, string secondary_camera, string loud_speaker, string audio_jack, string bluetooth, string gPS, string nFC, string radio, string uSB, string sensors, string battery, string colors, string approx_price_EUR, string img_url)
        {
            this.key = key;
            this.brand = brand;
            this.model = model;
            this.fourG = fourG;
            EDGE = eDGE;
            this.announced = announced;
            this.dimentions = dimentions;
            this.weight_g = weight_g;
            SIM = sIM;
            this.display_resolution = display_resolution;
            this.display_size = display_size;
            OS = oS;
            CPU = cPU;
            GPU = gPU;
            this.memory_card = memory_card;
            this.internal_memory = internal_memory;
            RAM = rAM;
            this.primary_camera = primary_camera;
            this.secondary_camera = secondary_camera;
            this.loud_speaker = loud_speaker;
            this.audio_jack = audio_jack;
            this.bluetooth = bluetooth;
            GPS = gPS;
            NFC = nFC;
            this.radio = radio;
            USB = uSB;
            this.sensors = sensors;
            this.battery = battery;
            this.colors = colors;
            this.approx_price_EUR = approx_price_EUR;
            this.img_url = img_url;
        }
    }

}
