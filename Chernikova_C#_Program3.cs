using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 33};
            for (int i = 0; i < numbers.Length; i++)

            {
              
                int nums = numbers[i] % 3;
                if(nums==0)

                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
    }
}
