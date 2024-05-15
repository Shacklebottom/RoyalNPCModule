using RoyalDomain.Enums;

namespace RoyalDomain.Interfaces
{
    public interface IProfile
    {
        Sociability Sociability { get; }

        DelayTendency DelayTendency { get; }

        Dictionary<Sociability, double> SociabilityWeights { get; }

        Dictionary<DelayTendency, double> DelayTendencyWeights { get; }
    }
}
