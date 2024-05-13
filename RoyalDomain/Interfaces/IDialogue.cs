
namespace RoyalDomain.Interfaces
{
    public interface IDialogue
    {
        IProfile Profile { get; }

        List<string> Lines { get; }

        List<string> GetLines();
    }
}
