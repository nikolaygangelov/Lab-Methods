using System;

namespace _8._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {

            double @base = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double result = MathPower(@base, power);
            Console.WriteLine(result);
        }
        static double MathPower(double @base, double power)
        {
            return Math.Pow(@base, power);
        }
    }
}
