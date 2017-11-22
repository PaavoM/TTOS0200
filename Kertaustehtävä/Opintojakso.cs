using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kertaustehtävä
{
    public class Opintojakso
    {
        string Nimi { get; set; }
        public List<Opiskelija> OP;
        public List<Opettaja> OPE;
        int määrä = 0;


        public Opintojakso(string nimi)
        {
            Nimi = nimi;
            OP = new List<Opiskelija>();
            OPE = new List<Opettaja>();
        }
        public override string ToString()
        {
            string retval = Nimi + " sisältö\n";
            retval += "*****Oppilaat*****\n";
            foreach (Opiskelija item in OP)
            {
                retval += item.ToString() + "\n";
                määrä++;
            }
            retval += "\nOpiskelijoita: " + määrä.ToString();
            retval += "\n*****Opettaja*****\n";
            foreach (Opettaja item in OPE)
            {
                retval += item.ToString() + "\n";
            }
            retval += "\n ------------------------------------------------------------";
            
            return retval;
        }




    }
}
