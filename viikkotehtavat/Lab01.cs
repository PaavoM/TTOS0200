using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Lab01
    {
        public static void Tehtava01()
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
            //Tee ohjelma, joka kysyy käyttäjältä 5 kokonaislukua. Luvut tulee sijoittaa taulukkoon. 
            //Ohjelman tulee tulostaa annetut luvut käänteisessä järjestyksessä.
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
            for (int i = 0; i < luvut.Length; i++)
            {
                Console.Write(luvut[i]);
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
        public static void CalcRandomNum()
        {
            //Tee ohjelma, joka arpoo satunnaisluvun väliltä 0-100. 
            //Käytä C#:n Random -luokkaa. 
            //Tämän jälkeen ohjelman käyttäjää kehoitetaan arvaaman arvottu luku. 
            //Ohjelman tulee antaa vihje arvauksen jälkeen onko arvottu luku pienemäi vai suurempi. 
            //Tämän jälkeen vihjeitä toistetaan kunnes käyttäjä arvaa oikean luvun. 
            //Tulosta lopuksi arvausten määrä näytölle.

            Random r = new Random();

            int numero = (r.Next(0, 101));
            int luku;
            int i=1;
            while (true)
            {
                Console.Write("Arvaa numero > ");
                luku = int.Parse(System.Console.ReadLine());
                if (luku == numero)
                {
                    Console.WriteLine("Arvasit numeron! Arvasit " + i + " kertaa.");
                    
                    break;
                }
                else if (luku != numero)
                {
                    if (luku > numero)
                    {
                        Console.WriteLine("Luku pienempi");
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Luku on suurempi");
                        i++;
                    }
                }
            }
        }
        public static void DoThreeTables()
        {
            //Tee ohjelma, joka lajittelee kahdessa kokonaislukutaulukossa olevat alkiot suurusjärjestykseen kolmanteen kokonaislukutaulukkoon. 
            //Tulosta lopuksi lajitellun taulukon sisältö.

            int[] luvut = new int[] { 10, 20, 30, 40, 50 };
            int[] luvut2 = new int[] { 5, 15, 25, 35, 45 };
            int[] luvut3 = new int[10];

            Console.WriteLine("Luvut taulukossa 1 : ");
            for (int i = 0; i < luvut.Length; i++) Console.Write(" " + luvut[i] + " ");
            Console.Write("\n");
            Console.WriteLine("Luvut taulukossa 2 : ");
            for (int i = 0; i < luvut2.Length; i++) Console.Write(" " + luvut2[i] + " ");
            Console.WriteLine("\n");

            Console.WriteLine("Luvut taulukossa 3 : ");
            for (int i = 0; i < luvut3.Length; i++)
            {

            }
        }
        public static void CheckPalindrom()
        {
            //Tee ohjelma, joka kysyy käyttäjältä merkkijonon (lause). 
            //Sovelluksen tulee ilmoittaa käyttäjälle oliko annettu merkkijono palidromi.
            string sana ;
            Console.WriteLine("Anna sana");
            sana = Console.ReadLine();

            char[] array = sana.ToCharArray(); //muutetaan annettu sana taulukoksi

            for (int i = 0; i < array.Length; i++)
            {
                char letter = array[i]; //laitetaan jokainen kirjain yhteen taulukon paikkaan
            }

            Array.Reverse(array); //käännetään taulukko ympäri

            string käännetty = new string(array); //muutetaan taulukko takaisin käännetty stringiksi

            if (sana == käännetty) //ja loppu on helppo vertailu
            {
                Console.WriteLine("Palindromi");
            }
            else
            {
                Console.WriteLine("Ei palindromi");
            }
        }
        public static void calculator()
        {
            int luku1;
            int luku2;
            int summa;
            int erotus;
            int osamäärä;
            int tulo;
            int jakojäännös;
            Console.WriteLine("Tervetuloa laskimeen, syötä kaksi lukua.");
            Console.WriteLine("Anna luku");
            luku1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna luku");
            luku2 = int.Parse(Console.ReadLine());

            Console.Write("====VALIKKO====" + "\n" + "===============" + "\n\n" + "1. Summa       " + "\n" + "2. Erotus      " + "\n" + "3. Tulo        " + "\n" + "4. Osamaara    \n" + "5. Jakojaannos    " + "\n\n");

            Console.WriteLine("Valitse toiminto");
           int valinta = int.Parse(Console.ReadLine());

            switch (valinta)
            {
                case 1:
                    Console.WriteLine("Valitsit summan");
                    summa = luku1 + luku2;
                    Console.WriteLine("Vastaus: " + summa);
                    break;
                case 2:
                    Console.WriteLine("Valitsit erotuksen");
                    erotus = luku1 - luku2;
                    Console.WriteLine("Vastaus: " + erotus);
                    break;
                case 3:
                    Console.WriteLine("Valitsit tulon");
                    tulo = luku1 * luku2;
                    Console.WriteLine("Vastaus: " + tulo);
                    break;
                case 4:
                    Console.WriteLine("Valitsit osamäärän");
                    osamäärä = luku1 / luku2;
                    Console.WriteLine("Vastaus: " + osamäärä);
                    break;
                case 5:
                    Console.WriteLine("Valitsit jakojäännöksen");
                    jakojäännös = luku1 % luku2;
                    Console.WriteLine("Vastaus: " + jakojäännös);
                    break;

            }
        }

    }
}


