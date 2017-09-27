using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Dynamonhissi
    {
        private readonly int Maxkerros = 5;
        private readonly int Minkerros = 1;

        private int kerros=1;
        public int Kerros
        {
            get
            {
                return kerros;
            }
            set
            {
                if (value <= Maxkerros && value >= Minkerros) kerros = value;
                else
                {
                    Console.WriteLine("Alin kerros on 1 ja ylin 5. Kokeile uudestaan.");
                    kerros = kerros;
                }
            }
        }
    }
}
