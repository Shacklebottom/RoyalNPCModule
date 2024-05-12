using RoyalDomain.Enums;

namespace RoyalDomain.Interfaces
{
    public interface IProfile
    {
        Sociability Sociability { get; }

        DelayTendency DelayTendency { get; }
    }
}
