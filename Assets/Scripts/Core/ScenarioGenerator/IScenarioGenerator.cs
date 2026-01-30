namespace RenAI.Core.ScenarioGenerator
{
    public interface IScenarioGenerator
    {
        public Scenario Generate(UserState state);
        public Scenario Adjust(UserState state);
    }
}