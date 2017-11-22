using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kertaustehtävä
{
    public class Tutkinto
    {
        string Name { get; set; }
        public List<Opintojakso> TK;

        public Tutkinto(string name)
        {
            Name = name;
            TK = new List<Opintojakso>();
        }
        public override string ToString()
        {
            
            string retval = Name + " sisältö\n"; 
            foreach (Opintojakso item in TK)
            {
                retval += item.ToString() + "\n";
            } 
            retval += "\n##########################################################";
            return retval;
        }

    }
}
