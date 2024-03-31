
namespace DialogueDomain
{
    public class StandardDialogue
    {
        public int Id { get; set; } = 0;

        public string DialogueResult { get; set; } = string.Empty;

        

        public StandardDialogue(int id, string dialogue)
        {
            Id = id;
            DialogueResult = dialogue;
        }


    }
}
