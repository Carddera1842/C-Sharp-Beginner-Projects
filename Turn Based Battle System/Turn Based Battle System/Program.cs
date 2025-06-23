using System;

namespace Turn_Based_Battle_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Unit player = new Unit(100, 20, 13, "Player");
            Unit enemy = new Unit(75, 10, 7, "Enemy Mage");
            Random random = new Random();

            while (!player.IsDead && !enemy.IsDead) 
            {
                Console.WriteLine(player.UnitName + " HP = " + player.HP);
                Console.WriteLine(enemy.UnitName + " HP = " + enemy.HP);

                // Player Turn
                Console.WriteLine("\n* * Player Turn * *");
                Console.WriteLine("What will you do?");
                string choice = Console.ReadLine();

                if (choice == "a")
                {
                    player.Attack(enemy);
                }
                else
                {
                    player.Heal();
                }

                if (player.IsDead || enemy.IsDead) break;

                Console.WriteLine(player.UnitName + " HP = " + player.HP);
                Console.WriteLine(enemy.UnitName + " HP = " + enemy.HP);

                // Enemy Turn
                Console.WriteLine("\n- - Enemy turn - -");

                int rand = random.Next(0, 2);

                if (rand == 0)
                {
                    enemy.Attack(player);
                }
                else
                {
                    enemy.Heal();
                }
            }
            
        }
    }
}
