using System.Collections.Generic;

namespace RenAI.AI.FunzzyLogic
{
    public sealed class FuzzyVariable
    {
        #region Properties
        public string Name { get; }
        public double Min { get; }
        public double Max { get; }

        private readonly List<FuzzySet> _sets = new();
        public IReadOnlyList<FuzzySet> Sets => _sets;
        #endregion

        #region Contructors
        public FuzzyVariable(
            string name,
            double min,
            double max)
        {
            Name = name;
            Min = min;
            Max = max;
        }
        #endregion

        #region Methods
        public void AddSet(FuzzySet fuzzySet)
        {
            _sets.Add(fuzzySet);
        }

        public Dictionary<string, double> Fuzzify(double value)
        {
            var result = new Dictionary<string, double>();

            foreach (var set in _sets)
                result[set.Name] = set.GetMembership(value);

            return result;
        }
        #endregion

    }
}