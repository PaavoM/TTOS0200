using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09T2
{
    class Ostoskärry
    {
        public string Name { get; set; }
        public List<Tuote> Kärry;

        public Ostoskärry()
        {
            Kärry = new List<Tuote>();
            Kärry.Add(new Tuote("Hk blö", "1,59"));
            Kärry.Add(new Tuote("Mustardö", "2,50"));
            Kärry.Add(new Tuote("Pepsi Make", "2,49"));
        }

        public override string ToString()
        {
            string retval = Name + "n ostoskärry: \n";
            foreach (Tuote item in Kärry)
            {
                retval += item.ToString() + "\n";
            }
            return retval;
        }
    }
}
