using RoyalDomain.Interfaces;

#pragma warning disable IDE1006

namespace RoyalDomain.Objects
{
    public class RandomGenerator : IRandomGenerator
    {
        private static Random _random 
        { 
            get
            {
                return new Random();
            } 
        }

        public double NextDouble()
        {
            return _random.NextDouble();
        }
    }
}
