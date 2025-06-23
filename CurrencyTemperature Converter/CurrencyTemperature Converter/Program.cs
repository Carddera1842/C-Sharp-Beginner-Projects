using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyTemperature_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine("Please enter 'c' to use the currency converter  " +
                "or  't' to use the temperature converter.");

            string answer = Console.ReadLine();

            if (answer == "c")
            {
                Console.WriteLine("You have selected the currency converter.");
                Console.WriteLine("Please enter 'a' to convert from pounds or 'b' " +
                    "to convert from euros");

                string choice = Console.ReadLine();

                if (choice == "a")
                {
                    Console.WriteLine("Please enter your amount in Britsh pounds.");
                    float pounds = float.Parse(Console.ReadLine());
                    float euros = pounds * 1.16f;

                    Console.WriteLine("The amount in Euros is " 
                        + euros.ToString("0.00"));
                }
                else if (choice == "b")
                {
                    Console.WriteLine("Please enter your amount in euros.");
                    float euros = float.Parse(Console.ReadLine());
                    float pounds = euros / 1.16f;

                    Console.WriteLine("The amount in British Pounds is "
                        + pounds.ToString("0.00"));
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    return;
                }
            }
            else if (answer == "t")
            {
                Console.WriteLine("You have selected the temperature converter.");
                Console.WriteLine("Please enter 'c' to convert from celcius or 'f' " +
                   "to convert from fahrenheit");

                string choice = Console.ReadLine();

                if (choice == "c")
                {
                    Console.WriteLine("Please enter your temperature in celcius.");
                    float celcius = float.Parse(Console.ReadLine());
                    float fahrenheit = celcius * 1.18f + 32f;

                    Console.WriteLine("The temperature in fahrenheit is " + fahrenheit);
                }
                else if (choice == "f")
                {
                    Console.WriteLine("Please enter your temperature in fahrenheight.");
                    float fahrenheit = float.Parse(Console.ReadLine());
                    float celcius = (fahrenheit - 32f) / 1.8f;

                    Console.WriteLine("The temperature in celcius is " + celcius);
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    return;
                }
            }
        }
    }
}
