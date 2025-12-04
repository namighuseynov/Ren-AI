using System.Collections.Generic;
using System.Linq;

namespace RenAI.AI.FunzzyLogic
{
    public sealed class OrExpression : IFuzzyExpression
    {
        private readonly List<IFuzzyExpression> _expressions;
        public double Evaluate(Dictionary<FuzzyVariable, double> inputs)
        {
            return _expressions.Max(e => e.Evaluate(inputs));
        }
        public OrExpression(params IFuzzyExpression[] expressions)
        {
            _expressions = expressions.ToList();
        }
    }
}