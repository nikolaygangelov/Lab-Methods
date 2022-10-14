using System;

namespace _9._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input == "string")
            {
                string string1 = Console.ReadLine();
                string string2 = Console.ReadLine();
                string result = GetMax(string1, string2);
                Console.WriteLine(result);
            }else if (input == "char")
            {
                char char1 = char.Parse(Console.ReadLine());
                char char2 = char.Parse(Console.ReadLine());
                GetMax(char1, char2);
            }else if (input == "int")
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                GetMax(num1, num2);
            }
        }

        private static string GetMax(string string1, string string2)
        {
            int result = string1.CompareTo(string2);
            if (result > 0)
            {
                return string1;
            }
            return string2;
        }

        private static void GetMax(char char1, char char2)
        {         
                if (char1 > char2)
                {
                    Console.WriteLine(char1);
                }
                else if (char2 > char1)
                {
                    Console.WriteLine(char2);
                }
        }

        private static void GetMax(int num1, int num2)
        {
                if (num1 > num2)
                {
                    Console.WriteLine(num1);
                }
                else if (num2 > num1)
                {
                    Console.WriteLine(num2);
                }
        }
    }
}
