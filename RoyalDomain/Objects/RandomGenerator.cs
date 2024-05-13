using RoyalDomain.Interfaces;

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
