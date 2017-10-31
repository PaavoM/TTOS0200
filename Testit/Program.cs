using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testit
{
    class Program
    {
        static void Main(string[] args)
        {
            string numerot;

                Console.WriteLine("Anna numero> ");
                numerot = Console.ReadLine();

                int integeeri;
                double dubles;

                if (int.TryParse(numerot, out integeeri))
                {
                    Console.WriteLine("Numero on integer");
                }

                else if (double.TryParse(numerot, out dubles))
                {
                    Console.WriteLine("Numero on doubles.");
                } 
        }
    }
}
