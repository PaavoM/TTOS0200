using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kertaustehtävä
{
    public class Opettaja
    {
        string Nimi { get; set; }
        int Ikä { get; set; }

        public Opettaja(string nimi, int ikä)
        {
            Nimi = nimi;
            Ikä = ikä;
        }

        public override string ToString()
        {
            return "Opettajan nimi: "+ Nimi +" ja ikä " + Ikä;
        }
    }
}
