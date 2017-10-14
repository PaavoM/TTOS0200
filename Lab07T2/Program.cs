using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07T2
{
    class Program
    {
        static void Main(string[] args)
        {
            CD Tiili = new CD();
            Tiili.Nimi = "Punainen tiili";
            Tiili.Artisti = "Avain";
            Console.WriteLine(Tiili.ToString());
        }
    }
}
