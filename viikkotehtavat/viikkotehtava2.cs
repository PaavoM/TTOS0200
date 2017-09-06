using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viikkotehtavat
{
    class viikkotehtava2
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
        
        public static void doGrades()
        {
            int points;
            //int grade;

            Console.WriteLine("Anna pistemäärä (0-12)");
            points = Convert.ToInt32(System.Console.ReadLine());

            if (points >= 0 && points <= 1 )
            {
                Console.WriteLine("Arvosana on 0");
            }
            if (points >= 2 && points <= 3)
            {
                Console.WriteLine("Arvosana on 1");
            }
            if (points >=4 && points <= 5)
            {
                Console.WriteLine("Arvosana on 2");
            }
            if (points >=6 && points <= 7)
            {
                Console.WriteLine("Arvosana on 3");
            }
            if (points >=8 && points <= 9)
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
