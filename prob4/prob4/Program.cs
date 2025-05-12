/*
Using Predicate<T> (a built-in generic delegate),
write a method that filters elements in a list based on the predicate passed to it.
Example: filter even numbers, or filter names starting with a specific letter.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob4
{

    internal class Program
    {
        public static List<T> FilterList<T>(List<T> input, Predicate<T> filter)
        {
            List<T> filtered = new List<T>();
            foreach (T item in input)
            {
                if (filter(item))
                {
                    filtered.Add(item);
                }
            }
            return filtered;
        }
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5 };

            List<int> evens = FilterList(nums, x => x % 2 != 0);
            Console.WriteLine(string.Join(", ", evens));

            List<string> names = new List<string> { "Anna", "Lena", "Monte" };

            List<string> startWith = FilterList(names, StartWith);
            Console.WriteLine(string.Join(", ", startWith));
        }

        public static bool StartWith(string name)
        {
            for (int i = 0; i < name.Length; ++i)
            {
                if (name[0] == 'A')
                {
                    return true;
                }
            }

            return false;
            
        }
    }
}
