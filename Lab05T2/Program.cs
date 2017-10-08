using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Jääkaappi Kaappi = new Jääkaappi();
            Kaappi.Name = "'Paven kylmiö'";
            Console.WriteLine(Kaappi.ToString());
        }
    }
}
