using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerScore = 0;
            int enemyScore = 0;

            Random random = new Random();

            Console.WriteLine("Welcome to Rock, Paper, Scissors!");

            while (playerScore != 3 &&  enemyScore != 3)
            {
                Console.WriteLine("Player Score: " + playerScore +" - - Enemy Score: " + enemyScore);
                Console.WriteLine("Please enter 'r' for Rock, 'p' for Paper, or 's' for Scissors!\n");
                string playerChoice = Console.ReadLine();

                int enemyChoice = random.Next(0, 3);

                if (enemyChoice == 0)
                {
                    Console.WriteLine("Enemy chose Rock!");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Tie!");
                            break;
                        case "p":
                            Console.WriteLine("Player wins this round");
                            playerScore++;
                            break;
                        case "s":
                            Console.WriteLine("Enemy wins this round");
                            enemyScore++;
                            break;
                        default:
                            return;
                    }
                }
                else if (enemyChoice == 1)
                {
                    Console.WriteLine("Enemy chose Paper!");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Enemy wins this round");
                            enemyScore++;
                            break;
                        case "p":
                            Console.WriteLine("Tie!");
                            break;
                        case "s":
                            Console.WriteLine("Player wins this round");
                            playerScore++;
                            break;
                        default:
                            return;
                    }
                }
                else
                {
                    Console.WriteLine("Enemy choose Scissors!");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Player wins this round");
                            playerScore++;
                            break;
                        case "p":
                            Console.WriteLine("Enemy wins this round!");
                            enemyScore++;
                            break;
                        case "s":
                            Console.WriteLine("Tie!");
                            break;
                        default:
                            return;
                    }
                }
            }
            if (playerScore == 3)
            {
                Console.WriteLine("\nYou Win!");
            }
            else
            {
                Console.WriteLine("\nYou Lose!");
            }
        }
    }
}
