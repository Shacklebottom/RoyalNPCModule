using RoyalDomain.Enums;
using RoyalDomain.Interfaces;

namespace RoyalDomain.Objects
{
    public class Profile : IProfile
    {
        public Sociability Sociability { get; set; }

        public DelayTendency DelayTendency { get; set; }

        //Constructor
        public Profile(Sociability sociability, DelayTendency delayTendency)
        {
            Sociability = sociability;

            DelayTendency = delayTendency;
        }
    }
}
