using System;

namespace ConsoleRPG_FilipMerta4A
{
    class Archer : Unit
    {
        public Archer(int hp, int maxAtt, int maxDeff, string name, string unitName = "Archer")
            : base(hp, maxAtt, maxDeff, name, unitName)
        {

        }

        public override int Attack()
        {
            return rnd.Next(1, MaxAttack + 3);
        }

        public override int Block()
        {
            if (MaxDeffense > 4)
            { return rnd.Next(1, MaxDeffense - 3); }
            else return rnd.Next(1, MaxDeffense);
        }
    }
}
