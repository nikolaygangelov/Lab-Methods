using System;

namespace _10._Multiply_Evens_By_Odds
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            int absValue = Math.Abs(int.Parse(input));

            int sumOfEvens = GetSumOfEvenDigits(absValue.ToString());
            int sumOfOdds = GetSumOfOddDigits(absValue.ToString());
            
            int result = GetMultipleOfEvenAndOdds(absValue.ToString());
            Console.WriteLine(result);
        }


        private static int GetSumOfOddDigits(string input)
        {
            
            int sumOfOdds = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int element = int.Parse(input[i].ToString());
                if (element % 2 != 0)
                {
                    sumOfOdds += element;
                }
            }
            return sumOfOdds;
        }

        private static int GetSumOfEvenDigits(string input)
        {
            int sumOfEvens = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int element = int.Parse(input[i].ToString());
                if (element % 2 == 0)
                {
                    sumOfEvens += element;
                }
            }
            return sumOfEvens;
        }
        static int GetMultipleOfEvenAndOdds(string input)
        {
            int result = GetSumOfEvenDigits(input)*GetSumOfOddDigits(input);
            return result;
        }
    }
}
