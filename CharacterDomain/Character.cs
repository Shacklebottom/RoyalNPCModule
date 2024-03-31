namespace CharacterDomain
{
    public class Character
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;

        public DelayTendency? DelayTendency { get; set; } = null;

        public Character()
        {

        }
    }
}
