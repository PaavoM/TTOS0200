using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9T4
{
    abstract class Shape
    {

        public string Name { get; set; }

        public abstract void Area();

        public abstract void Circumeference();

    }
}
