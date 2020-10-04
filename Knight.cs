using System;

namespace ConsoleRPG_FilipMerta4A
{
    class Knight : Unit
    {
        public Knight(int hp, int maxAtt, int maxDeff, string name, string unitName = "Knight")
            : base(hp, maxAtt, maxDeff, name, unitName)
        { 
        
        }

        public override int Attack()
        {
            if (MaxAttack > 3)
            { return rnd.Next(1, MaxAttack - 3); }
            else return rnd.Next(1, MaxAttack);
        }

        public override int Block()
        {
            return rnd.Next(1, MaxDeffense + 3);
        }
    }
}
