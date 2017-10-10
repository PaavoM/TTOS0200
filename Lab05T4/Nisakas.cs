using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05T4
{
    abstract class Nisakas
    {
        public int Ikä { get; set; }

        public Nisakas()
        {

        }
        public abstract void Liiku();
    }
}
