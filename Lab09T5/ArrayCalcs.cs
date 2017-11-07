using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09T5
{
    public class ArrayCalcs
    {
        public static double summa = 0;
        public static double ka = 0;
        public static double minimi = 0;
        public static double maximi = 0;
        public static double[] array2 = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
        public static void Sum(double[] array)
        {
            foreach (var num in ArrayCalcs.array2)
            {
                summa += num;
            }
        }
        public static void Average(double[] array)
        {
                ka = summa / ArrayCalcs.array2.Length;
        }
        public static void Min(double[] array)
        {
            minimi = array2.Min();
        }
        public static void Max(double[] array)
        {
            maximi = array2.Max();
        }
    }
}
