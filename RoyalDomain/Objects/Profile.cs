using RoyalDomain.Enums;
using RoyalDomain.Interfaces;

namespace RoyalDomain.Objects
{
    public class Profile(Sociability sociability, DelayTendency delayTendency, FidgetTendency fidgetTendency) : IProfile
    {
        public double SocialValue 
        { 
            get
            {
                var value = SociabilityWeights[sociability];

                return value;
            }
        }

        public double DelayValue
        {
            get
            {
                var value = DelayTendencyWeights[delayTendency];

                return value;
            }
        }

        public double FidgetValue
        {
            get
            {
                var value = FidgetTendencyWeights[fidgetTendency];

                return value;
            }
        }

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

        public Dictionary<FidgetTendency, double> FidgetTendencyWeights
        {
            get
            {
                var weights = new Dictionary<FidgetTendency, double>
                {
                    { FidgetTendency.Restless, 0.9 },
                    { FidgetTendency.Relaxed, 0.1 },
                };
                return weights;
            }
        }
    }
}
