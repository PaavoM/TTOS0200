using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9T4
{
    class Rectangle : Shape
    {
        public double A { get; set; }
        public double B { get; set; }
        public double Ala { get; set; }
        public double Piiri { get; set; }
        public Rectangle (double a, double b)
        {
            A = a;
            B = b;
        }

        public override void Area()
        {
            Ala = A * B;
        }
        public override void Circumeference()
        {
            Piiri =  A + A + B + B;
        }
        public override string ToString()
        {
            return "Suorakulmio : Sivut a x b: " + A + " x " + B + " Ala: " + Ala + " Piiri: " + Piiri;
        }
    }
}
