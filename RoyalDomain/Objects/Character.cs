﻿using RoyalDomain.Interfaces;

namespace RoyalDomain.Objects
{
    public class Character(IBehavior behavior, IRandomGenerator random)
    {
        public IBehavior Behavior { get; set; } = behavior;

        public IRandomGenerator Random { get; set; } = random;

        public bool ShallCharacterSpeak()
        {
            if (Random.NextDouble() <= Behavior.ChanceToSpeak)
            {
                return true;
            }
            return false;
        }

        public TimeSpan GetDelay()
        {
            return TimeSpan.FromMilliseconds(Behavior.WaitLenience * 1);
        }
    }
}