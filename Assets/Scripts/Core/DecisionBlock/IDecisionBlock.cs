namespace RenAI.Core.Expert
{
    public interface IDecisionBlock
    {
        public IDecisionOutput Decide(IDecisionInput input);
    }
}