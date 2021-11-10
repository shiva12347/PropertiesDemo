using System;
using System.Collections.Generic;

namespace PropertiesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Employe employe = new Employe {Id=1001, Name="Ashok", Salary=9000};
            Console.WriteLine(employe);

            List<Employe> employes = new List<Employe>
            {
                new Employe {Id=1002,Name="Sujana", Salary=9700},
                new Employe {Id=1003,Name="mounika", Salary=8000}
            };
  foreach (Employe emp in employes)
    Console.WriteLine(emp);

        }
    }
}
