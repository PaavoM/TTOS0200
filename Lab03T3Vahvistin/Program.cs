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
                Console.WriteLine("Anna voluumi 0-100 >");
                uusivahvistin.Volume = int.Parse(Console.ReadLine());
                Console.WriteLine("Volume:> " + uusivahvistin.Volume);
            }
        }


    }
}
