using System;

namespace Simple_Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;

            int playerPoints = 0;
            int enemyPoints = 0;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice");
                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("You rolled a " + playerRandomNum + "!");

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Enemy AI rolled a " + enemyRandomNum + "!");

                if (playerRandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("Player wins this round");
                }
                else if (playerRandomNum < enemyRandomNum)
                {
                    enemyPoints++;
                    Console.WriteLine("Enemy wins this round");
                    Console.WriteLine("Draaw");
                }

                Console.WriteLine("The score is now...");
                Console.WriteLine("Player: " + playerPoints);
                Console.WriteLine("Enemy: " + enemyPoints);
                Console.WriteLine();
            }

            if (playerPoints > enemyPoints)
            {
                Console.WriteLine("You win!");
            }
            else if (playerPoints < enemyPoints)
            {
                Console.WriteLine("You Lose!");
            }
            else
            {
                Console.WriteLine("It's a Draw!");
            }

                Console.ReadKey();
        }
    }
}
