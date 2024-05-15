
using RoyalDomain.Interfaces;

namespace RoyalDomain.Objects
{
    public class GenericDialogue(IProfile profile) : Dialogue(profile)
    {
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
