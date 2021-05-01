using System;

namespace Word2_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;
            int z = 15;
            x = x + y >> x++ * z;
            z = ++x & y * 5; 
            y = y / ( x + 5 | z);
            z = x++ & y * 5;
            x = y << x++ ^ z;
            Console.WriteLine($"X = {x}, Y = {y}, Z = {z}");
        }
    }
}
