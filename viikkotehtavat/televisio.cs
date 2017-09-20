using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Televisio
    {
        public string Tila { get; set; }
        public int Kanava { get; set; }
        public int Volyymi { get; set; }


        public void GetTila()
        {
            Console.WriteLine("Televisio on {0}", Tila);
        }
        public void VaihdaKanavaa()
        {
            Console.WriteLine("Valitsit kanavan {0}", Kanava);
        }
        public void SäädäVolyymi()
        {
            Console.WriteLine("Volyymi: {0}", Volyymi);
        }
    }
}
