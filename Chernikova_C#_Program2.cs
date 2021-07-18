using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string trName = "Вячеслав";
             Console.WriteLine("name:");
            string name = Console.ReadLine();
            if (name == trName)
            {
                Console.WriteLine($"Привет, {trName}");
            }
            else
            {
                Console.WriteLine("Нет такого имени");
            }
        }
    }
}
