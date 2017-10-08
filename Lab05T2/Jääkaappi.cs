using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05T2
{
    class Jääkaappi
    {
        public string Name { get; set; }
        public List<Elintarvike> Sisältö;

        public Jääkaappi()
        {
            Sisältö = new List<Elintarvike>();
            Sisältö.Add(new Elintarvike("Flora", "18.10.2017", "3/5"));
            Sisältö.Add(new Elintarvike("Pepsi make", "28.2.2019", "5/5"));
            Sisältö.Add(new Elintarvike("Makaroonilaatikko", "Ylihuomenna", "7/5"));
        }
        public override string ToString()
        {
            string retval = "Jääkappi nimeltään " + Name + " sisältää elintarvikkeet: \n";
            foreach (Elintarvike item in Sisältö)
            {
                retval += item.ToString() + "\n";
            }
            return retval;
        }
    }
}
