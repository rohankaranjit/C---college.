using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a first number");
            double first = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a second number");
            double second = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(first + second);
            Console.ReadLine();
            Console.WriteLine(first - second);
            Console.ReadLine();
            Console.WriteLine(first * second);
            Console.ReadLine();
            Console.WriteLine(first / second);
            Console.ReadLine();
        }
    }
}
