using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07T3
{
    class Program
    {
        static void Main(string[] args)
        {
            Pakka Temppu1 = new Pakka();
            for (int i = 1; i < 14; i++)
            {
                Temppu1.Korttipakka.Add(new Kortti("Pata", i));
            }
            for (int i = 1; i < 14; i++)
            {
                Temppu1.Korttipakka.Add(new Kortti("Ruutu", i));
            }
            for (int i = 1; i < 14; i++)
            {
                Temppu1.Korttipakka.Add(new Kortti("Risti", i));
            }
            for (int i = 1; i < 14; i++)
            {
                Temppu1.Korttipakka.Add(new Kortti("Hertta", i));
            }
            Console.WriteLine(Temppu1.ToString());

        }
    }
}
