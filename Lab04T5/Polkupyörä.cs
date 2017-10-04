using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04T5
{
    class Polkupyörä : Kulkuneuvo
    {
        public string Vaihdetyyppi { get; set; }
        public string Vaihdemalli { get; set; }

        public Polkupyörä()
        {

        }
        public Polkupyörä(string nimi, string malli, int vuosimalli, string väri, string vaihdetyyppi, string vaihdemalli)
        {
            Nimi = nimi;
            Malli = malli;
            Vuosimalli = vuosimalli;
            Väri = väri;
            Vaihdetyyppi = vaihdetyyppi;
            Vaihdemalli = vaihdemalli;
        }
        public override string ToString()
        {
            return "Bike info" + "\n" + "Nimi : " + Nimi + " " + "Malli: " + Malli + " " + "Vuosimalli: " + Vuosimalli + " " 
                + "Väri: " + Väri + " " + "Vaihdetyyppi: " + Vaihdetyyppi + " " + "Vaihdemalli: " + Vaihdemalli + "\n";
        }
    }
}
