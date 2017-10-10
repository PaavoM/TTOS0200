using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05T5
{
    class Komponentti
    {
        public string Nimi { get; set; }
        public string Tehtävä { get; set; }
        public int Hinta { get; set; }

        public Komponentti()
        {

        }
        public Komponentti(string nimi, string tehtävä, int hinta)
        {
            Nimi = nimi;
            Tehtävä = tehtävä;
            Hinta = hinta;
        }
        public override string ToString()
        {
            return "Komponentin nimi: " + Nimi + " " + "Komponentin Tehtävä: " + Tehtävä + " " + "Komponentin hinta: " + Hinta + "E";
        }
    }
}
