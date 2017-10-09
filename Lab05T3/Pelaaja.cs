using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05T3
{
    class Pelaaja
    {
        public string Etunimi;
        public string Sukunimi;
        public string Pelipaikka;
        public string Kätisyys;

        public Pelaaja()
        {

        }
        public Pelaaja(string etunimi, string sukunimi, string pelipaikka, string kätisyys)
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            Pelipaikka = pelipaikka;
            Kätisyys = kätisyys;
        }
        public override string ToString()
        {
            return "Nimi: " + Sukunimi + " " + Etunimi + ". " + "Pelipaikka: " + Pelipaikka + ". " + "Kätisyys: " + Kätisyys;
        }
    }
}
