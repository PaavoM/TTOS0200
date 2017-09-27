using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04T4
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }


        public Employee()
        {

        }
        public Employee(string firstName, string lastName) //**
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public Employee(string firstName, string lastName, string profession, int salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Profession = profession;
            Salary = salary;
        }
        public override string ToString()
        {
            return "Employee" +"\n" + "Nimi:" + FirstName + " " + LastName + " " + "Ammatti: " + Profession + " " + "Palkka: " + Salary;
        }
    }
}
