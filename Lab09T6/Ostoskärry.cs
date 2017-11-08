using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09T6
{
    class Ostoskärry
    {
        public string Name { get; set; }
        public List<Tuote> Kärry;

        public Ostoskärry()
        {

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
