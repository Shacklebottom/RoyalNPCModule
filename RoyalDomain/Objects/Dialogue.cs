
using RoyalDomain.Interfaces;

namespace RoyalDomain.Objects
{
    public abstract class Dialogue(IProfile profile) : IDialogue
    {
        public IProfile Profile { get; set; } = profile;

        public List<string> Lines
        {
            get
            {
                return GetLines();
            }
        }

        public abstract List<string> GetLines();
    }
}
