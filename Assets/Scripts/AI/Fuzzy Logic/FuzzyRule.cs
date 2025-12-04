using System.Collections.Generic;

namespace RenAI.AI.FunzzyLogic
{
    public sealed class FuzzyRule
    {
        public IFuzzyExpression Antecedent { get; }
        public FuzzyCondition Consequent { get; }

        public FuzzyRule(IFuzzyExpression antecedent, FuzzyCondition consequent)
        {
            Antecedent = antecedent;
            Consequent = consequent;
        }
        public double Evaluate(Dictionary<FuzzyVariable, double> inputs)
        {
            return Antecedent.Evaluate(inputs);
        }
    }
}