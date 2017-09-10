using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viikkotehtavat
{
    class Lab01
    {
        static void Tehtava01()
        {
            //Tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3) vastaavan luvun sanana (yksi, kaksi tai kolme). 
            //Jos käyttäjä syöttää jonkin muun luvun, 
            //tulee näytölle tulostaa teksti: "joku muu luku".

            int number;
            Console.WriteLine("Luvut yhdestä kolmeen toimivat.");
            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine("Anna luku");
                number = Convert.ToInt32(System.Console.ReadLine());
                if (number == 1)
                {
                    Console.WriteLine("Annoit luvun yksi");
                }
                if (number == 2)
                {
                    Console.WriteLine("Annoit luvun kaksi");
                }
                if (number == 3)
                {
                    Console.WriteLine("Annoit luvun kolme");
                }
                if (number != 1 && number != 2 && number != 3)
                {
                    Console.WriteLine("joku muu luku");
                }
            }
        }
        public static void DoGrades()
        {
            //Tee ohjelma, jossa annetaan oppilaalle koulunumero seuraavan taulukon mukaan
            //(pistemäärä kysytään ja ohjelma tulostaa numeron):
            //pisteet           numero
            //0-1               0
            //2-3               1
            //4-5               2
            //6-7               3
            //8-9               4
            //10-12             5
            {
                int points;


                Console.WriteLine("Anna pistemäärä (0-12)");
                points = Convert.ToInt32(System.Console.ReadLine());

                if (points >= 0 && points <= 1)
                {
                    Console.WriteLine("Arvosana on 0");
                }
                if (points >= 2 && points <= 3)
                {
                    Console.WriteLine("Arvosana on 1");
                }
                if (points >= 4 && points <= 5)
                {
                    Console.WriteLine("Arvosana on 2");
                }
                if (points >= 6 && points <= 7)
                {
                    Console.WriteLine("Arvosana on 3");
                }
                if (points >= 8 && points <= 9)
                {
                    Console.WriteLine("Arvosana on 4");
                }
                if (points >= 10 && points <= 12)
                {
                    Console.WriteLine("Arvosana on 5");
                }

            }
        }
        public static void AskNum()
        {
            //Tee ohjelma, joka kysyy käyttäjältä kolme lukua
            //ja tulostaa niiden summan ja keskiarvon.

            int numero1;
            int numero2;
            int numero3;
            int summa;
            int keskiarvo;

            Console.WriteLine("Anna ensinmäinen numero");
            numero1 = Convert.ToInt32(System.Console.ReadLine());

            Console.WriteLine("Anna toinen numero");
            numero2 = Convert.ToInt32(System.Console.ReadLine());

            Console.WriteLine("Anna kolmas numero");
            numero3 = Convert.ToInt32(System.Console.ReadLine());


            Console.WriteLine("Syötit numerot:" + " " + numero1 + " " + numero2 + " " + numero3);

            summa = numero1 + numero2 + numero3;
            keskiarvo = summa / 3;

            Console.WriteLine("Summa: " + summa);
            Console.WriteLine("Keskiarvo: " + keskiarvo);


        }
        public static void AskAge()
        {
            //Tee ohjelma, jossa kysytään käyttäjältä tämän ikä. 
            //Jos ikä on alle 18 vuotta, tulosta "alaikäinen", 
            //jos se on 18-65 vuotta, tulosta "aikuinen", 
            //muussa tapauksessa tulosta "seniori".

            int ikä;
            Console.WriteLine("Anna ikä");
            ikä = Convert.ToInt32(System.Console.ReadLine());

            if (ikä < 18)
            {
                Console.WriteLine("Alaikäinen");
            }
            if (ikä > 18 && ikä < 65)
            {
                Console.WriteLine("Aikuinen");
            }
            if (ikä > 65)
            {
                Console.WriteLine("Seniori");
            }
        }
        public static void GetTime()
        {
            //Tee ohjelma, joka näyttää annetun sekuntimäärän tunteina, minuutteina ja sekunteina. 
            //Aikamääre sekuntteina kysytään käyttäjältä.

            int sekunti;
            int minuutti;
            int tunti;

            int jjminuutti;
            int jjtunti;


            Console.WriteLine("Anna sekunnit");
            sekunti = Convert.ToInt32(System.Console.ReadLine());


            minuutti = sekunti / 60;
            tunti = minuutti / 60;

            jjminuutti = sekunti % 60;
            jjtunti = minuutti % 60;

            Console.WriteLine("Antamasi sekunnit voidaan esittää muodossa: " + tunti + " tuntia " + jjtunti + " minuuttia " + jjminuutti + " sekuntia ");
        }
        public static void CalcGas()
        {
            double matka;
            double kulutus = 7.02;
            double bensa = 1.595;
            double kokonaiskulutus;
            double hinta;

            Console.WriteLine("Anna matka kilometreissä");
            matka = int.Parse(System.Console.ReadLine());

            kokonaiskulutus = (matka / 100) * kulutus;
            hinta = kokonaiskulutus * bensa;

            Console.WriteLine("Bensaa kuluu " + kokonaiskulutus + "litraa, " + "kustannus " + hinta + " euroa.");



        }
        public static void CalcLeapYear()
        {
            //Tee ohjelma, joka näyttää onko annettu vuosi karkausvuosi. Vuosiluku kysytään käyttäjältä.
            int vuosi;
            int i;

            Console.WriteLine("Anna vuosi");
            vuosi = int.Parse(System.Console.ReadLine());
            i = vuosi % 4;

            if (i == 0)
            {

                if (vuosi % 400 == 0)
                {
                    Console.WriteLine("karkausvuosi");
                }

                else if (vuosi % 100 == 0)
                {
                    Console.WriteLine("ei karkausvuosi");
                }

                else
                {
                    Console.WriteLine("Karkausvuosi");
                }
            }
            else
            {
                Console.WriteLine("ei karkausvuosi");
            }


        }
        public static void AskThreeNums()
        {
            //Tee ohjelma, joka kysyy käyttäjältä 3 kokonaislukua ja tulostaa niistä suurimman.
            int numero1;
            int numero2;
            int numero3;
            int apu;

            Console.WriteLine("Anna numeroa");
            numero1 = int.Parse(System.Console.ReadLine());

            Console.WriteLine("Anna numeroa");
            numero2 = int.Parse(System.Console.ReadLine());

            Console.WriteLine("Anna numeroa");
            numero3 = int.Parse(System.Console.ReadLine());

            if (numero1 < numero2)
            {
                apu = numero1;
                numero1 = numero2;
                numero2 = apu;
            }
            if (numero2 < numero3)
            {
                apu = numero2;
                numero2 = numero3;
                numero3 = apu;
            }
            if (numero1 < numero2)
            {
                apu = numero1;
                numero1 = numero2;
                numero2 = apu;
            }
            Console.WriteLine("Suurin luku: " + numero1);

        }
        public static void AskNumSumm()
        {
            //Tee ohjelma, joka kysyy käyttäjältä lukuja, kunnes hän syöttää luvun 0. 
            //Ohjelman tulee tulostaa syötettyjen lukujen summa.
            int luku;
            int summa = 0;

            Console.Write("Voit lopettaa ohjelman syöttämällä 0." + "\n");
            while (true)
            {
                Console.Write("Anna luku > ");
                luku = int.Parse(System.Console.ReadLine()); ;
                if (luku == 0)
                {
                    break;
                }
                else if (luku != 0)
                {
                    summa = summa + luku;
                    continue;
                }
            }
            Console.WriteLine("Lukujen summa on : " + summa);
        }
        public static void PrintHep()
        {
            //Tee ohjelma, joka alustaa sovellukseen käyttöö seuraavan taulukon arvot = [1,2,33,44,55,68,77,96,100]. 
            //Käy sovelluksessa taulukko läpi ja tulosta ruutuun "HEP"-sana aina kun taulukossa oleva luku on parillinen.

            int[] numbers = new int[] { 1, 2, 33, 44, 55, 68, 77, 96, 100 };

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine("HEP");
                }
            }
        }
        public static void DoFor()

        {
            //Tee kahden sisäkkäisen for-silmukan avulla ohjelma, joka tulostaa seuraavanlaisen kuvion:
            //*
            //**
            //***
            //****
            //*****

            //Käyttäjä antaa syötteenä tähtirivien lukumäärän.Yllä olevassa esimerkissä käyttäjä on syöttänyt luvun 5.

            int i;

            Console.WriteLine("Anna luku ");
            i = int.Parse(System.Console.ReadLine());
            i++;
            for (int b = 0; b < i; b++)
            {
                for (int tähti = 0; tähti < b; tähti++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
        public static void AskFiveNums()
        {
            int[] luvut = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Anna luku");
                luvut[i] = int.Parse(System.Console.ReadLine());
            }
            for (int b = 4; b > -1; b--)
            {
                Console.Write(" " + luvut[b] + " ");
            }
        }
        public static void JumpHill()
        {
            //Mäkihypyssä käytetään viittä arvostelutuomaria. 
            //Kirjoita ohjelma, joka kysyy arvostelupisteet yhdelle hypylle ja tulostaa tyylipisteiden summan siten, että summasta on vähennetty pois pienin ja suurin tyylipiste.
            int summa;
            int[] luvut = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Anna luku");
                luvut[i] = int.Parse(System.Console.ReadLine());
            }
            Array.Sort(luvut);
            summa = luvut[1] + luvut[2] + luvut[3];
            System.Console.WriteLine(summa);
        }
        public static void CalcDistribution()
        {
            int luku;

            int viisi = 0;
            int viisiapu = 0;

            int neljä = 0;
            int neljäapu = 0;

            int kolme = 0;
            int kolmeapu = 0;

            int kaksi = 0;
            int kaksiapu = 0;

            int yksi = 0;
            int yksiapu = 0;

            int nolla = 0;
            

            Console.Write("Voit lopettaa ohjelman syöttämällä 404." + "\n");
            while (true)
            {
                Console.Write("Anna arvosana > ");
                luku = int.Parse(System.Console.ReadLine()); 
                if (luku == 404)
                {
                    break;
                }
                else if (luku != 404)
                {
                    if (luku == 5)
                    {
                        viisi = luku + viisi;
                        viisiapu = viisi / 5;
                    }
                    else if (luku == 4)
                    {
                        neljä = luku + neljä;
                        neljäapu = neljä / 4;
                    }
                    else if (luku == 3)
                    {
                        kolme = luku + kolme;
                        kolmeapu = kolme / 3;
                    }
                    else if (luku == 2)
                    {
                        kaksi = luku + kaksi;
                        kaksiapu = kaksi / 2;
                    }
                    else if (luku == 1)
                    {
                        yksi = luku + yksi;
                        yksiapu = yksi / 1;
                    }
                    else if (luku == 0)
                    {
                        nolla++;
                    }
                }
            }
            Console.WriteLine("Arvosanat" + "\n");
            Console.Write("5: ");
            for (int i = 0; i < viisiapu; i++)
            {
                Console.Write("*");
            }
            Console.Write("\n");

            Console.Write("4: ");
            for (int i = 0; i < neljäapu; i++)
            {
                Console.Write("*");
            }
            Console.Write("\n");

            Console.Write("3: ");
            for (int i = 0; i < kolmeapu; i++)
            {
                Console.Write("*");
            }
            Console.Write("\n");

            Console.Write("2: ");
            for (int i = 0; i < kaksiapu; i++)
            {
                Console.Write("*");
            }
            Console.Write("\n");

            Console.Write("1: ");
            for (int i = 0; i < yksiapu; i++)
            {
                Console.Write("*");
            }
            Console.Write("\n");

            Console.Write("0: ");
            for (int i = 0; i < nolla; i++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }

    }
}


