using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07T3
{
    class Pakka
    {
        public List<Kortti> Korttipakka;
        public Pakka()
        {
            Korttipakka = new List<Kortti>();
        }
        //public static void Shuffle<T>(this IList<T> Korttipakka)
        //{
        //    Random rng = new Random();
        //    int n = Korttipakka.Count;
        //    while (n > 1)
        //    {
        //        n--;
        //        int k = rng.Next(n + 1);
        //        T value = Korttipakka[k];
        //        Korttipakka[k] = Korttipakka[n];
        //        Korttipakka[n] = value;
        //    }
        //}
        public override string ToString()
        {
            int b = 1;
            string retval = "";
            foreach (Kortti item in Korttipakka)
            {
                retval += b + "Kortti on " + item.ToString() + "\n";
                b++;
             }
            return retval;
        }
    }
}
