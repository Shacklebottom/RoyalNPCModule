using RoyalDomain.Interfaces;

namespace RoyalDomain.Objects
{
    public class Character(IBehavior behavior, IRandomGenerator random)
    {
        public IBehavior Behavior { get; set; } = behavior;

        public IRandomGenerator Random { get; set; } = random;

        public bool ShallCharacterSpeak()
        {
            if (Random.NextDouble() <= Behavior.ChanceToSpeak)
            {
                return true;
            }
            return false;
        }

        public int GetCharacterWaitPeriod()
        {
            var milliseconds = 90000;

            int period = (int)(milliseconds * Behavior.WaitLenience);

            return period;
        }

        public bool ShallCharacterFidget()
        {
            if (Random.NextDouble() <= Behavior.ChanceToFidget)
            {
                return true;
            }
            return false;
        }
    }
}