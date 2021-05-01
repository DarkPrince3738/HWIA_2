using System;

namespace Word2_Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your work age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Write your salary without Promotion");
            int salary = int.Parse(Console.ReadLine());
            if(age>=0 && age < 5)
            {
                Console.WriteLine(age*1.1);
            }
            else if (age >= 5 && age < 10)
            {
                Console.WriteLine(age * 1.15);
            }
            else if (age >= 10 && age < 15)
            {
                Console.WriteLine(age * 1.25);
            }
            else if (age >= 15 && age < 20)
            {
                Console.WriteLine(age * 1.35);
            }
            else if (age >= 20 && age < 25)
            {
                Console.WriteLine(age * 1.45);
            }
            else if (age >= 25 && age < 50)
            {
                Console.WriteLine(age * 1.5);
            }
        }
    }
}
