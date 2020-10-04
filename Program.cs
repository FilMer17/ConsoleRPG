using System;

namespace ConsoleRPG_FilipMerta4A
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight karel = new Knight(30, 10, 5, "Karel");
            Archer lukas = new Archer(30, 10, 5, "Lukáš");

            Battle.Fight(karel, lukas);

            Console.ReadLine();
        }
    }
}
