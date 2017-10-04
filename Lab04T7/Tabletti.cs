using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04T7
{
    class Tabletti : Laite
    {
        public int Näyttö { get; set; }
        public string Kamerat { get; set; }

        public Tabletti()
        {

        }
        public Tabletti(string nimi, string saatu, string tyyppi, string käyttöjärjestelmä, string valmistaja, int näyttö, string kamerat)
        {
            Nimi = nimi;
            Saatu = saatu;
            Tyyppi = tyyppi;
            Käyttöjärjestelmä = käyttöjärjestelmä;
            Valmistaja = valmistaja;
            Näyttö = näyttö;
            Kamerat = kamerat;
        }
        public override string ToString()
        {
            return "Laite: " + Nimi + "\n" + "Mistä saatu? " + Saatu + "\n" + "Laitteen tyyppi: " + Tyyppi + "\n" + "Käyttöjärjestelmä: "
                + Käyttöjärjestelmä + "\n" + "Valmistaja: " + Valmistaja + "\n" + "Näytön koko: " + Näyttö + "\n" + "Kamerat: " + Kamerat + "\n";
        }
    }
}
