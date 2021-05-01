using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write Number");
            int number = int.Parse(Console.ReadLine());
            if(number>=0 && number <= 14)
            {
                Console.WriteLine("1 area");
            }
            else if (number >= 15 && number <= 35)
            {
                Console.WriteLine("2 area");
            }
            else if (number >= 36 && number <= 49)
            {
                Console.WriteLine("3 area");
            }
            else if (number >= 50 && number <= 100)
            {
                Console.WriteLine("4 area");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
