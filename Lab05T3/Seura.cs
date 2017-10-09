using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05T3
{
    class Seura
    {
        public string Nimi;
        public string Kaupunki;

        public List<Pelaaja> Joukkue;


        public Seura()
        {
            Joukkue = new List<Pelaaja>();
        }


        public override string ToString()
        {
            string retval = "Joukkuuessa " + Nimi + ",joka sijaitsee kaupungissa " + Kaupunki + " pelaa seuraavat pelaajat: \n";
           
            foreach (Pelaaja item in Joukkue)
            {
                retval += item.ToString() + "\n";
            }
            return retval;
        }
    }
}
