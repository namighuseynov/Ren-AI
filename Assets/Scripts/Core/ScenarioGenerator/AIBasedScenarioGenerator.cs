namespace RenAI.Core.ScenarioGenerator
{
    public class AIBasedScenarioGenerator : IScenarioGenerator
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