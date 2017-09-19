using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class vechile
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Kulkuneuvon merkki: " + Name + "\n" + "Huippunopeus: " + Speed + "\n" + "Renkaita: " + Tyres);
        }

    }
}
