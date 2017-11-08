using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09T6
{
    class Tuote
    {
        public string Nimi { get; set; }
        public double Hinta { get; set; }
        public int Maara { get; set; }
        public double Total { get; set; }

        public Tuote()
        {

        }

        public Tuote(string nimi, double hinta)
        {
            Nimi = nimi;
            Hinta = hinta;

        }
        public void LaskeHinta()
        {
            Hinta = Hinta * Maara;
        }
        public override string ToString()
        {

            return "Tuotteen nimi: " + Nimi + " Maksaa: " + Hinta + "e" + "Kokonais:" + (Total == Hinta * Maara);
        }
    }
}
