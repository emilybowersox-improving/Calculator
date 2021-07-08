using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A Console Calculator");
            Console.WriteLine("Enter a number.");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number, and I will add it to the first.");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int result = number1 + number2;
            Console.WriteLine("Result: " + result);
            Console.ReadLine();


        }
    }
}
