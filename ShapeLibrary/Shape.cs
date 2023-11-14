namespace ShapeLibrary
{
    public abstract class Shape
    {
        public abstract double Square();

        public string GetShapeType()
        {
            return GetType().Name;
        }

        public override string ToString()
        {
            return $"Shape type: {GetShapeType()}";
        }
    }
}