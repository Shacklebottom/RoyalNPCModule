using RoyalDomain.Enums;

namespace RoyalDomain.Interfaces
{
    public interface IProfile
    {
        double SocialValue { get; }

        double DelayValue { get; }

        Dictionary<Sociability, double> SociabilityWeights { get; }

        Dictionary<DelayTendency, double> DelayTendencyWeights { get; }
    }
}
