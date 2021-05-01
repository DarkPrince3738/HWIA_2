using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int operand1 = 64;
            int operand2 = 4;
            Console.WriteLine("Write Symbol");
            string sign = Console.ReadLine();
            switch (sign)
            {
                case "+":
                    {
                        Console.WriteLine(operand1+operand2);
                        break;
                    }
                case "-":
                    {
                        Console.WriteLine(operand1 - operand2);
                        break;
                    }
                case "*":
                    {
                        Console.WriteLine(operand1 * operand2);
                        break;
                    }
                case "/":
                    {
                        if (operand2 == 0)
                        {
                            Console.WriteLine("Error");
                            break;
                        }
                        else
                        {
                            Console.WriteLine(operand1 / operand2);
                            break;
                        }
                    }
                default:
                    {
                        Console.WriteLine("Error");
                        break;
                    }
            }
        }
    }
}
