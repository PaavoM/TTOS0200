using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05T5
{
    class Tietokone
    {
        public string Name { get; set; }
        public List<Komponentti> Kokoonpano;

        public Tietokone()
        {
            Kokoonpano = new List<Komponentti>();
            Kokoonpano.Add(new Komponentti("Intel Core i7-7700K", "Prosessori", 380));
            Kokoonpano.Add(new Komponentti("ASUS MAXIMUS IX HERO", "Emolevy", 299));
            Kokoonpano.Add(new Komponentti("Samsung SSD 960 EVO SSD 250GB", "Massamuisti", 149));
            Kokoonpano.Add(new Komponentti("Kingston 2x8GB HyperX Fury DDR4", "Työmuisti", 170));
            Kokoonpano.Add(new Komponentti("NVIDIA GeForce GeForce GTX 1070", "Näytönohjain", 500));
        }
        public override string ToString()
        {
            string retval = "Tietokone nimeltään " + Name + " on koottu seuraavista komponenteista: \n";
            foreach (Komponentti item in Kokoonpano)
            {
                retval += item.ToString() + "\n";
            }
            return retval;
        }
    }
}
