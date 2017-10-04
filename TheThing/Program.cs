using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheThing
{
    class Thing
    {
        //Julkinen jäsenmuuttuja != ominaisuus
        //public string Name;
        //parempi vaihtoehto, ominaisuus AutoImplemented Propertyn avulla
        //public string Name { get; set; }
        //ToString -metodi käyttää jäsenmuuttujaa tai propertyä
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //CONSTRUCTORS
        public Thing()
        {
            name = "Nobody here";
        }

        public override string ToString()
        {
            //return "Nimeni on: " + Name;
            //Mutta mieluummin jos on sisäinen muuttuja niin käytetään sitä
            return "nimeni on: " + name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Se-jostakin testaus
            //Thing t = new Thing();
            //Console.WriteLine(t.ToString());
            //t.Name = "Pentti";
            //Console.WriteLine(t.Name);
            //Console.WriteLine(t.ToString());

            //student olion testaus
            Student s = new Student();
            s.FirstName = "Esa";
            s.LastName = "Salmikangas";
            Student s2 = new Student("Jaska", "Jokunen");
            //Luodaan kokoelma Student olioita, käytetään List
            List<Student> students = new List<Student>();
            students.Add(s);
            students.Add(s2);
            students.Add(new Student("Arska", "Aaaltonen"));
            //Näytetään oppilaat
            Console.WriteLine("Luokan oppilaat: ");
            foreach (Student item in students)
            {
                Console.WriteLine(item.ToString());
            }
            //testataan group-luokka
            Group luokka = new Group();
            luokka.Name = "TTV16S1";
            luokka.Students.Add(new Student("Anna", "Aurinko"));
            Console.WriteLine(luokka.ToString());
        }
    }
}
