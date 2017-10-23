using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07T4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Seura> Joukkue = new List<Seura>();
            Seura Jypinkylä = new Seura();
            Jypinkylä.Nimi = "JYP";
            Jypinkylä.Kaupunki = "Jyväskylä";
            Pelaaja atte = new Pelaaja("Atte", "Engren", "(G)", 1);
            Jypinkylä.Joukkue.Add(atte);
            Jypinkylä.Joukkue.Add(new Pelaaja("Niilo", "Halonen", "(G)", 2));
            Jypinkylä.Joukkue.Add(new Pelaaja("Niklas", "Bäckström", "(G)", 3));
            Jypinkylä.Joukkue.Add(new Pelaaja("Teemu", "Eronen", "(D)", 4));
            Jypinkylä.Joukkue.Add(new Pelaaja("Joe", "Finley", "(D)", 5));
            Jypinkylä.Joukkue.Add(new Pelaaja("Miro", "Heiskanen", "(D)", 6));


            
            Console.WriteLine("Mitä haluat tehdä? 1 = Etsi pelaajaa syöttämällä halutun pelaajan numero. \n");
            int valinta = int.Parse(Console.ReadLine());

            switch (valinta)
            {
                case 1:
                    Console.WriteLine("Anna pelaajan numero");
                    int number = int.Parse(Console.ReadLine());

                    bool lippu = false;
                    foreach (Seura item in Joukkue)
                    {
                        if (Jypinkylä.Numero == number)
                        {
                            lippu = true;
                            Console.WriteLine(Joukkue[1]);
                        }
                    }
                    break;
            }
            

        }
    }
}
