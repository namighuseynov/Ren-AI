using System.Collections.Generic;

namespace RenAI.AI.FunzzyLogic
{
    public sealed class FuzzyCondition : IFuzzyExpression
    {
        public FuzzyVariable Variable { get; }
        public string SetName { get; }
        public FuzzyCondition(FuzzyVariable variable, string setName)
        {
            Variable = variable;
            SetName = setName;
        }
        public double Evaluate(Dictionary<FuzzyVariable, double> inputs)
        {
            var value = inputs[Variable];

            var membership = Variable.Fuzzify(value);

            return membership.TryGetValue(SetName, out var mu)
                ? mu :
                0.0;
        }
    }
}