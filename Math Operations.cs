using System;

namespace _11._Math_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            char @operator = char.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            double result = Calculate(a, @operator, b);
            Console.WriteLine(result);
        }

        private static double Calculate(int a, char @operator, int b)
        {
            double result = 0;
            if (@operator == '/')
            {
                result = a / b;
            }
            else if (@operator == '*')
            {
                result = a * b;
            }
            else if (@operator == '+')
            {
                result = a + b;
            }
            else if (@operator == '-')
            {
                result = a - b;
            }

            return result;
        }
    }
}
