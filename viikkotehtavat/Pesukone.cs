using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Pesukone
    {
        public string Tila { get; set; }
        public string PesuOhjelma { get; set; }
        public int VedenLämpötila { get; set; }
        public int LinkousNopeus { get; set; }

        public void GetTila()
        {
            Console.WriteLine("pesukone on {0}.", Tila);
        }
        public void GetOhjelma()
        {
            Console.WriteLine("Valitsit pesuohjelmaksi {0}", PesuOhjelma);
        }
        public void GetLämpötila()
        {
            Console.WriteLine("Lämpötila on: {0}", VedenLämpötila);
        }
        public void GetLinkous()
        {
            Console.WriteLine("Linkousnopeus on: {0}", LinkousNopeus);
        }
    }
}
