using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9T4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Shapes Muodot = new Shapes();
                Muodot.Name = "Kuvioita somia: \n";
                Console.WriteLine(Muodot.ToString());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
