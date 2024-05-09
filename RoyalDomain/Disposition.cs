
namespace RoyalDomain
{
    public class Disposition
    { 
        public InherentNature InherentNature { get; set; }

        public DelayTendency DelayTendency { get; set; }


        public Disposition(InherentNature inherentNature, DelayTendency delayTendency)
        {
            InherentNature = inherentNature;

            DelayTendency = delayTendency;
        }
    }
}
