using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04T4
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Pekka";
            employee.LastName = "Fisk";
            employee.Profession = "Talonmiess";
            employee.Salary = 1600;
            Console.WriteLine(employee.ToString());

            Employee jaska = new Employee("jaska", "jokunen"); //**
            Console.WriteLine(jaska.ToString());

            Employee matti = new Employee("Matti", "Meikaläinen", "Jokapaikanmies", 1200);
            Console.WriteLine(matti.ToString());

            Boss boss = new Boss();
            boss.FirstName = "Håkan";
            boss.LastName = "Åkerman";
            boss.Profession = "Johtaja";
            boss.Salary = 3600;
            boss.Car = "Mini cooper";
            boss.Bonus = 900;
            Console.WriteLine(boss.ToString());

        }
    }
}
