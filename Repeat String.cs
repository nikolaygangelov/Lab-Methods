using System;

namespace _7._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string array = Console.ReadLine();

            int n = int.Parse(Console.ReadLine());
            string result = PrintArray(array, n);
        }
        static string PrintArray(string array, int n)
        {
            string result = "";
            for (int i = 0; i < n; i++)
            {
                Console.Write(array);
            }
            return result;
        }
    }
}
