using NUnit.Framework;

namespace AreaCalculation
{
    [TestFixture]
    public class AreaCalculationTests
    {
        private Calculator _sut = new Calculator();

        [Test]
        public void AreaOfATriangleIsBaseMultipliedByHeight()
        {
            const double triangleBase = 6;
            const double triangleHeight = 4;

            var triangle = new Triangle(triangleBase, triangleHeight);

            Assert.AreEqual(12, _sut.GetTotalArea(triangle));
        }

        [Test]
        public void AreaOfASquareIsSquareOfSide()
        {
            const double side = 6;

            var square = new Square(side);

            Assert.AreEqual(36, _sut.GetTotalArea(square));
        }

        [Test]
        public void AreaOfARectangleIsWidthMultipliedByHeight()
        {
            const double height = 4;
            const double width = 8;

            var rectangle = new Rectangle(height, width);

            Assert.AreEqual(32, _sut.GetTotalArea(rectangle));
        }

        [Test]
        public void AreaOfACircleIsSquareOfRadiusMulitpliedByPi()
        {
            const double radius = 3;

            var circle = new Circle(radius);

            Assert.AreEqual(28.27, _sut.GetTotalArea(circle));
        }

        [Test]
        public void TotalAreaIsSumOfAreasOfDifferentShapes()
        {
            Assert.AreEqual(49.14, _sut.GetTotalArea(new Rectangle(4, 2), new Rectangle(3, 4), new Circle(1), new Square(1), new Triangle(10, 5)));
        }

        [Test]
        public void TotalAreaIsRoundedTo2Decimals()
        {
            Assert.AreEqual(4.45, _sut.GetTotalArea(new Rectangle(1.112, 2), new Rectangle(1.111, 2)));
        }

        [Test]
        public void TotalAreaIs0WhenThereAreNoShapes()
        {
            Assert.AreEqual(0, _sut.GetTotalArea());
        }
    }
}
