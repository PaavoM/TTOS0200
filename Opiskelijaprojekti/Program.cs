using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opiskelijaprojekti
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaOpiskelija();
        }
        static void TestaaOpiskelija()
        {
            opiskelija uusiopiskelija = new opiskelija();

            string[] students = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Anna etunimi>");
                uusiopiskelija.EtuNimi = Console.ReadLine();

                Console.WriteLine("Anna Sukunimi>");
                uusiopiskelija.SukuNimi = Console.ReadLine();

                Console.WriteLine("Anna opiskelijatunnus>");
                uusiopiskelija.OpiskelijaTunnus = Console.ReadLine();

                Console.WriteLine("Anna puhelinnumero");
                uusiopiskelija.PuhelinNumero = int.Parse(Console.ReadLine());

                Console.WriteLine("Anna sähköposti");
                uusiopiskelija.Sähkoposti = Console.ReadLine();

                students[i] = uusiopiskelija.EtuNimi + " " + uusiopiskelija.SukuNimi + ", " + uusiopiskelija.OpiskelijaTunnus + ", " + uusiopiskelija.PuhelinNumero + ", " + uusiopiskelija.Sähkoposti + ".";
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(students[i]);
            }
        }
    }
}
