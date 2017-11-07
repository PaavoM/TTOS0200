using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09T3
{
    class Kalastaja
    {
        public string Nimi { get; set; }
        public string PuhelinNro { get; set; }
        public List<Saalis> Kalavaleet;

        public Kalastaja()
        {
            
            Kalavaleet = new List<Saalis>();
            Kalavaleet.Add(new Saalis("Meri-Lohi", 160, 11.6, "Mallos", "Kangasniemi"));
            Kalavaleet.Add(new Saalis("Muikku", 5, 0.05, "Puula", "Kangasniemi"));
            Kalavaleet.Add(new Saalis("Ahven", 60, 0.5, "Simpiä", "Kangasniemi"));
            Kalavaleet.Sort((x, y) => y.Paino.CompareTo(x.Paino));
        }

        public override string ToString()
        {
            string retval = "Fisherman: " + Nimi + " Phone: " + PuhelinNro + " Kalat: \n\n";

            foreach (Saalis item in Kalavaleet)
            {
                retval += item.ToString() + "\n";
            }

            return retval;
        }
    }
}
