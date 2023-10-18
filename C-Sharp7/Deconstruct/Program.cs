using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deconstruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Mehrad", "Radman");
            var (firstName, lastName) = p;
            Console.WriteLine($"Name : {firstName} Family : {lastName}");
            Console.ReadKey();
        }

        class Person
        {
            private string FirstName { get; }
            private string LastName { get; }

            public Person(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }

            public void Deconstruct(out string firstName, out string lastName)
            {
                firstName = FirstName;
                lastName = LastName;
            }


        }
    }
}
