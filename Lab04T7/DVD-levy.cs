using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04T7
{
    class DVD_levy : Media
    {
        public int Koko { get; set; }
        public string Sisältää { get; set; }

        public DVD_levy()
        {

        }
        public DVD_levy( string tyyppi, string muoto, int koko, string sisältää)
        {

            Tyyppi = tyyppi;
            Muoto = muoto;
            Koko = koko;
            Sisältää = sisältää;
        }
        public override string ToString()
        {
            return "Media: " +  Tyyppi + "\n" + "Analoginen/digitaalinen: " 
                    + Muoto + "\n" + "Koko: " + Koko + "Gb" + "\n" + "Mitä pitää sisällään: " + Sisältää + "\n";
        }
    }
}
