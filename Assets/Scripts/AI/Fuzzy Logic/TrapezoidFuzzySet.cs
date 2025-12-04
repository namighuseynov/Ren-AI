namespace RenAI.AI.FunzzyLogic
{
    public sealed class TrapezoidFuzzySet : FuzzySet
    {
        #region Properties
        public double A;
        public double B;
        public double C;
        public double D;
        #endregion

        #region Methods
        public override double GetMembership(double x)
        {
            if (x <= A || x >= D)
                return 0;
            if (x >= B && x <= C)
                return 1;
            if (x > A && x < B)
                return (x - A) / (B - A);
            return (D - x) / (D - C);
        }
        #endregion

        #region Constructors
        public TrapezoidFuzzySet(
            string name,
            double a,
            double b,
            double c,
            double d
            ) : base(name)
        {
            A = a; B = b; C = c; D = d;
        }
        #endregion
    }
}


