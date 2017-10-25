using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07T2
{
    class CD
    {
        public string Nimi { get; set; }
        public string Artisti { get; set; }
        public List<Songs> Biisit;

        public CD()
        {
            Biisit = new List<Songs>();
            Biisit.Add(new Songs("1. Punainen tiili – 4.33"));
            Biisit.Add(new Songs("2. Markus – 3.33"));
            Biisit.Add(new Songs("3. Haastattelu – 0.47"));
            Biisit.Add(new Songs("4. Roihuvuori – 3.19 "));
            Biisit.Add(new Songs("5. Pullon sisällä - 3.45"));
            Biisit.Add(new Songs("6. Viedää bäkkii – 3.58"));
            Biisit.Add(new Songs("7. Farrah Muhammed – 1.06"));
            Biisit.Add(new Songs("8. Kaks lakii – 3.40"));
            Biisit.Add(new Songs("9. Yhdes iltaan – 4.35 "));
            Biisit.Add(new Songs("10. Silloin ennen – 4.24"));
            Biisit.Add(new Songs("11. Elämä on tentti – 3.39"));
            Biisit.Add(new Songs("12. Ympäri mennään, yhteen tullaan – 3.51"));
            Biisit.Add(new Songs("13. Mä hajotan tän maailman – 2.52"));
            Biisit.Add(new Songs("14. Don't Make a Sound – 5.39"));
            Biisit.Add(new Songs("15. Ruokaa, ei aseita – 4.30"));
            Biisit.Add(new Songs("16. 5 päivää, 5 yötä – 4.34"));
            new Songs();
        }
        
        public override string ToString()
        {
            string retval = "CD: " + Nimi + "\n" + "Artisti: " + Artisti + "\n" + "Biisit: " + "\n";
            foreach (Songs item in Biisit)
            {
                retval += item.ToString() + "\n";
            }
            return retval;
        }
    }
}
