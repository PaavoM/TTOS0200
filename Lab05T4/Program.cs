using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05T4
{
    class Program
    {
        static void Main(string[] args)
        {
            Aikuinen A1 = new Aikuinen();
            A1.Auto = "Mersu";
            A1.Ikä = 25;
            A1.Nimi = "Jorma";
            A1.Paino = 80;
            A1.Pituus = 175;
            Console.WriteLine(A1.ToString());
            A1.Kasva();
            A1.Liiku();
            A1.Liiku();
            A1.Liiku();
            Console.WriteLine(A1.ToString());

            Vauva V1 = new Vauva();
            V1.Vaippa = "Kakkaa pöksyssä";
            V1.Ikä = 1;
            V1.Nimi = "Joni-Petteri";
            V1.Paino = 4;
            V1.Pituus = 80;
            Console.WriteLine(V1.ToString());
            V1.Kasva();
            V1.Liiku();
            V1.Liiku();
            V1.Liiku();
            V1.Liiku();
            Console.WriteLine(V1.ToString());
        }
    }
}
