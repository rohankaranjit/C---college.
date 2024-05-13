using System;
using System.Dynamic;

namespace contif
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(GetMax(1, 20));

            Console.ReadLine();

             int GetMax(int num1 , int num2)
            {
                int result;

                if(num1 > num2)
                {
                    result = num1;
                }
                else
                {

                        result = num2;
                    
                }

                return result;

            }
        }
    }
}
