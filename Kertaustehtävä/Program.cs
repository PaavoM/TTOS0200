using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kertaustehtävä
{
    public class Program
    {
        static void Main(string[] args)
        {
            Opintojakso Opint1 = new Opintojakso("Olio");

            Opint1.OP.Add(new Opiskelija("Kalle Koskinen", 18));
            Opint1.OP.Add(new Opiskelija("Olli Koskinen", 18));
            Opint1.OP.Add(new Opiskelija("Pekka Jormakka", 18));
            Opint1.OPE.Add(new Opettaja("Arja koriseva", 59));
            Opint1.OPE.Add(new Opettaja("Kalle Palander", 59));

            Opintojakso Opint2 = new Opintojakso("Kertaus");

            Opint2.OP.Add(new Opiskelija("Kalle Koskinen", 18));
            Opint2.OP.Add(new Opiskelija("MAtti Nykänen", 18));
            Opint2.OP.Add(new Opiskelija("Merja Hämäläinen", 18));
            Opint2.OPE.Add(new Opettaja("Arja koriseva", 59));
            Opint2.OPE.Add(new Opettaja("Kalle Palander", 59));

            Opintojakso Opint3 = new Opintojakso("Olio2");

            Opint3.OP.Add(new Opiskelija("Jasper Pääkkönen", 18));
            Opint3.OP.Add(new Opiskelija("Kalle Koskinen", 18));
            Opint3.OP.Add(new Opiskelija("Matti Vanhanen", 18));
            Opint3.OPE.Add(new Opettaja("Arja koriseva", 59));
            Opint3.OPE.Add(new Opettaja("Kalle Palander", 59));

            Tutkinto Tutk1 = new Tutkinto("AMK");
            Tutk1.TK.Add(Opint1);
            Tutk1.TK.Add(Opint2);
            Tutk1.TK.Add(Opint3);

            Amk Amk1 = new Amk("Amk1");
            Amk1.Tutkintotyyppi.Add(Tutk1);

            Opintojakso Opint4 = new Opintojakso("Ohjelmointi");

            Opint4.OP.Add(new Opiskelija("Santeri Holopainen", 18));
            Opint4.OP.Add(new Opiskelija("Pekka Tolvanen", 18));
            Opint4.OP.Add(new Opiskelija("Kauko Hämäläinen", 18));
            Opint4.OPE.Add(new Opettaja("Aulis Hokkanen", 59));
            Opint4.OPE.Add(new Opettaja("Jaana Mäenpää", 59));

            Opintojakso Opint5 = new Opintojakso("C#");

            Opint5.OP.Add(new Opiskelija("Tiia Hokkanen", 18));
            Opint5.OP.Add(new Opiskelija("Jorma Mäenpää", 18));
            Opint5.OP.Add(new Opiskelija("Asko Hämäläinen", 18));
            Opint5.OPE.Add(new Opettaja("Aulis Hokkanen", 59));
            Opint5.OPE.Add(new Opettaja("Jaana Mäenpää", 59));

            Opintojakso Opint6 = new Opintojakso("C++");

            Opint6.OP.Add(new Opiskelija("Jasper Yykkönen", 18));
            Opint6.OP.Add(new Opiskelija("Iiro Okke", 18));
            Opint6.OP.Add(new Opiskelija("Usko Uskovainen", 18));
            Opint6.OPE.Add(new Opettaja("Aulis Hokkanen", 59));
            Opint6.OPE.Add(new Opettaja("Jaana Mäenpää", 59));

            Tutkinto Tutk2 = new Tutkinto("AMK");
            Tutk2.TK.Add(Opint4);
            Tutk2.TK.Add(Opint5);
            Tutk2.TK.Add(Opint6);

            Amk Ymk1 = new Amk("YMK1");
            Ymk1.Tutkintotyyppi.Add(Tutk2);

           
            Console.WriteLine(Amk1.ToString());
            Console.WriteLine(Ymk1.ToString());




        }
    }
}
