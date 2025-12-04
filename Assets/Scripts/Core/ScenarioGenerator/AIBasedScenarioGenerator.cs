namespace RenAI.Core.ScenarioGenerator
{
    public class AIBasedScenarioGenerator : IScenarioGenerator
    {
        public Scenario Generate(UserState state)
        {
            return new CustomScenario();
        }
    }
}