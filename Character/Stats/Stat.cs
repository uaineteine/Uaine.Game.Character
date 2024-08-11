using Uaine.Objects.Primitives.Values;

namespace Uaine.Game.Character.Stats
{
    public class Stat : FValue
    {
        public Stat(float val) : base(val)
        {
        }

        public void Buff(float buffSum)
        {
            Value = _def + buffSum;
        }
    }
}
