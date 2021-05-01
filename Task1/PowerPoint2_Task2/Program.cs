using System;

namespace PowerPoint2_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thirty white horses on a red hill,First they champ,Then they stamp,Then they stand still");
            string answer = Console.ReadLine();
            if(answer == "Teeth" || answer == "teeth")
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Try Again");
            }
        }
    }
}
