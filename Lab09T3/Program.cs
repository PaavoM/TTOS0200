using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09T3
{
    class Program
    {
        static void Main(string[] args)
        {
            Kalastaja Pera = new Kalastaja();
            Pera.Nimi = "Pertti Jormakka";
            Pera.PuhelinNro = "0400123456";

            Console.WriteLine(Pera.ToString());
        }
    }
}
