using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum, subtract, multiply, divide;
            Console.WriteLine("enter first and second no.");
            a = Convert.ToInt16(Console.ReadLine());
            b = Convert.ToInt16(Console.ReadLine());
            sum = a + b;
            Console.WriteLine("sum is");
            Console.WriteLine(sum);
            subtract = a - b;
            Console.WriteLine("difference is");
            Console.WriteLine(subtract);
            multiply = a * b;
            Console.WriteLine("product is");
            Console.WriteLine(multiply);
            divide = a / b;
            Console.WriteLine("division is");
            Console.WriteLine(divide);
            Console.ReadKey();
        }
    }
}
