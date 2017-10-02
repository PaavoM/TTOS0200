using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03T3Vahvistin
{
    class Vahvistin
    {
        private readonly int Maxvolume = 100;
        private readonly int Minvolume = 0;

        private int volume;
        public bool SäädäÄänenvoimakkuutta(int arvo)
        {
            if (arvo <= Maxvolume && arvo >= Minvolume)
            {
                volume = arvo;
                return true;
            }
            else
            {
                return false;
            }
        }
        //public int Volume { get ; set; }
        public int Volume
        { 
            get
            {
                return volume;
            }
            set
            {

            }
        }
    }
}
