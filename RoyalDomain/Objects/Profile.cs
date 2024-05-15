using RoyalDomain.Enums;
using RoyalDomain.Interfaces;

namespace RoyalDomain.Objects
{
    public class Profile(Sociability sociability, DelayTendency delayTendency) : IProfile
    {
        public Sociability Sociability { get; set; } = sociability;

        public DelayTendency DelayTendency { get; set; } = delayTendency;

        public Dictionary<Sociability, double> SociabilityWeights
        {
            get
            {
                var weights = new Dictionary<Sociability, double>
                {
                    { Sociability.Chatty, 0.9 },
                    { Sociability.Stoic, 0.1 },
                };
                return weights;
            }
        }

        public Dictionary<DelayTendency, double> DelayTendencyWeights 
        { 
            get
            {
                var weights = new Dictionary<DelayTendency, double> 
                {
                    { DelayTendency.Distracted, 0.9 },
                    { DelayTendency.Focused, 0.1 },
                };
                return weights;
            }        
        }
    }
}
