using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Program
    {
        static void Main(string[] args)
        {
            LiikutaHissia();
        }
        static void LiikutaHissia()
        {
            Dynamonhissi hissi = new Dynamonhissi();


            while (true)
            {
                Console.WriteLine("Anna kerros >");
                hissi.Kerros = int.Parse(Console.ReadLine());
                Console.WriteLine("Hissi on nyt kerroksessa> " + hissi.kerros);
            }
        }
    }
}