using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07T2
{
    class Songs
    {
        public string Biisu { get; set; }

        public Songs()
        {

        }
        public Songs(string biisu)
        {
            Biisu = biisu;
        }
        public override string ToString()
        {
            return Biisu;
        }
    }
}
