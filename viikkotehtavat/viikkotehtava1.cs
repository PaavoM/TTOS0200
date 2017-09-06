using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viikkotehtavat
{
    class viikkotehtava1
    {
        public static void tehtava01()
        {
            //Tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3) vastaavan luvun sanana (yksi, kaksi tai kolme). 
            //Jos käyttäjä syöttää jonkin muun luvun, 
            //tulee näytölle tulostaa teksti: "joku muu luku".

            int number;
            Console.WriteLine("Luvut yhdestä kolmeen toimivat.");
            for (int i=0; i<3; i++){
                
                    Console.WriteLine("Anna luku");
                    number = Convert.ToInt32(System.Console.ReadLine());
                    if (number == 1){
                                    Console.WriteLine("Annoit luvun yksi"); 
                                    }
                    if (number == 2){
                                    Console.WriteLine("Annoit luvun kaksi"); 
                                    }
                    if (number == 3){
                                    Console.WriteLine("Annoit luvun kolme");                                     
                                    }
                    if (number != 1 && number !=2 && number !=3){
                                    Console.WriteLine("joku muu luku");
                                    }
                }
       } 
    }
}

