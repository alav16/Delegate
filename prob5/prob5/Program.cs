/*
Given a list of Person objects with Name and Age properties,
use List.Sort and a lambda expression to sort the list:
by age ascending,
by name alphabetically.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace prob5
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>
            {
                new Person("Anna", 15 ),
                new Person("Nare", 10),
                new Person("Monte", 9)
            };

            list.Sort((a1, a2) => a1.Age.CompareTo(a2.Age));// yst tariq ajman

            Console.WriteLine("sorted by age: ");
            foreach (Person p in list)
            {
                Console.WriteLine($"{p.Name} // {p.Age}");
            }
            Console.WriteLine();
            list.Sort((a1, a2) => a2.Age.CompareTo(a1.Age));// yst tariqi nvazman
            foreach(Person p in list)
            {
                Console.WriteLine($"{p.Name} // {p.Age}");
            }
            Console.WriteLine();
            list.Sort((a1, a2) => a1.Name.CompareTo(a2.Name));
            foreach(Person p in list)
            {
                Console.WriteLine($"{p.Name} // {p.Age}");
            }

            Console.WriteLine();
            list.Sort((a1, a2) => a2.Name.CompareTo(a1.Name));
            foreach(Person p in list)
            {
                Console.WriteLine($"{p.Name} // {p.Age}");
            }
        }
    }
}
