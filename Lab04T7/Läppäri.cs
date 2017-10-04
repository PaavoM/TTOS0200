using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04T7
{
    class Läppäri : Laite
    {

        public string Prosessori { get; set; }
        public int Ram { get; set; }
        public string Massamuisti { get; set; }
        public int Akunkesto { get; set; }

        public Läppäri()
        {

        }
        public Läppäri(string nimi, string saatu, string tyyppi, string käyttöjärjestelmä, string valmistaja, string prosessori, int ram, string massamuisti, int akunkesto)
        {
            Nimi = nimi;
            Saatu = saatu;
            Tyyppi = tyyppi;
            Käyttöjärjestelmä = käyttöjärjestelmä;
            Valmistaja = valmistaja;
            Prosessori = prosessori;
            Ram = ram;
            Massamuisti = massamuisti;
            Akunkesto = akunkesto;
        }
        public override string ToString()
        {
            return "Laite: " + Nimi + "\n" + "Mistä saatu? " + Saatu + "\n" + "Laitteen tyyppi: " + Tyyppi + "\n" + "Käyttöjärjestelmä: "
                + Käyttöjärjestelmä + "\n" + "Valmistaja: " + Valmistaja + "\n" + "Prosessori: " + Prosessori + "\n" + "Ram: " + Ram + "Gb" + "\n" + "Massamuisti: " + Massamuisti + "Gb"
                + "\n" + "Akunkesto: " + Akunkesto + "h" + "\n";
        }
    }
}
