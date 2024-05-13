
using RoyalDomain.Interfaces;

namespace RoyalDomain.Objects
{
    public class Dialogue : IDialogue
    {
        public List<string> Lines { get; set; }

        public Dialogue(List<string> lines) 
        {
            Lines = lines;
        }
    }
}
