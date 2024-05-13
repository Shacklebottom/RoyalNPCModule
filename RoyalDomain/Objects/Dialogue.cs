
using RoyalDomain.Interfaces;

namespace RoyalDomain.Objects
{
    public abstract class Dialogue : IDialogue
    {
        public IProfile Profile { get; set; }
        public List<string> Lines { get; set; }

        public Dialogue(IProfile profile)
        {
            Profile = profile;

            Lines = GetLines();
        }

        public abstract List<string> GetLines();
    }
}
