namespace ShapeLibrary
{
    public class Triangle : Shape
    {
        private double _sideA;

        public double SideA
        {
            get { return _sideA; }
            set
            {
                Validate(value, SideB, SideC);
                _sideA = value;
            }
        }

        private double _sideB;

        public double SideB
        {
            get { return _sideB; }
            set
            {
                Validate(SideA, value, SideC);
                _sideB = value;
            }
        }

        private double _sideC;

        public double SideC
        {
            get { return _sideC; }
            set
            {
                Validate(SideA, SideB, value);
                _sideC = value;
            }
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
            Validate(SideA, SideB, SideC);
        }

        public override double Square()
        {
            double p = (SideA + SideB + SideC) / 2;
            double s = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));

            return s;
        }

        public bool IsStraightTriangle()
        {
            double powA = SideA * SideA;
            double powB = SideB * SideB;
            double powC = SideC * SideC;

            return powA + powB == powC
                   || powA + powC == powB
                   || powB + powC == powA;
        }

        private void Validate(double sideA, double sideB, double sideC)
        {
            if (sideA < 0 || sideB < 0 || sideC < 0)
            {
                throw new ArgumentException("The side cannot be less than zero");
            }
            if (sideA + sideB < sideC
                || sideA + sideC < sideB
                || sideB + sideC < sideA)
            {
                throw new ArgumentException("There is no such triangle");
            }
        }
    }
}