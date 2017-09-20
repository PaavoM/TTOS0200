using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lab01.Tehtava01();    //1
            //Lab01.DoGrades();     //2
            //Lab01.AskNum();       //3
            //Lab01.AskAge();       //4
            //Lab01.GetTime();      //5
            //Lab01.CalcGas();      //6
            //Lab01.CalcLeapYear(); //7
            //Lab01.AskThreeNums(); //8
            //Lab01.AskNumSumm();   //9
            //Lab01.PrintHep();     //10
            //Lab01.DoFor();        //11
            //Lab01.AskFiveNums();  //12    
            //Lab01.JumpHill();     //13
            //Lab01.CalcDistribution(); //14
            //Lab01.CalcRandomNum(); //16
            //Lab01.DoThreeTables(); //17 keskeneräinen
            //Lab01.CheckPalindrom(); //18
            //Lab01.calculator(); //20
            //TestaaKiuas();
            //TestaaPesukone();
            //TestaaTelevisio();
            //TestaaKulkuneuvo();
            
        }
        static void TestaaKiuas()
        {
            Kiuas uusiKiuas = new Kiuas();

            Console.WriteLine("Onko kiuas päällä/kiinni? (vastaa joko päällä tai kiinni");
            uusiKiuas.Tila = Console.ReadLine();
            uusiKiuas.GetTila();

            Console.WriteLine("Säädä lämpötila");
            uusiKiuas.Lämpötila = int.Parse(Console.ReadLine());
            uusiKiuas.GetLämpötila();

            Console.WriteLine("Heitä x määrä löylyä");
            uusiKiuas.Kosteus = int.Parse(Console.ReadLine());
            uusiKiuas.GetKosteus();
        }
        static void TestaaPesukone()
        {
            Pesukone uusipesukone = new Pesukone();

            Console.WriteLine("Laita pesukone päälle syöttämällä 'päällä' ");
            uusipesukone.Tila = Console.ReadLine();
            uusipesukone.GetTila();

            Console.WriteLine("Valitse ohjelma: Käsipesu, arkipesu vai megapesu");
            uusipesukone.PesuOhjelma = Console.ReadLine();
            uusipesukone.GetOhjelma();

            Console.WriteLine("Valitse veden lämpötila. 30/40/60");
            uusipesukone.VedenLämpötila = int.Parse(Console.ReadLine());
            uusipesukone.GetLämpötila();

            Console.WriteLine("Valitse linkousnopeus. 400 / 1000 / 1400");
            uusipesukone.LinkousNopeus = int.Parse(Console.ReadLine());
            uusipesukone.GetLinkous();

        }
        static void TestaaTelevisio()
        {
            Televisio uusiTelevisio = new Televisio();

            Console.WriteLine("Käynnistä televsisio syöttämällä 'päällä' ");
            uusiTelevisio.Tila = Console.ReadLine();
            uusiTelevisio.GetTila();

            Console.WriteLine("Valitse kanava");
            uusiTelevisio.Kanava = int.Parse(Console.ReadLine());
            uusiTelevisio.VaihdaKanavaa();


            Console.WriteLine("Säädä volyymiä");
            uusiTelevisio.Volyymi = int.Parse(Console.ReadLine());
            uusiTelevisio.SäädäVolyymi();
        }
        static void TestaaKulkuneuvo()
        {
            vechile uusiVechile = new vechile();


            uusiVechile.Name = "Mersu";
            uusiVechile.Speed = 320;
            uusiVechile.Tyres = 4;
            uusiVechile.PrintData();
        }
    }
}
