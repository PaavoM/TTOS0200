using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9T4
{
    class Shapes
    {
        public string Name { get; set; }
        public List<Shape> Kuviot;

        public Shapes()
        {
            Kuviot = new List<Shape>();

            Circle round = new Circle();
            Circle round2 = new Circle();
            Rectangle kulmio = new Rectangle(2, 5);
            Rectangle kulmio2 = new Rectangle(1, 6);

            round.R = 1.5;
            round2.R = 1.0;

            Kuviot.Add(round);
            Kuviot.Add(round2);

            Kuviot.Add(kulmio);
            Kuviot.Add(kulmio2);

            round.Area();
            round.Circumeference();

            round2.Area();
            round2.Circumeference();

            kulmio.Area();
            kulmio.Circumeference();

            kulmio2.Area();
            kulmio2.Circumeference();

        }
        public override string ToString()
        {
            int d = 1;
            string retval = "";
            foreach (Shape item in Kuviot)
            {
                retval += Name + " " + d + " " + item.ToString() + "\n";
                d++;
            }
            return retval;
        }
    }
}
