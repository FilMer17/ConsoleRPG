using System;

namespace ConsoleRPG_FilipMerta4A
{
    class Battle
    {
        public static void Fight(Unit un1, Unit un2)
        {
            while(true)
            {
                if(AttackResult(un1, un2) == "End")
                {
                    Console.WriteLine("Konec hry!");
                    break;
                }

                if (AttackResult(un2, un1) == "End")
                {
                    Console.WriteLine("Konec hry!");
                    break;
                }
            }
        }

        public static string AttackResult(Unit unA, Unit unB)
        {
            int unAAttack = unA.Attack();
            int unBDeffense = unB.Block();

            int damage = unAAttack - unBDeffense;

            if (damage > 0)
            { unB.HP -= damage; }
            else damage = 0;

            Console.WriteLine($"{unA.Name} ubral {unB.Name} {damage} životů.");
            Console.WriteLine($"{unB.Name} má {unB.HP} životů. \n");

            if (unB.HP <= 0)
            {
                Console.WriteLine($"{unB.Name} umřel.");
                Console.WriteLine($"{unA.Name} je vítěz!");

                return "End";
            }
            else return "Hra";
        }
    }
}
