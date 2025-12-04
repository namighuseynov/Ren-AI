namespace RenAI.Core.ScenarioGenerator
{
    public sealed class RandomScenarioGenerator : IScenarioGenerator
    {
        public Scenario Generate(UserState state)
        {
            return new CustomScenario();
        }
    }
}