using System;

namespace PowerPoint_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the period of working");
            int number = int.Parse(Console.ReadLine());
            if(number <= 3)
            {
                Console.WriteLine("Trainee");
            }
            else if(number > 3 && number <= 6)
            {
                Console.WriteLine("Low Junior");
            }
            else if(number > 6 && number <= 12)
            {
                Console.WriteLine("Junior");
            }
            else if(number > 12 && number <= 18)
            {
                Console.WriteLine("Strong Junior");
            }
            else if(number > 18 && number <= 24)
            {
                Console.WriteLine("Low Middle");
            }
            else if(number > 24 && number <= 36)
            {
                Console.WriteLine("Middle");
            }
            else if(number > 36 && number <= 48)
            {
                Console.WriteLine("Strong Middle");
            }
            else if(number > 48 && number <= 60)
            {
                Console.WriteLine("Low Senior");
            }
            else if(number > 60 && number <= 72)
            {
                Console.WriteLine("Senior");
            }
            else if(number > 72 && number <= 96)
            {
                Console.WriteLine("Strong Senior");
            }
            else if (number > 96)
            {
                Console.WriteLine("Profesional");
            }
            else
            {z
                Console.WriteLine("Error");
            }
        }
    }
}
