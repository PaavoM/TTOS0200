using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07T4
{
    class Seura : Pelaaja
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
        //public void HaePelaajat()
        //{
        //    Console.WriteLine("Mitä haluat tehdä? 1 = Etsi pelaajaa syöttämällä halutun pelaajan numero. \n");
        //    int valinta = int.Parse(Console.ReadLine());

        //    switch (valinta)
        //    {
        //        case 1:
        //            Console.WriteLine("Anna pelaajan numero");
        //            int numero = int.Parse(Console.ReadLine());

        //            bool lippu = false;

        //            foreach (Seura item in Joukkue)
        //            {
        //                if ()
        //            }
        //    }
        //}
    }
}
