using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04T7
{
    class Media
    {
        public string Tyyppi { get; set; }
        public string Muoto { get; set; }

        public Media()
        {

        }
        public Media( string tyyppi, string muoto)
        {
            Tyyppi = tyyppi;
            Muoto = muoto;
        }
    }
}
