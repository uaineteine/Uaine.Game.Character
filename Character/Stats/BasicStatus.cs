namespace Uaine.Game.Character.Stats
{
    public class BasicStatus
    {
        //basics
        public Stat Health;
        public int Tier { get; }

        //combat stuff
        public Stat Attack;
        public Stat Defense;
        public Stat Armour;
        public Stat Stamina;

        public Stat Dodge;
        public Stat Speed;
        public Stat CritChance;

        //magic
        public Stat MP;

        public BasicStatus(Stat attack, Stat defense, Stat armour, int level)
        {
            Attack = attack;
            Defense = defense;
            Armour = armour;
            Tier = level;
        }
    }
}
