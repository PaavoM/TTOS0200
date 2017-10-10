using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05T4
{
    class Ihminen : Nisakas
    {
        public string Nimi { get; set; }
        public int Paino { get; set; }
        public int Pituus { get; set; }

        public override void Liiku()
        {
            Console.WriteLine("Liikun");
        }
        public void Kasva()
        {
            Ikä++;
        }

    }
}
