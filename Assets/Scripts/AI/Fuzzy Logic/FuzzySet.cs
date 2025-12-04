namespace RenAI.AI.FunzzyLogic
{
    public abstract class FuzzySet
    {
        public string Name { get; }
        protected FuzzySet(string name)
        {
            Name = name;
        }
        public abstract double GetMembership(double x);
    }
}