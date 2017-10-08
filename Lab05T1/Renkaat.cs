using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05T1
{
    class Renkaat : Kulkuneuvo
    {
        public string Merkki { get; set; }
        public string Tyyppi { get; set; }
        public int Koko { get; set; }
        public Renkaat()
        {

        }
        public Renkaat(string merkki, string tyyppi, int koko)
        {
            Merkki = merkki;
            Tyyppi = tyyppi;
            Koko = koko;
        }
        public override string ToString()
        {
            return "Merkki: " + Merkki + " "+ "Tyyppi: " + Tyyppi + " "+ "Koko: " + Koko;
        }
        
    }
}
