using RoyalDomain.Interfaces;

namespace RoyalDomain.Objects
{
    public class Character
    {
        public IProfile Profile { get; set; }

        public IBehavior Behavior { get; set; }

        public Character(IProfile profile, IBehavior behavior)
        {
            Profile = profile;

            Behavior = behavior;
        }
    }
}
