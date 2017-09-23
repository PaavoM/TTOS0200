using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
   public static class Luku
    {
 

        public static bool OnkoLuku(string syote)
        {
            if (syote.All(char.IsDigit) || syote.ToLower().Contains(','))
            {
                Console.WriteLine("On luku");
                return true;
            }
            else
            {
                Console.WriteLine("Ei ole luku");
                return false;
            }
            
        }
        public static bool OnkoPvm(string syote)
        {
            string[] format = new string[] { "dd.MM.yyyy" };
            DateTime dateTime;

            if (DateTime.TryParseExact(syote, format, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.NoCurrentDateDefault, out dateTime))
            {
                Console.WriteLine("On päivämäärä");
                return true;
            }
            else
            {
                Console.WriteLine("Ei ole päivämäärä");
                return false;
            }
        }


    }
}
