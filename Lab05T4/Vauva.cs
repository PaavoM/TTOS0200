using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05T4
{
    class Vauva : Ihminen
    {
        public string Vaippa { get; set; }
        public override void Liiku()
        {
            Console.WriteLine("Konttaan");
        }
        public override string ToString()
        {
            return "Vauva: " + Nimi + ", " + Paino + "Kg, " + Pituus + "Cm, " + Ikä + "v" + " Vaipan status: " + Vaippa;
        }

    }
}
