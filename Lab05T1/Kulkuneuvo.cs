using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05T1
{
    class Kulkuneuvo
    {
        public string Nimi { get; set; }
        public string Malli { get; set; }
        public int RengasLKM { get; set; }

        public Kulkuneuvo()
        {

        }
        public Kulkuneuvo(string nimi, string malli, int rengasLKM)
        {
            Nimi = nimi;
            Malli = malli;
            RengasLKM = rengasLKM;
        }
    }
}
