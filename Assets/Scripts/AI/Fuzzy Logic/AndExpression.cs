using System.Collections.Generic;
using System.Linq;

namespace RenAI.AI.FunzzyLogic
{
    public sealed class AndExpression : IFuzzyExpression
    {
        private readonly List<IFuzzyExpression> _expressions;
        public AndExpression(params IFuzzyExpression[] expressions) { 
            _expressions = expressions.ToList(); 
        }
        public double Evaluate(Dictionary<FuzzyVariable, double> inputs)
        {
            return _expressions.Min(e => e.Evaluate(inputs));
        }
    }
}