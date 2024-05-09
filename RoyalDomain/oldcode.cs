//namespace CharacterDomain
//{
//    public class Character
//    {
//        public int Id { get; set; } = 0;
//        public string Name { get; set; } = string.Empty;

//        public DelayTendency? DelayTendency { get; set; } = null;

//        public Character()
//        {

//        }
//    }
//}
//using CharacterDomain;

//namespace BehaviorDomain
//{
//    public class StandardBehavior(Character npc)
//    {
//        public Character NPC { get; set; } = npc;

//        protected virtual TimeSpan WaitDuration { get; set; } = TimeSpan.FromMilliseconds(0);

//        public void DecideDelay()
//        {
//            switch (NPC.DelayTendency)
//            {
//                case DelayTendency.Indecisive:
//                    Random random = new Random();
//                    int waitLenience = random.Next(300);
//                    WaitDuration = TimeSpan.FromMilliseconds(waitLenience * 100);
//                    break;
//                default:
//                    break;
//            }
//        }
//    }
//}

//namespace DialogueDomain
//{
//    public class StandardDialogue
//    {
//        public int Id { get; set; } = 0;

//        public string DialogueResult { get; set; } = string.Empty;



//        public StandardDialogue(int id, string dialogue)
//        {
//            Id = id;
//            DialogueResult = dialogue;
//        }


//    }
//}
