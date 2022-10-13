using System;

namespace _4._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {

            int end = int.Parse(Console.ReadLine());
            for (int i = 1; i <= end; i++)
            {
                PrintLine(i);
            }

            for (int i = end -1; i >= 1; i--)
            {
                PrintLine(i);
            }
        }

        private static void PrintLine(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
