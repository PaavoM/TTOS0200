using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaLuku();
            TestaaPvm();
        }

        static void TestaaLuku()
        {
            Console.WriteLine("Anna testattava teksti");
            string teksti = Console.ReadLine();
            Luku.OnkoLuku(teksti);
        }
        static void TestaaPvm()
        {
            Console.WriteLine("Anna testattava päivämäärä");
            string paivamaara = Console.ReadLine();
            Luku.OnkoPvm(paivamaara);
        }
    }
}
