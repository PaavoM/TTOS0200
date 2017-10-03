using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04T7
{
    class Program
    {
        static void Main(string[] args)
        {
            Läppäri Hp = new Läppäri("Hpn paske", "Lukiosta saatu", "Kannettava tietokone", "Windows 10", "Hp", "i3", 4, "ssd/256", 2);
            Tabletti Nexus = new Tabletti("Nexus tabletti", "Ostettu 2015", "Tabletti", "Android 7.0", "Google/Htc", 9, "Etu ja takakamera");

            DVD_levy levy = new DVD_levy("DVD-levy", "Digitaalinen", 4, "Video imppu5vn synttäreistä");
            Kirja Remes = new Kirja("Kirja", "analoginen", 344, "Jännitys");

            Console.WriteLine(Hp.ToString());
            Console.WriteLine(Nexus.ToString());

            Console.WriteLine(levy.ToString());
            Console.WriteLine(Remes.ToString());
        }
    }
}
