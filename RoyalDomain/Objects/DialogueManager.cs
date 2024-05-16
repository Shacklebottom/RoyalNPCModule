using RoyalDomain.Interfaces;

namespace RoyalDomain.Objects
{
    public class DialogueManager() : IDialogueManager
    {
        public List<string>GetFileInfo(string filePath)
        {
            return new List<string> { filePath };
            //return File.ReadAllLines(filePath).ToList();
        }
    }
}
