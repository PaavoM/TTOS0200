using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07T1
{
    class TestaaMiniASIO
    {
        static void Main(string[] args)
        {
            // create a list for opiskelijat
            List<Opiskelija> opiskelijat = new List<Opiskelija>();

            // add some test students different way to the list
            Opiskelija oo = new Opiskelija("Masa", "Niemi");
            opiskelijat.Add(oo);
            opiskelijat.Add(new Opiskelija("Allan", "Aalto", "A1111"));
            //myÃ¶s nÃ¤in
            opiskelijat.Add(new Opiskelija { Etunimi = "Hanna", Sukunimi = "Husso", AsioID = "B2222" });
            opiskelijat.Add(new Opiskelija { Etunimi = "Teppo", Sukunimi = "Testaaja", AsioID = "C3333", Ryhmä = "TTV17S1" });

            // show one Opiskelija data
            Console.WriteLine("The First Opiskelija in the MiniASIO is:");
            Console.WriteLine(opiskelijat.ElementAt(0).ToString());

            // show one Opiskelija data
            Console.WriteLine("The Last Opiskelija in the MiniASIO is:");
            int lkm = opiskelijat.Count;
            Console.WriteLine(opiskelijat[lkm - 1]);

            // loop through all the opiskelijat
            Console.WriteLine();
            Console.WriteLine("The all students in MiniASIO:");
            foreach (Opiskelija o in opiskelijat)
            {
                Console.WriteLine(o.ToString());
            }
            // sort by Sukunimi
            opiskelijat.Sort((x, y) => x.Sukunimi.CompareTo(y.Sukunimi));
            Console.WriteLine();
            Console.WriteLine("The all students in alphabetical order in MiniASIO::");
            foreach (Opiskelija o in opiskelijat)
            {
                Console.WriteLine(o.ToString());
            }
            //uuden opiskelijat lisÃ¤Ã¤minen
            //tarkistetaan AsioID
            Console.WriteLine("Please, give data of a new Opiskelija:");
            Console.WriteLine("AsioID:");
            string ai = Console.ReadLine();
            //tutkitaan onko listassa
            bool lippu = false;
            foreach (Opiskelija o in opiskelijat)
            {
                if (o.AsioID == ai)
                {
                    lippu = true;
                    break;
                }
            }
            if (lippu)
            {
                Console.WriteLine("AsioID {0} on jo kÃ¤ytÃ¶ssÃ¤, tietoja ei voi lisÃ¤tÃ¤.", ai);
            }
            else
            {
                Console.WriteLine("Etunimi:");
                string en = Console.ReadLine();
                Console.WriteLine("Sukunimi:");
                string sn = Console.ReadLine();
                Console.WriteLine("Ryhmä:");
                string ry = Console.ReadLine();
                //luodaan uusi olio
                Opiskelija uusi = new Opiskelija(en, sn, ai, ry);
                opiskelijat.Add(uusi);
                Console.WriteLine("The all students in MiniASIO:");
                foreach (Opiskelija o in opiskelijat)
                {
                    Console.WriteLine(o.ToString());
                }
            }
            // read line to keep output windows visible
            Console.WriteLine();
            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}

