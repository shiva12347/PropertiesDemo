using System;
using System.Collections.Generic;

namespace PropertiesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Employe employe = new Employe {Id=1001, Name="KRISHNA", Salary=9000};
            Console.WriteLine(employe);

            List<Employe> employes = new List<Employe>
            {
                new Employe {Id=1002,Name="SHIVA", Salary=1000},
                new Employe {Id=1003,Name="RAGHUU", Salary=8000}
            };
  foreach (Employe emp in employes)
    Console.WriteLine(emp);

        }
    }
}
