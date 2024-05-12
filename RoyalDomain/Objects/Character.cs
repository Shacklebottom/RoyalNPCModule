using RoyalDomain.Interfaces;

namespace RoyalDomain.Objects
{
    public class Character
    {
        public IBehavior Behavior { get; set; }

        public Character(IBehavior behavior)
        {
            Behavior = behavior;
        }

        //something something random.NextDouble()
    }
}
