

using System;
namespace beautifulcalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter the operator");
            string op = Console.ReadLine();

            Console.WriteLine("Enter the second number");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            Console.ReadLine();
            }
    }
}
