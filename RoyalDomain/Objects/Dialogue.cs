
using RoyalDomain.Interfaces;

namespace RoyalDomain.Objects
{
    public abstract class Dialogue : IDialogue
    {
        public List<string> Lines { get; set; }

        public Dialogue()
        {
            Lines = GetLines();
        }

        public abstract List<string> GetLines();
    }
}
