using System.Collections.Generic;

namespace RenAI.AI.FunzzyLogic
{
    public interface IFuzzyExpression
    {
        double Evaluate(Dictionary<FuzzyVariable, double> inputs);
    }
}