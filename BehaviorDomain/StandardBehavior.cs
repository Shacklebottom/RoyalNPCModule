using CharacterDomain;
using System.Diagnostics;

namespace BehaviorDomain
{
    public class StandardBehavior(Character npc)
    {
        public Character NPC { get; set; } = npc;

        protected virtual TimeSpan WaitDuration { get; set; } = TimeSpan.FromMilliseconds(0);

        public void DecideDelay()
        {
            switch (NPC.DelayTendency)
            {
                case DelayTendency.Indecisive:
                    Random random = new Random();
                    int waitLenience = random.Next(300);
                    WaitDuration = TimeSpan.FromMilliseconds(waitLenience * 100);
                    break;
                default:
                    break;
            }
        }
    }
}
