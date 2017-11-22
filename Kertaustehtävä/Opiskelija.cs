using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kertaustehtävä
{
    public class Opiskelija
    {
        string Nimi { get; set; }
        int Ikä { get; set; }
        public static int opiskelijoidenlkm = 0;
        public Opiskelija(string nimi, int ikä)
        {
            Nimi = nimi;
            Ikä = ikä;
            opiskelijoidenlkm++;
        }
        public static int Montako()
        {
            return opiskelijoidenlkm;
        }

        public override string ToString()
        {
            return "Oppilaan nimi: " + Nimi + " ja ikä " + Ikä;
        }
    }
}
