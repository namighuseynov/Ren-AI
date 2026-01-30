namespace RenAI.Core.Expert
{
    public sealed class FuzzyDecisionOutput : IDecisionOutput
    {
        public DifficultyLevel DifficultyLevel { get; }
        public IExpertRecommendation ExpertRecommendation { get; }

        //public ScenarioParameters Parameters { get; }

        public FuzzyDecisionOutput(
            DifficultyLevel difficulty,
            //ScenarioParameters parameters,
            IExpertRecommendation recommendation = null)
        {
            DifficultyLevel = difficulty;
            //Parameters = parameters;
            ExpertRecommendation = recommendation;
        }
    }
}
