using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04T5
{
    class Program
    {
        static void Main(string[] args)
        {
            Polkupyörä Serious = new Polkupyörä("Serious", "ATHABASCA", 2017,"Musta", "3x10", "Deore XT");
            Polkupyörä Oiva = new Polkupyörä("Helkama", "Oiva", 2005, "Musta", "One and only.", " ");

            Console.WriteLine(Serious.ToString());
            Console.WriteLine(Oiva.ToString());

            Vene Busteri = new Vene("Busteri", "xyz", 2000, "Keltainen", "Moottorivene", 4);
            Vene paatti = new Vene("Paatti", "9000gt", 1989, "Ruskea", "Merikelpoinen moottorivene", 9);

            Console.WriteLine(Busteri.ToString());
            Console.WriteLine(paatti.ToString());
        }
    }
}
