using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viikkotehtavat
{
    class Lab01
    {
        static void Tehtava01()
        {
            //Tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3) vastaavan luvun sanana (yksi, kaksi tai kolme). 
            //Jos käyttäjä syöttää jonkin muun luvun, 
            //tulee näytölle tulostaa teksti: "joku muu luku".

            int number;
            Console.WriteLine("Luvut yhdestä kolmeen toimivat.");
            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine("Anna luku");
                number = Convert.ToInt32(System.Console.ReadLine());
                if (number == 1)
                {
                    Console.WriteLine("Annoit luvun yksi");
                }
                if (number == 2)
                {
                    Console.WriteLine("Annoit luvun kaksi");
                }
                if (number == 3)
                {
                    Console.WriteLine("Annoit luvun kolme");
                }
                if (number != 1 && number != 2 && number != 3)
                {
                    Console.WriteLine("joku muu luku");
                }
            }
        }
        public static void DoGrades()
        {
            //Tee ohjelma, jossa annetaan oppilaalle koulunumero seuraavan taulukon mukaan
            //(pistemäärä kysytään ja ohjelma tulostaa numeron):
            //pisteet           numero
            //0-1               0
            //2-3               1
            //4-5               2
            //6-7               3
            //8-9               4
            //10-12             5
            {
                int points;


                Console.WriteLine("Anna pistemäärä (0-12)");
                points = Convert.ToInt32(System.Console.ReadLine());

                if (points >= 0 && points <= 1)
                {
                    Console.WriteLine("Arvosana on 0");
                }
                if (points >= 2 && points <= 3)
                {
                    Console.WriteLine("Arvosana on 1");
                }
                if (points >= 4 && points <= 5)
                {
                    Console.WriteLine("Arvosana on 2");
                }
                if (points >= 6 && points <= 7)
                {
                    Console.WriteLine("Arvosana on 3");
                }
                if (points >= 8 && points <= 9)
                {
                    Console.WriteLine("Arvosana on 4");
                }
                if (points >= 10 && points <= 12)
                {
                    Console.WriteLine("Arvosana on 5");
                }

            }
        }
        public static void AskNum()
        {
            //Tee ohjelma, joka kysyy käyttäjältä kolme lukua
            //ja tulostaa niiden summan ja keskiarvon.

            int numero1;
            int numero2;
            int numero3;
            int summa;
            int keskiarvo;

            Console.WriteLine("Anna ensinmäinen numero");
            numero1 = Convert.ToInt32(System.Console.ReadLine());

            Console.WriteLine("Anna toinen numero");
            numero2 = Convert.ToInt32(System.Console.ReadLine());

            Console.WriteLine("Anna kolmas numero");
            numero3 = Convert.ToInt32(System.Console.ReadLine());


            Console.WriteLine("Syötit numerot:" + " " + numero1 + " " + numero2 + " " + numero3);

            summa = numero1 + numero2 + numero3;
            keskiarvo = summa / 3;

            Console.WriteLine("Summa: " + summa);
            Console.WriteLine("Keskiarvo: " + keskiarvo);


        }
        public static void AskAge()
        {
            //Tee ohjelma, jossa kysytään käyttäjältä tämän ikä. 
            //Jos ikä on alle 18 vuotta, tulosta "alaikäinen", 
            //jos se on 18-65 vuotta, tulosta "aikuinen", 
            //muussa tapauksessa tulosta "seniori".

            int ikä;
            Console.WriteLine("Anna ikä");
            ikä = Convert.ToInt32(System.Console.ReadLine());

           if (ikä < 18)
            {
                Console.WriteLine("Alaikäinen");
            }
           if (ikä > 18 && ikä < 65)
            {
                Console.WriteLine("Aikuinen");
            }
            if (ikä > 65)
            {
                Console.WriteLine("Seniori");
            }
        }
        public static void GetTime()
        {
            //Tee ohjelma, joka näyttää annetun sekuntimäärän tunteina, minuutteina ja sekunteina. 
            //Aikamääre sekuntteina kysytään käyttäjältä.

            int sekunti;
            int minuutti;
            int tunti;

            int jjminuutti;
            int jjtunti;


            Console.WriteLine("Anna sekunnit");
            sekunti = Convert.ToInt32(System.Console.ReadLine());


            minuutti = sekunti / 60;
            tunti = minuutti / 60;

            jjminuutti = sekunti % 60;
            jjtunti = minuutti % 60;
    
            Console.WriteLine("Antamasi sekunnit voidaan esittää muodossa: " + tunti + " tuntia " + jjtunti + " minuuttia " + jjminuutti + " sekuntia " );
        }
        public static void CalcGas()
        {
            double matka;
            double kulutus = 7.02;
            double bensa = 1.595;
            double kokonaiskulutus;
            double hinta;

            Console.WriteLine("Anna matka kilometreissä");
            matka = int.Parse(System.Console.ReadLine());

            kokonaiskulutus = (matka / 100) * kulutus;
            hinta = kokonaiskulutus * bensa;

            Console.WriteLine("Bensaa kuluu " + kokonaiskulutus + "litraa, " + "kustannus " + hinta + " euroa.");

           
            
        }
    }
}


