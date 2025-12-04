namespace RenAI.AI.FunzzyLogic
{
    public sealed class TriangleFuzzySet : FuzzySet
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public TriangleFuzzySet(string name, double a, double b, double c)
            : base(name)
        {
            A = a; B = b; C = c;
        }

        public override double GetMembership(double x)
        {
            if (x <= A || x >= C) return 0;
            if (x == B) return 1;
            if (x > A && x < B) return (x - A) / (B - A);
            return (C - x) / (C - B);
        }
    }
}
