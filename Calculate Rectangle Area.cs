using System;

namespace _6._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double area = PrintArea(a, b);
            Console.WriteLine(area);
        }
        static double PrintArea (double a, double b)
        {

            return a * b;
        }
    }
}
