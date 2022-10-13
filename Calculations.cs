using System;

namespace _3._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            CommandAdd(command, number1, number2);
            CommandMultiply(command, number1, number2);
            CommandSubtract(command, number1, number2);
            CommandDivide(command, number1, number2);
        }

        private static void CommandDivide(string command, int number1, int number2)
        {
            if (command == "divide")
            {
                Console.WriteLine(number1 / number2);
            }
        }

        private static void CommandSubtract(string command, int number1, int number2)
        {
            if (command == "subtract")
            {
                Console.WriteLine(number1 - number2);
            }
        }

        private static void CommandMultiply(string command, int number1, int number2)
        {
            if (command == "multiply")
            {
                Console.WriteLine(number1 * number2);
            }
        }

        private static void CommandAdd(string command, int number1, int number2)
        {
            if (command == "add")
            {
                Console.WriteLine(number1 + number2);
            }
        }
    }
}
