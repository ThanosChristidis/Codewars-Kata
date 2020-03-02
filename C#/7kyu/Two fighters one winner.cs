using System;

//Description:
//Create a function that returns the name of the winner in a fight between two fighters.

//Each fighter takes turns attacking the other and whoever kills the other first is victorious.Death is defined as having health <= 0.

//Each fighter will be a Fighter object/instance.See the Fighter class below in your chosen language.

//Both health and damagePerAttack(damage_per_attack for python) will be integers larger than 0. You can mutate the Fighter objects.

//Example:
//public class Fighter
//{
//    public string Name;
//    public int Health, DamagePerAttack;
//    public Fighter(string name, int health, int damagePerAttack)
//    {
//        this.Name = name;
//        this.Health = health;
//        this.DamagePerAttack = damagePerAttack;
//    }
//}


class Program
    {
        //First Solution
        public static string declareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker)
        {   
            do
            {
                if (firstAttacker == fighter1.Name) { fighter2.Health -= fighter1.DamagePerAttack; firstAttacker = fighter2.Name; }
                else { fighter1.Health -= fighter2.DamagePerAttack; firstAttacker = fighter1.Name; }

                if (fighter2.Health <= 0) return fighter1.Name;
                else return fighter2.Name;

            } while (fighter1.Health > 0 && fighter2.Health > 0);
        }
         //Second Solution
        public static string declareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker)
        {   
            do
            {
                if (fighter2.Health <= 0)
                    return fighter1.Name;
                else if(fighter1.Health <= 0)
                    return fighter2.Name;

                if (firstAttacker == fighter1.Name)
                {
                    fighter2.Health -= fighter1.DamagePerAttack;
                    firstAttacker = fighter2.Name;
                }
                else
                {
                    fighter1.Health -= fighter2.DamagePerAttack;
                    firstAttacker = fighter1.Name;
                }

            } while (true);
        }
    }
    public class Fighter
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamagePerAttack { get; set; }
        public Fighter() { }
        public Fighter(string name,int health,int damagePerAttack)
        {
            this.Name = name;
            this.Health = health;
            this.DamagePerAttack = damagePerAttack;
        }
    }

