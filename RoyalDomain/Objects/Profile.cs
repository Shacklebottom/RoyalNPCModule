using RoyalDomain.Enums;
using RoyalDomain.Interfaces;

namespace RoyalDomain.Objects
{
    public class Profile : IProfile
    {
        public Sociability Sociability { get; set; }

        public DelayTendency DelayTendency { get; set; }

        public Dictionary<Sociability, double> SociabilityWeights { get; set; }

        public Dictionary<DelayTendency, double> DelayTendencyWeights { get; set; }

        //Constructor
        public Profile(Sociability sociability, DelayTendency delayTendency)
        {
            Sociability = sociability;

            DelayTendency = delayTendency;

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
