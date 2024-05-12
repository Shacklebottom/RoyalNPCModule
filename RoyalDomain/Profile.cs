

namespace RoyalDomain
{
    public class Profile : IProfile
    {
        public Sociability Sociability { get; set; }

        public DelayTendency DelayTendency { get; set; }

        public Profile(Sociability sociability, DelayTendency delayTendency)
        {
            Sociability = sociability;

            DelayTendency = delayTendency;
        }
    }
}
