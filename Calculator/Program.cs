﻿using System;
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
            decimal number1 = 0;
            decimal number2 = 0;
            string userInput1 = "";
            string userInput2 = "";

            Console.WriteLine("A Console Calculator");





            string fullInput = "";
            char[] delimiterChars = { ' ', '+', '-', '*', '/' };
            decimal number = 0;
            

            Console.WriteLine("Enter what you would like to see added.");
/*            fullInput = Console.ReadLine();

            string[] inputs = fullInput.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);*/

         
/*            foreach (var input in inputs)
            {
                Console.WriteLine(input);
            }*/
           
            do
            {
                Console.WriteLine("Enter what you would like to see added.");
                fullInput = Console.ReadLine();
                string[] inputs = fullInput.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                foreach (var input in inputs)
                {
                    {
                        if (decimal.TryParse(input, out number) == true)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine(fullInput + " is not a valid expression.");
                        }
                    } while (decimal.TryParse(input, out number) == false) ;
                }




/*            Console.WriteLine(inputs[0]);
            Console.WriteLine(inputs[1]);
            Console.ReadLine();*/




            do
            {
                Console.WriteLine("Enter a number.");
                userInput1 = Console.ReadLine();
                if (decimal.TryParse(userInput1, out number1) == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(userInput1 + " is not a valid number.");
                }
            } while (decimal.TryParse(userInput1, out number1) == false);


            do
            {
                Console.WriteLine("Enter a second number, and I will add it to the first.");
                userInput2 = Console.ReadLine();
                if (decimal.TryParse(userInput2, out number2) == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(userInput2 + " is not a valid number.");
                }
            } while (decimal.TryParse(userInput2, out number2) == false);


            decimal result = number1 + number2;
            Console.WriteLine("Result: " + result);
            Console.ReadLine();


        }
    }
}
