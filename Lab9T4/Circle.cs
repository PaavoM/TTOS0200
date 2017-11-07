using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9T4
{
    class Circle : Shape
    {
        public double R { get; set; }
        public double Pii = Math.PI;
        public double Ala = 0;
        public double Piiri = 0;
        public Circle()
        {

        }
        public override void Area()
        {
             Ala = Pii * R * R;
        }
        public override void Circumeference()
        {
            Piiri = 2 * Pii * R;
        }
        public override string ToString()
        {
            return " Ympyrä : Säde: " + R + " Ala: " + Ala + " Piiri: " + Piiri;
        }
    }
}
