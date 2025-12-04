namespace RenAI.AI.FunzzyLogic
{
    public static class FuzzyExtensions
    {
        public static FuzzyCondition Is(this FuzzyVariable variable, string setName)
            => new FuzzyCondition(variable, setName);
    }
}