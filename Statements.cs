using System;

namespace statement
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true;
            bool isTall = true;

            if (isMale && isTall)
            {
                Console.Write("You are tall man.");

            }
            else if (isMale && !isTall)
            {
                Console.Write("You are male but not tall.");
            }
            else if (!isMale && isTall)
            {
                Console.Write("You are not male but you are tall.");

            }
            else
            {
                Console.Write("You are neither tall nor a male.");
            }

            Console.ReadLine();
        }
    }
}
