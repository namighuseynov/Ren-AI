namespace RenAI.AI.FunzzyLogic
{
    public static class FuzzyOperators
    {
        public static IFuzzyExpression And(this IFuzzyExpression a, IFuzzyExpression b)
            => new AndExpression(a, b);
        public static IFuzzyExpression Or(this IFuzzyExpression a, IFuzzyExpression b)
            => new OrExpression(a, b);
    }
}