using System;

namespace Word2_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your number");
            int number = int.Parse(Console.ReadLine());
            int step = 2;
            int k = 0;
            while (step <= number)
            {
                if (step == number)
                {
                    k++;
                }
                if (number != step)
                {
                    step *= 2;
                }
            }
            if (k == 1)
            {
                Console.WriteLine("Number is step 2");
            }
            else
            {
                Console.WriteLine("Not step");
            }
        }
    }
}
