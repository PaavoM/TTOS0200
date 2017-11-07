using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ostoskärry cart = new Ostoskärry();
            cart.Name = "Jorma";
            Console.WriteLine(cart.ToString());
        }
    }
}
