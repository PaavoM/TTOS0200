using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03T3Vahvistin
{
    class Program
    {
        static void Main(string[] args)
        {
            GetVolume();
        }
        static void GetVolume()
        {
            Vahvistin uusivahvistin = new Vahvistin();
            while (true)
            {
                Console.WriteLine("Anna volumi");
                if (uusivahvistin.SäädäÄänenvoimakkuutta(int.Parse(Console.ReadLine())))
                {
                    Console.WriteLine("Volumit " + uusivahvistin.Volume);
                }
                else
                {
                    Console.WriteLine("Ei onnistu");
                    Console.WriteLine(uusivahvistin.Volume);
                }
            }
        }
    }
}
