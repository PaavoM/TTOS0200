using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07T3
{
    class Kortti
    {
        public string Maa { get; set; }
        public int Numero { get; set; }

        public Kortti()
        {

        }
        public Kortti(string maa, int numero)
        {
            Maa = maa;
            Numero = numero;
        }
        public override string ToString()
        {
            return Maa + "/" + Numero;
        }
    }
}
