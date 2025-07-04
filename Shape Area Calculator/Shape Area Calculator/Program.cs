﻿using System;

namespace Shape_Area_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            float result;

            Console.WriteLine("What shape would you like to find the are of?");
            Console.WriteLine("Please enter 'r' for rectangle or 'c' for circle.");

            answer = Console.ReadLine();

            if (answer == "r")
            {
                Console.WriteLine("Please enter the height of the rectangle");
                float height = float.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the width of the rectangle");
                float width = float.Parse(Console.ReadLine());

                result = height * width;
            }
            else if (answer == "c")
            {
                Console.WriteLine("Please enter the radius of the circle");
                float radius = float.Parse(Console.ReadLine());

                result = (float)Math.PI * (radius * radius);

            }
            else
            {
                Console.WriteLine("Invalid Input");
                return;
            }
            Console.WriteLine("The result is " + result);
            Console.ReadKey();
        }
    }
}
