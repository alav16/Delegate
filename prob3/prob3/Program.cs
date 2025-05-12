/*
Create a generic delegate Transformer<T> that takes one parameter and returns a result.
Write a method that accepts this delegate to transform a list of elements
(e.g., convert integers to strings, strings to uppercase, etc.).
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob3
{
    public delegate T Transformer<T> (T value);

    public static class ListTransformer
    {
        public static List<T> TransformList<T>(List<T> inputList, Transformer<T> transformer)
        {
            List<T> res = new List<T>();
            foreach (T value in inputList)
            {
                res.Add(transformer(value));
            }
            return res;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5};
            List<int> doubled = ListTransformer.TransformList(numbers, Double);
            Console.WriteLine(string.Join(", ", doubled));

            List<string> words = new List<string> { "hello", "world" };
            List<string> upper = ListTransformer.TransformList(words, ToUpper);
            Console.WriteLine(string.Join(", ", upper));
        }

        public static int Double(int num)
        {
            return num * 2;
        }

        public static string ToUpper(string str)
        {
            return str.ToUpper();
        }
    }
}
