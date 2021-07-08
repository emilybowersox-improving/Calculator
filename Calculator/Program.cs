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
            int number1;
            int number2;

            Console.WriteLine("A Console Calculator");
            Console.WriteLine("Enter a number.");

            string userInput = Console.ReadLine();

            try
            {
                number1 = Convert.ToInt32(userInput);

            } catch
            {
                Console.WriteLine(userInput + " is not a valid number.");
            }

            Console.WriteLine("Enter a second number, and I will add it to the first.");

            string userInput2 = Console.ReadLine();

            try
            {
                number2 = Convert.ToInt32(userInput2);
            }
            catch
            {
                Console.WriteLine(userInput2 + " is not a valid number.");
            }

            int result = number1 + number2;
            Console.WriteLine("Result: " + result);
            Console.ReadLine();

            /*            if (userInput.GetType())
                        if (Console.ReadLine().GetType == int)*/



            /*            decimal number1 = Convert.ToDecimal(Console.ReadLine());
                        int number1 = Convert.ToInt32(Console.ReadLine());
                        // implicit conversion from int to decimal 
                        int i = 345;
                        decimal f = i;*/


        }
    }
}
