using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kertaustehtävä
{
    public class Amk
    {
        string Name { get; set; }
        public List<Tutkinto> Tutkintotyyppi;

        public Amk(string name)
        {
            Name = name;
            Tutkintotyyppi = new List<Tutkinto>();
        }
        public override string ToString()
        {
            string retval = Name + " sisältö\n";
            foreach (Tutkinto item in Tutkintotyyppi)
            {
                retval += item.ToString() + "\n";
            }
            return retval;
        }
    }
}
