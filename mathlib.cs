










using System;
namespace Mathlib
{
    class Program
    {
        static void Main(string[] args) {
            Console.Write("Choose a color.");
            string color = Console.ReadLine();

            Console.Write("Choose a plural noun.");
            string pluralnoun = Console.ReadLine();

            Console.Write("Choose a celebrity you admire.");
            string celebrity = Console.ReadLine();



            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralnoun + " are blue");
            Console.WriteLine("I love " + celebrity);
            Console.ReadLine();
            

        }
    }
}
