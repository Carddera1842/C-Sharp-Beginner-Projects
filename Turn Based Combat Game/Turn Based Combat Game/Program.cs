using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turn_Based_Combat_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerHP = 40;
            int enemyHP = 20;

            int playerAttack = 5;
            int enemyAttack = 7;

            int healAmount = 5;

            Random random = new Random();

            while (playerHP > 0 && enemyHP > 0)
            {
                

                //Player Turn
                Console.WriteLine("- - Player Turn - -\n");
                Console.WriteLine("Player HP is " + playerHP);
                Console.WriteLine("Enemy HP is " + enemyHP + "\n");
                Console.WriteLine("Enter 'a' to attack or 'h' to heal");

                string choice = Console.ReadLine();

                if (choice == "a")
                {
                    enemyHP -= playerAttack;
                    Console.WriteLine("Player attacks enemy and deals " + playerAttack + " damage!\n");
                }
                else if (choice == "h")
                {
                    playerHP += healAmount;
                    Console.WriteLine("Player restores " + healAmount + " health points!\n");
                }

                //Enemy Turn
                if (enemyHP > 0)
                {
                    Console.WriteLine("- - Enemy Turn - -\n");
                    Console.WriteLine("Player HP is " + playerHP);
                    Console.WriteLine("Enemy HP is " + enemyHP + "\n");
                    int enemyChoice = random.Next(0,2);

                    if (enemyChoice == 0)
                    {
                        playerHP -= enemyAttack;
                        Console.WriteLine("Enemy attacks and deals " + enemyAttack + " damage!\n");
                    }
                    else
                    {
                        enemyHP += healAmount;
                        Console.WriteLine("Enemy restores " + healAmount + " health points!\n");
                    }
                    
                }
                
            }
            if (playerHP > 0)
            {
                Console.WriteLine("Congratulations! You Won!");
            }
            else
            {
                Console.WriteLine("You Lose!");
            }
        }
    }
}
