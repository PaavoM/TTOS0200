using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05T4
{
    class Aikuinen : Ihminen
    {
        public string Auto { get; set; }
        public override void Liiku()
        {
            Console.WriteLine("Kävelee");
        }
        public override string ToString()
        {
            return "Aikuinen: " + Nimi + ", " + Paino + "Kg, " + Pituus + "Cm, " + Ikä + "v" + " Auto: " + Auto;
        }
    }
}
