/*
Basic Calculator with Delegates
Write a program that defines a delegate Operation for arithmetic operations.
Create methods for Add, Subtract, Multiply, and Divide,
and assign them to the delegate to perform operations based on user input.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob1
{
    public delegate double Operation(double a, double b);

    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter 1 for adding, 2 for subtract, 3 for multiply, 4 for dividing");

            Operation operation;

            string choice = Console.ReadLine();
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            switch (choice)
            {
                case "1":
                    operation = Add;
                    break;
                case "2":
                    operation = Subtract;
                    break;
                case "3":
                    operation = Multiply;
                    break;
                case "4":
                    operation = Divide;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    return;
            }

            double result = operation(num1, num2);
            Console.WriteLine($"{result}");
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return (a * b);
        }

        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return a / b;
        }
    }
}

