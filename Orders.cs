

namespace _5._Orders
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();

            int n = int.Parse(Console.ReadLine());
            TotalPrice(product, n);

            
        }
        static void TotalPrice(string product, int n)
        {
            
            if (product == "coffee")
            {
                Console.WriteLine($"{n * 1.50:f2}");
            }
            else if (product == "water")
            {
                Console.WriteLine($"{n * 1.00:f2}");
            }
            else if (product == "coke")
            {
                Console.WriteLine($"{n * 1.40:f2}");
            }
            else if (product == "snacks")
            {
                Console.WriteLine($"{n * 2.00:f2}");
            }
        }
    }
}
