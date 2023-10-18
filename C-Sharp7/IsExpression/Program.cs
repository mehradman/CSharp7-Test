using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonCar pc = new PersonCar("Mehrad", "Radman", 25, "Pride", 1390);

            if (pc is Person p)
            {
                Console.WriteLine($"Name : {p.Name} Family : {p.Family} Age : {p.Age}");
            }

            switch (pc)
            {
                case Person p2 when (p2.Age > 20):
                    {
                        Console.WriteLine($"Name Is : {p2.Name} ");
                        break;
                    }
                case Person p2 when (p2.Age > 40):
                    {
                        Console.WriteLine($"{p2.Name} is old!");
                        break;
                    }
                case PersonCar car when (car.CarName == "Pride"):
                    {
                        Console.WriteLine($"Pride ");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Not Found");
                        break;
                    }
                case null:
                    {
                        Console.WriteLine("Is Null");
                        break;
                    }
            }

            Console.ReadKey();
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public int Age { get; set; }

    }

    class PersonCar : Person
    {
        public string CarName { get; set; }
        public int CarModel { get; set; }

        public PersonCar(string name, string family, int age, string carName, int carModel)
        {
            Name = name;
            Family = family;
            Age = age;
            CarName = carName;
            CarModel = carModel;
        }
    }
}
