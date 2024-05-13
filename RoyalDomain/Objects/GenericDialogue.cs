
using RoyalDomain.Interfaces;

namespace RoyalDomain.Objects
{
    public class GenericDialogue : Dialogue
    {
        public GenericDialogue(IProfile profile) : base(profile)
        {

        }
        public override List<string> GetLines()
        {
            return new List<string>()
            {
                "turtles, and",
                "more turtles"
            };
        }
    }
}
