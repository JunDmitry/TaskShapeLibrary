using ShapeLibrary;

namespace UnitTest_1
{
    public class CircleTests
    {
        [Test]
        public void ArgumentExceptionTest()
        {
            Assert.Catch<ArgumentException>(() => new Circle(-1));
            Assert.DoesNotThrow(() => new Circle(1));
        }

        [TestCase(2, 12.57)]
        public void SquareValueTest(double radius, double expected)
        {
            Shape circle = new Circle(radius);

            double actual = Math.Round(circle.Square(), 2);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ShapeTypeTest()
        {
            Shape circle = new Circle(2);

            string actual = circle.GetShapeType();
            string expected = "Circle";

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}