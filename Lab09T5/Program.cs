using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09T5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double[] array2 = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
                ArrayCalcs.Sum(array2);
                ArrayCalcs.Average(array2);
                ArrayCalcs.Min(array2);
                ArrayCalcs.Max(array2);

                Console.WriteLine("Summa on = " + ArrayCalcs.summa);
                Console.WriteLine("Keskiarvo on = " + ArrayCalcs.ka);
                Console.WriteLine("Minimi on = " + ArrayCalcs.minimi);
                Console.WriteLine("Maximi on = " + ArrayCalcs.maximi);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
