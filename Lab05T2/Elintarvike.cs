using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05T2
{
    class Elintarvike
    {
        public string Nimi { get; set; }
        public string Exp { get; set; }
        public string Arvosana { get; set; }

        public Elintarvike()
        {

        }
        public Elintarvike(string nimi, string exp, string arvosana)
        {
            Nimi = nimi;
            Exp = exp;
            Arvosana = arvosana;
        }
        public override string ToString()
        {
            return "Nimi: " + Nimi + ". " + "Parasta ennen: " + Exp + ". " + "Arvosana: " + Arvosana + ".";
        }
    }
}
