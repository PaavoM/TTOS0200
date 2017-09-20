using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Kiuas
    {
        public string Tila { get; set; }
        public int Lämpötila { get; set; }
        public int Kosteus { get; set; }

        public void GetTila()
        {
            Console.WriteLine("Kiuas on {0}.", Tila);
        }
        public void GetLämpötila()
        {
            Console.WriteLine("Kiukaan lämpötila on {0}.", Lämpötila);
        }
        public void GetKosteus()
        {
            Console.WriteLine("Heitit löylyä {0} kertaa.", Kosteus);
        }
    }
}
