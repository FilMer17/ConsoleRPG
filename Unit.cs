using System;

namespace ConsoleRPG_FilipMerta4A
{
    class Unit
    {
        public int HP { get; set; }
        public int MaxAttack { get; set; }
        public int MaxDeffense { get; set; }
        public string Name { get; set; }
        public string UnitName { get; set; }

        protected Random rnd = new Random();

        public Unit(int hp, int maxAtt, int maxDeff, string name, string unitName)
        {
            HP = hp;
            MaxAttack = maxAtt;
            MaxDeffense = maxDeff;
            Name = name;
            UnitName = unitName;
        }

        public virtual int Attack()
        {
            return rnd.Next(1, MaxAttack);
        }

        public virtual int Block()
        {
            return rnd.Next(1, MaxDeffense);
        }

        public override string ToString()
        {
            return $"{UnitName}, Jméno: {Name}, HP: {HP}, Attack: {MaxAttack}, Deffense: {MaxDeffense}";
        }
    }
}
