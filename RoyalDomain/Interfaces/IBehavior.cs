using RoyalDomain.Enums;

namespace RoyalDomain.Interfaces
{
    public interface IBehavior
    {
        double ChanceToSpeak { get; }

        double WaitLenience { get; }

        double ChanceToFidget { get; }

        IProfile Profile { get; }
    }
}
