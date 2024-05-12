
namespace RoyalDomain
{
    public class Behavior
    {
        public Dictionary<Sociability, double> sociabilityWeights { get; set; }

        public Dictionary<DelayTendency, double> delaytendencyWeights { get; set; }

        public Behavior()
        {
            sociabilityWeights = new Dictionary<Sociability, double> 
            {
                { Sociability.Chatty, 0.9 },
                { Sociability.Stoic, 0.1 },
            };

            delaytendencyWeights = new Dictionary<DelayTendency, double>
            {
                { DelayTendency.Focused, 0.9 },
                { DelayTendency.Distracted, 0.1 },
            };
        }
    }
}
