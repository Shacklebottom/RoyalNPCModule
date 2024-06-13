using RoyalDomain.Enums;

namespace RoyalDomain.Interfaces
{
    public interface IProfile
    {
        double SocialValue { get; }

        double DelayValue { get; }

        double FidgetValue { get; }

        Dictionary<SocialTendency, double> SociabilityWeights { get; }

        Dictionary<DelayTendency, double> DelayTendencyWeights { get; }

        Dictionary<FidgetTendency, double> FidgetTendencyWeights { get; }
    }
}
