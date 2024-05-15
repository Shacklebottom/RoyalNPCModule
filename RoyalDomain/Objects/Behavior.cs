using RoyalDomain.Enums;
using RoyalDomain.Interfaces;

namespace RoyalDomain.Objects
{
    public class Behavior : IBehavior
    {
        public IProfile Profile { get; set; }

        public double ChanceToSpeak
        {
            get
            {
                var baseChance =
                    Profile.SociabilityWeights[Profile.Sociability] * 0.7 +
                    Profile.DelayTendencyWeights[Profile.DelayTendency] * 0.3;
                return baseChance;
            }
        }

        public double WaitLenience
        {
            get
            {
                var baseLenience =
                    Profile.DelayTendencyWeights[Profile.DelayTendency] * 0.6 +
                    Profile.SociabilityWeights[Profile.Sociability] * 0.4;
                return baseLenience;
            }
        }

        //Constructor
        public Behavior(IProfile profile)
        {
            Profile = profile;


        }
    }
}
