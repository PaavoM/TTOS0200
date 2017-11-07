using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09T1
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int luku;
            int kerrat = 0;
            int summa = 0;
            float ka = 0;

            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int e = 0;
            int f = 0;
            List<int> Heitot = new List<int>(); 

            Console.WriteLine("Kuinka monta kertaa haluat heittää noppaa?");
            kerrat = int.Parse(Console.ReadLine());
            for (int i = 0; i < kerrat; i++)
            {
                luku = (rnd.Next(1, 7));
                Heitot.Add(luku);
                Console.WriteLine("-> " + luku);
                summa = summa + luku;
            }
            ka = (1.0F * summa / kerrat);
            Console.WriteLine("Keskiarvo on: " + ka);

            foreach (int t in Heitot)
            {
                if (t == 1)
                {
                    a++;
                }
               else if (t == 2)
                {
                    b++;
                }
               else if (t == 3)
                {
                    c++;
                }
               else if (t == 4)
                {
                    d++;
                }
               else if (t == 5)
                {
                    e++;
                }
               else if (t == 6)
                {
                    f++;
                }
            }
            Console.WriteLine("1: {0} \n2: {1} \n3: {2} \n4: {3} \n5: {4} \n6: {5}", a, b, c, d, e, f);
        }
    }
}
