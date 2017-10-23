using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07T4
{
    class Pelaaja
    {
        public string Etunimi;
        public string Sukunimi;
        public string Kätisyys;
        public int Numero;

        public Pelaaja()
        {

        }
        public Pelaaja(string etunimi, string sukunimi, string kätisyys, int numero)
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            Kätisyys = kätisyys;
            Numero = numero;
        }
        public override string ToString()
        {
            return "Nimi: " + Sukunimi + " " + Etunimi + ". " + "Pelipaikka: " + ". " + "Kätisyys: " + Kätisyys + ". " + Numero;
        }
    }
}
