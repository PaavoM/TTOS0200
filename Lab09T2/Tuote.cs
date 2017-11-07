using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09T2
{
    class Tuote
    {
        public string Nimi { get; set; }
        public string Hinta { get; set; }

        public Tuote()
        {

        }

        public Tuote(string nimi, string hinta)
        {
            Nimi = nimi;
            Hinta = hinta;
        }

        public override string ToString()
        {
            return "Tuotteen nimi: " + Nimi + " Maksaa: " + Hinta + "e";
        }
    }
}
