using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1;
            float num2;
            float result = 0;

            string answer;

            Console.WriteLine("Hello! Welcome to the calculator program!");
            
            Console.WriteLine("Please enter your first number: ");
            num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your second number: ");
            num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("What type of operation would you like to do?");
            Console.WriteLine("Please enter 'a' for addition, 's' for subtraction, 'm' for multiplication, or 'd' for division.");

            answer = Console.ReadLine().ToLower();

            if (answer == "a")
            {
                result = num1 + num2;
            }
            else if (answer == "s")
            {
                result = num1 - num2;
            }
            else if (answer == "m")
            {
                result = num1 * num2;
            }
            else if (answer == "d")
            {
                result = num2 ==0? float.NaN : num1 / num2;
            }
            else
            {
                Console.WriteLine("Invalid Input");
                return;
            }

            if (float.IsNaN(result))
            {
                Console.WriteLine("Cannot divide by zero!");
            }
            else
            {
                Console.WriteLine("The result is " + result);
            }

                
            Console.WriteLine("Thank you for using the calculator program!");

            Console.ReadKey();
        }
    }
}
