using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09T3
{
    class Saalis
    {
        public string Laji { get; set; }
        public int Pituus { get; set; }
        public double Paino { get; set; }
        public string Paikka { get; set; }
        public string Sijainti { get; set; }

        public Saalis()
        {

        }
        public Saalis(string laji, int pituus, double paino, string paikka, string sijainti)
        {
            Laji = laji;
            Pituus = pituus;
            Paino = paino;
            Paikka = paikka;
            Sijainti = sijainti;
        }
        public override string ToString()
        {
            return "Laji: " + Laji+ " " + Pituus + "cm " + Paino + "kg \n" + "Paikka: " + Paikka + "\n" + "Sijainti: " + Sijainti + "\n";
        }
    }
}
