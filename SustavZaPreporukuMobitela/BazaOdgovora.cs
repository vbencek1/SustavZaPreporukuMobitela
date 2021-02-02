using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SustavZaPreporukuMobitela
{
    public static class BazaOdgovora
    {
        public static List<String> brand = new List<string>();
        public static float budzet = 0;
        public static float baterija = 0;
        public static String operacijskiSistem = "";
        public static float tezina = 0;
        public static float gps = 0;
        public static float display = 0;
        public static float kamera = 0;
        public static float memorijskaKartica = 0;
        public static float cpu = 0;
        public static float ram = 0;
        public static float unutarnjaMemorija = 0;
        public static float poboljsaniZvucnik=0;
        public static float audioPrikljucak = 0;
        public static float radio = 0;
        public static float nfc = 0;
        public static float cetriG = 0;
        public static float bluetooth = 0;
        public static float sim = 0;
        public static float zaobljeniEkran = 0;
        public static float godina = 0;

        public static List<Mobitel> mobiteli = new List<Mobitel>();

        public static void ucitajMobitele()
        {
            using (TextFieldParser parser = new TextFieldParser(@"../../../podaci_mobiteli.csv"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(";");
                if (!parser.EndOfData)
                {
                    parser.ReadFields();
                }
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    Mobitel mob = new Mobitel(fields[0], fields[1], fields[2], fields[3], fields[4], fields[5],
                        fields[6], fields[7], fields[8], fields[9], fields[10], fields[11],
                        fields[12], fields[13], fields[14], fields[15], fields[16], fields[17],
                        fields[18], fields[19], fields[20], fields[21], fields[22], fields[23],
                        fields[24], fields[25], fields[26], fields[27], fields[28], fields[29], fields[30]);
                    mobiteli.Add(mob);                    
                }
            }
        }

        public static Mobitel dajMobitel(String key)
        {
            foreach(Mobitel mob in mobiteli)
            {
                if (mob.key == key)
                {
                    return mob;
                }
            }
            return null;
        }

    }
}
