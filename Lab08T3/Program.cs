using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08T3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string filupath1 = (@"E:\Koulujuttuaj\Syksy 2017\C#\integers.txt");
                string filupath2 = (@"E:\Koulujuttuaj\Syksy 2017\C#\doubles.txt");
                string numero;
                int integeeri;
                double dubles;

                while (true)
                {
                    Console.WriteLine("Anna numero (syötä ei-numero tai enter lopettaaksesi)> ");
                    numero = Console.ReadLine();

                    if (int.TryParse(numero, out integeeri))
                    {
                        Console.WriteLine("Numero on integer");
                        if (!File.Exists(filupath1))
                        {
                            using (StreamWriter sw = File.CreateText(filupath1))
                            {
                                sw.WriteLine("Integer-tiedosto");
                            }
                        }
                        using (StreamWriter sw = File.AppendText(filupath1))
                        {
                            sw.WriteLine(numero);
                        }
                    }
                    else if (double.TryParse(numero, out dubles))
                    {
                        Console.WriteLine("Numero on doubles.");
                        if (!File.Exists(filupath2))
                        {
                            using (StreamWriter sw = File.CreateText(filupath2))
                            {
                                sw.WriteLine("Double-tiedosto");
                            }
                        }
                        using (StreamWriter sw = File.AppendText(filupath2))
                        {
                            sw.WriteLine(numero);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Syöte ei ollut numero");
                        break; 
                    }
                }
                string text1 = System.IO.File.ReadAllText(filupath1);
                System.Console.WriteLine("integers.txt sisältö: " + text1);

                string text2 = System.IO.File.ReadAllText(filupath2);
                System.Console.WriteLine("dubles.txt sisältö: " + text2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
