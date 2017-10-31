using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Lab08T4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Ohjelma> Ohjelmaopas = new List<Ohjelma>();

                Ohjelmaopas.Add(new Ohjelma { Nimi = "Possen Roosa nauha-ilta", Kanava = 3, Aika = "Klo 20-22", Info = "Lämminhenkisessä suorassa lähetyksessä Jarpin, HP:n, Jarnon, Viivin ja Jaskan vieraina nähdään joukko julkisuudesta tuttuja vieraita, joilla on omakohtaista kokemusta syövästä ja kamppailusta sen voittamiseksi, kuullaan pysähdyttäviä syöpäpotilaiden tarinoita sekä perehdytään tärkeään syöpätutkimukseen." });
                Ohjelmaopas.Add(new Ohjelma { Nimi = "Junior MasterChef Suomi", Kanava = 4, Aika = "Klo 20-20:58", Info = "Kausi 3. Jakso 9/10. Jännittää niin, että vatsaan sattuu!. Semifinaali." });
                Ohjelmaopas.Add(new Ohjelma { Nimi = "Simpsonit", Kanava = 6, Aika = "Klo 20-20:30", Info = "Loppumaton tarina. Kausi 17, 12/22. Homer joutuu jälleen pahaan pulaan ja Lisa kertoo isälleen loppumattomalta vaikuttavan tarinan." });

                Stream writeMultipleStream = new FileStream(@"E:\Koulujuttuaj\Syksy 2017\C#\persons.txt", FileMode.Create, FileAccess.Write, FileShare.None);
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(writeMultipleStream, Ohjelmaopas);
                writeMultipleStream.Close();

                Stream openStream = new FileStream(@"E:\Koulujuttuaj\Syksy 2017\C#\persons.txt", FileMode.Open, FileAccess.Read, FileShare.Read);

                List<Ohjelma> LueOhjelmaopas = (List<Ohjelma>)formatter.Deserialize(openStream);
                openStream.Close();

                foreach(Ohjelma o in LueOhjelmaopas)
                {
                    Console.WriteLine("Ohjelma: {0} \n Kanava {1} \n Aika {2} \n Info: {3} \n", o.Nimi, o.Kanava, o.Aika, o.Info);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
