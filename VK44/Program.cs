﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VK44
{
    public struct Ohjastaja
    {
        public string Nimi;
        public int Startit;
        public int Voitot;
        public float VoittoProsentti;
    }
    class Program
    {
        static void LueOhjastajatVer2()
        {
            try
            {
                //luetaan CSV-tiedotosta tiedot ja tallennetaan structeihin
                string erotin = ";";
                //luetaan kaikki rivit muuttujaan
                string[] rivit = System.IO.File.ReadAllLines(@"D:\VisualstudioH8250\tilasto2017.csv");
                Ohjastaja kuski;
                int lkm = rivit.Length;
                Console.WriteLine("Ohjastajia yhteenstä {0}", lkm - 1);
                //käydään muistiin luetut rivit läpi
                for (int i = 1; i < lkm; i++)
                {
                    string[] sanat = rivit[i].Split(erotin.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    //tietueita on kahdenlaisia: V1: etunimi+ wsukunumi V2: etunimi+väliosa+sukunimi
                    if (int.TryParse(sanat[2], out int apu))
                    {
                        kuski.Nimi = sanat[0] + " " + sanat[1];
                        kuski.Startit = int.Parse(sanat[2]);
                        kuski.Voitot = int.Parse(sanat[3]);
                        kuski.VoittoProsentti = (100F * kuski.Voitot / kuski.Startit);
                    }
                    else
                    {
                        kuski.Nimi = sanat[0] + " " + sanat[1];
                        kuski.Startit = int.Parse(sanat[3]);
                        kuski.Voitot = int.Parse(sanat[4]);
                        kuski.VoittoProsentti = (100F * kuski.Voitot / kuski.Startit);
                    }
                  
                    Console.WriteLine("{0}: {1} startit {2} voitot {3} voittoprosentti {4}", i, kuski.Nimi, kuski.Startit, kuski.Voitot, kuski.VoittoProsentti);
                }
                Console.WriteLine("Loppu");
            }
            catch ( Exception ex)
            {

                throw;
            }
        }
        
        static void LueOhjastajatVer1()
        {
            try
            {
                //
                int counter = 1;
                string line;
                System.IO.StreamReader stream = new System.IO.StreamReader(@"D:\VisualstudioH8250\Ohjastilasto2017.txt");
                while ((line = stream.ReadLine()) != null)
                {
                    Console.WriteLine(counter + ":" + line);
                    counter++;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        static void Main(string[] args)
        {
            try
            {
                //LueOhjastajatVer1();
                LueOhjastajatVer2();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
