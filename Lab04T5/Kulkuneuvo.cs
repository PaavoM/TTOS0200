using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04T5
{
    class Kulkuneuvo
    {
        public string Nimi { get; set; }
        public string Malli { get; set; }
        public int Vuosimalli { get; set; }
        public string Väri { get; set; }

        public Kulkuneuvo()
        {

        }
        public Kulkuneuvo(string nimi, string malli, int vuosimalli, string väri)
        {
            Nimi = nimi;
            Malli = malli;
            Vuosimalli = vuosimalli;
            Väri = väri;
        }
    }
}
