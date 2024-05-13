using RoyalDomain.Interfaces;

namespace RoyalDomain.Objects
{
    public class Character
    {
        public IBehavior Behavior { get; set; }

        public IRandomGenerator Random { get; set; }

        //Constructor
        public Character(IBehavior behavior, IRandomGenerator random)
        {
            Behavior = behavior;

            Random = random;
        }

        public bool ShallCharacterSpeak()
        {
            if (Random.NextDouble() <= Behavior.ChanceToSpeak)
            {
                return true;
            }
            return false;
        }
    }
}
