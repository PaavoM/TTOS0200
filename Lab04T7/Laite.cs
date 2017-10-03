using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04T7
{
    class Laite
    {
        public string Nimi { get; set; }
        public string Saatu { get; set; }
        public string Tyyppi { get; set; }
        public string Käyttöjärjestelmä { get; set; }
        public string Valmistaja { get; set; }


        public Laite()
        {

        }
        public Laite(string nimi, string saatu, string tyyppi, string käyttöjärjestelmä, string valmistaja)
        {
            Nimi = nimi;
            Saatu = saatu;
            Tyyppi = tyyppi;
            Käyttöjärjestelmä = käyttöjärjestelmä;
            Valmistaja = valmistaja;
        }
    }
}
