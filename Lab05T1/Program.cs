using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kulkuneuvo Mersu = new Kulkuneuvo("Mercedes Benz", "C63S AMG", 4);
            Kulkuneuvo Honda = new Kulkuneuvo("Honda", "CBR", 2);

            Renkaat Nokialaiset = new Renkaat("Nokia", "R1", 20);
            Renkaat Pirellit = new Renkaat("Pirelli", "Rengas 9000", 17);

            List<Renkaat> Renkulit = new List<Renkaat>();

            for (int i = 0; i < Mersu.RengasLKM; i++)
            {
                Renkulit.Add(Nokialaiset);
            }
            for (int i = 0; i < Honda.RengasLKM; i++)
            {
                Renkulit.Add(Pirellit);
            }
            foreach (Renkaat item in Renkulit)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
