using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your word");
            string word = Console.ReadLine();
            switch (word)
            {
                case "клей":
                    {
                        Console.WriteLine("Glue");
                        break;
                    }
                case "карандаш":
                    {
                        Console.WriteLine("Pencil");
                        break;
                    }
                case "ручка":
                    {
                        Console.WriteLine("Pen");
                        break;
                    }
                case "ластик":
                    {
                        Console.WriteLine("Rubber");
                        break;
                    }
                case "пенал":
                    {
                        Console.WriteLine("Penal");
                        break;
                    }
                case "линейка":
                    {
                        Console.WriteLine("Ruler");
                        break;
                    }
                case "фломастер":
                    {
                        Console.WriteLine("Marker");
                        break;
                    }
                case "корректор":
                    {
                        Console.WriteLine("Corrector");
                        break;
                    }
                case "блокнот":
                    {
                        Console.WriteLine("Notepad");
                        break;
                    }
                case "тетрадь":
                    {
                        Console.WriteLine("Notebook");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Write Again");
                        break;
                    }

            }
        }
    }
}
