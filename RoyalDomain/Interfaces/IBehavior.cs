﻿using RoyalDomain.Enums;

namespace RoyalDomain.Interfaces
{
    public interface IBehavior
    {
        double ChanceToSpeak { get; }

        double WaitLenience { get; }

        Dictionary<Sociability, double> SociabilityWeights { get; }

        Dictionary<DelayTendency, double> DelayTendencyWeights { get; }

        IProfile Profile { get; }
    }
}