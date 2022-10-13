using System;

namespace _1._Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintNumbers(number);
        }

        private static void PrintNumbers(int number)
        {
            
            if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative. ");
            }
            else if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero. ");
            }
            else if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive. ");
            }
        }
    }
}
