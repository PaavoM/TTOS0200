using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05T3
{
    class Program
    {
        static void Main(string[] args)
        {
            Seura Hifki = new Seura();
            Hifki.Nimi = "HIFK";
            Hifki.Kaupunki = "Helsinki";
            Hifki.Joukkue.Add(new Pelaaja("Atte", "Engren", "(G)", "L"));
            Hifki.Joukkue.Add(new Pelaaja("Niilo", "Halonen", "(G)", "L"));
            Hifki.Joukkue.Add(new Pelaaja("Niklas", "Bäckström", "(G)", "L"));
            Hifki.Joukkue.Add(new Pelaaja("Teemu", "Eronen", "(D)", "L"));
            Hifki.Joukkue.Add(new Pelaaja("Joe", "Finley", "(D)", "L"));
            Hifki.Joukkue.Add(new Pelaaja("Miro", "Heiskanen", "(D)", "L"));
            Hifki.Joukkue.Add(new Pelaaja("Oliwer",  "Kaski", "(D)", "R"));
            Hifki.Joukkue.Add(new Pelaaja("Teemu", "Laakso", "(D)","R"));
            Hifki.Joukkue.Add(new Pelaaja("Ryan",  "O'Connor", "(D)", "R" ));
            Hifki.Joukkue.Add(new Pelaaja("Saku",  "Salmela", "(D / F)", "L"));
            Hifki.Joukkue.Add(new Pelaaja("Juuso",  "Salmi", "(D)", "L"));
            Hifki.Joukkue.Add(new Pelaaja("Miihkali", "Teppo", "(D)", "L"));
            Hifki.Joukkue.Add(new Pelaaja("Elias", "Ulander", "(D)", "L"));
            Hifki.Joukkue.Add(new Pelaaja("Ville",  "Varakas", "(D)", "L"));
            Hifki.Joukkue.Add(new Pelaaja("Jerry", "Ahtola", "(W / C)", "L"));
            Hifki.Joukkue.Add(new Pelaaja("Patrik", "Carlsson", "(LW / C)", "L"));
            Hifki.Joukkue.Add(new Pelaaja("Teemu", "Engberg", "(RW)", "L"));
            Hifki.Joukkue.Add(new Pelaaja("Juha - Pekka",  "Haataja", "(RW)", "R"));
            Hifki.Joukkue.Add(new Pelaaja("Janne",  "Hämäläinen", "(LW)", "L"));
            Hifki.Joukkue.Add(new Pelaaja("Lauri", "Kulmala", "(C)", "L"));
            Hifki.Joukkue.Add(new Pelaaja("Jarkko", "Malinen", "(C)", "L"));
            Hifki.Joukkue.Add(new Pelaaja("Niklas", "Nordgren", "(RW)", "R"));
            Hifki.Joukkue.Add(new Pelaaja("Thomas", "Nykopp", "(C / LW)", "L"));
            Hifki.Joukkue.Add(new Pelaaja("Mika", "Partanen", "(LW / RW)", "L"));
            Hifki.Joukkue.Add(new Pelaaja("Lennart", "Petrell", "(LW / RW)", "L"));
            Hifki.Joukkue.Add(new Pelaaja("Joonas", "Rask", "(RW / LW)", "R"));
            Hifki.Joukkue.Add(new Pelaaja("Vili", "Sopanen", "(RW)", "R"));
            Hifki.Joukkue.Add(new Pelaaja("Henri ", "Tamminen", "(RW / LW)", "R"));
            Hifki.Joukkue.Add(new Pelaaja("Erik",  "Thorell", "(LW / RW)", "L"));
            Hifki.Joukkue.Add(new Pelaaja("Juhani",  "Tyrväinen", "(C / LW)",  "L"));

            Seura Tpra = new Seura();
            Tpra.Nimi = "Tappara";
            Tpra.Kaupunki = "Tampere";
            Tpra.Joukkue.Add(new Pelaaja("Pekka", "Saravo", "(D)", "L"));
            Tpra.Joukkue.Add(new Pelaaja("Pekka", "Saravo", "(D)", "L"));
            Tpra.Joukkue.Add(new Pelaaja("Pekka", "Saravo", "(D)", "L"));
            Tpra.Joukkue.Add(new Pelaaja("Pekka", "Saravo", "(D)", "L"));
            Tpra.Joukkue.Add(new Pelaaja("Pekka", "Saravo", "(D)", "L"));
            Tpra.Joukkue.Add(new Pelaaja("Pekka", "Saravo", "(D)", "L"));
            Tpra.Joukkue.Add(new Pelaaja("Pekka", "Saravo", "(D)", "L"));
            Tpra.Joukkue.Add(new Pelaaja("Pekka", "Saravo", "(D)", "L"));
            Tpra.Joukkue.Add(new Pelaaja("Pekka", "Saravo", "(D)", "L"));
            Tpra.Joukkue.Add(new Pelaaja("Pekka", "Saravo", "(D)", "L"));

            Console.WriteLine("Minkä Joukkuen pelaaajat haluat? 1 = Hifk, 2 = Tappara");
            int valinta = int.Parse(Console.ReadLine());

            switch (valinta)
            {
                case 1:
                    Console.WriteLine(Hifki.ToString());
                    break;
                case 2:
                    Console.WriteLine(Tpra.ToString());
                    break;
            }

        }
    }
}
