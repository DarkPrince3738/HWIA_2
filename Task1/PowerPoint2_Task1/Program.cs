using System;

namespace PowerPoint2_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 4;
            int z = 3;
            x = x + y >> x - 1;
            z = --x & y * 3;
            y = y * x + 4 | z + 2;
            z = x++ & y * 2;
            x = y << x++ ^ z;
            z = x-- & y * 2 | z;
            x = y << ++x ^ z;
            Console.WriteLine($"X = {x}, Y = {y}, Z = {z}");
        }
    }
}
