using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07T1
{
    class TestaaMiniASIO
    {
        static void Testaa()
        {
            //luodaan List-tyyppinen lista opiskelijoista
            List<Opiskelija> opiskelijat = new List<Opiskelija>();
            //Testin vuokdi erilaisia tapoja lisätä oliota listaan
            Opiskelija masa = new Opiskelija("Masa", "Niemi");
            opiskelijat.Add(masa);
            opiskelijat.Add(new Opiskelija("Allan", "Aalto", "A1234"));
            //myös näin
            opiskelijat.Add(new Opiskelija { Etunimi = "Hanna", Sukunimi = "Husso", AsioID = "H5678" });
            opiskelijat.Add(new Opiskelija { Etunimi = "Teppo", Sukunimi = "Testaaaja", AsioID = "T5678", Ryhmä = "TTV16S6" });
            Opiskelija kalle = new Opiskelija();
            kalle.Etunimi = "Kalle"; kalle.Sukunimi = "Ankka"; kalle.AsioID = "k6666";
            opiskelijat.Add(kalle);
            //yhden opiskelijan tietoejen näyttäminen
            Console.WriteLine("Anna numero väliltä 1-{0}", opiskelijat.Count);
            int i = int.Parse(Console.ReadLine());
            if (i -1 < opiskelijat.Count)
                Console.WriteLine("Miniasion {0} opiskelija on {1}", i, opiskelijat[i - 1].ToString());
            else
                Console.WriteLine("Miniasiossa on vain {0} opiskelijaa", opiskelijat.Count);
            Console.WriteLine("Miniasion kaikki opiskelijat: ");
            foreach (var o in opiskelijat)
            {
                Console.WriteLine(o.ToString());
            }
            //Kaikkien opiskelijoitten tiedot aakkosjärjestyksessä sukunimen mukaa
            //sprtataan oliot sukunimi-ominaisuuden mukaiseen järjestykseen
            opiskelijat.Sort((x,y) => x.Sukunimi.CompareTo(y.Sukunimi));
            Console.WriteLine("Miniasion kaikki opiskelijat: ");
            foreach (var o in opiskelijat)
            {
                Console.WriteLine(o.ToString());
            }
            //uuden opiskelijan lisääminen, huom tehthään tarkistus ettei asioID ole jo olemassa
            Console.WriteLine("Anna uuden opiskelijan AsioID");
            string asioid = Console.ReadLine();
            //tutkitaan onko listassa
            bool lippu = false;
            foreach (Opiskelija o in opiskelijat)
            {
                if (asioid == o.AsioID)
                {
                    lippu = true;
                    break;
                }
            }
            if (lippu)
            {
                Console.WriteLine("AsioUD {0} on jo käytössä", asioid);
            }
            else
            {
                Console.WriteLine("Anna uuden opiskelijan etunimi");
                string etunimi = Console.ReadLine();
                Console.WriteLine("Anna uuden opiskelijan sukunimi");
                string sukunimi = Console.ReadLine();
                Console.WriteLine("Anna uuden opiskelijan ryhmä");
                string ryhmä = Console.ReadLine();
                //luodaan uusi opiskelija olio
                Opiskelija uusi = new Opiskelija(etunimi, sukunimi, asioid, ryhmä);
                opiskelijat.Add(uusi);
                Console.WriteLine("Miniasion kaikki {0} opiskelijaa: ", opiskelijat.Count);
                foreach (var o in opiskelijat)
                {
                    Console.WriteLine(o.ToString());
                }
            }
        }
        static void Main(string[] args)
        {
            Testaa();
        }
    }
}
