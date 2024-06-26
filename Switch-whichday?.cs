



using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(GetDay(3));

            Console.ReadLine();
        }

        static string GetDay(int DayNum)
        {
            string DayName;

            switch (DayNum)
            {
                case 0:
                    DayName = "Sunday";
                    break;
                case 1:
                    DayName = "Monday";
                    break;
                case 2:
                    DayName = "Tuesday";
                    break;
                case 3:
                    DayName = "Wednesday";
                    break;
                default:
                    DayName = "Invalid Day Number";
                    break;
            }
            

            return DayName;



        }
    }
}
