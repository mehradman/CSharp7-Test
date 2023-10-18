using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exam1();
            Exam2();
            Exam3();
            Exam4();
            Exam5();
            Exam6();
            Console.ReadKey();
        }

        static void Exam1()
        {
            var person = new Tuple<string, string, int>("Mehrad", "Radman", 25);
            Console.WriteLine($"Exam 1 -- Name : {person.Item1} Family : {person.Item2} Age : {person.Item3}");
        }

        static void Exam2()
        {
            var site = Tuple.Create("google.com", "Info@gmail.Com", "Mehrad Radman", "9092301202", 12);
            Console.WriteLine($"Exam 2 -- {site.Item1} - {site.Item2} - {site.Item3} - {site.Item4} - {site.Item5}");
        }

        static void Exam3()
        {
            var nestedTuple = new Tuple<int, int, int, int, int, int, int,
            Tuple<string, string>>(1, 2, 3, 4, 5, 6, 7, Tuple.Create("Mehrad", "Radman"));
            Console.WriteLine("Exam 3 -- {0},{1},{2}", nestedTuple.Item3, nestedTuple.Rest.Item1, nestedTuple.Rest.Item2);
        }

        static void Exam4()
        {
            TupleSample ts = new TupleSample();
            var person = Tuple.Create("Mehrad", "Radman", 25);
            Console.Write("Exam 4 -- ");
            ts.SetTupleInMethod(person);
        }

        static void Exam5()
        {
            var person = TupleSample.GetTuple();
            Console.WriteLine($"Exam 5 -- Name : {person.Item1} Family : {person.Item2} Age: {person.Item3}");
        }

        static void Exam6()
        {
            var person = TupleSample.GetNewTuple();
            Console.WriteLine($"Exam 6.1 -- Name : {person.Item1} Family : {person.Item2} Age : {person.Item3}");

            var person2 = TupleSample.GetPerson();
            Console.WriteLine($"Exam 6.2 -- {person2.name} - {person2.family} - {person2.age}");
        }
    }

    public partial class TupleSample
    {
        public void SetTupleInMethod(Tuple<string, string, int> person)
        {
            Console.WriteLine($"Name : {person.Item1} Family : {person.Item2} Age: {person.Item3}");
        }

        public static Tuple<string, string, int> GetTuple()
        {
            return Tuple.Create("Mehrad", "Radman", 25);
        }
    }

    public partial class TupleSample
    {
        public static (string, string, int) GetNewTuple()
        {
            string name = "Mehrad";
            string family = "Radman";
            int age = 25;

            return (name, family, age);
        }

        public static (string name, string family, int age) GetPerson()
        {
            string name = "Mehrad";
            string family = "Radman";
            int age = 25;

            return (name, family, age);
        }
    }
}
