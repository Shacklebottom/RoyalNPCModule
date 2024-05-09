
using System.Net.Mime;

namespace RoyalDomain
{
    public interface IProfile
    {
        string Name { get; }

        Disposition Disposition { get; }


    }
}
