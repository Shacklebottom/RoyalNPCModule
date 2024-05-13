using RoyalDomain.Enums;
using RoyalDomain.Interfaces;

namespace RoyalDomain.Objects
{
    public class Behavior : IBehavior
    {
        public IProfile Profile { get; set; }

        public Dictionary<Sociability, double> SociabilityWeights { get; set; }

        public Dictionary<DelayTendency, double> DelayTendencyWeights { get; set; }

        public double ChanceToSpeak
        {
            get
            {
                var baseChance =
                    SociabilityWeights[Profile.Sociability] * 0.7 +
                    DelayTendencyWeights[Profile.DelayTendency] * 0.3;
                return baseChance;
            }
        }

        public double WaitLenience
        {
            get
            {
                var baseLenience =
                    DelayTendencyWeights[Profile.DelayTendency] * 0.6 +
                    SociabilityWeights[Profile.Sociability] * 0.4;
                return baseLenience;
            }
        }

        //Constructor
        public Behavior(IProfile profile)
        {
            Profile = profile;

            SociabilityWeights = new Dictionary<Sociability, double>
            {
                { Sociability.Chatty, 0.9 },
                { Sociability.Stoic, 0.1 },
            };

            DelayTendencyWeights = new Dictionary<DelayTendency, double>
            {
                { DelayTendency.Distracted, 0.9 },
                { DelayTendency.Focused, 0.1 },
            };
        }
    }
}
