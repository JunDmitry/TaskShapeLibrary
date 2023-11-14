using ShapeLibrary;

namespace UnitTest_1
{
    public class TriangleTests
    {
        [TestCase(-1, 2, 2)]
        [TestCase(1, -2, 2)]
        [TestCase(1, 2, -2)]
        public void LessThanZeroExceptionTest(double sideA, double sideB, double sideC)
        {
            Assert.Catch<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [TestCase(4.1, 2, 2)]
        [TestCase(2, 4.1, 2)]
        [TestCase(2, 2, 4.1)]
        public void TriangleNotExistsExceptionTest(double sideA, double sideB, double sideC)
        {
            Assert.Catch<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [TestCase(4, 2, 2)]
        [TestCase(2, 4, 2)]
        [TestCase(2, 2, 4)]
        public void TriangleNoExceptionTest(double sideA, double sideB, double sideC)
        {
            Assert.DoesNotThrow(() => new Triangle(sideA, sideB, sideC));
        }

        [TestCase(2, 3, 4, 2.90)]
        public void SquareValueTest(double sideA, double sideB, double sideC, double expected)
        {
            Shape triangle = new Triangle(sideA, sideB, sideC);

            double actual = Math.Round(triangle.Square(), 2);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(3, 4, 5, true)]
        [TestCase(2, 3, 4, false)]
        public void IsStraightTriangleTest(double sideA, double sideB, double sideC, bool expected)
        {
            Triangle triangle = new(sideA, sideB, sideC);

            bool actual = triangle.IsStraightTriangle();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ShapeTypeTest()
        {
            Shape shape = new Triangle(1, 1, 1);

            string actual = shape.GetShapeType();
            string expected = "Triangle";

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}