using Uaine.Game.Character.Stats;

namespace Uaine.Game.Character
{
    public class CharacterStats
    {
        public Skills skills { get; private set; }
        public BasicStatus stats { get; private set; }

        public CharacterStats(Skills skills, BasicStatus stats)
        {
            this.skills = skills;
            this.stats = stats;
        }
    }
}
