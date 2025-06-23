using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turn_Based_Battle_System
{
    internal class Unit
    {
        private int currentHP;
        private int maxHP;
        private int attackPower;
        private int healPower;
        private string unitName;
        private Random random;

        public int HP { get { return currentHP; } }

        public string UnitName { get { return unitName; } }

        public bool IsDead { get { return currentHP <= 0; } }

        public Unit(int maxHP, int attackPower, int healPower, string unitName)
        {
            this.maxHP = maxHP;
            this.currentHP = maxHP;
            this.attackPower = attackPower; 
            this.healPower = healPower;
            this.unitName = unitName;
            this.random = new Random();
        }

        public void Attack(Unit unitToAttack)
        {
            double rng = random.NextDouble();
            rng = rng / 2 + 0.75f;
            int randDamage = (int)(attackPower * rng);
            unitToAttack.TakeDamage(randDamage);
            Console.WriteLine(unitName + " attacks " + unitToAttack.unitName 
                + " and deals " + randDamage + " damage!");
        }

        public void TakeDamage(int damage)
        {
            currentHP -= damage;

            if (IsDead)
            {
                Console.WriteLine(UnitName + " has been defeated!");
            }
            
        }

        public void Heal()
        {
            double rng = random.NextDouble();
            rng = rng / 2 + 0.75f;
            int heal = (int)(rng+healPower);
            currentHP = heal + currentHP > maxHP ? maxHP : currentHP + heal;
            Console.WriteLine(UnitName + " heals " + heal + " points!");
        }
    }
}
