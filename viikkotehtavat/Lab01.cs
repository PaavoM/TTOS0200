using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viikkotehtavat
{
    class Lab01
    {
        public static void tehtava01()
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

        public static void doGrades()
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
    }
}


