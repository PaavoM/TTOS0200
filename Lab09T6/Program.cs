using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09T6
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{

                List<Tuote> Kärry = new List<Tuote>();
                Kärry.Add(new Tuote("Hk blö", 1));
                Kärry.Add(new Tuote("Mustardö", 3));
                Kärry.Add(new Tuote("Pepsi Make", 5));
                Kärry.Add(new Tuote("Pepsi Make", 5));
            

                Ostoskärry cart = new Ostoskärry();
                cart.Name = "Jorma";
                Console.WriteLine(cart.ToString());
            //}
            //catch (Exception ex)
            ////{

            //    Console.WriteLine(ex.Message);
            ////}
        }
    }
}
