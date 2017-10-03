using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04T7
{
    class Kirja : Media
    {
        public int Sivut { get; set;}
        public string Genre { get; set; }

        public Kirja()
        {

        }
        public Kirja(string tyyppi, string muoto, int sivut, string genre)
        {
            Tyyppi = tyyppi;
            Muoto = muoto;
            Sivut = sivut;
            Genre = genre;
        }
        public override string ToString()
        {
            return "Media: " + Tyyppi + "\n" + "Analoginen/digitaalinen: "
                    + Muoto + "\n" + "Sivut: " + Sivut +  "\n" + "Genre: " + Genre + "\n";
        }
    }
}
