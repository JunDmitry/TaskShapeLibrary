namespace ShapeLibrary
{
    public class Circle : Shape
    {
        // Does the user need to be given the option to change the state of the object or not?
        // If not, then we change the access of the Radius setter to Private.
        private double _radius;

        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The radius cannot be less than zero");
                }
                _radius = value;
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Square()
        {
            return Math.PI * Radius * Radius;
        }
    }
}