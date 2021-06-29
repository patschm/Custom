using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinkeSoep
{
    class Program
    {
        static List<Person> people = new Faker<Person>()
                .RuleFor(p => p.FirstName, f => f.Name.FirstName())
                .RuleFor(p => p.LastName, f => f.Name.LastName())
                .RuleFor(p => p.Age, f => f.Random.Int(0, 123))
                .Generate(1000);

        static void Main(string[] args)
        {
            string aaa = "H";
            var list = people.Where(p=> p.LastName.StartsWith(aaa));

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            DoeIets();

            int DoeIets()
            {
                Console.WriteLine("Hoi");
                return 42;
            }
        }

        static string  OrderByLastName(Person p)
        {
            return p.LastName;
        }
        static int OrderByAge(Person p)
        {
            return p.Age;
        }
        static bool LastnameStartsWithT(Person p)
        {
            return p.LastName.StartsWith("T");
        }
        static bool LastnameStartsWithS(Person p)
        {
            return p.LastName.StartsWith("S");
        }
    }
}
