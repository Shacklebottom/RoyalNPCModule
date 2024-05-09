
namespace RoyalDomain
{
    public class Profile
    {
        public string Name { get; set; }

        public Disposition Disposition { get; set; }


        public Profile(string name, Disposition disposition)
        {
            Name = name;

            Disposition = disposition;
        }
    }
}
