
namespace RoyalDomain
{
    public class Behavior
    {
        public double ChanceToSpeak 
        { get 
            {
                var baseChance =
                    (SociabilityWeights[Profile.Sociability] * 0.7) +
                    (DelayTendencyWeights[Profile.DelayTendency] * 0.9);
                return baseChance;
            }
        }

        public Dictionary<Sociability, double> SociabilityWeights { get; set; }

        public Dictionary<DelayTendency, double> DelayTendencyWeights { get; set; }

        public IProfile Profile { get; set; }

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
                { DelayTendency.Focused, 0.9 },
                { DelayTendency.Distracted, 0.1 },
            };
        }
    }
}
