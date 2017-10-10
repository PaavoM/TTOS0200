using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05T5
{
    class Program
    {
        static void Main(string[] args)
        {
            Tietokone Mylly = new Tietokone();
            Mylly.Name = "Paven mylly";
            Console.WriteLine(Mylly.ToString());
        }
    }
}
