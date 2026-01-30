using System.Collections.Generic;
using RenAI.AI.FunzzyLogic;

namespace RenAI.Core.Expert
{
    public sealed class FuzzyInput : IDecisionInput
    {
        public Dictionary<FuzzyVariable, double> Values { get; }

        public FuzzyInput(Dictionary<FuzzyVariable, double> values)
        {
            Values = values;
        }
    }
}
