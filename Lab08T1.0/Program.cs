using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08T1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //KÄYTTÄKÄÄ AINA TRY-CATCHIA
                string nimi;
                string filupath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string filu = filupath + @"\testi.txt";
                //Kirjoitetaan käyttäjän antamat rivit tiedostoon
                //luodaan StreamWriter tyyppinen olio johon kirjoitetaan
                StreamWriter sw = new StreamWriter(filu);
                do
                {
                    Console.Write("Anna nimi (Enter lopettaa):");
                    nimi = Console.ReadLine();
                    if (nimi.Length > 0)
                        sw.WriteLine(nimi);
                }
                while (nimi.Length != 0);
                sw.Close();
                //avataan tiedosto uudestaan ja lueetaan sen sisältö ja näytetään
                if (File.Exists(filu))
                {
                    string teksti = File.ReadAllText(filu);
                    Console.WriteLine(teksti);
                }
            }

            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        
    }
}
