namespace RenAI.Core.ScenarioGenerator
{
    public sealed class RandomScenarioGenerator : IScenarioGenerator
    {
        public Scenario Adjust(UserState state)
        {
            throw new System.NotImplementedException();
        }

        public Scenario Generate(UserState state)
        {
            return new CustomScenario();
        }
    }
}